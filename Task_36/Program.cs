Console.WriteLine("Введите кол-во элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collecton) 
{
    for(int i = 0; i < collecton.Length; i++) collecton[i] = new Random().Next(-99,100);
}

int UnevenSumArray(int[] collecton, int unevenSum)
{
    for(int i = 0; i < collecton.Length; i++) if(i % 2 != 0) unevenSum += collecton[i];
    return unevenSum;
}

int[] array = new int[numbers];
int unevenSum = 0;
FillArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Сумма элементов с нечётным индексом = {0}", UnevenSumArray(array, unevenSum));
