int xa = grafAB("x", "A");
int ya = grafAB("y", "A");
int za = grafAB("z", "A");
int xb = grafAB("x", "B");
int yb = grafAB("y", "B");
int zb = grafAB("z", "B");

int grafAB(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double xa, double xb, 
                double ya, double yb, 
                double za, double zb){
  return Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2));
}

double segmentLength =  Math.Round (Decision(xa, xb, ya, yb, za, zb), 2 );

Console.WriteLine($"Длина   {segmentLength}");