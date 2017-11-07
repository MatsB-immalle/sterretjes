using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sterretjes = "";


            for (int i = 0; i < 100; i++)
            {
                sterretjes = sterretjes + '*';
            }
            Console.WriteLine(sterretjes);
        }
    }
}
