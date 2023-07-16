// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
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

int rows = ReadInt("Введите количество строк и столбцов >");
int cols = rows;

ShowArray(FilArray(rows, cols));

int [,]  FilArray(int i, int j)
{
    int[,] array = new int[i, j];
    int element = 1;
    int startI = 0;
    int endI = i - 1;
    int startJ = 0;
    int endJ = j - 1;
    while (startI <= endI && startJ <= endJ)
    {
        for (j = startJ; j <= endJ; j++)
        {
            array[startI, j] = element++;
        }
        startI++;

        for (i = startI; i <= endI; i++)
        {
            array[i, endJ] = element++;
        }
        endJ--;

        for (j = endJ; j >= startJ; j--)
        {
            array[endI, j] = element++;
        }
        endI--;

        for (i = endI; i >= startI; i--)
        {
            array[i, startJ] = element++;
        }
        startJ++;
    }
    return array;
}