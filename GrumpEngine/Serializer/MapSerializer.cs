using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace GrumpEngine.Serializer
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


            return null;
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
