/*
Выводим список от N до 1
Используем рекурсию
*/


int ReadInt (string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Numbers (int N)
{
    if (N == 0) return;
    Console.Write(N + " ");
    Numbers(N-1);
}

void Main()
{
    int N = ReadInt("Введите число");
    Numbers(N);
}

Main();


