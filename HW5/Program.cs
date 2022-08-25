// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] array = new int[12];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     Random rand = new Random();
//     array[i] = rand.Next(100, 1000);
//     if (array[i] % 2 == 0) count++;
// }
// Console.WriteLine(count);

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// int[] array = new int[12];
// int sum = 0;

// for (int i = 1; i < array.Length; i = i + 2)
// {
//     Random r = new Random();
//     array[i] = r.Next();
//     sum = sum + array[i];
// }
// Console.WriteLine(sum);

// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
Double[] array = new Double[12];
Double min = 0;
Double max = 0;

for (int i = 0; i < array.Length; i++)
{
    Random rand = new Random();
    array[i] = rand.NextDouble();
    if(array[i] < min) min = array[i];  
    if(array[i] > max) max = array[i];
}
Console.WriteLine(max-min);
Console.WriteLine(String.Join(" ", array));