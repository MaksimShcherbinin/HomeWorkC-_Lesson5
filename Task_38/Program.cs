Console.Write("Введите кол-во вещественных чисел массива: ");
int numbers = Convert.ToInt16(Console.ReadLine());

void FillArray(double[] collecton)
{
    for (int i = 0; i < collecton.Length; i++)
    {
        Console.Write("Введите {0} вещественное число массива: ", (i + 1));
        collecton[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double DiffArray(double[] collecton, double diff)
{
    double max = collecton[0], min = collecton[0];
    for (int i = 0; i < collecton.Length; i++)
    {
        if(collecton[i] > max) max = collecton[i];
        if(collecton[i] < min) min = collecton[i];
    }
    diff = max - min;
    return diff;
}

double[] array = new double[numbers];
double diff = 0;
FillArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Разнца между максимальным и минимальным элементом = {0}", DiffArray(array, diff));
