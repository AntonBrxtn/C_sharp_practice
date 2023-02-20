// Задача 26: Напишите программу, которая принимает на
// вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

string GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}

string a = GetNumber("Введите число n");
int len = a.Length;
System.Console.WriteLine($"Количество цифр во введённом числе = {len}");