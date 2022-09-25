//Дополнительная задача
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=699
//

int searchPlace(string[] array, int value)  // можно было без метода, он тут нужен для того, чтобы при нахождении места сразу вернуть результат, не перебирая остальные варианты
{
    for (int i = 1; i < array.Length; i++)             // С первым по росту уже сравнили - начинаем со второго
    {       
        if (value <= Convert.ToInt32(array[i-1]) && value  > Convert.ToInt32(array[i])) //Если не выше предыдущего И выше следующего  - то это его место. Дальше искать бессмысленно. Возвращаем результат.
            return i;
    }
    return array.Length;                             // Если не нашли подходящего места - то Петя встанет последним (самый низкий или одного роста с самым низким)
};


Console.Clear();
var sr = new StreamReader("input.txt");                // Открываем текстовый файл, используя StreamReader
int stCount = Convert.ToInt32(sr.ReadLine());          // Количество учеников - в первой строке - непонятно зачем оно вообще - будем работать через длину массива из второй строки. Но раз дано в условии задачи - пусть будет в отдельной переменной
string initialString = sr.ReadLine();                  // Рост каждого ученика - в виде массива - вторая строка
string[] stHeigthsArr = initialString.Split(' ');
int pHeight = Convert.ToInt32(sr.ReadLine());          //Рост Пети
int pIndex;// = stHeigthsArr.Length+1;                 //Место Пети пока последнее в шеренге
if (pHeight > Convert.ToInt32(stHeigthsArr[0]) )       //Если Петя самый высокий, то он встанет первым
    pIndex = 1;
else
    pIndex = searchPlace(stHeigthsArr, pHeight)+1;       // Иначе найдем ему место

string outString = $"Петя со своим ростом в {pHeight} см. должен занять {pIndex}-е место в шеренге [{initialString}]";
 Console.WriteLine(outString);
using (StreamWriter writer = new StreamWriter("output.txt", false)) // Используя StreamWriter перезаписываем содержимое файла output.txt
    await writer.WriteAsync(outString);