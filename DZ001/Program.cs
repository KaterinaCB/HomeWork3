Console.Write("Введите пятизначиное целое число ");
int num = Convert.ToInt32(Console.ReadLine());

int a = num % 10;
int b = (num / 10000) % 10;
int c = (num / 10) % 10;
int d = (num / 1000) % 10;

if (a == b & c == d) Console.WriteLine("Да");
else Console.WriteLine("Нет");