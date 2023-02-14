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

Console.WriteLine("Hello, World!");
void massiv(string[] m)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(i);
    }

}

massiv(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(array.Length);