// Напишите программу, которая выводит случайное трехзначное
// число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
System.Console.WriteLine($"Случайное число: {number}");
int leftNum = number / 100;
int rightNum = number % 10;
// System.Console.WriteLine($"{leftNum}{rightNum}");
number = ((leftNum * 10) + (rightNum));
System.Console.WriteLine(number);