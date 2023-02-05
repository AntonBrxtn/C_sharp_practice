// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

Random rand = new Random();
int number = rand.Next(10, 100);
System.Console.WriteLine($"Случайное число: {number}");
int leftNum = number / 10;
int rightNum = number % 10;

// System.Console.WriteLine($"{leftNum} {rightNum}");

if (leftNum > rightNum)
{
    System.Console.WriteLine($"Левое число больше и равно {leftNum}");
}
else if (leftNum < rightNum)
{
    System.Console.WriteLine($"Правое число больше и равно {rightNum}");
}
else
{
    System.Console.WriteLine("Числа равны");
}