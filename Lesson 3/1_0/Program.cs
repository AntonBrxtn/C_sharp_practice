// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    System.Console.WriteLine("Номер четверти 1");
}
else if (x<0 && y<0)
{
    System.Console.WriteLine("Номер четверти 3");
}
else if (x>0 && y<0)
{
    System.Console.WriteLine("Номер четверти 4");
}
else if (x<0 && y>0)
{
    System.Console.WriteLine("Номер четверти 2");
}
else
{
    System.Console.WriteLine("Точка лежит в начале координат");
}