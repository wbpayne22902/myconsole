namespace MyConsole
{
    /// <summary>
    /// Represents the entry point of the program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main method of the program.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x;
            for (x = 0; x <= 11; x++)
            {
                Console.WriteLine($"This is X = {x}");
            }
            for(int i = 1; i <= args.Length; i++)
            {
                Console.WriteLine($"Argument {i}: {args[i - 1]}");
            }

            Console.WriteLine("Done now!");
        }
    }
}
