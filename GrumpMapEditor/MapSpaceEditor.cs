using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GrumpEngine;

namespace GrumpMapEditor
{
    class MapSpaceEditor
    {
#pragma warning disable IDE0044 // Add readonly modifier
        MapSpaceDefinition mapInEdit;
#pragma warning restore IDE0044 // Add readonly modifier
#pragma warning disable IDE0044 // Add readonly modifier
        GridPositionPoint currentPoint;
#pragma warning restore IDE0044 // Add readonly modifier

        const int DEFAULT_ROWS = 5;
        const int DEFAULT_COLS = 5;

        public MapSpaceEditor()
        {
            mapInEdit = new MapSpaceDefinition(DEFAULT_ROWS, DEFAULT_COLS);
            currentPoint = new GridPositionPoint(0, 0);
        }

        public MapSpaceDefinition Map
        {
            get { return mapInEdit; }
        }

        public void WriteToSystem(string filepath)
        {
            using(StreamWriter sw = new StreamWriter(filepath))
            {
                using(JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer js = new JsonSerializer();
                    js.Serialize(jtw, mapInEdit);
                }
            }
        }

        public void RefreshDataSet(Grid grid)
        {
            for(int i = 0; i < mapInEdit.GetLength(0); i++)
            {
                for(int j = 0; j < mapInEdit.GetLength(1); j++)
                {
                    mapInEdit.EditPoint(i, j, grid.GetButton(i, j).EditedTile);
                }
            }
        }

        public override string ToString()
        {
            return System.Text.RegularExpressions.Regex.Unescape(mapInEdit.ToString());
        }
    }
}
