using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void f1()
        {

            Console.WriteLine("Работа с одномерным массивом.");
            Console.Write("Введите количество чисел: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0) Console.WriteLine("Размер массива не может быть равен 0");
            else
            {
                Console.Write("Введите число, с которым будет происходить сравнение остальных чисел: ");
                double number = Convert.ToDouble(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine("Введите числа: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] < number) arr[i] *= 2;
                }
                Console.WriteLine("Вывод результата: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i]);
                    if (i < arr.Length - 1) Console.Write(", ");
                }
            }
        }

        static void f2()
        {
            Console.WriteLine("Работа с двумерным массивом.");
            Console.WriteLine("Введите размерность массива: ");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (n <= 0 || m <= 0) Console.WriteLine("Размер массива не может быть равен 0 или быть отрицательным");
            else
            {
                Console.Write("Введите число, с которым будет происходить сравнение остальных чисел: ");
                double number = Convert.ToDouble(Console.ReadLine());
                int[,] arr = new int[n, m];
                Console.WriteLine("Введите числа: ");
                for (int i = 0; i < n; i++)
                {
                    string[] a = Console.ReadLine().Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        if (Convert.ToInt32(a[j]) < number) arr[i, j] = Convert.ToInt32(a[j]) * 2;
                        else arr[i, j] = Convert.ToInt32(a[j]);
                    }
                }
                Console.WriteLine("Вывод результата: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++) Console.Write(arr[i, j] + "  ");
                    Console.WriteLine();
                }
            }

        }
        static void Main(string[] args)
        {           
                try
                {
                    f1();
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine();
                    f2();
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод данных");
                }
            Console.ReadKey();


}
    }
}
