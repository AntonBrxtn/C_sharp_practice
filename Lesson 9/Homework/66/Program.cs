// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
point:
System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<=m)
{
    System.Console.WriteLine("Вероятно, вы ввели число, которого нет в промежутке. Пожалуйста, повторите ввод");
    goto point;
}

int sum(int m, int n)
{
    if (m == n) { return m; }
    return m + sum(m + 1, n);
}
System.Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} = {sum(m, n)}");

