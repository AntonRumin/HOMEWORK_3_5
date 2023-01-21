/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();
// Функция 1. Запрос и ввод значений
int GetNumber(string msg)
{

    int result = 0;
    while(true)
    {
        Console.Write(msg);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}
//Функция 2. Объявление массива, заданного размера, и заполнение его случайными значениями

int[]GetArr(int number)
{
    int[]array = new int[number];
    
    Random rnd = new Random ();

    for (int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
    Console.Write("Элементам массива присвоены случайные значения: ");
    return array;
}
//  Объявление переменных

int num = GetNumber ("Введите размер массива (целое число): ");

    int[] mass = GetArr(num);

    for (int i = 0; i < mass.Length; i++)
    {
    
    Console.Write(mass[i] + "; ");
    }
    int countEve = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i]%2 == 0) countEve += 1;
    }
    // Вывод результатов расчета
    
    Console.WriteLine ();

    Console.Write($"В массиве {num} элементов, из них четных чисел: {countEve}");
    