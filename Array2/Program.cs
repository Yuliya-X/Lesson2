int[] array = { 15, 4, 86, 22, 89, 69, 4, 78 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
        // break; - чтобы искал только первый индекс, а не все равные файнд
    }
    index++;
}