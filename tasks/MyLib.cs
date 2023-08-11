namespace MyLib;

public static class MyLibClass
{
    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void FillArray(int[] array, int minValue = -10, int maxValue = 10)
    {
        maxValue++;
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(minValue, maxValue);
        }
    }
    public static void PrintArray(int[] array)
    {
        Console.Write("Array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write("\b\b  ");
        Console.WriteLine();
    }

    public static void PrintArray(double[] array)
    {
        Console.Write("Array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{Math.Round(array[i], 2)}, ");
        }
        Console.Write("\b\b  ");
        Console.WriteLine();
    }

    public static void FillArray(double[] array, int minValue = -10, int maxValue = 10)
    {
        maxValue++;
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(minValue, maxValue)+rnd.NextDouble();
        }
    }

    public static void FillMatrix(int[,] Matr, int minValue = -10, int maxValue = 10)
    {
        maxValue++;
        Random rnd = new Random();
        Console.WriteLine($"Matrix: ");

        // 0 - rows
        // 1 - columns
        for (int i = 0; i < Matr.GetLength(0); i++)
        {
            for (int j = 0; j < Matr.GetLength(1); j++)
            {
                Matr[i, j] = rnd.Next(minValue, maxValue);
            }
        }
    }

    public static void PrintMatrix(int[,] Matr)
    {
        for (int i = 0; i < Matr.GetLength(0); i++)
        {
            for (int j = 0; j < Matr.GetLength(1); j++)
            {
                Console.Write($"{Matr[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.Write("\b\b  ");
        Console.WriteLine();
    }

    public static void FillMatrix(double[,] Matr, int minValue = -100, int maxValue = 100)
    {
        maxValue++;
        Random rnd = new Random();

        // 0 - rows
        // 1 - columns
        for (int i = 0; i < Matr.GetLength(0); i++)
        {
            for (int j = 0; j < Matr.GetLength(1); j++)
            {
                Matr[i, j] = rnd.Next(minValue, maxValue)+rnd.NextDouble();
            }
        }
    }

    public static void PrintMatrix(double[,] Matr)
    {
        Console.WriteLine($"Matrix: ");
        for (int i = 0; i < Matr.GetLength(0); i++)
        {
            for (int j = 0; j < Matr.GetLength(1); j++)
            {
                Console.Write($"{Math.Round(Matr[i, j], 1)}\t");
            }
            Console.WriteLine();
        }
        Console.Write("\b\b  ");
        Console.WriteLine();
    }
}



