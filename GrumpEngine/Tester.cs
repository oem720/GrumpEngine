using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrumpEngine
{
    class Tester
    {
        static void Main(string[] args)
        {
            ResizeableMatrix rm = new ResizeableMatrix(6, 3);

            rm.Fill(27);

            Console.Write($"Matrix before add is - \n{rm}");

            rm.Add(new EncounterType(4));

            Console.WriteLine($"Matrix after add is - \n{rm}");

            Console.ReadKey();
        }
    }
}
