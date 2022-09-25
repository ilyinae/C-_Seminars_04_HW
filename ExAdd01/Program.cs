//Дополнительная задача
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=699
//

Console.Clear();
// Открываем текстовый файл, используя StreamReader.
var sr = new StreamReader("input.txt");
// Количество учеников - в первой строке - непонятно зачем оно вообще - будем работать через длину массива из второй строки. Но раз дано в условии задачи - пусть будет в отдельной переменной
int stCount = Convert.ToInt32(sr.ReadLine());
//Рост каждого ученика - в виде массива - вторая строка
string initialString = sr.ReadLine();
string[] stHeigthsArr = initialString.Split(' ');
//Рост Пети
int pHeight = Convert.ToInt32(sr.ReadLine());

//Петя как новичок - временно в конце шеренги
int pIndex = stHeigthsArr.Length;

//Начинаем искать место
//Если Петя самый высокий
if (pHeight > Convert.ToInt32(stHeigthsArr[0]) )
        pIndex = 0;
else
{    
    for (int i=1; i<stHeigthsArr.Length;i++) // С первым по росту уже сравнили - начинаем со второго
    {
        if (pHeight <= Convert.ToInt32(stHeigthsArr[i-1]) && pHeight > Convert.ToInt32(stHeigthsArr[i])) // если не выше предыдущего И выше следующего 
                    pIndex = i;
    }
}
string outString = $"Петя со своим ростом в {pHeight} см. должен занять {pIndex+1}-е место в шеренге [{initialString}]";
 Console.WriteLine(outString);

// Используя StreamWriter перезаписываем содержимое файла output.txt
  using (StreamWriter writer = new StreamWriter("output.txt", false))
      await writer.WriteAsync(outString);