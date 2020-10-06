using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiMunka1006
{
    class Program
    {
        static int bekert=0;
        static string szoveg;
        static string honap;
        static int honapszam = 0;
        static int ossz;
        static int aold;
        static int bold;
        static int szel;
        static int mag;
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat:");
            int[] tomb1 = new int[100];
            Random rnd = new Random();
            
            for (int i = 0; i < tomb1.Length; i++)
            {
                tomb1[i] = rnd.Next(10, 99);
            }
            foreach (var vizsgalt in tomb1)
            {
                Console.Write(" "+vizsgalt);
            }
            Console.WriteLine();
            Console.WriteLine("11. feladat:");
            Console.WriteLine("Kérem adja meg az osztályzatot");
            bekert = int.Parse(Console.ReadLine());
            Osztalyos();
            Console.WriteLine("Az adott jegy "+szoveg+".");
            Console.WriteLine("12. Feladat: ");
            Console.WriteLine("Kérem adjon meg egy hónap nevét:");
            honap = Console.ReadLine();
            HonapSzama();
            Console.WriteLine("A hónap a "+honapszam+". hónap");
            Console.WriteLine("13-as feladat: ");
            Console.WriteLine("Kérem adja meg előszőr az 'a' oldalát a téglalapnak: ");
            aold = int.Parse(Console.ReadLine());
            Console.WriteLine("Most pedig a 'b' oldalt kérném: ");
            bold = int.Parse(Console.ReadLine());
            KerTer();
            Console.WriteLine("A kerület : "+ossz+" egység illetve a terület: "+(aold*bold));
            Console.WriteLine("17. Feladat: ");
            Console.WriteLine("Kérem adja meg a rajzolni kívánt téglalap magasságát: ");
            mag = int.Parse(Console.ReadLine());
            Console.WriteLine("Most pedig kérném a a szélességét: ");
            szel = int.Parse(Console.ReadLine());
            Console.WriteLine("A téglalap: ");
            teglalapok();
            Console.WriteLine();
            Console.WriteLine("Illetve a paraméteres téglalapok: ");
            Console.ForegroundColor = ConsoleColor.Red;
            mag = 23;
            szel = 78;
            teglalapok();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            mag = 19;
            szel = 74;
            teglalapok();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            mag = 15;
            szel = 70;
            teglalapok();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            mag = 11;
            szel = 66;
            teglalapok();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            mag = 7;
            szel = 62;
            teglalapok();
            Console.WriteLine();
            mag = 3;
            szel = 58;
            Console.ForegroundColor = ConsoleColor.Yellow;
            teglalapok();
            Console.WriteLine();
            Console.ResetColor();
            Console.ReadKey();
        }

        static void Osztalyos()
        {
            switch (bekert)
            {
                case 1:
                    szoveg = "elégtelen";
                    break;
                case 2:
                    szoveg = "elégséges";
                    break;
                case 3:
                    szoveg = "közepes";
                    break;
                case 4:
                    szoveg = "jó";
                    break;
                case 5:
                    szoveg = "jeles";
                    break;

                default:
                    szoveg = "Nem megfelelő formátum!";
                    break;
            }
        }

        static void HonapSzama() 
        {
            if (honap=="január" || honap=="Január")
            {
                honapszam = 1;
            }
            if (honap == "február" || honap == "Február")
            {
                honapszam = 2;
            }
            if (honap == "március" || honap == "Március")
            {
                honapszam = 3;
            }
            if (honap == "Április" || honap == "április")
            {
                honapszam = 4;
            }
            if (honap == "május" || honap == "Május")
            {
                honapszam = 5;
            }
            if (honap == "Agusztus" || honap == "agusztus")
            {
                honapszam = 8;
            }
            if (honap == "június" || honap == "Június")
            {
                honapszam =  6;
            }
            if (honap == "Július" || honap == "július")
            {
                honapszam = 7;
            }
            if (honap == "Szeptember" || honap == "szeptember")
            {
                honapszam = 9;
            }
            if (honap == "Október" || honap == "október")
            {
                honapszam = 10;
            }
            if (honap == "November" || honap == "november")
            {
                honapszam = 11;
            }
            if (honap == "December" || honap == "december")
            {
                honapszam = 12;
            }

        }

        static void KerTer() 
        {
            ossz = aold + aold + bold + bold;
        }

        static void teglalapok()
        {
            Console.WriteLine();
            for (int i = 0; i < szel + 2; i++)
            {
                Console.Write("* ");
            }
            for (int i = 0; i < mag; i++)
            {
                Console.WriteLine();
                Console.Write("*");

                for (int j = 0; j < szel; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");
            }
            Console.WriteLine();
            for (int i = 0; i < szel + 2; i++)
            {
                Console.Write("* ");
            }
        }
    }
}
