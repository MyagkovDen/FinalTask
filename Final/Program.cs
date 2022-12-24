Console.Clear();
int number = GetNumberFromUser("Введите количество строк в массиве: ", "Ошибка ввода!");



int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
    Console.WriteLine(message);
    if(int.TryParse(Console.ReadLine(), out int userNumber))
    return userNumber;
    else
    Console.WriteLine(errorMessage);
    }
}