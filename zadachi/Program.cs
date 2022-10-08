void zadacha47()
{
    //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными 
    //вещественными числами, округлёнными до одного знака.
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);
}

void FillArray(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        array[i,j] = Math.Round(random.NextDouble() * 100, 1);
        }
    } 
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void zadacha50()
{
    //Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.

    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Введите индекс i:");
    int stroka = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс j:");
    int stolb = Convert.ToInt32(Console.ReadLine());

    if (stroka < rows && stolb < columns)
        Console.WriteLine($"Элемент {stroka},{stolb} = {array[stroka,stolb]}");
    else
        Console.WriteLine($"Элемент {stroka},{stolb} такого элемента в массиве нет");
}

void zadacha52()
{
    //Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int[,] array = new int[rows, columns];
    int count = 0;
    double rez = 0, sum = 0;
    FillArray2(array);
    PrintArray2(array);
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < columns; j++, rez = sum = count = 0)
    {
        for (int i = 0; i < rows; i++)
        {
            sum = sum + array[i,j];
            count++;
        }
        rez = sum / count;
        Console.Write(Math.Round(rez,2) + "|");
    }
}

void PrintArray2(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArray2(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        array[i,j] = random.Next(0,10);
        }
    } 
}


//zadacha47();
zadacha50();
//zadacha52();