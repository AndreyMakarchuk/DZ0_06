// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэфициэнты к1, b1, k2, b2: ");

double[] GetArray(double size)
{
    double[] res = new double[4];

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Введите коэфициэнт: ");
        res[i] = Convert.ToInt32(Console.ReadLine());
    }

    return res;
}
double[] array = GetArray(4);

double x = 0;
double y = 0;

if (array[0] == array[2])

    Console.WriteLine($"Прямые (y = {array[0]} * x + {array[1]}); (y = {array[2]} * x + {array[3]}) -> не пересекаются");

else
{
    x = (array[3] - array[1]) / (array[0] - array[2]);
    y = array[2] * x + array[3];

    Console.Write($" k1={array[0]}, b1={array[1]}, k2={array[2]}, b2={array[3]}");
    Console.WriteLine($" -> А({x}; {y})");
}
