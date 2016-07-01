using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            Primos p = new Primos();

            Console.WriteLine("Até que numero você deseja?");
            p.limit = int.Parse(Console.ReadLine());
            

            p.initNumbers(p.limit);

            p.markAndDelete ();

            p.numbersAsString ();



        }
    }
}
