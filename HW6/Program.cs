// Фибоначчи через массивы без рекурсии
// Console.WriteLine("Введите номер числа Фибоначчи");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arrFibo = new int[size];
// arrFibo[0] = 0;
// arrFibo[1] = 1;

// for (int i = 2; i < size; i++)
// {
//     arrFibo[i] = arrFibo[i - 1] +  arrFibo[i - 2];
// }
// Console.WriteLine(string.Join(" ", arrFibo));

// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Console.WriteLine("Сколько чисел будем использовать?");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите числа");
// int count = 0;
// for (int i = 0; i < length; i++)
//     if (Convert.ToInt32(Console.ReadLine()) >0) count ++;

// Console.WriteLine(count);

// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Console.WriteLine("Введите коэфициенты первой и второй прямых");
// int[] arrLine = new int[4];
// for (int i = 0; i < arrLine.Length; i++)
// {
//     arrLine[i] = Convert.ToInt32(Console.ReadLine());
// }
// int x = (arrLine[3] - arrLine[1]) / (arrLine[0] - arrLine[2]);
// int y = x * arrLine[0] + arrLine[1];

// Console.WriteLine($"x = {x}, y = {y}");

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Console.WriteLine("Введите число");
// int dividend = Convert.ToInt32(Console.ReadLine());
// int quotient = 1;
// int remainder;
// string result = string.Empty;
// while (quotient > 0)
// {
//     quotient = dividend / 2;
//     remainder = dividend % 2;
//     result = result + remainder; 
//     dividend = quotient;
// }
// int size = result.Length; 
// while (size > 0)
// {
//     Console.Write(result[size - 1]);
//     size--;
// }



