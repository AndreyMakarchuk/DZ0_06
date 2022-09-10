// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите колличество чисел для ввода: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        res[i] = Convert.ToInt32(Console.ReadLine());
    }

    return res;
}
int[] array = GetArray(size);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sum++;
}
Console.Write(String.Join(", ", array));
Console.WriteLine($" -> {sum} больше нуля");
