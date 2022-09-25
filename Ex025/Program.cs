// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = -1;
int aPow = 1;
while (B < 0 )
{
    Console.WriteLine("Введите число B: ");
    B = Convert.ToInt32(Console.ReadLine());
}    
for (int i = 1; i <= B; i++) aPow = A*aPow;
Console.WriteLine ($"{A}^{B} = {+aPow}");