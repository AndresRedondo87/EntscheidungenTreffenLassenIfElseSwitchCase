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


            //-----------------------------------SWITCH-CASE
            // Alter
            int age = 16;
            Console.WriteLine("Bitte trage deinen Alter ein");
            age = int.Parse(Console.ReadLine());
            switch (age)
            {
                //...usw, alle sind zu klein.
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("Zu jung zum Feiern");
                    break;
                case 25:
                    Console.WriteLine("Alles klar, abgehts");
                    break;
                // wie Else bei einer If Bedingung
                default:
                    Console.WriteLine("Wie alt bist du eigentlich?");
                    break;
            }

            if (age <= 15)
            {
                Console.WriteLine("Zu jung zum Feiern");
            }
            else if (age <= 25)
            {
                Console.WriteLine("Alles klar, abgehts");
            }
            else
            {
                Console.WriteLine("Wie alt bist du eigentlich?");
            }

            string username = "I am Groot";
            Console.WriteLine("Bitte trage deinen Benutzernamen ein(Denis,root,)");
            username = Console.ReadLine();

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("Benutzername ist Denis");
                    break;
                case "root":
                    Console.WriteLine("Benutzername ist root");
                    break;
                default:
                    Console.WriteLine("Benutzername unbekannt");
                    break;
            }
            //--------------------------------------------SWITCH-CASE


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
