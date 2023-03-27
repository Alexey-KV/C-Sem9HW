// Num 64
// задайте значение N;
// выведите все натуральные числа в промежутке от N до 1 с помощью рекурсии;
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Num(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

string Numbers(int N)
{
    if (N < 1) return "Initial value less than 1";
    if (N == 1) return "1";
    return (N + ", " + Numbers(N - 1));
}
Console.WriteLine(Numbers(Num("Enter the number (N): ")));

