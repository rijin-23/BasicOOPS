using System;
using System.Diagnostics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School School1 = new School("USF", "Rhea Law", 1000000);
            Debug.WriteLine(School1.getDetails());

            MiddleSchool middleSchool1 = new MiddleSchool("HCC", "Randy Orton", 25000, 25.5M, 100);
            Debug.WriteLine(middleSchool1.getMSDetails());

            HighSchool highSchool1 = new HighSchool("UT", "Michelle Obama", 120000, "Spartans Playground");
            Debug.WriteLine(highSchool1.getHSDetails());
        }
    }
}