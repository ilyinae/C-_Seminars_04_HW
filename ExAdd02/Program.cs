//Дополнительная задача
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=702

Console.Clear();
// Открываем текстовый файл, используя StreamReader.
var sr = new StreamReader("input.txt");
// Размерность входного массива - в первой строке - непонятно зачем оно вообще - будем работать через длину массива из второй строки. Но раз дано в условии задачи - пусть будет в отдельной переменной
int arrLength = Convert.ToInt32(sr.ReadLine());
//Сам массив
string[] inputArr = sr.ReadLine().Split(' ');
//Величина сдвига
int shift = Convert.ToInt32(sr.ReadLine());

string[] outputArr = new string[inputArr.Length];

 for(int i = 0; i < inputArr.Length; i++)
 {
    int outIndex = i + shift;
        if (shift > 0) //правый сдвиг 
        {
            if (outIndex < inputArr.Length)       outputArr[outIndex] = inputArr[i]; 
            else                                  outputArr[outIndex % inputArr.Length] = inputArr[i];  //берем остаток от деления и используем в качестве нового индекса
        }
        else   //левый сдвиг
        {
            if (outIndex < 0)                     outputArr[inputArr.Length + outIndex] = inputArr[i]; // отнимаем величину отрицательного индекса от длины массива
            else                                  outputArr[i+shift] = inputArr[i];
        }
}
Console.WriteLine ("Входной массив: [" + string.Join(", ", inputArr) + "]");
Console.WriteLine ("Сдвиг: " + shift);
Console.WriteLine ("Выходной массив: [" + string.Join(", ", outputArr) + "]");
// Используя StreamWriter перезаписываем содержимое файла output.txt
   using (StreamWriter writer = new StreamWriter("output.txt", false))
       await writer.WriteAsync(string.Join(", ", outputArr));