using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_Oplysninger
{
    public class Class2
    {
        public static void NyeOplysninger()
        {
            Console.Clear();
            Console.WriteLine("Aktuelt indtastede oplysninger:");
            Console.WriteLine("Hvad vil du ændre?");
            Console.Write("1. Forhandlerens navn\n2. Bilens model\n3. Topfart\nVælg en option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Ny forhandlerens navn: ");
                    Variabler.nyFornavn = Console.ReadLine();
                    break;

                case 2:
                    Console.Write("Ny bilens model: ");
                    Variabler.nyBilmod = Console.ReadLine();
                    break;

                case 3:
                    Console.Write("Ny topfart (km/t): ");
                    Variabler.nyBiltop = Console.ReadLine();
                    break;
                    
                default:
                    Console.WriteLine("Ugyldig option.");
                    break;
            }
        }
    }
}
