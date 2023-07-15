// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    int number = Convert.ToInt32(inputedString);
    return number;
}

int[,] Create2DArray(int rows, int cols)
{
    int[,] array2D = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(1, 5);
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

int rows1 = ReadInt("Введите количество строк Первой матрицы и столбцов второй матрицы >");
int cols1 = ReadInt("Введите количество столбцов Первой матрицы >");
int cols2 = rows1;
int rows2 = ReadInt("Введите количество  строк Второй матрицы >");
int[,] array1 = Create2DArray(rows1, cols1);
int[,] array2 = Create2DArray(rows2, cols2);
ShowArray(array1);
System.Console.WriteLine();
ShowArray(array2);

void MultiplArray(int[,] array1, int[,] array2, int[,] arrayMultipl)
{
    for (int i = 0; i < arrayMultipl.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultipl.GetLength(1); j++)
        {
            int element = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                element += array1[i,k]*array2[k,j];
            }
        arrayMultipl[i,j] = element;
        }
    }
}

int[,] arrayMultipl = new int[rows1, cols2];
MultiplArray(array1, array2, arrayMultipl);
System.Console.WriteLine("произведение массивов =");
ShowArray(arrayMultipl);