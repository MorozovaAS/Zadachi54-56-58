// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha54()
{
    int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine();

    }
    return result;
}
void GoodArray(int[,] matrix) // СМЕНИ НАЗВАНИЕ
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            for (int y = 0; y < matrix.GetLength(1)-1; y++)
            {
                if (matrix[i, y] < matrix[i, y + 1])
                {
                    int temp = matrix[i, y + 1];
                    matrix[i, y + 1] = matrix[i, y];
                    matrix[i, y] = temp;
                }
            }
        }
    }


}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetArray(4, 4, 1, 10);
GoodArray(matrix);
System.Console.WriteLine();
System.Console.WriteLine("Упорядоченый по убыванию массив:");
WriteArray(matrix);
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56()
{
    int width = ReadData("Введите ширину массива: ");
    int length = ReadData("Введите длину массива: ");
    int[,] matrix = new int[width, length];

    int ReadData(string msg)
    {
        System.Console.Write(msg);
        int number = int.Parse(System.Console.ReadLine());
        return number;
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void LineSum(int[,] matr)
    {
     int one_sum=0;          
     int line=0;
     int j = 0;
        for (int i = 0; i < width; i++)
        {
            int two_sum = 0;
            for (j = 0; j < length; j++)
            {
                two_sum = two_sum + matrix[i, j];
            }
            one_sum = one_sum==0 ? two_sum : one_sum;
            
            if (two_sum < one_sum)
            {
                one_sum = two_sum;
            }
            line = two_sum == one_sum ? i+1 : line;
           

        }
      System.Console.WriteLine("Cтрока с наименьшей суммой элементов: " + line);
    }
    FillArray(matrix);
    PrintArray(matrix);
    LineSum(matrix);
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Zadacha58()
{
    int[,] FillArrayOne(int length, int width)
{
    int[,] matr = new int[width, length];
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < length; j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}
int[,] FillArrayTwo(int length, int width)
{
    int[,] matr = new int[width, length];
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < length; j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    return matr;
}

int[,] FillArrayThree(int[,] matr, int[,] array, int length, int width)
{
    int[,] matrix = new int[width, length];

    for (int i = 0; i < width; i++)
    {
        int x = i;
        for (int j = 0; j < length; j++)
        {
            int y = j;
            matrix[x, y] = matr[i, 0] * array[0, j] + matr[i, 1] * array[1, j];                

        }
        
    }
    return matrix;
}
void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int [,] matrix_one = FillArrayOne(2, 2);
int [,] matrix_two = FillArrayTwo(2, 2);
System.Console.WriteLine("Матрица 1: ");
WriteArray(matrix_one);
System.Console.WriteLine("Матрица 2: ");
WriteArray(matrix_two);
System.Console.WriteLine("Произведение матриц: ");
WriteArray(FillArrayThree(matrix_one, matrix_two, 2, 2));
}
Zadacha58();
