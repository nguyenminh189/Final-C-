using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimenstions of the cylinder ");

            Console.WriteLine("Enter radius: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(Radius, Height);

            Console.WriteLine("Radius: " + cylinder.Radius);
            Console.WriteLine("Height: " + cylinder.Height);

            cylinder.Process();

            Console.WriteLine("\nCylinder Characteristics");
            
            cylinder.Result();
        }
    }
}

