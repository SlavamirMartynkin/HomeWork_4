//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int number = ReadInt("Введите число: ");
System.Console.WriteLine(Sum(DoMassiv(number)));

int ReadInt(string argument)
{
	Console.Write(argument);
	int i;
	while (!int.TryParse(Console.ReadLine(), out i))
	{
        Console.WriteLine("Это не число!");
        Console.Write(argument);
	}
	return i;
}
int [] DoMassiv(int x)
{
    x = Math.Abs(x);
    string str = x.ToString();
    int [] S = new int [str.Length];
    for (int i = 0; i < str.Length; i++)
    {
       S[i] = int.Parse(str[i].ToString()); 
    }
    return S;
}
int Sum(int[] x)
{
    int sum = 0;
    for (int i = 0; i < x.Length; i++)
    {
        sum +=x[i];
    }
    return sum;
}
