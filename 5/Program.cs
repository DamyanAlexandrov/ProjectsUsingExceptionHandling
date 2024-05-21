namespace lab_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int exceptions = 0;

            while (exceptions < 3)
            {
                string[] commands = Console.ReadLine().Split(" ");

                if (commands[0] == "Replace")
                {
                    try
                    {
                        if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) > nums.Count())
                        {
                            throw new IndexOutOfRangeException("The index does not exist!");
                        }
                        nums[int.Parse(commands[1])] = int.Parse(commands[2]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);

                        exceptions++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");

                        exceptions++;
                    }
                }
                else if (commands[0] == "Show")
                {
                    try
                    {
                        if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) > nums.Count())
                        {
                            throw new IndexOutOfRangeException("The index does not exist!");
                        }

                        Console.WriteLine(nums[int.Parse(commands[1])]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                        exceptions++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                    }
                }
                else if (commands[0] == "Print")
                {
                    try
                    {
                        if (int.Parse(commands[1]) < 0 || int.Parse(commands[2]) >= nums.Count())
                        {
                            throw new IndexOutOfRangeException("The index does not exist!");
                        }

                        int end = int.Parse(commands[2]);

                        List<int> numsToPrint = new List<int>();

                        for (int i = int.Parse(commands[1]); i <= end; i++)
                        {
                            numsToPrint.Add(nums[i]);
                        }

                        Console.WriteLine(String.Join(", ", numsToPrint));
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                        exceptions++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptions++;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
