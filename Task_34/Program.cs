Console.WriteLine("Введите кол-во элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collecton) 
{
    for(int i = 0; i < collecton.Length; i++) collecton[i] = new Random().Next(100,1000);
}

int EvenArray(int[] collecton, int even)
{
    for(int i = 0; i < collecton.Length; i++) if(collecton[i] % 2 == 0) even++;
    return even;
}

int[] array = new int[numbers];
int even = 0;
FillArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("В массиве {0} четных чисел(а)", EvenArray(array, even));
