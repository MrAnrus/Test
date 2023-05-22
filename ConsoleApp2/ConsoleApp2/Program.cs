using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static int[,] NewMas(int[,] mas, int n) //Процедура для заполнения двухмерного массива
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = r.Next(-100, 100);
                }
            }
            Vivod2m(mas, n);
            return mas;
        }
        static void Vivod2m(int[,] mas, int n) //Процедура для вывода двухмерного массива 
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.Write("\n");
            }
        }
        static void BubbleSort(int[] inArray) //Процедура сортировки одномерного массива методом пузырька
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
        static void Mas1vMas2(int[] mas2, int i, int[,] mas) //Процедура заполнения ряда двухмерного массива из одномерного массива
        {
            for (int j = 0; j < mas2.Length; j++)
            {
                mas[i, j] = mas2[j];
            }
        }
        static int[,] LineSortMas2(int[,] mas, int n) //Процедура сортировки двухмерного массива по строкам
        {
            int[] mas2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas2[j] = mas[i, j]; //Присваиваем одномерному массиву строку двухмерного массива
                }
                BubbleSort(mas2); //Сортируем одномерный массив 
                Mas1vMas2(mas2, i, mas); //Заполняем ряд двухмерного массива одномерным
            }
            Console.WriteLine("\n");
            Vivod2m(mas, n);
            return mas;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, n];
            NewMas(mas, n);
            LineSortMas2(mas, n);
            Console.ReadKey();
        }
    }
}