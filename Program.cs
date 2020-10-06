using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntscheidungenTreffenLassenIfElseSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            //// if(Bedingung)
            //// {
            ////      auszuführender Code
            //// }

            //Console.WriteLine("Wie warm ist es gerade? Trage den Wert als Zahl ein");
            //// Benutzereingabe
            //string temperatureInput = Console.ReadLine();
            ////int temperature = int.Parse(temperatureInput);
            //int temperature;
            //int number;



            //bool userEnteredANumber = int.TryParse(temperatureInput, out number);       //TRYPARSE!!!

            //if (userEnteredANumber)
            //{
            //    temperature = number;
            //}
            //else
            //{
            //    temperature = 0;
            //}


            //if (temperature < 20)
            //{
            //    Console.WriteLine("Zieh deine Jacke an!");
            //}
            //else if (temperature == 20)
            //{
            //    Console.WriteLine("Es ist genau 20 Grad C° Warm");
            //}
            //else if (temperature > 30)
            //{
            //    Console.WriteLine("Es ist eine Bullenhitze!");
            //}
            //else
            //{
            //    Console.WriteLine("Zwischen 21 und 30 Grad - T-Shirt und kurze Hose reicht!");
            //}


            ////-------------------------------------------------------------------------------Versachtelte If Statements
            //Console.WriteLine("Versachtelte If Statements");

            //bool isAdmin = true;
            //bool isRegistered = true;
            //string userName = "";
            //Console.WriteLine("Bitte trage deinen Benutzernamen ein!");
            //userName = Console.ReadLine();

            //if (isRegistered && userName != "" && userName == "Admin")
            //{
            //    Console.WriteLine("Hallo registrierter Nutzer!");
            //    Console.WriteLine("Hi {0}", userName);
            //    Console.WriteLine("Hallo Admin!");

            //}

            //if (isAdmin || isRegistered)
            //{
            //    Console.WriteLine("Du bist eingeloggt");
            //}

            /*-----------------------------------------Herausforderung If Statements
             * Erstelle ein Benutzer-Login-System, in dem sich der Benutzer zuerst registrieren und dann einloggen kann. 
             * Das Programm sollte überprüfen, ob der Benutzer den richtigen Benutzernamen und das richtige Passwort eingegeben hat, 
             * wenn er sich einloggt (also die gleichen, die er bei der Registrierung verwendet hat).
             * 
             * Da wir das Speichern von Daten noch nicht abgedeckt haben, erstelle das Programm einfach so,
             * dass das Registrieren und Einloggen in der gleichen Ausführung erfolgt.
             * User If-Anweisungen und Benutzereingaben und Methoden zur Lösung der Herausforderung.
             */

            string user1 = "Andres";
            string user2 = "er";
            string user3 = "du";
            string user4 = "Admin";
            bool isUser = false;
            bool isAdmin = false;

            string userName = "";
            Console.WriteLine("Bitte trage deinen Benutzernamen ein!");
            userName = Console.ReadLine();

            bool passwordIsRight = false;
            string savedPassword = "pw";
            string userPassword = "";
            Console.WriteLine("Bitte trage deinen Password ein!");
            userPassword = Console.ReadLine();

            passwordIsRight= userPassword.Equals(savedPassword)?  true:false;


            if (userName.ToUpper().Equals(user1.ToUpper()))
            {
                Console.WriteLine("Willkommen Andrés");
                isUser = true;
                isAdmin = false;
            }
            else if ((userName.ToUpper().Equals(user2.ToUpper())) 
                    ||userName.ToUpper().Equals(user3.ToUpper())) 
            {
                string userNameDisplay = userName.ToUpper().Equals(user2.ToUpper()) ? user2 : user3;
                Console.WriteLine($"Willkommen {userNameDisplay}.");
                isUser = true; 
                isAdmin = false;
            }
            else if (userName.ToUpper().Equals(user4.ToUpper()))
            {
                Console.WriteLine("Willkommen Administrator");
                isUser = true;
                isAdmin = true;
            }
            else
            {
                Console.WriteLine("Sie Sind keine bekannte Benutzer...");
            }


            if (isUser)
            {
                Console.WriteLine("Du bist ein normaler benutzer!");
            }
            else
            {
                Console.WriteLine("Du bist KEIN benutzer! Gehen sie bitte raus.");
            }

            if (isAdmin)
            {
                Console.WriteLine("Du bist ein Administrator! Was wollen Sie administrieren?");
            }
            else
            {
                Console.WriteLine("Du bist KEIN Administrator. Ist aber nicht schlimm.");
            }

            if (passwordIsRight)
            {
                Console.WriteLine("Password ist korrekt, eingelogt.");
            }

            else
            {
                Console.WriteLine("Password ist inkorrekt, ausgelogt.");
            }


            Console.WriteLine("ENDE");
            Console.ReadKey();
        }
    }
}
