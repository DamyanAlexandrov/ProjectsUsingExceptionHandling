namespace lab_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            double overallSum = 0;

            foreach (string ellement in input)
            {

                bool validElement = true;

                try
                {
                    int.Parse(ellement);

                }
                catch (FormatException)
                {

                    Console.WriteLine($"The element '{ellement}' is in wrong format!");
                    validElement = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{ellement}' is out of range!");
                    validElement = false;
                }
                finally
                {
                    if (validElement)
                    {
                        overallSum += double.Parse(ellement);
                    }

                    Console.WriteLine($"Element '{ellement}' processed - current sum: {overallSum}");

                }
            }

            Console.WriteLine($"The total sum of all integers is: {overallSum}");
        }
    }
}
