//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Тело программы

Console.Write("Введите кол-во элементов массива: ");
int M = InputInt();

int[] local_array = FillArray(M);
PrintArray(local_array);

Console.WriteLine($"Кол-во положительных чисел = {CountNegativeNumber(local_array)}");

//Методы

int InputInt()
{
    bool isParse = int.TryParse(Console.ReadLine(), out int number);

    if(isParse)
    {
        return number;
    }
    else
    {
        throw new ArgumentException("Введено некорректое значение!");
    }
}

int[] FillArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"введите значение для {i} элемента: ");
        array[i] = InputInt();
    }

    return array;
}

void PrintArray(int[] array)
{
    string out_array = string.Join(", ", array);
    Console.WriteLine($"[{out_array}]");
}

int CountNegativeNumber(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }

    return count;
}