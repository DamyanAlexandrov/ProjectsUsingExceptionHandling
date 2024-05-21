namespace lab_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",").ToArray();

            Dictionary<int, double> accounts = new Dictionary<int, double>();

            foreach (string accData in input)
            {
                string[] strings = accData.Split('-');

                accounts.Add(int.Parse(strings[0]), double.Parse(strings[1]));
            }

            while (true)
            {
                try
                {
                    string[] commands = Console.ReadLine().Split();

                    if (commands[0] == "Deposit")
                    {
                        if (!accounts.ContainsKey(int.Parse(commands[1])))
                        {
                            throw new Exception("Invalid account!");
                        }

                        accounts[int.Parse(commands[1])] += double.Parse(commands[2]);
                        Console.WriteLine($"Account {commands[1]} has new balance: {accounts[int.Parse(commands[1])]:f2}");
                        Console.WriteLine("Enter another command");
                    }
                    else if (commands[0] == "Withdraw")
                    {
                        if (!accounts.ContainsKey(int.Parse(commands[1])))
                        {
                            throw new Exception("Invalid account!");
                        }

                        if (accounts[int.Parse(commands[1])] < double.Parse(commands[2]))
                        {
                            throw new Exception("Insufficient balance!");
                        }
                        else
                        {
                            accounts[int.Parse(commands[1])] -= double.Parse(commands[2]);
                            Console.WriteLine($"Account {commands[1]} has new balance: {accounts[int.Parse(commands[1])]:f2}");
                            Console.WriteLine("Enter another command");
                        }
                    }
                    else if (commands[0] == "End")
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception("Invalid command!");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter another command");
                    continue;
                }
            }
        }
    }
}
