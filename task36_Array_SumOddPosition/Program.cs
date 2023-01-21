/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


Console.Clear();
// Функция 1. Запрос и ввод целого числа
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
// Функция 2. Объявление массива, заданного размера, определение границ для генератора СЧ,
// присвоение случайных значений элементам массива

int[]GetArr(int number, int Left, int Rigth)
{
    int[]array = new int[number];
    
    Random rnd = new Random ();

    Console.Write ("Элементам массива присвоены случайные значения :");

    for (int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(Left,Rigth+1);
        
    }
    return array;
}
// Объявление переменных и ввод данных

    int num = GetNumber ("Введите размер массива (целое число): ");

    int borderLeft = GetNumber ("Введите левую границу случайных значений массива: ");

    int borderRigth = GetNumber ("Введите правую границу случайных значений массива: ");

    int[] mass = GetArr(num, borderLeft,borderRigth );

// Расчет суммы элементов на нечетных позициях
    for (int i = 0; i < mass.Length; i++)
    {
    Console.Write(mass[i] + "; ");
    }
    int sumOdd = 0;
    for (int i = 0; i < mass.Length; i++)
    {
       if (i % 2 != 0) sumOdd += mass[i]; // если позицию считать по индексу элемента массива (i), т.е. от 0
        // if (i % 2 == 0) sumOdd += mass[i];// если позицию считать по порядковому положению элемента в массиве, т.е. от 1
    }
// Вывод результатов расчета

    Console.WriteLine ();

    Console.Write($"В массиве {num} элементов, сумма элементов на нечетных позициях равна: {sumOdd}");
    