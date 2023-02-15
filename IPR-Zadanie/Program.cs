// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

string[] array = { "hello", "2", "world", ":-)" };

void massiv(string[] m)
{
    int count = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] marray = new string[count];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            marray[j] = array[i];
            j++;
        }

    }
    Console.WriteLine(string.Join(", ", marray));


}

massiv(array);
