double L = 0, x = 5, a = 5;
Console.Write("Введите количество элементов ряда: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
        L += (Math.Pow(x, i * 2) + 5 * i / (Math.Sqrt(Math.Pow(Math.Sin(x), i + 1))) + (Math.Pow(a, i * 2)));
    else
        L += (Math.Pow(x, i * 2) + 5 * i / (Math.Sqrt(Math.Pow(Math.Sin(x), i + 1))) + (Math.Pow(a, i * 2)));
}
Console.Write("Сумма элементов ряда: ");
Console.WriteLine(L.ToString());