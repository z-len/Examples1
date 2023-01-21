void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index<Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // это значит "создай новый массив, в котором будет 10 элементов
// по умолчанию он будет наполнен нулями

FillArray(array);
PrintArray(array);

