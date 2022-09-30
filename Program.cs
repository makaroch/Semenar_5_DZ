int[]  createArray(int length, int x, int y){
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(x,y+1);
    }
    return arr;
}

void lookArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+", ");
    }
}


void Zadacha34(){
/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

    int[] array = createArray(y:999, x:100, length: 10);
    int count = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    lookArray(array);
    Console.WriteLine();
    Console.WriteLine("количество чётных чисел в массиве "+count);
}


void Zadacha36(){
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

    int[] array = createArray(8,-10,10);
    int sum = 0;  
    for (int i = 1; i < array.Length; i = i +2)
    {
        sum = sum + array[i];
    }
    lookArray(array);
    Console.WriteLine();
    Console.WriteLine("суммa элементов на нечётных позициях " +sum);

}


void Zadacha38(){
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

    int[] array = createArray(10,-10,10);
    int indexMin = 0;  
    int indexMax = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[indexMax]) indexMax = i;
        if (array[i] < array[indexMin]) indexMin = i;
    }

    int dif = array[indexMax] - Math.Abs(array[indexMin]);
    lookArray(array);
    Console.WriteLine();
    Console.WriteLine("разницa между максимальным и минимальным элементоv массива "+dif);
}

Console.WriteLine("Введите номер задачи");
int zadachaNumber = Convert.ToInt32(Console.ReadLine());

if (zadachaNumber == 34 | zadachaNumber == 36 | zadachaNumber == 38){
    if (zadachaNumber == 34) Zadacha34();
    if (zadachaNumber == 36) Zadacha36();
    if (zadachaNumber == 38) Zadacha38();
}else Console.WriteLine("Есть толь задачи номер 34, 36, 38");