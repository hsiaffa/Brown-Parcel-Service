// 199-75
// Grading ID: 1566
// Due: April 20, 2020
//Program 4
// A Console application with two classes, One class will be the test application where the Main method is located and
//the other public class is named GroundPackage and will be our initial attempt at representing some of the packages delivered by Brown Parcel Service.
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
  public class Program
    {
        static void Main(string[] args)
        {
            GroundPackage[] packages = new GroundPackage[6];
            packages[0] = new GroundPackage(48794, 65656, 8, 7, 6, 2);
            packages[1] = new GroundPackage(98989, 54649, 6, 9, 7, 4);
            packages[2] = new GroundPackage(98795, 64656, 4, 4, 6, 1);
            packages[3] = new GroundPackage(99999, 56214, 2, 6, 9, 8);
            packages[4] = new GroundPackage(98999, 33256, 6, 9, 6, 7);
            packages[5] = new GroundPackage(64649, 64849, 9, 6, 7, 1);

            DisplayPackages(packages);

            // Changing the 
            packages[0].AZipcode = 64646;
            packages[1].BZipcode = 99999;
            packages[2].Length = 1;
            packages[3].Width = 2;
            packages[4].Height = 5;
            packages[4].Weight = 6;

            DisplayPackages(packages); // Display Package method
        }
        public static void DisplayPackages(GroundPackage[] packages)
        {
            foreach(GroundPackage a in packages)
            {
                // output
                WriteLine(a.ToString());
                double sum = a.CalcCost(); 
                WriteLine(sum); 
            }
        }
    }
}
