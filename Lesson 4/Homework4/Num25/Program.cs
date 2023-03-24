// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Request(string text)
{
    System.Console.Write(text);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Base (int A, int B)
{
    int Base = 1;
    for (int i = 0; i < B; i++)
    {
            Base *= A;
    }
    return Base;
}

bool CheckNumber (int B)
{
    if (B < 0)
    {
        System.Console.WriteLine("Число должно быть больше нуля");
        return false;
    }
    return true;
}

int A = Request("Введите число A: ");
int B = Request("Введите число B: ");
if (CheckNumber(B))
{
    System.Console.WriteLine($"Число {A} в степени {B} равно {Base(A, B)}");
}