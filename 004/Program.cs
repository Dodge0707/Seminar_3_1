/*Console.WriteLine("Введите координаты точки Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int katet1 = x1 - x2;
int katet2 = y1 - y2;

double gipotenusa = Math.Round(Math.Sqrt((katet1*katet1) + (katet2*katet2)), 2);
Console.WriteLine($"Расстояние между точками равняется: {gipotenusa}"); */



int x1 = Cordinate("x", "1");
int y1 = Cordinate("y", "1");
int x2 = Cordinate("x", "2");
int y2 = Cordinate("y", "2");

int Cordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}



