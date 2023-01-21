/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.Clear();
// Функция ввода значений числа
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
            Console.WriteLine("Введенное значение должно быть числом. Повторите ввод.");
        }
    }
    return result;
}
//  Функция заполнения массива случайными значениями

int[]GetArr(int number, int Left, int Rigth)
{
    int[]array = new int[number];
    
    Random rnd = new Random ();

    Console.Write("Элементам массива присвоены значения :");

    for (int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(Left,Rigth+1);
    }
    return array;
}
// Функция нахождения минимального и максимального значений массива

(int,int) FindArrayMinMax (int[] arr)
{

int max = arr[0];
int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];

        if (arr[i] < min) min = arr[i];
    }
    
    return (max, min);
}

// Метод вывода значений массива
void PrintArray (int[] group)
{
    for (int k = 0; k < group.Length; k++)
    {
        Console.Write(group[k] + "; ");
    }
}

// Объявление переменных 
int num = GetNumber ("Введите размер массива (целое число): ");

int borderLeft = GetNumber ("Введите левую границу случайных значений массива: ");

int borderRigth = GetNumber ("Введите правую границу случайных значений массива: ");

int[] mass = GetArr(num, borderLeft,borderRigth );

// Вывод элементов массива

PrintArray (mass);

// Нахождение максимального и минимального значений

(int massMax, int massMin) = FindArrayMinMax (mass);

// Вывод результатов

Console.WriteLine ();

Console.Write ($"В массиве из {mass.Length} элементов, максимальное значение {massMax}, минимальное значение {massMin}, разность максимального и минимального значений {massMax - massMin}");
    
   