//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numberN)
{
    int sum = 0;
    int digit = 0;
    while (numberN > 0)
    {
        digit = numberN % 10;
        if (digit != 0)
        {
            sum = sum + digit;
        }
        numberN = numberN / 10;
    }
    return sum;
}

int sumNumbers = SumNumbers(numberN);
Console.WriteLine($"Сумма цифр в числе: {sumNumbers}");