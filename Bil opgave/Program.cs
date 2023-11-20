using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_Oplysninger
{
    public class Menu

    {
        public static void Main()
        {
            int valg;
            do
            {
                Console.Clear();
                Console.Write("1. Indtast biloplysninger");
                Console.Write("\n2. Ændre oplysninger");
                Console.Write("\n3. Se indtastede oplysninger");
                Console.Write("\n0. Afslut");

                Console.Write("\nVælg en handling: ");
                valg = Convert.ToInt32(Console.ReadLine());

                switch (valg)
                {
                    case 1:
                        Class1.bilOplysninger();
                        break;

                    case 2:
                        Class2.NyeOplysninger();
                        break;

                    case 3:
                        Class3.VisOplysninger();
                        break;

                    case 0:
                        Console.WriteLine("Programmet afsluttes.");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Ugyldig handling. Prøv igen.");
                        break;
                }
            } while (true);
        }
    }

    public class Variabler
    {
        public static string nyFornavn { get; set; }
        public static string nyBilmod { get; set; }
        public static string nyBiltop { get; set; }
    }
}