using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            RandNum firstRand = new RandNum(100, 200);

            firstRand.RandVoidNumMethod();

            foreach (int number in (firstRand.RandIntNumMethod()))
                {
                Console.Write("{0} ",number);
                }
        }
    }
}
