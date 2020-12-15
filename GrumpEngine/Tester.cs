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

            string text = "In the beginning. There was a Grump. A BIG Grump!!\nOwen didn't know how to encounter this problem because he was too smooth brain. So he woke up with an idea!\nHe grabbed his boots and ran out the door. Hopped on his bike and rode off a cliff.\nNow Owen is no longer smooth brain.";
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }
            ResizeableMatrix rm = new ResizeableMatrix(6, 3);

            rm.Fill(27);

            Console.Write($"Matrix before add is - \n{rm}");

            rm.Add(new EncounterType(4));

            Console.WriteLine($"Matrix after add is - \n{rm}");

            Console.ReadKey();
        }
    }
}
