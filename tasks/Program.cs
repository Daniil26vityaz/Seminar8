using MyLib;
namespace tasks;

class Program
{
    static void Main(string[] args)
    {


        //==========Задача 54: Задайте двумерный массив.
        //  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2


        void Task54()
        {
            int rows = MyLibClass.Input("Введите количество строк двумерного массива: ");
            int columns = MyLibClass.Input("Введите количество столбцов двумерного массива: ");
            int[,] Matr = new int[rows, columns];
            MyLibClass.FillMatrix(Matr, -9, 9);
            MyLibClass.PrintMatrix(Matr);
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    for (int k = 0; k < Matr.GetLength(1) - j - 1; k++)
                    {
                        if (Matr[i, k] < Matr[i, k + 1])
                        {
                            (Matr[i, k], Matr[i, k + 1]) = (Matr[i, k + 1], Matr[i, k]);
                        }
                    }
                }
            }
            MyLibClass.PrintMatrix(Matr);
        }

        Task54();


        // Задача 56: Задайте прямоугольный двумерный массив.
        // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


        void Task56()
        {
            int rows = 5;
            int columns = 7;
            int[,] Matr = new int[rows, columns];
            MyLibClass.FillMatrix(Matr, -9, 9);
            MyLibClass.PrintMatrix(Matr);
            int min = Int32.MaxValue;
            int indexMin = 0;

            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    sum += Matr[i, j];
                }
                if (min > sum)
                {
                    min = sum;
                    indexMin = i;
                }
            }
            Console.Write($"минимальная сумма в(о) {indexMin + 1} строке = {min}");
        }

        Task56();


        // Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07

        void Task58()
        {
            int rows = 4;
            int columns = 4;
            int[,] Matr = new int[rows, columns];
            int i = 0;
            int j = 0;
            int delta_i = 0;
            int delta_j = 1;
            int steps = columns;
            int turns = 0;
            for (int k = 0; k < Matr.Length; k++)
            {
                Matr[i, j] = k + 1;
                steps--;

                if (steps == 0)
                {
                    steps = rows - 1 - turns / 2;
                    turns++;
                    int temp = -delta_i;
                    delta_i = delta_j;
                    delta_j = temp;
                }
                i += delta_i;
                j += delta_j;
            }
            MyLibClass.PrintMatrix(Matr);
        }

        Task58();


    }
}
