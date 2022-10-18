// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе (натуральное) число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB >= 1)
{
    int extent = Extent(numA, numB);

    int Extent(int numA, int numB)
    {
        int result = 1;
        for (int i = 1; i <= numB; i++)
        {
            result = result * numA;
        }
        return result;
    }
    Console.WriteLine($"Первое число в степени второго числа равно {extent}");
}
else
Console.WriteLine("Второе число не натуральное");