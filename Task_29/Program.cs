﻿//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] array = new int[8];

int[] FillArray()
{
    int Length = array.Length;
    int index = 0;
    while (index < Length)
    {
        array[index] = new Random().Next();
        index++;
    }
    return array;
}

System.Console.WriteLine(string.Join("  ", FillArray()));



