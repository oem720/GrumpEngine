using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GrumpEngine.Serializer
{
    public class MapSerializer
    {
        public string Serialize(object obj)
        {
            bool encoded = false;
            string final;
            StringBuilder sb = new StringBuilder();
            Type objType = obj.GetType();
            PropertyInfo[] props = objType.GetProperties();

            //Step 1: Build the initial starting point of the serialized string
            if (objType.Equals(typeof(Map)))
            {
                sb.Append($"{props[0].Name}=");
                sb.Append("{" + $"{Serialize(props[0].GetValue(obj))}" + "}");
                encoded = true;
            }
            //Step 2: Serialize the internal matrix (called during Step 1)
            else if(objType.Equals(typeof(ResizeableMatrix<Tile>)))
            {
                sb.Append($"{props[2].Name}={props[2].GetValue(obj)},{props[1].Name}={props[1].GetValue(obj)},{props[0].Name}=");

                object[,] tiles = (object[,])props[0].GetValue(obj);
                for(int i = 0; i < tiles.GetLength(0); i++)
                {
                    for (int j = 0; j < tiles.GetLength(1); j++)
                    {
                        if(j == tiles.GetLength(1) - 1 && i == tiles.GetLength(0) - 1)
                        {
                            sb.Append($"{Serialize(tiles[i, j])}");
                            continue;
                        }
                        sb.Append($"{Serialize(tiles[i, j])},");
                    }
                    if(i < tiles.GetLength(0) - 1)
                        sb.AppendLine();
                }                    
            }
            //Step 3: Serialize each Tile (called during Step 2)
            else if (objType.Equals(typeof(Tile)))
            {
                sb.Append($"|{props[0].Name}={props[0].GetValue(obj)},{props[1].Name}=[");

                List<DescriptorString> desc = (List<DescriptorString>)props[1].GetValue(obj);
                for(int i = 0; i < desc.Count; i++)
                {
                    if (i == desc.Count - 1)
                    {
                        sb.Append(Serialize(desc[i]));
                        continue;
                    }
                    sb.Append(Serialize(desc[i]) + ",");
                }

                sb.Append($"],{props[2].Name}=[");
                List<IEntity> ent = (List<IEntity>)props[2].GetValue(obj);
                if (ent.Count == 0)
                    sb.Append("]");
                for (int i = 0; i < ent.Count; i++)
                {
                    if (i == ent.Count - 1)
                    {
                        sb.Append(Serialize(ent[i]));
                        continue;
                    }
                    sb.Append(Serialize(ent[i]) + ",");
                }
                sb.Append("]|");
            }
            //Step 4a: Serialize each DescriptorString (called during Step 3)
            else if (objType.Equals(typeof(DescriptorString)))
                sb.Append($"({props[0].Name}={props[0].GetValue(obj)},{props[1].Name}={props[1].GetValue(obj)})");
            //Step 4b: Serialize each IEntity (called during Step 3)
            else if(IsCustomType(objType) || objType.GetInterface("IEntity") != null)
            {
                sb.Append($"{objType.Name}=!");
                for(int i = 0; i < props.Length; i++)
                {
                    if (props[i].GetValue(obj) != null && !(props[i].GetValue(obj) is Enum) && IsCustomType(props[i].GetValue(obj).GetType()))
                    {
                        if(i == props.Length - 1)
                        {
                            sb.Append($"{props[i].Name}={Serialize(props[i].GetValue(obj))},");
                            continue;
                        }
                        sb.Append($"{props[i].Name}={Serialize(props[i].GetValue(obj))},");
                    }
                    else if (props[i].GetValue(obj) != null && IsList(props[i].GetValue(obj).GetType()))
                    {
                        List<IEntity> list = (List<IEntity>)props[i].GetValue(obj);
                        sb.Append($"{props[i].Name}=/");
                        for(int k = 0; k < list.Count; k++)
                        {
                            if(k == list.Count - 1)
                            {
                                sb.Append($"{props[i].Name}=/{Serialize(list[k])}");
                                continue;
                            }
                            sb.Append($"{props[i].Name}=/{Serialize(list[k])},");
                        }
                        sb.Append("/");
                    }
                    else
                    {
                        if(i == props.Length - 1)
                        {
                            sb.Append($"{props[i].Name}={props[i].GetValue(obj)}");
                            continue;
                        }
                        sb.Append($"{props[i].Name}={props[i].GetValue(obj)},");
                    }
                }
                sb.Append("!");
            }
            //Step 5: Serialize all remaing properties for remaining types (called during Step 4b)
            else
            {
                sb.Append("?");
                for(int i = 0; i < props.Length; i++)
                {
                    if(i == props.Length - 1)
                    {
                        sb.Append($"[{props[i].Name}={props[i].GetValue(obj)}]");
                        continue;
                    }
                    sb.Append($"[{props[i].Name}={props[i].GetValue(obj)}],");
                }
                sb.Append("?");
            }

            if (encoded)
            {
                final = sb.ToString();
                byte[] ba = Encoding.Default.GetBytes(final);
                var hexstring = BitConverter.ToString(ba);
                sb.Clear();
                sb.Append(hexstring);
            }


            return sb.ToString();   
        }

        private bool IsCustomType(Type t)
        {
            return t.Namespace.Contains("GrumpEngine");
        }

        private bool IsList(Type t)
        {
            return t.Namespace.Equals("System.Collections.Generic");
        }
    }
}
