using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace Bewerbungsgespräch
{
    class Program
    {
        static bool showMenu = true;
        static void Main(string[] args)
        {


            while (showMenu)
            {
                mainMenu();
            }
        }

        private static void mainMenu()
        {
            Console.Title = "Hauptmenü";
            Console.Clear();
            Console.SetWindowSize(180, 50);
            Console.SetWindowPosition(0, 0);
            Console.WriteLine("Herzlich Willkommen bei meinem Bewerbungsgespräch.");
            Console.WriteLine("Mein Name ist Ditlind Hani und ich möchte mich hiermit interaktiv auf Ihre Ausbildungsstelle bewerben.");
            Console.WriteLine("Um im Menü zu navigieren, müssen Sie jeweils die möglichen Zahlen eingeben:");
            Console.WriteLine();
            Console.WriteLine("1) Über mich");
            Console.WriteLine("2) Was ich über Sie wissen möchte");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nWählen Sie einen Menüpunkt: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ÜberMich();
                    break;
                case "2":
                    ÜberSie();
                    break;
                case "3":
                    showMenu = false;
                    break;
            }
        }

        private static void ÜberSie()
        {
            Console.Title = "Hauptmenü";
            Console.Clear();
            Console.WriteLine("An dieser Stelle würde ich den Spieß gerne umdrehen und von Ihnen in erfahrung bringen, wieso Sie mein richtiger Arbeitgeber sind.");
            Console.WriteLine("Das Vorgehen wird folgendermaßen ablaufen:");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sie kriegen von mir Fragen gestellt auf die Sie per Eingabe antworten können.");
            Console.WriteLine("Am Ende des Interviews können Sie entscheiden, ob das Programm eine .txt Datei erstellen soll, in der Die Fragen + Antworten übersichtlich aufgeführt sind.");
            Console.WriteLine("Sollten Sie an einem persönlichen Gespräch interessiert sein, würde ich Sie bitten mich per Mail zu kontaktieren, sodass wir einen Termin vereinbaren können. Meine Email finden Sie im Untermenü \"Über mich\"");
            Console.Write("\r\nWenn sie bereit sind bestätigen Sie mit 1, andernfalls drücken Sie 0 um ins Hauptmenü zu gelangen: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Fragespiel();
                    break;
                case "0":
                    mainMenu();
                    break;
            }




        }

        private static void Fragespiel()
        {

            Console.Title = "Ausbildungsgeber";
            Console.Clear();
            ArrayList Interview = new ArrayList();
            ArrayList Fragen = new ArrayList();

     
            Fragen.Add("Besteht die Möglichkeit der Verkürzung der Ausbildung? Wenn Ja, wovon ist dies abhängig");
            Fragen.Add("Mit welcher Ausbildungsvergütung ist geplant?");
            Fragen.Add("Bestehen Übernahmechancen nach der Ausbildung?");
            Fragen.Add("Welche Fortbildungsmaßnahmen hat man während der Ausbildung?");
            Fragen.Add("Kriegen Auszubildende bei Ihnen Verantwortung übertragen?");
            Fragen.Add("Welche außerunternehmischen Aktivitäten werden gefördert?");
            Fragen.Add("Profitieren auch Auszubildende von Benefits wie andere Mitarbeiter?");


            foreach (String frage in Fragen)
            {
                Console.Clear();
                Console.WriteLine("Frage " + (Fragen.IndexOf(frage) + 1) + " von " + (Fragen.Count));
                Console.WriteLine();
                Console.WriteLine(frage);
                Console.WriteLine();
                Console.Read();
                Interview.Add("Die Frage war "+frage);
                Interview.Add("Ihre Antwort: " + Console.ReadLine());
            }

            Console.WriteLine("Sie haben mein Kreuzverhör überstanden. Es ist nun Ihnen überlassen zu Entscheiden ob Sie eine Übersicht im .txt Format möchten oder nicht.");
            Console.WriteLine("Für eine Datei wählen Sie 1. ");
            Console.WriteLine("Andernfalls gelangen Sie mit der 0. zurück ins Hauptmenü");
            switch (Console.ReadLine())
            {
                case "1":
                    dateischreiben(Interview);
                    break;
                case "0":
                    mainMenu();
                    break;
            }
        }

        private static void dateischreiben(ArrayList Interview)
        {
            String Speicherort = "";
            Console.Clear();
            Console.Title = "Interview speichern";
            Console.Write("geben Sie den Speicherort zum abspeicher der Datei im Format \"C:\\Temp\" ein: ");
            Speicherort = Console.ReadLine();
            Console.WriteLine("Die Datei wird auf folgendem Verzeichnis abgespeichert: " + Speicherort + "\\Interview.txt");
            try
            {
                System.IO.File.WriteAllLines(Speicherort + "\\Interview.txt", Interview.Cast<string>());
                Console.WriteLine("Das abspeichern war erfolgreich.");
                Thread.Sleep(3000);
                mainMenu();
            }
            catch (Exception e) {
                Console.WriteLine("Es ist zu Fehlern beim abspeichern gekommen. Möglicherweiße verfügen Sie nicht über genug Berechtigungen.");
                Console.WriteLine("Sie werden wieder ins Hauptmenü gebracht.");
                Thread.Sleep(3000);
                mainMenu();
            }


        }

        private static void ÜberMich()
        {
            Console.Title = "Über mich";
            Console.Clear();
            Console.WriteLine("Mein Name ist Ditlind Hani, geboren am 26.03.1994 in Struga einer wunderschönen Stadt in Nordmazedonien.");
            Console.WriteLine("aufgewachsen bin ich seit meinem vierten Lebensjahr in der Kleinstadt Siegen.");
            Console.WriteLine("Hier habe ich meinen Realschulabschluss mit Q-Vermerk, mein Abitur, sowie einige Semester an der Hochschule bestritten.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Neben meiner Leidenschaft für das Programmieren, bin ich in meiner Freizeit gerne auf dem Fußballplatz oder im Fitnessstudio.");
            Console.WriteLine("Dort finde ich immer wieder den Ausgleich zu meinem aktuellen Job.");
            Console.WriteLine("Möchten Sie mehr über meine aktuellen und vergangen Projekte Erfahren, dann zögern Sie nicht und begeben sich in Tür Nummer 2.");
            Console.WriteLine("Wenn Sie sich für Tür Nummer 1 entscheiden, können Sie meinen tabellarischen Lebenslauf einsehen.");
            Console.WriteLine("Möchten Sie alles ungeschehen machen, dann drehen Sie doch an der Zeit und begeben sich mit 3 direkt zurück ins Hauptmenü.");
            Console.WriteLine("Haben Sie genug gesehen und möchten mich wieder los werden, so wählen Sie die 4.");
            Console.WriteLine("1) Tabellarischer Lebenslauf");
            Console.WriteLine("2) Projekte");
            Console.WriteLine("3) Hauptmenü");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nWählen Sie einen Menüpunkt: ");

            switch (Console.ReadLine())
            {
                case "1":
                    TabellarischerLebenslauf();
                    break;
                case "2":
                    projekte();
                    break;
                case "3":
                    mainMenu();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Vielen dank für Ihre Aufmerksamkeit");
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    showMenu = false;
                    break;
            }
        }

        private static void projekte()
        {
            Console.Title = "Projekte";
            Console.Clear();
            Console.WriteLine("Während meiner Werkstudententätigkeit bei der QdKC GmbH in Siegen, konnte ich mein Vorwissen in der Softwareentwicklung, welches ich im Studium erlangt habe positiv einbringen.");
            Console.WriteLine("Zu meinem Aufgabengebiet gehörten neben der Microsoft Dynamics NAV Programmierung in der Sprache AL vorallem die Kundenspezifischen anpassungen im Dokumentenmanagementsystem D3.");
            Console.WriteLine("");
            Console.WriteLine("Hier war ich selbstständig dafür Verantwortlich, dass z.B Anhänge aus MSG-Dateien (Emails die auf der Platte abgespeichert wurden) in ein gewisses Verzeichnis abgelegt und vom Serverprozess abgeholt wurden.");
            Console.WriteLine("Anschließend musste ich dafür sorgen, dass eine UPD-Datei geschrieben wurde -welche von einem weiteren Serverprozess verarbeitet werden- um so die zuvor abgelegten Dateien nach dem RenditionService automatisch zu Verschlagworten. ");
            Console.WriteLine("");
            Console.WriteLine("Diese Aufgaben konnte ich stets und mit guter Vorsicht in den Programmiersprachen Java und C#.Net umsetzen.");
            Console.WriteLine("Zusätzlich dazu musste ich auch per SQL und Groovy-Script-Language verschiedene Operationen an Datenbanken ausführen, um so an die nötigen Daten zu gelangen.");
            Console.WriteLine();
            Console.WriteLine("Gerne kann ich Ihnen einen Link zu meinem privaten Git-Repository zukommen lassen, sodass Sie sich mehr Eindrücke verschaffen können.");
            Console.WriteLine("1.) kehren Sie zurück zur Seite \"Über mich\"");
            Console.WriteLine("2.) Hauptmenü");
            Console.WriteLine("3.) Exit");
            Console.Write("\r\nWählen Sie einen Menüpunkt: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ÜberMich();
                    break;
                case "2":
                    mainMenu();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Vielen dank für Ihre Aufmerksamkeit");
                    Thread.Sleep(2000);
                    System.Environment.Exit(0);
                    showMenu = false;
                    break;
            }

        }

        private static void TabellarischerLebenslauf()  
        {
            Console.Title = "Tabellarischer Lebenslauf";
            Console.Clear();
            Console.WriteLine("**************************************Über mich**************************************");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("***Name***********************************************************************Hani***");
            Console.WriteLine("***Vorname*****************************************************************Ditlind***");
            Console.WriteLine("***Straße***********************************************************Am Wolfshain 2***");
            Console.WriteLine("***Ort***************************************************************57250 Netphen***");
            Console.WriteLine("***Tel.**************************************************************01578 2284389***");
            Console.WriteLine("***Mail*************************************************ditlindhani@googlemail.com***");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++Bildungsweg+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("***2010-2013*********************************************Allgemeine Hochschulreife***");
            Console.WriteLine("***2013-2017*******************************Wirtschaftsinformatik (90CP) Uni Siegen***");
            Console.WriteLine("***2017-Heute**************************************Medienwissenschaften Uni Siegen***");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++Berufserfahrung+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("***2013-2017***************************************Horn und Co., Siegen IT-Support***");
            Console.WriteLine("***2017-2018***************************Weber Geräte, Freudenberg Marketing Manager***");
            Console.WriteLine("***2018-2019**********Dornseifer Personaldienstleister, Siegen IT-Verantwortlicher***");
            Console.WriteLine("***2019-Heute**************************************QdKC, Siegen Softwareentwickler***");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("1.) kehren Sie zurück zur Seite \"Über mich\"");
            Console.WriteLine("2.) Hauptmenü");
            Console.Write("\r\nWählen Sie einen Menüpunkt: ");

            switch (Console.ReadLine()) {
                case "1":
                    ÜberMich();
                    break;
                case "2":
                    mainMenu();
                    break;
            }
        }
    }
}
