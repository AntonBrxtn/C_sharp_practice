// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// ((x2-x1)^2 + (y2-y1)^2)^1/2
// Math.Pow (число, количество квадратов)
// Math.Sqrt (квадратный корень из указанного числа)

int InputNumber (string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату х1: ");
int y1 = InputNumber("Введите координату y1: ");

int x2 = InputNumber("Введите координату х2: ");
int y2 = InputNumber("Введите координату y2: ");

System.Console.WriteLine(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow ((y2-y1),2)));