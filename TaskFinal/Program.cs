// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

using System;
using static System.Console;
Clear();

Write("Введите значения через пробел: ");
string[] array = ReadLine().Split(" ");

string [] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");;


string[] FindLessThan(string[] inArray, int n) 
{
    string[] resArray = new string[SizeLessThan(inArray, n)];

    for(int i = 0, j = 0; i < inArray.Length; i++) 
    {
        if(inArray[i].Length <= n) 
        {
            resArray[j] = inArray[i];
            j++;
        }
    }

    return resArray;
}

int SizeLessThan(string[] inArray, int n) 
{
    int size = 0;

    for(int i = 0; i < inArray.Length; i++) 
    {
        if(inArray[i].Length <= n) 
        {
            size++;
        }
    }

    return size;
}
