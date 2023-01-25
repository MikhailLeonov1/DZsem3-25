// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;

while (a > 0)

{
int c = a % 10;
a = a / 10; b = b + c;
}

Console.WriteLine("сумма = " + b);