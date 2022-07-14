// Принять на вход число и вывести сумму чисел в нём


int SumDigits(int a)
{
    if (a == 0) return 0;

    return a%10 + SumDigits(a / 10);
}

int N = 4515;

Console.WriteLine(SumDigits(N));