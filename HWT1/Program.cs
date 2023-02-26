// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    var rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }

    return result;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int evenNum(int[] array)
{
    int countNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countNum ++;
    }
    return countNum;
}

int size = 4;
int minValue = 100;
int maxValue = 999;
int[] myArray = GenerateArray(size, minValue, maxValue);
ShowArray(myArray);
System.Console.WriteLine($"Количество четных элементов в массиве = {evenNum(myArray)}");