// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowNum(int num, int range)
{
    int result = num;
    for (int i = 1; i < range; i++)
    {
        result *= num;
    }
    return result;
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum(int num)
{
    int result = 0;
    for (; num != 0; num /= 10)
    {
        result += num % 10;
    } 
    return result;
}

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] SetArray (int size)
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("Введите элемент массива");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void ShowMass (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

// ShowMass(SetArray(8));