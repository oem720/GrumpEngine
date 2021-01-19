using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GrumpSerializer
{
    public class MapSerializer : IGrumpSerializer
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

        public void Serialize(object ob)
        {
            
        }


    }
}
