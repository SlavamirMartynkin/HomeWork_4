int a = ReadInt("Введите А: ");// сторона прямоугольника
int b = ReadInt("Введите B: ");// сторона прямоугольника
int c = ReadInt("Введите C: ");// сторона квадрата

if (ABC(a, b, c))
{
    System.Console.WriteLine($"Квадрат со стороной {c} поместится в прямоугольник {a}x{b} {Area(a, b, c)} раз(а).");
}
else
{
    System.Console.WriteLine($"Квадрат со стороной {c} не влезет в прямоугольник {a}x{b}.");
}

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
bool ABC(int a, int b, int c)
{
    if (c > a || c > b)
    {
        return false;
    }
    else
    {
    return true;
    }
}
int Area(int a, int b, int c)
{
    int count = 0;
    count = (a * b) / (c * c);
    return count;
}   
