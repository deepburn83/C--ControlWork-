// 1-й вариант решения задачи с использованием функций (методов).

int maxLength = 3;

Console.Clear();
string input = InputMessage("Введите любые данные (слова, числа, символы) через запятую: ");
string[] newArray = input.Split(',');

int sizeResult = SizeNewArray(newArray, maxLength);

if (sizeResult == 0)
{
    Console.Clear();
    Console.WriteLine($"[{string.Join(", ", newArray)}] - Все введённые данные длиной более 3 (трёх).");
}
else
{
    string[] resultArray = ResultArray(newArray, maxLength, sizeResult);
    Console.Clear();
    Console.WriteLine($"[{string.Join(", ", newArray)}] -> [{string.Join(", ", resultArray)}]");
}

string InputMessage(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine()!;
}

int SizeNewArray(string[] array, int length)
{
    int sizeNewArray = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Trim().Length <= length)
        {
            sizeNewArray++;
        }
    }

    return sizeNewArray;
}

string[] ResultArray(string[] array, int length, int size)
{
    string[] outputArray = new string[size];
    int outputIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        string trimmed = array[i].Trim();
        if (trimmed.Length <= length)
        {
            outputArray[outputIndex] = trimmed;
            outputIndex++;
        }
    }

    return outputArray;
}