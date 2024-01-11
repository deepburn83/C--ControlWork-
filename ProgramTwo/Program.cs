// 2-й вариант решения задачи без использования функций (методов).

int maxLength = 3;

Console.Clear();
Console.WriteLine("Введите любые данные (слова, числа, символы) через запятую: ");
string input = Console.ReadLine()!;
string[] inputArray = input.Split(",");

string[] outputArray = new string[inputArray.Length];
int outputIndex = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    string trimmed = inputArray[i].Trim();
    if (trimmed.Length <= maxLength)
    {
        outputArray[outputIndex] = trimmed;
        outputIndex++;
    }
}
if (outputIndex == 0)
{
    Console.Clear();
    Console.WriteLine($"[{string.Join(", ", inputArray)}] -> Все введённые данные длиной более 3 (трёх).");
}
else
{
    string[] resultArray = new string[outputIndex];
    Array.Copy(outputArray, resultArray, outputIndex);

    Console.Clear();
    Console.WriteLine($"[{string.Join(", ", inputArray)}] -> [{string.Join(", ", resultArray)}]");
}