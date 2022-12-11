int Power(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = EnterData("Введите число: ");
int b = EnterData("Введите степень: ");

int result = Power(a, b);

Console.WriteLine($"Число {a} в степени {b} равно {result}");