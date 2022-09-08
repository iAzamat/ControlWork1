# Контрольная работа № 1

## Задание

> Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## Реализация

1. В репозитории приложен файл блок схемы решения задачи:
*[просмотр](https://github.com/iAzamat/ControlWork1/blob/main/diagram.png "блок-схема")*
2. В программе задается массив **strArray** размером **size = 4**

```
int size = 4;
string[] strArray = new string[size];
```

3. Этот массив заполняется пользователем с помощью метода **FillArray**

```
FillArray(strArray);
```

```  
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }

}
```
4. Выводим заполненный массив с помощью метода **PrintArray**

```
 Console.WriteLine("Введенный массив"); 
 PrintArray(strArray);
```

```
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"'{array[i]}'");
        else
        {
            Console.Write($"'{array[i]}', ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
```

5. Для создания результирующего массива, необходимо узнать размерность массива. Используем метод **SizeResultArray** с параметром **maxLength = 3**. Это условие, что нас интересуют только строки меньше или равные трем. Записываем результат в переменную **resultArraySize**

```
int maxLength = 3;
int resultArraySize = SizeResultArray(strArray, maxLength);
```

```
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
```
6. Создаем результирующий массив **resultArray** размерности **resultArraySize**

```
string[] resultArray = new string[resultArraySize];
```

7. Заполняем результирующий массив с помощью метода **FillResultArray**

```
int maxLength = 3;
FillResultArray(strArray, resultArray, maxLength);
```

```
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
```
8. Выводим полученный массив с помощью метода **PrintArray**

```
Console.WriteLine("Результирующий массив");
PrintArray(resultArray);
```
