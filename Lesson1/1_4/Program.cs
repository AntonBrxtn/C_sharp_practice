// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8
System.Console.WriteLine("Введите трёхзначное число");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (n > 99 && n < 1000)
{
    System.Console.WriteLine("Последняя цифра этого числа это " + n % 10);
}
else
{
    System.Console.WriteLine("Введено не трёхзначное число");
}
