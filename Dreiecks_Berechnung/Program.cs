using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreiecks_Berechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1
            Console.WriteLine("Bitte geben Sie Seite a in cm ein");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Jetzt die Seite b in cm");
            double b = Double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine("Seite c ist " + c + "cm lang");
            Console.WriteLine("");
            double Volumen = a * b * 0.5;
            Console.WriteLine("Das Volumen ist " + Volumen + "cm²");
            double Umfang = a + b + c;
            Console.WriteLine("Der Umfang ist " + Umfang + "cm");
            Console.ReadLine();
        }
    }
}
