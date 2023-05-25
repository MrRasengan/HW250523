// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]}  ");
    }
    return res;
}

void GetNumArr(int[] array, int userNumMin, int userNumMax)
{
    int count = 0;
    foreach (int el in array)
    {

        if (el >= userNumMin && el <= userNumMax && el %2 == 0 )
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чётных чисел в двнном массиве равно {count}");
}

Console.Write("Массив: ");
int[] array = GetArray(10, 100, 999);
Console.WriteLine();
GetNumArr(array, 100, 999);
