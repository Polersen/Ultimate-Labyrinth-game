namespace UltimateLabyrinthGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovementLoop();
        }
        public static void MovementLoop()
        {
            do
            {
                var keypress = Console.ReadKey();
                if (keypress.Key == ConsoleKey.UpArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå upp");
                }
                else if (keypress.Key == ConsoleKey.DownArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå ner");
                }
                else if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå Vänster");
                }
                else if (keypress.Key == ConsoleKey.RightArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå höger");
                }
                else if (keypress.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            while (true);
        }
    }
}