using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadanieSpisuci
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> names = Console.ReadLine().Split().ToList();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                   // Console.WriteLine(string.Join(" ", names));
                    break;
                }
                if (int.TryParse(input, out int n) == true)
                {
                    names.Sort();
                    Console.WriteLine(string.Join(" ", names));
                    break;
                }
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "add":
                            string element = commands[1];
                            if (!names.Contains(commands[1]))
                            {
                                names.Add(element);
                            }
                            else
                            {
                                Console.WriteLine("Element already exists!");
                            }
                            break;
                    case "contains":
                        string element1 = (commands[1]);
                        if(names.Contains(element1))
                            {
                            Console.WriteLine(names.IndexOf(element1));
                        }
                        break;
                    case "insert":
                        int index = int.Parse(commands[1]);
                        for (int i = 0; i < names.Count; i++)
                        {
                            names[i] = names[i];
                        }
                        break;
                    case "print":
                        if (input == "print")
                        {
                            Console.WriteLine(string.Join(" ", names));
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
