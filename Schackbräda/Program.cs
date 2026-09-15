using System.Security.AccessControl;

namespace Schackbräda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Be användaren om storleken och spara i en variabel

            Console.WriteLine("Skriv storlek på din schackbräda som du vill ha.");
            int StorLek = int.Parse(Console.ReadLine());


            // Tillåter mig använda symboler.// Detta googlade jag fram faktiskt :D 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            
            // 2. Skapa en loop för raderna (uppifrån och ner)
            for (int rad = 0; rad < StorLek; rad++)
            {
                for (int kolumn = 0; kolumn < StorLek; kolumn++)
                {
                    if ((rad + kolumn) % 2 == 0)
                    {
                        Console.Write("■ ");
                    }
                    else
                    {
                        Console.Write("□ ");
                    }
                }
                Console.WriteLine();
            }

            
        }
    }
}
