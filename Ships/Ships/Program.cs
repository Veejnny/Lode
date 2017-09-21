using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    enum Typy
    {
        Lod, Prazdno, Strela, Minuto
    }
    class Program
    {
        static void Main(string[] args)
        {

            Typy moznost = Typy.Prazdno;
            Typy[] more = new Typy[3];
            more[0] = Typy.Lod;
            more[1] = Typy.Strela;
            more[2] = Typy.Prazdno;
        }
    }
}
