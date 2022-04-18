Console.WriteLine("Введите номер четверти: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

Quarter(quarterNumber);

void Quarter(int quarterNumber)
{
if (quarterNumber == 1)
    Console.WriteLine($"Х: (+1;{Int64.MaxValue}), а Y: (1;{Int64.MaxValue})");
if (quarterNumber == 2)
    Console.WriteLine($"Х: (-1;{Int64.MinValue}), а Y: (1;{Int64.MaxValue})");
if (quarterNumber == 3)
    Console.WriteLine($"X: (-1;{Int64.MinValue}), Y: (-1;{Int64.MinValue})");
if (quarterNumber == 4)
    Console.WriteLine($"X: (1;{Int64.MaxValue}), Y: (-1;{Int64.MinValue})");
if (quarterNumber <1 || quarterNumber > 4)
{
    Console.WriteLine($"Введите корректный номер четверти!!!!");
    return;
}
}
