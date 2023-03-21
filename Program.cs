/*int[] array = GetRandomArray(12, 9, -9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach(int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"Positive sum = {positiveSum} and negative Sum = {negativeSum}");*/
// int N = ReadInt("Введите число n: ");
// int[] array = GetRandomArray(12, -9, 9);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"Массив с заменёнными элементами массива = [{String.Join(",", ChangeZnak(array))}]");
/*
if (FindElement(array, N))
{
    Console.WriteLine("Да ");
}
else
{
    Console.WriteLine("Нет ");
}
*/

// int[] array = GetRandomArray(123, -99, 99);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int Count(int[] array)
// {
//     int counter = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 10 && array[i] <= 99)
//         {
//             counter++;
//         }
//     } 
//     return counter;
// }
//Console.WriteLine($"Количество чисел между 10 и 99 включительно = [{Count(array)}]");

//читаем инт с клавиатуры
// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

//генерируем рандомный массив
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

//ищем элемент
/*bool FindElement(int[] array, int Numer)
{
    foreach(int el in array)
    {
        if (N == el) return true;
    }
    return false;
}*/

//меняем знак
// int[] ChangeZnak(int[] Mass)
// {
//     for (int i = 0; i < Mass.Length; i++)
//     {
//         Mass[i] *= -1;
//     }
//     return Mass;
// }

int[] array = GetRandomArray(9, 0, 10);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", GetMultiply(array))}]");
int[] GetMultiply(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0) size++;
    int[] arrayMultiply = new int[size];
    for(int i = 0; i < array.Length / 2; i++)
    {
        arrayMultiply[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 != 0) arrayMultiply[size - 1] = array[array.Length / 2];
    return arrayMultiply;
}
