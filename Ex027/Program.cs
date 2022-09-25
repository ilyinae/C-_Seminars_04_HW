// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
string A = Console.ReadLine();
int summ = 0;

for (int i=0; i< A.Length; i++)
    summ = summ + Convert.ToInt32(Convert.ToString(A[i]));
Console.WriteLine($"Сумма цифр числа {A} равна {summ}");
