using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace Erster_Modultag;

class Program
{
    static void Main(string[] args)
    {
        //Abschnitt für das Titelbild
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");



        Console.Write("                        Entkomme dem Traum                    ");




        Console.WriteLine("         Versuche, dem traumartigen Labyrinth in dir zu entkommen!           ");


        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");
        Console.WriteLine("**************************************************");






        Console.WriteLine("Drücke eine beliebige Tatse und bestätige mit der Enter-Taste um das Spiel zu starten!");


        //Einlesen der Eingabe um das Spiel zu starten.



        Console.ReadKey();
       
       




            //Szene 1
            //Einführungstext schreiben
            Console.WriteLine("Um dich herum schwingen sich schattenartige Gebilde in die Höhe, alles dreht sich. Dann fallen kleine Spinnen auf dich, sie rieseln neben dir auf den Boden und immer höher werdend drohen sie, dich wie Treibsand zu verschlingen. Kreischend reisst du die Augen auf, doch dein schriller Schrei hörst du nur in deinem Schädel widerhallen. Du bist irgendwie wach, aber dabei stehst du in deinem Traum. Gefangen. Doch plötzlich spürst du die Spinnen an dir hochkrabbeln, und es fühlt sich real an. Die Bisse schmerzen und du bekommst Panik.  ");

        //OptionA
        Console.WriteLine("a:Scheisse! Denkst du und schnappst nach Luft. Du musst hier irgendwie weg.");

        //hier Antwort X eingeben 0.o Wie?

        //OptionB
        Console.WriteLine("b: das ist nur ein Traum denkst du dir. Das hier ist alles nicht real und es kann dir nichts passieren. Ich muss mich einfach fallen und von der Dunkelheit begraben lassen. Dann wache ich auf. ");
        Console.WriteLine("Schreibe a oder b, bestätige mit der Enter-Tast");
        // Einlesen der eingabe
        string eingabe = Console.ReadLine();

        if (eingabe.ToLower() == "a")
        {
            //Szene 2
            //Einführungstext schreiben
            Console.WriteLine("Du watest durch die Spinnenflut, hustest und spuckst dabei Spinnen aus, die in deinen Mund hinein krabbeln. Deine Finger berühren einen kalten Fels. Du ziehst dich an einem Felsvorsprung heran, schlitzt dir dabei deine Handfläche auf, doch egal, langsam ertastet deine Hand einen Spalt, deine Füsse finden Halt, du stosst dich hinauf, bohrst deinen rechten Zehen in einen Spalten und erwischst mit deiner linken Hand einen Grasbüschel über dir. Du hältst dich daran fest, hievst dich hoch auf die Fläche über dir. Bäuchlings und keuchend liegst du da, die letzten Spinnen krabbeln aus deinen Haaren heraus und fliehen quikend ins Dunkle. Du rollst dich auf den Rücken. Über dir funkeln dich die Sterne an. Der Mond scheint ruhig und gross und silbern zu dir herunter.  Du hörst einen Bach liebevoll plätschern in der Nähe, sein gurgeln ruft dir zu, von seinem köstlichen, klaren Wasser zu trinken.  \r\nAm Bach kniest du in die Nasse Erde, deine Hosen ziehen sich voll, aber es stört nicht, dass sie dreckig davon sind, denn du fühlst dich frei und unbekümmert, du formst deine Hände zu einer Wasserschale und trinkst von dem kühlen Bergwasser. \r\nMit geschlossenen Augen fährt der Schock der Erfrischung durch deinen Kopf. Plötzlich erklingt eine Stimme, als heller Strahl blitzt sie in dir auf und durchrauscht deine dunklen Gedanken wie ein Lichtstrahl am Horizont, als würde der Mond in dir versinken, um sich unbeobachtet eine weitere Runde durch den Singsang der Planetaren Irrwege zu bahnen. Wie ein Uhrwerk wird dir klar, dass du gefangen bist, aber du weisst nicht wo, du weisst nicht wie und auch nicht warum.  Die Stimme fragt dich: \r\nWillst du erfahren, wieso du hier gefangen bist?\r\n");
            // Ja oder nein?
            Console.WriteLine("Antworte mit Ja oder Nein");
            // Einlesen der eingabe
            string eingabe2 = Console.ReadLine();
            if (eingabe2.ToLower() == "ja")
            {
                //Szene 3
                Console.WriteLine("Also gut. Dann werde ich dich nun auf ein Abenteuer schicken. Du musst die Antwort finden, denn du willst. Du hast 4 mögliche Wege zur Auswahl, um eine Antwort für dich zu finden. Entweder du gehst in das Labyrinth, oder du fragst dein Büsi, oder du liest das dicke Buch, dass in der Bibliotheke im Turm hoch über den Wolken steht... oder du nimmst das Schiff am Hafen von Piirania-City und segelst bis zum Südpol und schaust ins glitzrige Eis der Eisscholle, bis dir dein Spiegelbild eine Antwort gibt. Dies sind die Antworten. Wähle 1 -4.");
                // Einlesen der eingabe
                string AntwortText = Console.ReadLine();
                //  Convertieren strin to int
                int Antwortmöglichkeiten;
                Antwortmöglichkeiten = Convert.ToInt32(AntwortText);
                switch (Antwortmöglichkeiten)
                {
                    case 1:
                        Console.WriteLine("Du möchtest also in das Labyrinth. Dort blabla");
                        //hier könnte das nächste if stehen: Einführungstext mit Auswahlmöglichkeiten-->string eingabe = Console.ReadLine();-->if (eingabe == "a(oder was zur auswahl steht)")-->die else Option noch beifügen.
                        break;
                    case 2:
                        Console.WriteLine("Ok, das Büsi kommt zu dir, es schnurrt und streicht dir um die Beine. Vor lauter entspannung schläfst du ein und als du wieder aufwachst, merkst du, dass alles nur ein böser Traum gewesen ist. Puh! Alles tamam.");
                        break;
                    case 3:
                        Console.WriteLine("Du wanderst monatelang, bis du den Hafen von Piranya-City erreichst. Dort steigst du auf ein Schiff und segelst durch die 7 Weltmeere. Dort erfährst du so viel, dass du du vor lauter Meeresböhe vergisst, dass du in Gefangeschaft bist, und darum bist du dann also frei");
                        break;
                    case 4:
                        Console.WriteLine("Los! Lichtet die Segel! Die Antwort wird mir am Südpol entgegenscheinen. Du reist bis zum Südpol doch dort erfrierst du, denn es ist zu kalt. So wirst du die Antwort nie erfahren.");
                        break;
                    default:
                        Console.WriteLine("Ungültige Antwort! Du musst aus Antwort 1, 2, 3, 4 wählen ");
                        break;
                }

            }
            else if (eingabe2.ToLower() == "nein")
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("default. schreibe Ja oder Nein");
            }
        }
        else if(eingabe.ToLower() == "b")
        {
            Console.WriteLine("Du lässt dich fallen und die schwarzen kleinen Spinnenkörper decken dich bald schon zu, Schwärze umgibt dich. Ihre tausenden kleinen Bisse schmerzen zwar noch, aber bald schon ist es vorbei. Du wachst wieder auf, aber der Raum ist der gleiche und schon geht oben eine Lucke auf und alles geht wieder von vorne los. Game Over");
        }
        else
        {
            Console.WriteLine("");
        }
        Console.ReadKey();    
    }
    // Zusätzliche Klasse mit einer erweiterten Console.ReadLine Funktion mit einer TimeOut-Funktion die wir nicht programmiert haben, da dies zu kompliziert ist.
    class Reader
    {
        private static Thread inputThread;
        private static AutoResetEvent getInput, gotInput;
        private static string input;
    }
}


 
