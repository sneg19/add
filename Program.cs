/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


Console.Clear();


int[] get_array(int min_value, int max_value)
{
    Random temp_random = new Random();
    int size = temp_random.Next(6, 12); 
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = temp_random.Next(min_value, max_value);
    }
    return res;
}


int index (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}


void main()
{
int[] our_array = get_array(-100, 100);
int ar = index(our_array);
Console.WriteLine(String.Join(",", our_array));
Console.WriteLine(ar);
}



