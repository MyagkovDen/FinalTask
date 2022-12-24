/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.Clear();
int userNumber = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");
string[] initialArray = new string[userNumber];
FillArray(userNumber, initialArray);
PrintArray(initialArray);
Console.Write(" => ");
string[] resultArray = new string[FindLength(initialArray)];
GetArray(initialArray, resultArray);
PrintArray(resultArray);

void GetArray(string[] arr, string[] col)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            col[j] = arr[i];
            j++;
        }
    }
}

int FindLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"\"{arr[i]}\", ");
    }
    Console.Write($"\"{arr[arr.Length - 1]}\"");
    Console.Write("]");
}

void FillArray(int number, string[] arr)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите строку: ");
        arr[i] = Console.ReadLine();
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        else
            Console.WriteLine(errorMessage);
    }
}