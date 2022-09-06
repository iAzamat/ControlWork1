/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либа равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

*/



int size = 4;
string[] strArray = new string[size];
int maxLength = 3;

FillArray(strArray);
Console.WriteLine("Введенный массив");
PrintArray(strArray);

int resultArraySize = SizeResultArray(strArray, maxLength);
string[] resultArray = new string[resultArraySize];

FillResultArray(strArray, resultArray, maxLength);
Console.WriteLine("Результирующий массив");
PrintArray(resultArray);



void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }

}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}


int SizeResultArray(string[] array, int maxcount)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxcount)
        {
            count++;
        }
    }
    return count;
}


void FillResultArray(string[] array1, string[] array2, int maxcount)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= maxcount)
        {
            array2[index] = array1[i];
            index++;
        }
    }
}