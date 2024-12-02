using System;

namespace Primitive_Obsession
{
    // Klasse, die eine Adresse repräsentiert
    public class Adresse
    {
        // Eigenschaften der Adresse
        public string Straße { get; set; }
        public string Stadt { get; set; }
        public string Postleitzahl { get; set; }

        //-----------------------------------------------------------------------------------------------------------
        // Konstruktor: Wird verwendet, um ein neues Objekt mit Werten zu erstellen
        public Adresse(string straße, string stadt, string postleitzahl)
        {
            Straße = straße; // Wert der Straße setzen
            Stadt = stadt; // Wert der Stadt setzen
            Postleitzahl = postleitzahl; // Wert der Postleitzahl setzen
        }

        //-----------------------------------------------------------------------------------------------------------
        // Parameterloser Konstruktor: Ermöglicht das Erstellen eines Objekts ohne Werte
        public Adresse()
        {
            // Optional: Standardwerte setzen
            Straße = "Unbekannt";
            Stadt = "Unbekannt";
            Postleitzahl = "00000";
        }

        //-----------------------------------------------------------------------------------------------------------
        // Methode: Gibt die Adresse als Text zurück
        public string GibAdresse()
        {
            return $"{Straße}, {Stadt}, {Postleitzahl}";
        }
    }

        //-----------------------------------------------------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zur Primitive_Obsession-Demo!");

            // Beispiel 1: Objekt mit Werten über den parametrisierten Konstruktor erstellen
            Console.WriteLine("\nBeispiel 1: Adresse mit parametrisiertem Konstruktor");
            Adresse adresse1 = new Adresse("Hauptstraße 123", "Berlin", "12345"); // Objekt 1

            Console.WriteLine($"Adresse 1: {adresse1.GibAdresse()}");

            //-----------------------------------------------------------------------------------------------------------

            // Beispiel 2: Objekt mit parameterlosem Konstruktor erstellen und Werte manuell setzen
            Console.WriteLine("\nBeispiel 2: Adresse mit parameterlosem Konstruktor");
            Adresse adresse2 = new Adresse();
            adresse2.Straße = "Nebenstraße 456";
            adresse2.Stadt = "Hamburg";
            adresse2.Postleitzahl = "67890";
            Console.WriteLine($"Adresse 2: {adresse2.GibAdresse()}");

            //-----------------------------------------------------------------------------------------------------------

            // Beispiel 3: Eingabe vom Benutzer
            Console.WriteLine("\nBeispiel 3: Adresse durch Benutzereingabe");
            Console.Write("Gib die Straße ein: ");
            string straße = Console.ReadLine();

            Console.Write("Gib die Stadt ein: ");
            string stadt = Console.ReadLine();

            Console.Write("Gib die Postleitzahl ein: ");
            string postleitzahl = Console.ReadLine();

            Adresse adresse3 = new Adresse(straße, stadt, postleitzahl);
            Console.WriteLine($"Adresse 3: {adresse3.GibAdresse()}");

            // Programm beenden
            Console.WriteLine("\nDrücke eine beliebige Taste, um die Anwendung zu beenden...");
            Console.ReadKey();
        }
    }
}
