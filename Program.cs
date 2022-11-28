// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.



/*
//int[]array = new int[ ] {345, 897, 568, 234};
int[]array = new int[10]; 
GetMas(array);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int CountEven = 0;

for (int i = 0; i < 10; i++) {
    
    if (array[i]%2 == 0) {
        CountEven ++;
    }
    
}
Console.WriteLine($"Количество четных элементов массива = {CountEven}");

int[] GetMas (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
*/




// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд)).

/*
int[] array = new int[8];
GetMas(array);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}


Console.WriteLine($"Сумма элементов, стоячих на нечетных позициях: {sum}");

int[] GetMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}
*/




// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.



Console.WriteLine("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

GetMas(array);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int left = 0;
int right = array.Length - 1;


while (left < right)
{
    if (array.Length % 2 == 0)
        {
        int[] temp = new int[array.Length / 2];
        for (int k = 0; k < array.Length / 2; k++)
        {
            temp[k] = array[left] * array[right];
            left += 1;
            right -= 1;
        }
        Console.WriteLine($"[{String.Join(", ", temp)}]");
    }
    else{
        int[] temp = new int[array.Length / 2 + 1];
        for (int k = 0; k < array.Length / 2 ; k++)
        {
            temp[k] = array[left] * array[right];
            left += 1;
            right -= 1;
            temp[array.Length/2] = array[array.Length/2];
        }
        Console.WriteLine($"[{String.Join(", ", temp)}]");
    }
}





int[] GetMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

//Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.

/*
int[] array = new int[6];
GetMas(array);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++){
    if (array[i] < min) {
        min = array[i];
    }
    if (array[i] > max){
        max = array[i];
    }
}


Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {max - min}");

int[] GetMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}
*/