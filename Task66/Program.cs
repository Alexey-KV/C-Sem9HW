// Num 66
// задать значения M и N;
// найти сумму натуральных элементов в промежутке от M до N;
// M = 1, N = 15 -> 120
// M = 4, N = 8 -> 30

int Num(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int M, int N)
{
    if (M == N) return N;
    if (M < N)
    {
        return (M + Sum(M + 1, N));
    }
    else
    {
        return (M + Sum(M - 1, N));
    }
}

Console.WriteLine(Sum(Num("Enter initial value (M): "), Num("Enter end value (N): ")));

