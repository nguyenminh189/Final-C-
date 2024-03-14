using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Ex2
{
    public class Animal
    {
        protected double weight;
        protected string name;

        public Animal(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}, Weight: {weight}kg");
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}
