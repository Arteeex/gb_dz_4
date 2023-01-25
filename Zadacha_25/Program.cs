int powpow(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a,b));
    return result;
}

Console.Write("Введите число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int value2 = Convert.ToInt32(Console.ReadLine());

int result = powpow(value1, value2);
Console.WriteLine("Ответ: " + result);