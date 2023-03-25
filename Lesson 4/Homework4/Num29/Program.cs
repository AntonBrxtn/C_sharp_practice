// Напишите программу, которая задаёт массив из любого количества элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayGen(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random rnd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

int Length = GetNumber("Длина массива: ");
int min = GetNumber("Начальное значение: ");
int max = GetNumber("Конечное значение: ");
int[] array = ArrayGen(Length, min, max);
PrintArray(array);