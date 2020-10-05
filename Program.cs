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

            // if(Bedingung)
            // {
            //      auszuführender Code
            // }
            Console.WriteLine("Wie warm ist es gerade? Trage den Wert als Zahl ein");
            // Benutzereingabe
            string temperatureInput = Console.ReadLine();
            //int temperature = int.Parse(temperatureInput);
            int temperature;
            int number;



            bool userEnteredANumber = int.TryParse(temperatureInput, out number);       //TRYPARSE!!!

            if (userEnteredANumber)
            {
                temperature = number;
            }
            else
            {
                temperature = 0;
            }


            if (temperature < 20)
            {
                Console.WriteLine("Zieh deine Jacke an!");
            }
            else if (temperature == 20)
            {
                Console.WriteLine("Es ist genau 20 Grad C° Warm");
            }
            else if (temperature > 30)
            {
                Console.WriteLine("Es ist eine Bullenhitze!");
            }
            else
            {
                Console.WriteLine("Zwischen 21 und 30 Grad - T-Shirt und kurze Hose reicht!");
            }


            //-------------------------------------------------------------------------------Versachtelte If Statements
            Console.WriteLine("Versachtelte If Statements");

            bool isAdmin = true;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Bitte trage deinen Benutzernamen ein!");
            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName == "Admin")
            {
                Console.WriteLine("Hallo registrierter Nutzer!");
                Console.WriteLine("Hi {0}", userName);
                Console.WriteLine("Hallo Admin!");

            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("Du bist eingeloggt");
            }

            Console.WriteLine("ENDE");
            Console.ReadKey();
        }
    }
}
