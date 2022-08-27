string NumbersInCube()
{
    Console.Write("Введите целое число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    string result = string.Empty;

    while (i <= N)
    {
        result = result + Math.Pow(i,3) + ",";
        i = i + 1;
    }
    return result;
}

try
{
    Console.WriteLine(NumbersInCube());
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
