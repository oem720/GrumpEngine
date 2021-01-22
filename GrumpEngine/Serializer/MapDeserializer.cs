using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GrumpEngine.Serializer
{
    public static class MapDeserializer
    {
        public static string Deserialize(string input)
        {
            string[] split = input.Split('-');
            byte[] raw = new byte[split.Length];
            for(int i = 0; i < split.Length; i++)
            {
                raw[i] = Convert.ToByte(split[i], 16);
            }
            return Encoding.ASCII.GetString(raw);
        }
    }
}
