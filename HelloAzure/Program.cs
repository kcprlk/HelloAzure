using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAzure
{
    public class Program
    {
        public static string ZwrocNapis(string napis)
        {
            return napis;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(ZwrocNapis("Hello World!"));
            Console.Read();
        }
    }
}
