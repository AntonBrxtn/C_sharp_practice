// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату х1: ");
int y1 = InputNumber("Введите координату y1: ");
int z1 = InputNumber("Введите координату z1: ");

int x2 = InputNumber("Введите координату х2: ");
int y2 = InputNumber("Введите координату y2: ");
int z2 = InputNumber("Введите координату z2: ");

System.Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));