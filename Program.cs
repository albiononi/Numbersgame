namespace Numbersgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nu skapar jag en tekst som läses upp på terminal när man startar det.
            Console.WriteLine("Välkommen, jag tänker på ett nummer kan du gissa vilket? du får fem försök.");

            //denna funktionen ska göra så att systemet slumpar fram ett random nummer från 1 till 21
            Random random = new Random();
            int hemligtTal = random.Next(1, 21);

            bool gissadeRett = false;

            //här skapar jag en loop för sjäva gissningen så att man har fem försök på att gissa rätt
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("gissa på ett tal:");
                int gissning = int.Parse(Console.ReadLine());

                gissadeRett = CheckGuess(gissning, hemligtTal);

                if (gissadeRett)
                {
                    break;
                }
            }

            if (!gissadeRett)
            {
                Console.WriteLine("tyvärr så lyckades du inte gissa talet på fem försök!");
            }
        }

        //här har jag skapat tre olika returns baserat på hur fu gissade i spelet.
        static bool CheckGuess(int gissning, int hemligtTal)
        {
            if (gissning == hemligtTal)
            {
                Console.WriteLine("wohhooo! Du gjorde det!");
                return true;
            }
            else if (gissning < hemligtTal)
            {
                Console.WriteLine("tyvärr så gissade du för lågt!");
                return false;
            }
            else
            {
                Console.WriteLine("tyvärr så gissade du för högt!");
                return false;
            }
        }
    }
}