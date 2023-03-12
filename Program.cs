//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

void checkThirdNumber(int a)
{
if (a < 100)
{

System.Console.WriteLine("Нет третьей цифры");
return;
}
while (a > 999)
{
a /= 10;
}
System.Console.WriteLine($"Третья цифра - {a % 10}");
}
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
checkThirdNumber(a);
