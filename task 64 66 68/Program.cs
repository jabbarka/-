using System.Globalization;
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

string[] EnterAndSplitString()
{
    Console.Write("Введите числа через пробел, запятую или / : ");
    return Console.ReadLine()!.Split(' ', ',', '/');
}

int[] ParseInput(string[] nums)
{
    int[] integerNums = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        integerNums[i] = int.Parse(nums[i])!;
    }
    return integerNums;
}



//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void ShowAllNums(int num)
{
    if (num < 1)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($"{num} ");
    ShowAllNums(num - 1);

}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumNumsBetween(int min, int max)
{
    int sum = 0;
    if (min == max)
    {
        return min;
    }
    sum += max;
    return SumNumsBetween(min, max - 1) + sum;

}


int AckermannFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}


Console.WriteLine("Введите два числа.");
int[] nums = ParseInput(EnterAndSplitString());
int min = 0;
int max = 0;

if (nums[0] < nums[1]) { min = nums[0]; max = nums[1]; }
else { min = nums[1]; max = nums[0]; }

Console.WriteLine();
Console.Write($"Функция Акермана для {min} , {max} -> ");
Console.WriteLine(AckermannFunc(min, max));
Console.WriteLine();
Console.Write($"Сумма чисел от {min} до {max} -> ");
Console.WriteLine(SumNumsBetween(min, max));
Console.WriteLine();
System.Console.WriteLine("Введите число, чтобы вывести все числа от 1 до Вашего числа");
ShowAllNums(ParseInput(EnterAndSplitString())[0]);
Console.WriteLine();


