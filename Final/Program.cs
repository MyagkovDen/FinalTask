Console.Clear();
int userNumber = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");
string[] array = new string[userNumber];
FillArray(userNumber, array);



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