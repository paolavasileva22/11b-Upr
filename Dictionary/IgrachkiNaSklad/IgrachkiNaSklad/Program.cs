using System;
using System.Collections.Generic;

namespace IgrachkiNaSklad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> toys = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Stop")
                {
                    foreach (var i in toys)
                    {
                        string toy = i.Key;
                        int quantity = i.Value;
                        Console.WriteLine($"{toy} -> {quantity}");
                    }
                    break;
                }
                if (input[0] == "Purchase")
                {
                    string toy = input[1];
                    int quantity = int.Parse(input[2]);
                    if (!toys.ContainsKey(toy))
                    {
                        if (toy.StartsWith("d"))
                        {
                            toys.Add(toy, quantity);
                        }
                        else
                        {
                            Console.WriteLine("Input is not correct!");
                        }
                    }
                    else
                    {
                        toys[toy] += quantity;
                    }
                }

                    if (input[0] == "Sale")
                {
                    string toy = input[1];
                    if (toys.ContainsKey(toy))
                    {
                        foreach (var i in toys)
                        {
                            int quantity = i.Value;
                            if (toys.ContainsKey(toy))
                            {
                                Console.WriteLine(quantity--);
                            }
                            }
                        }
                    }
                else
                {
                    Console.WriteLine($"{toys} does not exist!");
                }
                foreach(var i in toys)
                {
                    int quantity = i.Value;
                    if (quantity == 0)
                    {
                        Console.WriteLine("Sale is not allowed!");
                    }
                }
            }
                }
        }
    }

