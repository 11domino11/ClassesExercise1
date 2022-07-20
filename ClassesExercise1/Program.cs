using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car buickRegal98 = new Car("Buick","Regal", 1998);
            Console.WriteLine($"{ buickRegal98.Make} {buickRegal98.Model} made in {buickRegal98.Year}");

            Car hondaAccord09 = new Car();
                hondaAccord09.Make = "Honda";
                hondaAccord09.Model = "Accord";
                hondaAccord09.Year = 2009;
            
            Console.WriteLine(hondaAccord09.Make + hondaAccord09.Model + hondaAccord09.Year);
            Console.ReadLine();
        }
    }
}
