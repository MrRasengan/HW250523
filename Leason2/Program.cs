// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
    int sum = 0;
    foreach (int el in array)
    {
        if (el >= userNumMin && el <= userNumMax && el < 0 )
        {
            sum += el;
        }
    }
    Console.Write($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
}
Console.Write("Массив: ");
int[] array = GetArray(7, -10, 10);
Console.WriteLine();
GetNumArr(array, -10, 10);