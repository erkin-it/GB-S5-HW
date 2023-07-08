// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

int[] InitArray (int LenArray, int MinNumber, int MaxNumber) //Иннициализация массива
{
    int[] arr = new int[LenArray];
    Random rnd = new Random ( );
    for (int i = 0; i < LenArray; i++)
    {
        arr[i] = rnd.Next(MinNumber, MaxNumber+1);
    }

    return arr;
}

void PrintArray (int[] arr) //Вывод на экран массив
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1)
        {
            Console.Write ($"{arr[i]}, ");
        }
        else
        {
            Console.Write ($"{arr[i]}]");
        }
    }
}

int OddSum (int[] arr) //Подсчёт суммы элементов, стоящих на нечётных позициях.
{
    int result = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        result+=arr[i];
    }
    return result;
}

//------------------------------------------------------------------------------

int Len = int.Parse(InputTxt("Введите величину массива: "));
int MinValue = int.Parse(InputTxt("Введите минимальное значение массива: "));
int MaxValue = int.Parse(InputTxt("Введите максимальное значение массива: "));

int[] ArrayNum = InitArray (Len, MinValue, MaxValue);

PrintArray (ArrayNum);

Console.Write($"-> Сумма элементов, стоящих на нечётных позициях {OddSum(ArrayNum)}");