using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava5olio
{
    class Program
    {
        static void Main(string[] args)
        {
            // luo opiskelijat
            Opiskelija opiskelija1 = new Opiskelija();
            opiskelija1.Etunimi = "Sami";
            opiskelija1.Sukunimi = "Lindroos";
            opiskelija1.Ika = 20;

            Opiskelija opiskelija2 = new Opiskelija();
            opiskelija2.Etunimi = "Mikko";
            opiskelija2.Sukunimi = "Mallikas";
            opiskelija2.Ika = 15;

            Opiskelija opiskelija3 = new Opiskelija();
            opiskelija3.Etunimi = "Maija";
            opiskelija3.Sukunimi = "Meikalainen";
            opiskelija3.Ika = 25;
            // display car data
            opiskelija1.PrintData();
            opiskelija2.PrintData();
            opiskelija3.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            opiskelija1.Ikaanny();
            opiskelija2.Ikaanny();
            opiskelija3.Ikaanny();
            // display car data again, notice changed speed value!
            opiskelija1.PrintData();
            opiskelija2.PrintData();
            opiskelija3.PrintData();
            Console.ReadLine();
        }
    }

}
