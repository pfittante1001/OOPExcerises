using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    class RandNum
    {
        //fields
        private int min;
        private int max;
        private int arrSize;

        //Properties

        public int Min
        {
            get { return this.min; }
            set { this.min = value; }
                
        }
        
        public int Max
        {
            get { return this.min; }
            set { this.max = value; }
        }

        public int ArrSize
        {
            get { return this.arrSize; }
            set { this.arrSize = value; }
        }

        //Constructor

        public RandNum()
        {
            //Default constructor
        }

        public RandNum(int minRN, int maxRN)
        {
            this.min = minRN;
            this.max = maxRN;
         }

        //Methods

        public int[] RandIntNumMethod()
        {
            int[] numArray = new int[10];
            Random ranNum = new Random();
            for(int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = ranNum.Next(this.min, this.max);
            }
            return numArray;
        }
        public void RandVoidNumMethod()
        {
            int[] numArray = new int[10];
            Random ranNum = new Random();
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = ranNum.Next(this.min, this.max);
                Console.Write("{0} ", numArray[i]);
            }
            Console.WriteLine();
        }
    }
}
