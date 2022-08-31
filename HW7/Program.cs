// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Random r = new Random();
//         array[i, j] = r.NextDouble();
//         Console.Write(array[i, j] +" ");
//     }
//     Console.WriteLine();
// }

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Random r = new Random();
//         array[i, j] = r.Next();
//         // Console.Write(array[i, j] +" "); оставим для тестов
//     }
//     // Console.WriteLine();                 оставим для тестов
// }

// Console.WriteLine("Введите номер строки");
// int findRow = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int findColumn = Convert.ToInt32(Console.ReadLine());

// if (findRow > rows || findColumn > columns) Console.WriteLine("Такого элемента не существует");
// else Console.WriteLine(array[findRow-1,findColumn-1]);

// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Random r = new Random();
        array[i, j] = r.Next(3);
        Console.Write(array[i, j] +" "); //оставим для тестов
    }
    Console.WriteLine();                 //оставим для тестов
}
double[] result = new double[columns];
double res = 0;
for (int m = 0; m < columns; m++)
{
    res = 0;
    for (int n = 0; n < rows; n++)
    {
        res = res + array[n,m];
    }
    result[m] = res/rows;
}
System.Console.WriteLine();
Console.WriteLine(String.Join(" ", result));