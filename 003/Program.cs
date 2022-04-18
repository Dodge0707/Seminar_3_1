Console.WriteLine("Введите координату точки X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Quarter(x,y);

void Quarter(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine($"Координата не может равняться нулю!!!!");
        return;
    }
    if (x > 0 && y > 0)
        Console.WriteLine($"Это 1 четверть");
    if (x < 0 && y > 0)
        Console.WriteLine($"Это 2 четверть");
    if (x < 0 && y < 0)
        Console.WriteLine($"Это 3 четверть");
    if (x > 0 && y < 0)
        Console.WriteLine($"Это 4 четверть");
}
