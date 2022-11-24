/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */

Console.Write("введите количество N элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
 {
    arr [i] = new Random().Next(0, 100);
    Console.Write( " " + Method (i) + " " );
 }

int Method (int a)
{
    return arr[a];
}
