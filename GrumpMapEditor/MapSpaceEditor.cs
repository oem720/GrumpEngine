using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrumpEngine;
using System.IO;

namespace GrumpMapEditor
{
    class MapSpaceEditor
    {
        MapSpaceDefinition mapInEdit;
        GridPositionPoint currentPoint;

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

        public void WriteToSystem()
        {
            StreamWriter file = new StreamWriter(@".\map.txt");
            file.WriteLine(mapInEdit.ToString());
            file.WriteLine("#endmapstructuredata");
            
            for (int i = 0; i < mapInEdit.GetLength(0); i++)
            {
                for (int j = 0; j < mapInEdit.GetLength(1); j++)
                {
                    List<string> temp = mapInEdit.GetTileValue(i, j).Descriptors;

                    if(temp != null)
                    {
                        foreach (string s in temp)
                        {
                            file.WriteLine($"{i}, {j}.\t{s}");
                        }
                    }
                }
            }            

            file.WriteLine("#endtiledescritpordata");
            
            for (int i = 0; i < mapInEdit.GetLength(0); i++)
            {
                for (int j = 0; j < mapInEdit.GetLength(1); j++)
                {
                    List<Entity> temp = mapInEdit.GetTileValue(i, j).EntityRegistry;

                    if(temp != null)
                    {
                        foreach (Entity s in temp)
                        {
                            file.WriteLine($"{i}, {j}.{s.GetIdentifier()}");
                        }
                    }
                }
            }            

            file.WriteLine("#endtileentityregistrydata");

            file.Close();
        }

        public override string ToString()
        {
            return System.Text.RegularExpressions.Regex.Unescape(mapInEdit.ToString());
        }
    }
}
