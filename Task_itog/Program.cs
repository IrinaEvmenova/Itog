//Задача для итоговой проверочной работы. Из имеющегося массива строк формируем массив из строк, длина которых меньше либо равна 3 символам.

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(8,10,10000);
WriteLine($"[{String.Join(",",array)}]");
GetCount();
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result [i] = new Random(). Next(minValue, maxValue);
    }
    return result;
}


void GetCount()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].ToString().Length <= 3)
        {
            Write($"[{String.Join(",",array[i])}]");
        }
    }
}

