/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int ReadInt (string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Ack (int M, int N)
{
    if (M == 0) return N+1;
    else if (N == 0) return Ack(M-1, 1);
    else return Ack(M-1, Ack(M, N-1));
}

bool CheckInputNumbers (int M, int N)
{
    if (M < 0 || N<0) return false;
    else return true;
}

void Main()
{
    int M = ReadInt("Введите первое число (положительное или 0)");
    int N = ReadInt("Введите второе число (положительное или 0)");
    if (CheckInputNumbers(M, N)) Console.WriteLine(Ack(M, N));
    else System.Console.WriteLine("Отрицательные числа нам не подойдут =(");
}

Main();