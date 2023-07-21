/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/


int ReadInt (string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbers (int M, int N)
{
    if (M > N) return 0;
    return M + SumNumbers(M+1, N);
}

bool CheckInputNumbers (int M, int N)
{
    if (M < N) return true;
    else return false;
}

void Main()
{
    int M = ReadInt("Введите первое число");
    int N = ReadInt("Введите второе число");
    if (CheckInputNumbers(M, N))
    {
        Console.WriteLine(SumNumbers(M, N));
    }
    else 
    {
        Console.WriteLine(SumNumbers(N, M));
    }
}

Main();


