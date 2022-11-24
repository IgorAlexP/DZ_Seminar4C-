/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.*/


Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;
int i = 1;
while(i < b)
{
    step = step * a;
    i++;
}
Console.WriteLine($"{a} в степени {b} равно: {step}" );


