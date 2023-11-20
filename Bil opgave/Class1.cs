using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_Oplysninger
{
    public class Class1
    {
        public static void bilOplysninger()
        {
            Console.Clear();
            Console.Write("Indtast forhandlerens navn: ");
            Variabler.nyFornavn = Console.ReadLine();
            Console.Write("\nIndtast bilens model: ");
            Variabler.nyBilmod = Console.ReadLine();
            Console.Write("\nIndtast bilens topfart (km/t): ");
            Variabler.nyBiltop = Console.ReadLine();
            Console.Write("\nTryk på en knap for at gå tilbage til hovedmenuen");
            Console.ReadKey();
        }
    }
}
