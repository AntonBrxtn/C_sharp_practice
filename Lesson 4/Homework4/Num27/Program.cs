// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum (int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int num = GetNumber("Введите число: ");
System.Console.WriteLine($"Сумма всех числе в цифре {num} = {Sum(num)}");