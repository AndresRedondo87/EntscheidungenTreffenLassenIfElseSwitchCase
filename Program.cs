using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntscheidungenTreffenLassenIfElseSwitchCase
{
    class Program
    {
        // Lehrer lösung:
        // Benutzername - static, damit es in einer static Methode verwendet werden kann
        static string username;
        // Passwort - static, damit es in einer static Methode verwendet werden kann
        static string password;

        static void Main(string[] args)
        {
            /*-----------------------------------------Herausforderung If Statements
             * Erstelle ein Benutzer-Login-System, in dem sich der Benutzer zuerst registrieren und dann einloggen kann. 
             * Das Programm sollte überprüfen, ob der Benutzer den richtigen Benutzernamen und das richtige Passwort eingegeben hat, 
             * wenn er sich einloggt (also die gleichen, die er bei der Registrierung verwendet hat).
             * 
             * Da wir das Speichern von Daten noch nicht abgedeckt haben, erstelle das Programm einfach so,
             * dass das Registrieren und Einloggen in der gleichen Ausführung erfolgt.
             * User If-Anweisungen und Benutzereingaben und Methoden zur Lösung der Herausforderung.
             */
            

            // Lehrer lösung:
            // Benutzername - static, damit es in einer static Methode verwendet werden kann
            //static string username;
            //// Passwort - static, damit es in einer static Methode verwendet werden kann
            //static string password;

            ////static void Main(string[] args)
            ////{
                Register();
                Login();
                Console.ReadKey();
            ////}

            

            Console.WriteLine("ENDE");
            Console.ReadKey();
        }
        public static void Register()
        {
            Console.WriteLine("Bitte trage deinen Benutzernamen ein");
            username = Console.ReadLine();
            Console.WriteLine("Bitte trage dein Passwort ein!");
            password = Console.ReadLine();
            Console.WriteLine("Registrierung abgeschlossen!");
            Console.WriteLine("------------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Benutzername eingeben bitte:");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Bitte gib dein Passwort ein");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Einloggen war erfolgreich");
                }
                else
                {
                    Console.WriteLine("Login schiefgegangen, falsches Passwort. Starte das Programm neu.");
                }
            }
            else
            {
                Console.WriteLine("Benutzername existiert nicht. Bitte versuche es mit einem anderen Benutzernamen");
            }
        }
    }

}
