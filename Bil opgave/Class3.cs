using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_Oplysninger
{
    public class Class3
    { 
        public static void VisOplysninger()
        {
            Console.Clear();
            Console.Write($"Forhandlerens navn: {Variabler.nyFornavn}");
            Console.Write($"\nBilens model: {Variabler.nyBilmod}");
            Console.Write($"\nTopfart (km/t): {Variabler.nyBiltop}");
            Console.ReadKey();

        }
    }
}
