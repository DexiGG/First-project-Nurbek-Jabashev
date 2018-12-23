using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Джабашев Нурбек";
            Console.WriteLine(name);
            Console.WriteLine("--------------------------------------------------");
            const int number = 3;
            int[] arr = new int[number];
            Random rand = new Random();
            int i = 0, Sum = 0;
            for (; i < number; i++)
            {
                arr[i] = rand.Next(0, 10);
                Console.WriteLine(arr[i]);
                Sum += arr[i];
            }
            Console.WriteLine("Сумма равна = " + Sum);
            Console.ReadLine();
        }
    }
}
