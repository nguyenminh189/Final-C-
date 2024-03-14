using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(180, "Lion");
            Tiger tiger = new Tiger(200, "Tiger");

            lion.Show();
            Console.WriteLine("\n");
            tiger.Show();
        }
    }
}
