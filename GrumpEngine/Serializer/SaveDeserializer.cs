using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace GrumpEngine.Serializer
{
    public static class SaveDeserializer
    {
        public static Map Deserialize(string input) //TODO: CHANGE TO SAVE TYPE AND FIX MOST OF THIS CODE (transplanted here so i wouldn't lose it)
        {
            string data = Decode(input);//Get the string containing all data that has been decoded
            data = data.Substring(data.IndexOf('{') + 1, data.IndexOf('}') - data.IndexOf('{'));//Extract the text contained between the mapGrid property spot
            string[] matrixParms = SplitOnNumberOfDelimiters(',', data, 2);

            List<Data> matrixParameters = new List<Data>();
            foreach (string parm in matrixParms)
                if (IsBaseData(parm))
                    matrixParameters.Add(CreateDataInstanceFromString(parm));

            int numRows = 0, numCols = 0;
            foreach (Data dat in matrixParameters)
            {
                if (dat.PropertyName.Equals("Rows"))
                    numRows = Int32.Parse(dat.Value);
                else
                    numCols = Int32.Parse(dat.Value);
            }

            Tile[,] matrix = new Tile[numRows, numCols];

            char[] nextCharTiles = new char[] { ',', '}' };
            string[] tiles = GetStringsOfEndDelimiters('|', matrixParms[2], nextCharTiles);
            Tile[] parsedTiles = ParseTileData(tiles);

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = parsedTiles[i * j];

            ResizeableMatrix<Tile> mapGrid = new ResizeableMatrix<Tile>(numRows, numCols);
            bool hasAddedGrid = false;
            foreach (var dat in matrixParameters)
            {
                if (!hasAddedGrid)
                {
                    var gridProperty = mapGrid.GetType().GetProperty("Matrix");
                    gridProperty?.SetValue(mapGrid, matrix, null);
                    hasAddedGrid = true;
                }
                var propInfo = mapGrid.GetType().GetProperty(dat.PropertyName);
                propInfo?.SetValue(mapGrid, Convert.ChangeType(dat.Value, propInfo.PropertyType), null);
            }


            return null;
        }

        private static Tile[] ParseTileData(string[] data)
        {
            List<Tile> tileData = new List<Tile>();
            foreach (string tile in data)
            {
                string[] propertyData = SplitOnNumberOfDelimiters(',', tile, 2, true);
                Data outwardval;
                List<DescriptorString> listds;
                List<IEntity> listent;
                Tile addedTile = new Tile();
                foreach (string propdat in propertyData)
                {
                    if (IsBaseData(propdat))
                    {
                        outwardval = CreateDataInstanceFromString(propdat);
                        var outintprop = addedTile.GetType().GetProperty("OutwardValue");
                        outintprop?.SetValue(addedTile, Convert.ChangeType(outwardval.Value, outintprop.PropertyType));
                    }
                    else if (GetPropName(propdat).Equals("Descriptors"))
                    {
                        listds = DeserializeListData<DescriptorString>(propdat);
                        var dslistprop = addedTile.GetType().GetProperty("Descriptors");
                        dslistprop?.SetValue(addedTile, listds);
                    }
                    else if (GetPropName(propdat).Equals("EntityRegistry"))
                    {
                        listent = DeserializeListData<IEntity>(propdat);
                        var entlistprop = addedTile.GetType().GetProperty("EntityRegistry");
                        entlistprop?.SetValue(addedTile, listent);
                    }
                }
                tileData.Add(addedTile);
            }

            return tileData.ToArray();
        }

        private static List<T> DeserializeListData<T>(string input)
        {
            List<T> data = new List<T>();
            input = input.Substring(input.IndexOf('=') + 1);
            input = input.Remove(0, 1);
            input = input.Remove(input.Length - 1, 1); //remove bounding brackets

            if (input.Equals(string.Empty))
                return data;

            string[] datasets = GetCustomDataTypeStrings(input);

            foreach (string dat in datasets)
            {
                int equals = dat.IndexOf('=');
                if (dat.Substring(0, equals).Equals("DescriptorString"))
                {
                    string temp = dat.Substring(dat.IndexOf('(') + 1, dat.Length - (2 + dat.IndexOf('(')));
                    List<Data> dsargs = new List<Data>();
                    string[] args = SplitOnNumberOfDelimiters(',', temp, 1);
                    foreach (string arg in args)
                        dsargs.Add(CreateDataInstanceFromString(arg));
                    T dsadded;
                    if (dsargs[0].PropertyName.Equals("Descriptor"))
                    {
                        object[] addedargs = new object[] { dsargs[0].Value, (Tag)Enum.Parse(typeof(Tag), dsargs[1].Value) };
                        dsadded = (T)Activator.CreateInstance(typeof(T), addedargs);
                    }
                    else
                    {
                        object[] addedargs = new object[] { dsargs[1].Value, dsargs[0].Value };
                        dsadded = (T)Activator.CreateInstance(typeof(T), addedargs);
                    }
                    data.Add(dsadded);
                }
                else
                {

                }
            }

            return data;
        }

        private static Data CreateDataInstanceFromString(string input)
        {
            int equalsIndex = input.IndexOf('=');
            if (input.Contains("/\""))
                input = input.Remove(input.IndexOf("/\""), 2);
            if (input.Contains("\"/"))
                input = input.Remove(input.IndexOf("\"/"), 2);
            return new Data { PropertyName = input.Substring(0, equalsIndex), Value = input.Substring(equalsIndex + 1) };
        }

        private static bool IsBaseData(string input)
        {
            char[] nextCharDelims = new char[] { '[', '|', '(' };

            foreach (char c in nextCharDelims)
                if (input.IndexOf(c) != -1)
                    return false;

            return true;
        }

        private static string GetPropName(string input)
        {
            return input.Substring(0, input.IndexOf('='));
        }

        private static string Decode(string input)
        {
            //string[] split = input.Split('-');
            //byte[] raw = new byte[split.Length];
            //for (int i = 0; i < split.Length; i++)
            //    raw[i] = Convert.ToByte(split[i], 16);
            //return Encoding.ASCII.GetString(raw);
            return input;
        }

        private static string[] SplitOnNumberOfDelimiters(char[] delim, string input, int num)
        {
            int splitCount = 0;
            List<string> splits = new List<string>();

            for (int i = 0; splitCount < num && i < input.Length; i++)//search the given string for the delimiter   
                foreach (char delimiter in delim)
                    if (input[i].Equals(delimiter))                  //if found, substring it out and remove the substring piece
                    {
                        splits.Add(input.Substring(0, i));
                        input = input.Remove(0, i + 1);
                        splitCount++;
                        i = 0;
                    }
            splits.Add(input);//Add the remaining strings to the list

            return splits.ToArray();
        }

        private static string[] SplitOnNumberOfDelimiters(char delim, string input, int num, bool removeFirstChar = false)
        {
            int splitCount = 0;
            List<string> splits = new List<string>();
            if (removeFirstChar)
                input = input.Remove(0, 1);
            bool hasCollectionData = false, isInStringDelim = false;
            if (input.IndexOf('[') != -1)
                hasCollectionData = true;

            string[] stringDelim = new string[] { "/\"", "\"/" };

            if (!hasCollectionData)
            {
                for (int i = 0; splitCount < num && i < input.Length; i++)//search the given string for the delimiter   
                {
                    if (i < input.Length - 2)
                        if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[0]))
                            isInStringDelim = true;
                        else if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[1]))
                            isInStringDelim = false;

                    if (!isInStringDelim && input[i].Equals(delim))                  //if found, substring it out and remove the substring piece
                    {
                        splits.Add(input.Substring(0, i));
                        input = input.Remove(0, i + 1);
                        splitCount++;
                        i = 0;
                    }
                }
                splits.Add(input);//Add the remaining strings to the list

                return splits.ToArray();
            }
            else
            {
                for (int i = 0; i < input.IndexOf('[') && splitCount < num; i++)
                {
                    if (i < input.Length - 2)
                        if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[0]))
                            isInStringDelim = true;
                        else if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[1]))
                            isInStringDelim = false;

                    if (!isInStringDelim && input[i].Equals(delim))                  //if found, substring it out and remove the substring piece
                    {
                        splits.Add(input.Substring(0, i));
                        input = input.Remove(0, i + 1);
                        splitCount++;
                        i = 0;
                    }
                }
                if (splitCount == num)
                {
                    splits.Add(input);
                    return splits.ToArray();
                }


                bool isInNestedCollection = false, hasFoundStartPoint = false;

                int nestedCollectionCount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (i < input.Length - 2)
                        if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[0]))
                            isInStringDelim = true;
                        else if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[1]))
                            isInStringDelim = false;

                    if (input[0].Equals(','))
                    {
                        input = input.Substring(1);
                        i = 0;
                    }
                    else if (input[i].Equals('[') && !isInStringDelim)
                        if (!hasFoundStartPoint)
                            hasFoundStartPoint = true;
                        else
                        {
                            isInNestedCollection = true;
                            nestedCollectionCount++;
                        }
                    else if (input[i].Equals(']') && !isInStringDelim)
                        if (!isInNestedCollection)
                        {
                            splits.Add(input.Substring(0, i + 1));
                            input = input.Remove(0, i + 1);
                            hasFoundStartPoint = false;
                            i = 0;
                        }
                        else
                            if (nestedCollectionCount == 1)
                            {
                                isInNestedCollection = false;
                                nestedCollectionCount--;
                                continue;
                            }
                            else
                            {
                                nestedCollectionCount--;
                                continue;
                            }
                    else if (isInStringDelim || isInNestedCollection)
                        continue;
                }
                return splits.ToArray();
            }


        }

        /// <summary>
        /// Returns an array of type string for the data contained between a single sided delimiter such as , or |
        /// </summary>
        /// <param name="delim"></param>
        /// <param name="input"></param>
        /// <param name="nextCharDelim"></param>
        /// <returns></returns>
        private static string[] GetStringsOfEndDelimiters(char delim, string input, char[] nextCharDelim)
        {
            List<string> splits = new List<string>();
            int startPoint = 0;
            bool startPointFound = false;
            for (int i = 0; i < input.Length - 1; i++)
                if (input[i].Equals(delim))
                    if (!startPointFound)
                    {
                        startPoint = i;
                        startPointFound = true;
                    }
                    else
                        foreach (char delimiter in nextCharDelim)
                            if (input[i + 1].Equals(delimiter))
                            {
                                splits.Add(input.Substring(startPoint, (i + 1) - startPoint));
                                input = input.Remove(0, i + 1);
                                startPointFound = false;
                                i = 0;
                            }

            return splits.ToArray();
        }

        private static string[] GetCustomDataTypeStrings(string input)
        {
            List<string> splits = new List<string>();
            int commaCount = 0, nestedTypeCount = 0;
            bool startPointFound = false, isInStringDelim = false, isInNestedCustomDataType = false;
            string[] stringDelim = new string[] { "/\"", "\"/" };

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 2)
                    if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[0]))
                        isInStringDelim = true;
                    else if ($"{input[i]}{input[i + 1]}".Equals(stringDelim[1]))
                        isInStringDelim = false;

                if (input[0].Equals(','))
                {
                    input = input.Substring(1);
                    i = 0;
                }
                else if (input[i].Equals(')') && !isInStringDelim)
                    if (commaCount == Type.GetType("GrumpEngine." + input.Substring(0, input.IndexOf('='))).GetProperties().Length - 1)
                    {
                        splits.Add(input.Substring(0, i + 1));
                        input = input.Remove(0, i + 1);
                        startPointFound = false;
                        i = 0;
                    }
                    else
                        if (nestedTypeCount == 1)
                    {
                        isInNestedCustomDataType = false;
                        nestedTypeCount--;
                        continue;
                    }
                    else
                    {
                        nestedTypeCount--;
                        continue;
                    }
                else if (input[i].Equals('(') && !isInStringDelim)
                    if (!startPointFound)
                        startPointFound = true;
                    else
                    {
                        isInNestedCustomDataType = true;
                        nestedTypeCount++;
                    }
                else if (isInStringDelim || isInNestedCustomDataType)
                    continue;
                else if (input[i].Equals(',') && !isInNestedCustomDataType && !isInStringDelim)
                    commaCount++;
            }
            return splits.ToArray();
        }
    }

    public struct Data
    {
        public string PropertyName;
        public string Value;
    }
}
