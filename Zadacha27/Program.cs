/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("ВВедите любое число: ");             //ввод числа с консоли
int i = Convert.ToInt32(Console.ReadLine());
int cons = 10;
int sum = 0;

while(i > 0)
{
    int number = i % cons;
    i = i / cons;
    sum = sum + number;
}
Console.WriteLine($"сумма всех чисел равна {sum}");