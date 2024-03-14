using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Ex1
{
    public class Cylinder
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double baseArea { get; set; }
        public double lateralArea { get; set; }
        public double totalArea { get; set; }
        public double volume { get; set; }

        public Cylinder(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }



        public void Process()
        {
            baseArea = Math.PI * Math.Pow(Radius, 2);

            lateralArea = 2 * Math.PI * Radius * Height;

            totalArea = (2 * baseArea) + lateralArea;

            volume = baseArea * Height;
        }

        public void Result()
        {
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine($"Base Area: {baseArea}");
            Console.WriteLine($"Lateral Area: {lateralArea}");
            Console.WriteLine($"Total Area: {totalArea}");
            Console.WriteLine($"Volume: {volume}");
        }

    }
}
