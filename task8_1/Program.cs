// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] Create2DArray(int rows, int cols)
{
    int[,] array2D = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0, 11);
        }
    }
    return array2D;
}

void ShowArray(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            System.Console.Write($"{arr2D[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    int number = Convert.ToInt32(inputedString);
    return number;
}

int[] FindSumRow(int[,] array)
{
    int[] SumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SumRow[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow[i] += array[i, j];
        }
    }
    return SumRow;
}

void FindMin(int[] array1d)
{
    int min = array1d[0];
    int indexmin = 0;
    for (int i = 1; i < array1d.Length; i++)
    {
        if (array1d[i] < min)
        {
            min = array1d[i];
            indexmin = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в строке {indexmin + 1} и равна {min}");
}

int rows = ReadInt("Введите количество строк и столбцов >");
int cols = rows;
int[,] array2D = Create2DArray(rows, cols);
ShowArray(array2D);
FindMin(FindSumRow(array2D));


