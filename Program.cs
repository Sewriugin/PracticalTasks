// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.  
// Напишите программу, которая покажет количество чётных чисел в массиве.
//           1) 345, 897, 568, 234, -> 2

// Задача 34
Console.WriteLine("Задача 34");
int[] createOneArray(int n)
{
    return new int[n];
}

void fillArray (int [] array, int i1, int i2)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(i1,i2);
    }
}

void printArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void evenNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    Console.WriteLine("Количество чётных чисел в массиве: " + count);
}


int[] arrayOne = createOneArray(4);
fillArray(arrayOne, 100, 1000);
printArray(arrayOne);
evenNumbers(arrayOne);

int[] arrayOne1 = {345, 897, 568, 234};
printArray(arrayOne1);
evenNumbers(arrayOne1);

// Задача 36: Задайте одномерный массив, заполненный случайными числами.  
// Найдите сумму элементов, стоящих на чётных позициях.
//           1) [3, 7, 23, 12] -> 19; 2) [-4, -6, 89, 6] -> 0

// Задача 36
Console.WriteLine("Задача 36");

void sumEvenNumbers(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = array[i] + sum;
    }
    Console.WriteLine("Сумма чисел стоящих на чётных индексах массива: " + sum);
}

int[] arrayOne36 = createOneArray(4);
fillArray(arrayOne36, -100, 100);
printArray(arrayOne36);
sumEvenNumbers(arrayOne36);

int[] arrayOne362 = {3, 7, 23, 12};
printArray(arrayOne362);
sumEvenNumbers(arrayOne362);

int[] arrayOne363 = {-4, -6, 89, 6};
printArray(arrayOne363);
sumEvenNumbers(arrayOne363);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//           1) [3, 7, 22, 2, 78] -> 76

// Задача 38
Console.WriteLine("Задача 38");

void arrayMaxMin(int [] array)
{
    int max = array[0];
    int min = array[0];
    int difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if (array[i] < max)
            {
                min = array[i];
            }
        }
    }
    difference = max - min;
    Console.WriteLine("max: " + max + " , " + "min: " + min + "; " + "max - min = " + difference);
}

int[] arrayOne38 = {3, 7, 22, 2, 78};
printArray(arrayOne38);
arrayMaxMin(arrayOne38);