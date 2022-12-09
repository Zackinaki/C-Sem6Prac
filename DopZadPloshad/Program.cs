// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить 
// его площадь.

Console.Clear();
Console.WriteLine("Vvedite koordinati : ");
Console.Write("Vvedite x1 : ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite y1 : ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite x2 : ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite y2 : ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite x3 : ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite y3 : ");
double y3 = Convert.ToDouble(Console.ReadLine());

double ab=0,bc=0,ac=0,p=0,s=0;

ab=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
bc=Math.Sqrt(Math.Pow(x2-x3,2)+Math.Pow(y2-y3,2));
ac=Math.Sqrt(Math.Pow(x1-x3,2)+Math.Pow(y1-y3,2));
p=(ab+ac+bc)/2;
s=Math.Round(Math.Sqrt((p-ab)*(p-ac)*(p-bc)*p),2);

Console.WriteLine($"Ploshad' treugolnika ravna: {s}");