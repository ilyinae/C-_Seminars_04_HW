// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Какой длины массив будем создавать?");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[arrayLength];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    arr[i] = Console.ReadLine();
}
Console.WriteLine("Создан массив: ["+ string.Join(", ", arr)+ "]");
