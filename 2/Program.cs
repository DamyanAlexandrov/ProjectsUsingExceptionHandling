namespace lab_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validNumbersCount = 0;
            List<int> validNumbers = new List<int>();
            int previousNumber = 1;

            while (validNumbersCount < 10)
            {
                string n = Console.ReadLine();

                try
                {
                    int number = int.Parse(n);

                    if (number <= previousNumber || number >= 100)
                    {
                        throw new ArgumentException($"Your number is not in range {previousNumber} - 100!");
                    }
                    else
                    {
                        validNumbers.Add(number);

                        previousNumber = int.Parse(n);
                        validNumbersCount++;
                    }
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                    continue;
                }
            }

            Console.WriteLine(String.Join(", ", validNumbers));
        }
    }
}
