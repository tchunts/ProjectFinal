// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] --> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -->["-2"]
// ["Russia", "Denmark", "Kazan"] --> []

Console.WriteLine("Введите массив строк через пробел");
string inPutString = Console.ReadLine();
string[] userArray = inPutString.Split(' ');

// string[] userArray = {"hello", "2", "world", ":-)"};

string[] resultArray = new string[userArray.Length];

// PrintArray(userArray);
// Console.WriteLine();
SearchElemnentsBigerThenFour(userArray, resultArray);
Console.Write($"Элементы со значением меньше либо равно 3 символам: ");
PrintArray(resultArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SearchElemnentsBigerThenFour(string[] inputArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length < 4)
        {
            resultArray[count] = inputArray[i];
            count++;
        }
    }
}
