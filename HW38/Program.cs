// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

double[] InitArray (int LenArray) //Иннициализация массива вещественных чисел
{
    double[] arr = new double[LenArray];

    for (int i = 0; i < LenArray; i++)
    {
        arr[i] = double.Parse(InputTxt($"Введите {i+1} элемент массива: "));
    }

    return arr;
}

double MaxValue (double[] arr)
{
    double MaxNumber = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]>MaxNumber)
        {
            MaxNumber=arr[i];
        }
    }

    return MaxNumber;

}

double MinValue (double[] arr)
{
    double MinNumber = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<MinNumber)
        {
            MinNumber=arr[i];
        }
    }

    return MinNumber;

}

void PrintArray (double[] arr) //Вывод на экран массив вещественных чисел
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

//---------------------------------------------------------------------------------------------------

int Len = int.Parse(InputTxt("Введите величину массива: "));

double[] ArrayNum = InitArray (Len);

double resMax = MaxValue(ArrayNum);

double resMin = MinValue(ArrayNum);

PrintArray (ArrayNum);

Console.Write ($" => {resMax} - {resMin} = {resMax - resMin}");