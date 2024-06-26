namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            try
            {
                if (number < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(number));
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
