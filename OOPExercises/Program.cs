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
            //RandNum firstRand = new RandNum(100, 200);

            //firstRand.RandVoidNumMethod();

            //foreach (int number in (firstRand.RandIntNumMethod()))
            //    {
            //    Console.Write("{0} ",number);
            //    }

            //WeekDay firstWeek = new WeekDay(3);

            //Console.WriteLine("\n{0}",firstWeek.GetWeekDaySwitch());

            //Console.WriteLine();

            //WeekDay secondWeek = new WeekDay(2017, 7, 11);

            //Console.WriteLine("\n{0}", secondWeek.GetWeekDay());

            Student firstStudent = new Student();
            firstStudent.FirstName = "Pete";
            firstStudent.MiddleName = "Frank";
            firstStudent.LastName = "Fittante";
            firstStudent.PhoneNumber = "216 609 8675";
            firstStudent.EmailAdd = "pfittante@yahoo.com";
            firstStudent.StudentInfo();

        }
    }
}
