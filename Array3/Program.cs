// функция заполнения массива рандомными числами 
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// функция вывода на печать полученных рандомных чисел
void PrintArray(int[] collection2)
{
    int count = collection2.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection2[position]);
        position++;
    }
}

// функция поиска числа в массиве 
int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //чтобы выдавал только первое значение
        }
        index++;
    }
    return position;
}
int [] array = new int[10]; // определили (ограничили) массив из 10ти элементов

FillArray(array); // заполнили массив рандомными числами 
PrintArray(array); // вывели на печать полученные числа 

Console.WriteLine(); // пустая строка в результате

int pos = IndexOff(array, 4); // ввели новую переменну "пос" (искать элемент массива равный 4 "файнд" и показать его "пос" (индекс))
Console.WriteLine(pos); // вывели на печать индекс файнда