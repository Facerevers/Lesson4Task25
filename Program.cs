// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetRes(int num1, int num2)
{
    int res = 1;
    for (int i = 0; i < num2; i++)
    {
        res = res * num1;
    }
    return res;
}


int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInput("Введите число: ");
int numberB = GetInput("Введите степень числа: ");
int res = GetRes(numberA, numberB);
Console.WriteLine($"{numberA} -> {res}");