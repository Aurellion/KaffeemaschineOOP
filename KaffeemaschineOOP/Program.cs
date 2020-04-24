using System;

namespace OOP_Kaffeemaschine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaffeemaschine");
            string t = "0";
            Kaffeemaschine k = new Kaffeemaschine();
            double menge0, verhaeltnis0;
            while (t != "5")
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1: Kaffee machen");
                Console.WriteLine("2: Wasser auffuellen");
                Console.WriteLine("3: Bohnen auffuellen");
                Console.WriteLine("4: Fuellstand abfragen");
                Console.WriteLine("5: Beenden");
                Console.WriteLine("Auswahl:");
                t = Console.ReadLine();
                switch (t)
                {
                    case "1":
                        Console.WriteLine("Wieviel Kaffee soll gemacht werden?");
                        menge0 = double.Parse(Console.ReadLine());
                        Console.WriteLine("In welchen Verhaeltnis?");
                        verhaeltnis0 = double.Parse(Console.ReadLine());
                        if (k.macheKaffee(menge0, verhaeltnis0))
                        {
                            Console.WriteLine("Die Maschine hat insgesamt " + k.gesamtMengeKaffeeProduziert + " kg Kaffee produziert.");
                        }
                        else
                        {
                            Console.WriteLine("Nicht genug Zutaten, oder falsche Eingabe!");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Wieviel Wasser soll aufgefuellt werden?");
                        menge0 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Es wurde(n) " + k.wasserAuffuellen(menge0) + " l Wasser aufgefuellt.");
                        break;
                    case "3":
                        Console.WriteLine("Wieviel Bohnen sollen aufgefuellt werden?");
                        menge0 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Es wurde(n) " + k.bohnenAuffuellen(menge0) + " kg Bohnen aufgefuellt.");
                        break;
                    case "4":
                        Console.WriteLine("Fuellstand:");
                        Console.WriteLine("Wasser: " + k.wasser.ToString("0.00") + " l");
                        Console.WriteLine("Bohnen: " + k.bohnen.ToString("0.00") + " kg");
                        Console.WriteLine("Kaffee: " + k.gesamtMengeKaffeeProduziert.ToString("0.00") + " kg");
                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe!");
                        break;
                }
            }
            Console.ReadKey();
        }
        
    }


}
