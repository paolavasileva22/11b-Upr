using System;
using System.Linq;

namespace ZadMasivi1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            while(n-->0)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0].ToLower())
                {
                    case "reverse":
                        {
                            Array.Reverse(arr);
                            break;
                        }
                    case "distinct":
                        {
                            arr = arr.Distinct().ToArray();
                            break;
                        }
                    case "replace":
                        {
                            int index = int.Parse(command[1]);
                            string newWord = command[2];
                            arr[index] = newWord;
                            break;
                        }
                }
                Console.WriteLine(string.Join(", ",arr));
            }
        }
    }
}
