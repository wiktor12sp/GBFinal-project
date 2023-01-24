// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreatArray()
{
    string[] array = new string[new Random().Next(1, 5)];
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write("Введите: ");
        array[j] = Console.ReadLine();
    }
    return array;
}

string[] array1 = CreatArray();

void PrintFinalArray()
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
            Console.Write($"\"{array1[i]}\" ");
    }
}

PrintFinalArray();