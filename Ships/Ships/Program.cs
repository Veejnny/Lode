using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){
                
                string LOD = "|O|";
                string More = "|~|";
                string Zasah = "@@";

                string[,] pole2d = new string[10, 10];

                for (int delka = 0; delka < pole2d.GetLength(0); delka++)
                {

                    for (int sirka = 0; sirka < pole2d.GetLength(1); sirka++)
                    {
                        pole2d[delka, sirka] = More;
                        pole2d[7, 0] = LOD;
                        pole2d[7, 1] = LOD;
                        pole2d[8, 0] = LOD;
                        Console.Write(pole2d[delka, sirka]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Vyberte pozici pro střelbu...");
                Console.Write("Pozice X: ");
                string vstup_X = Console.ReadLine();
                int cislo_X = 0;
                try
                {
                    cislo_X = int.Parse(vstup_X);
                }
                catch (Exception e)
                {

                }
                if (cislo_X != 0 && cislo_X < pole2d.GetLength(0))
                {
                    Console.WriteLine();
                    Console.Write("Pro pozici X jste vybral hodnotu: ");
                    Console.WriteLine(cislo_X);
                    Console.Write("Nyní vyberte hodnotu pro pozici Y: ");

                    string vstup_Y = Console.ReadLine();
                    int cislo_Y = 0;
                    try
                    {
                        cislo_Y = int.Parse(vstup_Y);
                    }
                    catch (Exception e)
                    {

                    }
                    if(cislo_Y != 0 && cislo_Y < pole2d.GetLength(1)) // V téhle podmínce je změna
                    {
                        pole2d[cislo_X, cislo_Y] = Zasah;
                    } else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nenapsal jste hodnotu od 1 do 10!");
                        Console.WriteLine();
                    }
                } else
                {
                    Console.WriteLine();
                    Console.WriteLine("Nenapsal jste hodnotu od 1 do 10!");
                    Console.WriteLine();
                }
            }
        }
    }
}
