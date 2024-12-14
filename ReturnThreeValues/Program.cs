namespace ReturnThreeValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            if(int.TryParse(Console.ReadLine(), out int consoleInput))
            {
                var output1 = ReturnThreeValues(consoleInput, out double output2, out int  output3);
                Console.WriteLine("Dane wyjściowe:\n" +
                    "plus jeden: {0}\n" +
                    "połowa: {1:F}\n" +
                    "dwukrotność: {2}",
                    output1, output2, output3);
            }
        }

        public static int ReturnThreeValues(int value, out double half, out int twice)
        {
            half = value / 2f;
            twice = value * 2;
            return value+1;
        }
    }
}
