// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int[] FillArray (int size)
{
int[] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine("Input a number: ");
  array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}

int CountPositive (int[] array)
{
  int count = 0;
  for (int j = 0; j < array.Length; j++) 
  {
    if(array[j] > 0)
    count++;
  }
  return count;
}

Console.WriteLine("Input the number of numbers we need:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine($"[{string.Join("," , array )}]");
Console.WriteLine("The quantity of input positive number is " + CountPositive(array));



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Input the first number for the first line:  ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number for the first line:  ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the first number for the second line:  ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number for the second line:  ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

if(k1 == k2) 
  Console.WriteLine("There are no intersection points - the lines are parallel.");
else
{
  if(b1 == b2)
    Console.WriteLine("The lines match.");
  else
  {
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Coordinates of the intersection point of the lines are: ( {x} , {y})");
  }
}

*/

