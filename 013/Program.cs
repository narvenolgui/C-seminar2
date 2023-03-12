//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

void checkSecondNumber(int a)
{
if (a < 10)
{

System.Console.WriteLine("Нет второй цифры");
return;
}
while (a > 99)
{
a /= 10;
}
System.Console.WriteLine($"Вторая цифра - {a % 10}");
}
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
checkSecondNumber(a);
