// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Например:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "competer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// метод ввода числа
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод создания и заполнения пользователем исходного массива
string[] GetArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива:");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}

// метод вывода массива в терминал
void PrintArray(string[] array) 
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
    Console.WriteLine();
}

int sizeArray = ReadNumber("Введите размер создаваемого массива:");
string[] array = GetArray(sizeArray);
PrintArray(array);