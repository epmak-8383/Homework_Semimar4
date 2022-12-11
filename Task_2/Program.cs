int SumOfNumber(int a)
{
    int sum = 0;
    for (int i = a; i > 0;)
    {
        sum = sum + a%10;
        i = a/10;
        a = a/10;
    }
    return sum;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int c = int.Parse(Console.ReadLine());
    return c;
}

int a = GetNumber("введите число: ");
int s = SumOfNumber(a);
Console.WriteLine($"полученная сумма цифр равна {s}");