// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

int EventNum (int[] arr) //Подсчёт положительных чисел массива
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i]%2) == 0)
        {
            result+=1;
        }
    }
    return result;
}

//------------------------------------------------------------------------------

int Len = int.Parse(InputTxt("Введите величину массива: "));

int[] ArrayNum = InitArray (Len, 100, 1000);

PrintArray (ArrayNum);

Console.Write($"-> Колличество чётных чисел {EventNum(ArrayNum)}");