// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void SortArrayRows(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j =0; j < array2D.GetLength(1); j++)
        {
            for (int k = 0; k < array2D.GetLength(1) - 1; k++)
            {
                if (array2D[i, k] < array2D[i, k + 1])
                {
                int max = array2D[i,k + 1];
                array2D[i, k + 1] = array2D[i, k];
                array2D[i, k] = max;
                }
            }
        }
    }
}

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    int number = Convert.ToInt32(inputedString);
    return number;
}

int rows = ReadInt("Введите количество строк >");
int cols = ReadInt("Введите количество столбцов >");
int[,] array2D = Create2DArray(rows, cols);
ShowArray(array2D);
SortArrayRows(array2D);
System.Console.WriteLine();
ShowArray(array2D);