double x1 = 0, y1 = 2, x2 = 1.5, y2 = 0.7, x3 = 1, y3 = 1, x4 = 3, y4 = 0;

Console.WriteLine("1 задача");
if (Math.Abs(x1*x1 + y1*y1 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x1},{y1}): да");
} else
{
    Console.WriteLine($"Для ({x1},{y1}): нет");
}
if (Math.Abs(x2 * x2 + y2 * y2 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x2},{y2}): да");
}
else
{
    Console.WriteLine($"Для ({x2},{y2}): нет");
}
if (Math.Abs(x3 * x3 + y3 * y3 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x3},{y3}): да");
}
else
{
    Console.WriteLine($"Для ({x3},{y3}): нет");
}
if (Math.Abs(x4 * x4 + y4 * y4 - 4) >= 0.001)
{
    Console.WriteLine($"Для ({x4},{y4}): да");
}
else
{
    Console.WriteLine($"Для ({x4},{y4}): нет");
}

x1 = -1;
y1 = 0;
x2 = 1;
y2 = 0;
x3 = 0;
y3 = 1;

Console.WriteLine("\n2 задача");

if (y1 >= 0 && (y1 + Math.Abs(x1) <= 1))
{
    Console.WriteLine($"Для ({x1},{y1}): да");
}
else
{
    Console.WriteLine($"Для ({x1},{y1}): нет");
}
if (y2 >= 0 && (y2 + Math.Abs(x2) <= 1))
{
    Console.WriteLine($"Для ({x2},{y2}): да");
}
else
{
    Console.WriteLine($"Для ({x2},{y2}): нет");
}
if (y3 >= 0 && (y3 + Math.Abs(x3) <= 1))
{
    Console.WriteLine($"Для ({x3},{y3}): да");
}
else
{
    Console.WriteLine($"Для ({x3},{y3}): нет");
}

double s = 0,n = 5,inp = 5;

Console.WriteLine("Введите рост детей (5):\n");

for (int i = 0; i < n; i++)
{
    if (double.TryParse((Console.ReadLine()), out inp)) {
        s += inp;
    }
}

Console.WriteLine($"Средний рост: {s/n}");

