using System;
using SampleWebConsumer.WebServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleWebConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new WebService();

            Console.Write("Square root of 64 = {0}", service.SquareRoot(64));
        }
    }
}
