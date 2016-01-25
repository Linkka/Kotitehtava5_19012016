using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava5olio
{
    class Opiskelija
    {
        // properties
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }

        // don't create any constructor, so default one will be used

        // method to give more speed
        public void Ikaanny()
        {
            Ika += 1;
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Opiskelijan tiedot : ");
            Console.WriteLine("- Etunimi : " + Etunimi);
            Console.WriteLine("- Sukunimi : " + Sukunimi);
            Console.WriteLine("- Ika : " + Ika);
        }

        // destructor
        ~Opiskelija()
        {
            Console.WriteLine("Opiskelija object destroyed.");
        }

    }
}
