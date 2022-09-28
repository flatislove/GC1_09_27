//Напишите программу, которая из имеющегося массива строк формирует массив
// из строк длина которых меньше либо равна 3 символа. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами

string[] ReadStrings()
{
    string str = string.Empty;
    string? readString = string.Empty;
    string correctString = String.Empty;
    while (true)
    {
        Console.WriteLine("Введите строку(Выход - введите EXIT");
        readString = Console.ReadLine();
        if (!string.IsNullOrEmpty(readString))
        {
            correctString = readString;
        }
        if (correctString.ToUpper() != "EXIT")
        {
            str += correctString + " ";
        }
        else return GetArrayFromString(str);
    }
}

string[] GetArrayFromString(string str)
{
    return str.Replace("  ", " ").Split(' ');
}

string[] GetStringResultArray(string[] stringArray)
{
    string resultString = String.Empty;
    foreach (string v in stringArray)
    {
        if (v.Length > 0 && v.Length <= 3)
        {
            resultString += v + " ";
        }
    }
    return GetArrayFromString(resultString);
}

void PrintArray(string[] stringArray)
{
    Console.WriteLine(String.Join("  ", stringArray));
}

Console.Clear();
string[] beginArray = ReadStrings();
PrintArray(beginArray);
PrintArray(GetStringResultArray(beginArray));