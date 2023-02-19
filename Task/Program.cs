/*
Написать программу, которая из имеющегося массива строк формирует массив из строк длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении, не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

Примеры:
1) ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
2) ["1234", "1567", "-2", "computer science"] -> ["-2"]
3) ["Russia", "Denmark", "Kazan"] -> []
*/

using static System.Console;

Clear();

WriteLine("Программа сформирует массив из строк, длина которых, меньше либо равна 3 символам из имеющегося массива.");
WriteLine();
Write("Посчитайте и введите, сколько слов и значений будет в списке: ");
bool isSize = int.TryParse(ReadLine()!, out int size);
if (!isSize)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}
Write("Введите длину элемента, которое должно быть выведено в новом массиве: ");
bool isWordLength = int.TryParse(ReadLine()!, out int WordLength);
if (!isWordLength)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}
WriteLine();
WriteLine("Введите поочерёдно элементы из списка, через Enter:");
string[] array = GetArray(size);
WriteLine();
WriteLine("Получен массив:");
WriteLine("[{0}]", string.Join(", ", array));
WriteLine();
WriteLine("Результат:");
string[] resultArray = NewArray(array, WordLength);
WriteLine("[{0}]", string.Join(", ", resultArray));
WriteLine();




string[] GetArray(int size)         // метод ввода пользователем элементов в массив и его формирования.
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{i + 1} -> ");
        arr[i] = ReadLine()!;
    }
    return arr;
}

string[] NewArray(string[] GetArray, int wordSize)        // метод формирования нового массива по условию задачи
{
    int count = 0;
    for (int j = 0; j < GetArray.Length; j++)       // вычисление размера нового массива
    {
        if (GetArray[j].Length <= wordSize)
        {
            count++;
        }
    }

    int q = 0;
    string[] newArr = new string[count];
    for (int k = 0; k < GetArray.Length; k++)       // заполнение нового массива
    {
        if (GetArray[k].Length <= wordSize)
        {
            newArr[q] = GetArray[k];
            q++;
        }
    }
    return newArr;
}
