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



        //Herausforderung If Statements 2
        static string playerName, newplayerName;
        static int highScore, newScore;


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
            //Register();
            //Login();
            //Console.ReadKey();
            ////}


            //-----------------------------------SWITCH-CASE
            // Alter
            //int age = 16;
            //Console.WriteLine("Bitte trage deinen Alter ein");
            //age = int.Parse(Console.ReadLine());
            //switch (age)
            //{
            //    //...usw, alle sind zu klein.
            //    case 9:
            //    case 10:
            //    case 11:
            //    case 12:
            //    case 13:
            //    case 14:
            //    case 15:
            //    case 16:
            //    case 17:
            //        Console.WriteLine("Zu jung zum Feiern");
            //        break;
            //    case 25:
            //        Console.WriteLine("Alles klar, abgehts");
            //        break;
            //    // wie Else bei einer If Bedingung
            //    default:
            //        Console.WriteLine("Wie alt bist du eigentlich?");
            //        break;
            //}

            //if (age <= 15)
            //{
            //    Console.WriteLine("Zu jung zum Feiern");
            //}
            //else if (age <= 25)
            //{
            //    Console.WriteLine("Alles klar, abgehts");
            //}
            //else
            //{
            //    Console.WriteLine("Wie alt bist du eigentlich?");
            //}

            //string username = "I am Groot";
            //Console.WriteLine("Bitte trage deinen Benutzernamen ein(Denis,root,)");
            //username = Console.ReadLine();

            //switch (username)
            //{
            //    case "Denis":
            //        Console.WriteLine("Benutzername ist Denis");
            //        break;
            //    case "root":
            //        Console.WriteLine("Benutzername ist root");
            //        break;
            //    default:
            //        Console.WriteLine("Benutzername unbekannt");
            //        break;
            //}
            //--------------------------------------------SWITCH-CASE



            //Herausforderung If Statements 2

            InputPlayerAndHighScore();
            do
            {
                InputnewScore();
                checkNewHighScore(newplayerName, newScore);
            } while (!string.IsNullOrEmpty(newplayerName));

            //Herausforderung If Statements 2 Ende

            Console.WriteLine("ENDE");
            Console.ReadKey();
        }

        //Herausforderung If Statements 2
        public static void InputPlayerAndHighScore()
        {
            Console.WriteLine("Bitte trage deinen PlayerName ein:");
            playerName = Console.ReadLine();
            Console.WriteLine("Bitte trage dein HighScore ein!");
            highScore = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");
        }
        public static void InputnewScore()
        {
            Console.WriteLine("Bitte trage deinen NEW PlayerName ein(LEER zum beenden):");
            newplayerName = Console.ReadLine(); 
            Console.WriteLine("Bitte trage dein NEW Score ein!(mindestens 0)");
            newScore = int.Parse(Console.ReadLine());
        }

        public static void checkNewHighScore(string newplayerName, int newScore)
        {
            if(newScore >= highScore)
            {
                // save the new highscore value and name
                highScore = newScore;
                playerName = newplayerName;
                Console.WriteLine($"Neuer highscore ist: {highScore}");
                Console.WriteLine($"Neuer Rekordhalter ist: {playerName}");
            }
            else
            {
                Console.WriteLine($"Der alte highscore von: {highScore} konnte nicht gebrochen werden \nund wird immer noch gehalten von {playerName}");
            }
        }
        //-------------Herausforderung If Statements 2 ENDE

        /////// <summary> Herausforderung If Statements 2  Lehrer Lösung
        /////// // höchste Punktzahl
        ////static int highscore = 300;
        ////// Rekordhalter
        ////static string highscorePlayer = "Denis";

        ////static void Main(string[] args)
        ////{
        ////    CheckHighscore(255, "Frank");
        ////    CheckHighscore(325, "Michaela");
        ////    CheckHighscore(270, "Guido");
        ////    Console.ReadKey();
        ////}

        ////public static void CheckHighscore(int score, string playerName)
        ////{
        ////    if (score > highscore)
        ////    {
        ////        highscore = score;
        ////        highscorePlayer = playerName;

        ////        Console.WriteLine("Neuer Highscore ist {0}", score);
        ////        Console.WriteLine("Neuer Rekordhalter ist {0}", playerName);
        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine("Der alte Highsore konnte nicht gebrochen werden. Er ist immer noch " +
        ////            "{0} und wird von {1} gehalten", highscore, highscorePlayer);
        ////    }
        ////}
        /////// 
        /// </summary>



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
