// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

System.Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();

if(num.Length == 5 && num[0] == num[4] && num[1] == num[3])
{
    System.Console.WriteLine("Число является палиндромом");
}
else if (num.Length == 5 && num[0] != num[4] && num[1] != num[3])
{
    System.Console.WriteLine("Число не является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является пятизначным. Пожалуйста, введите пятизначное число");
}



