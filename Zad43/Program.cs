// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Vvedite parametri pramih: ");
Console.Write("Vvedite b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Vvedite k2: ");
double k2= Convert.ToDouble(Console.ReadLine());
double y=0,x=0;

if((k1==k2)&&(b1==b2))
Console.WriteLine("Pramie sovpadaut");
else 
if(k1==k2)
Console.WriteLine("Pramie paralel'nu");
else
{
    x=(b2-b1)/(k1-k2);
    y=k1*(b2-b1)/(k1-k2)+b1;
    Console.WriteLine($"Tochka peresechenia ({x};{y})");
}