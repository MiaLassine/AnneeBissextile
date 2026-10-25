//Programme : Exercice conversation de température
//Creator : Mia Lassine 107B
//Date : 25/10/2026

namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

        Console.WriteLine("Veuillez indiquer une année :");
        Console.WriteLine("------------------------------------------------------------------");

        string stringYear = Console.ReadLine();
        int intYear = Convert.ToInt32(stringYear);
        Console.WriteLine("------------------------------------------------------------------");

        if (intYear % 400 == 0)
        {
            Console.WriteLine("L'année " + intYear + " est paire.");
        }
        else if(intYear % 100 == 0)
        {
            Console.WriteLine("L'année " + intYear + " est impaire.");
        }
        else if(intYear % 4 == 0)
        {
            Console.WriteLine("L'année " + intYear + " est paire.");
        }
        else
        {
            Console.WriteLine("L'année " + intYear + " est impaire.");
        }
    }
}