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

int[] SetArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        int j = rand.Next(1, 10);
        while (array.Contains(j))   //проверка встречается ли элемент. true - если встречается, false - если нет
        {
            j = rand.Next(1, 10);
        }
        array[i] = j;
    }
    return array;
}

void ShowMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}


// double PercentBank(double num)
// {
//     int percent = 5;
//     if (num >= 100 && num <= 200) percent = 7;
//     if (num > 200) percent = 10;

//     double result = num + num / 100 * percent;
//     return result;
// }
// ShowMass(SetArray(8));

void MessageBegin ()
{
    System.Console.WriteLine("Давай сыграем в игру: быки и коровы.");
    System.Console.WriteLine("Загадано случайное 4-значное число (цифры не повторяются). Твоя задача его отгадать.");
    System.Console.WriteLine("Компьютер показывает число отгаданных цифр, стоящих на своих местах (быков),"); 
    System.Console.WriteLine("и число отгаданных цифр, стоящих не на своих местах (коров).");
    System.Console.WriteLine("Выйти из игры ты можешь в любой момент, просто введя 0");
    System.Console.WriteLine("Готов? Давай начнем.");
}

int[] UserNumber (int num)
{
    int length = 4;
    int[] userNumArray = new int[length];
    for (int i = 3; i >= 0; i--)
    {
        userNumArray[i] = num % 10;
        num /= 10;
    }
    return userNumArray;
}

int CheckNumBull (int[] mass, int[] arr)
{
    int numBull = 0;
    for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] == arr[i]) numBull++;
        }
    return numBull;
}

int CheckNumCow (int[] mass, int[] arr)
{
    int numCow = 0;
    for (int i = 0; i < mass.Length; i++)
        {
            for (int j = 0; j < mass.Length; j++)
            {
                if (mass[i] == arr[j]) numCow++;
            }
        }
    return numCow;
}

void GameBullCow ()
{
    int lengthMassProgram = 4;
    int[] massProgram = SetArray(lengthMassProgram);
    int numBull = 0;
    int numCow = 0;
    int countAttempt = 0;
    // ShowMass(massProgram);
    MessageBegin();
    
    while (numBull != 4)
    {
        numBull = 0; 
        numCow = 0;
        System.Console.WriteLine("Введи число: ");
        int userNum = int.Parse(Console.ReadLine());

        if (userNum == 0) 
        {
            break;
        }      

        if (userNum > 999 && userNum < 10000) 
        {
        int[] userNumArray = UserNumber(userNum);
        numBull = CheckNumBull(massProgram, userNumArray);
        numCow = CheckNumCow(massProgram, userNumArray);
        System.Console.WriteLine($"Ты угадал {numBull} быков и {numCow} коров.");
        }

        else System.Console.WriteLine("Требуется 4-значное число");
        countAttempt++;
    }
    if (numBull == 0) System.Console.WriteLine("Мне жаль, ты старался");
    else System.Console.WriteLine($"Поздравляю с победой! Ты угадал число с {countAttempt} попытки.");
}

GameBullCow();
