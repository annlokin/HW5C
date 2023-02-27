//  Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();
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

int Difference(int[] array)
{
    int min = array [0];
    int max = array [0];
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
   return diff = max - min;
}

int size = 5;
int minValue = 0;
int maxValue = 50;
int[] myArray = GenerateArray(size, minValue, maxValue);
ShowArray(myArray);
System.Console.WriteLine($"Разница между максимальным и минимальным числом массива = {Difference(myArray)}");