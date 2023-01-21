int[] array = { 10, 21, 34, 46, 5, 689, 70, 8, 70 };
int n = array.Length;
int find = 70;
int index = 0;
while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}