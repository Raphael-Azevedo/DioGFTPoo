using System;
using DioPOO.src.Entities;

namespace DioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight", 469, 72);
            WhiteWizard Jennica = new WhiteWizard("Jennica", 23, "White Wizard", 325, 474);
            BlackWizard Topapa = new BlackWizard("Topapa", 23, "Black Wizard Wizard", 106, 611);
            Ninja Wedge = new Ninja("Wedge", 23, "Ninja", 292, 89);

            System.Console.WriteLine(Arus.Attack());
            System.Console.WriteLine(Jennica.Attack());
            System.Console.WriteLine(Topapa.Attack());
            System.Console.WriteLine(Wedge.Attack());
        }
    }
}