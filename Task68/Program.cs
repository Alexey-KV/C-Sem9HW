// Num 68
// даны два неотрицательных числа m и n;
// вычисление функции Аккермана с помощью рекурсии;
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return ack(m - 1, 1);
    }
    return ack(m - 1, ack(m, n - 1));
}

for (int i = 0; i <= 3; i++)
{
    for (int j = 0; j <= 3; j++)
    {
        Console.Write($"ACK({i}, {j})={ack(i, j)}\t");
    }
    Console.WriteLine();
}
