using System.IO;
using GrumpEngine;
using GrumpEngine.Serializer;

namespace GrumpMapEditor
{
    class MapSpaceEditor
    {
        const int DEFAULT_ROWS = 5;
        const int DEFAULT_COLS = 5;

        public Map Map { get; set; } = new Map(DEFAULT_ROWS, DEFAULT_COLS);

        public void WriteToSystem(string filepath)
        {
            using(StreamWriter sw = new StreamWriter(filepath))
            {
                MapSerializer ms = new MapSerializer();
                sw.Write(ms.Serialize(Map));
            }
        }

        public void RefreshDataSet(Grid grid)
        {
            for(int i = 0; i < Map.GetLength(0); i++)
            {
                for(int j = 0; j < Map.GetLength(1); j++)
                {
                    Map[i, j] = grid.GetButton(i, j).EditedTile;
                }
            }
        }
    }
}
