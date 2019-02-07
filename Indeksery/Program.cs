using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndexersClasses;

namespace Indeksery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Names names = new Names(5);
            //names[0] = "Roman";
            //names[1] = "Aśka";
            //names[2] = "Krzyś";

            //for (int i = 0; i < names.Count; i++)            
            //    Console.WriteLine(names[i]);
            
            Years years = new Years();
            years["Roman"] = 1900;
            years["Aśka"] = 1950;
            years["Krzyś"] = 1990;

            Console.WriteLine(years["Roman"]);
            Console.WriteLine(years["Aśka"]);
            Console.WriteLine(years["Krzyś"]);

            Console.Read();
        }
    }
}
