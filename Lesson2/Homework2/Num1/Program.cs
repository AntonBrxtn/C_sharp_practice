﻿// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    System.Console.WriteLine(num / 10 % 10);
}
else
{
    System.Console.WriteLine("Число не трехзначное. Пожалуйста, введите ТРЕХЗНАЧНОЕ число!");

}