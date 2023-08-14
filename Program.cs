namespace HeldogLotto
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Trækker ugens numre...");

            Random Random = new();

            List<int> Numbers = new();

            // While list does not contain 7 numbers
            while (Numbers.Count < 7) 
            {
                int Number = Random.Next(1, 37);

                // Don't add the same number twice
                if (!Numbers.Contains(Number)) 
                {
                    Numbers.Add(Number);
                }
            }

            // Loop to find a joker number that doesn't exist in the list
            int Joker;
            do 
            {
                Joker = Random.Next(1, 37);
            }
            while (Numbers.Contains(Joker));

            Numbers.Sort();

            foreach (int Number in Numbers)
            {
                // Output messes up if user interacts with the console so I'm just flushing the input stream
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                Console.Write($"{Number} ");
                Thread.Sleep(2000);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Joker}");
            Console.ResetColor();

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}