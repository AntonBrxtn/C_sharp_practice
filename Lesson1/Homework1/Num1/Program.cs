// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
{
    System.Console.WriteLine("Наибольшее число равно " + (max = a));
}
else
{
    System.Console.WriteLine("Наибольшее число равно " + (max = b));
}