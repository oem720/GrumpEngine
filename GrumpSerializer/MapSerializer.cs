using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GrumpSerializer
{
    public class MapSerializer : IGrumpSerializer, IDisposable
    {
        private StreamWriter _writer;
        private BinaryFormatter _bf;
        private string _filepath;

        public MapSerializer(StreamWriter sw, string filepath)
        {
            _writer = sw;
            _bf = new BinaryFormatter();
            _filepath = filepath;
        }

        public string Serialize(object obj)
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.Append($"#!{obj.GetType()}#");
            List<PropertyInfo> props = new List<PropertyInfo>(obj.GetType().GetProperties());

            foreach(var prop in props)
            {
                
                var propValue = prop.GetValue(obj, null);
                sb.AppendLine();
                sb.Append($"\t[{prop.Name}={propValue}]");
                if (!IsCustomType(propValue.GetType()))
                {
                    if (!IsList(propValue.GetType()))
                    {

                    }
                    else
                    {
                        foreach (var item in (IEnumerable<object>)propValue)
                        {

                        }
                    }
                }
                else
                {

                }
            }
            sb.AppendLine();
            sb.Append($"#{obj.GetType()}!#");
            return sb.ToString();
        }

        private bool IsCustomType(Type t)
        {
            return !t.Namespace.StartsWith("System");
        }

        private bool IsList(Type t)
        {
            return t.Namespace.Equals("System.Collections.Generic");
        }

        public void Dispose()
        {
            _writer.Dispose();            
        }
    }
}
