// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
//  пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
}

void Polozh(int[] array)
{
    int a=0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i]>0)
    a=a+1;
    }
Console.WriteLine($"Kol-vo chisel bol'she 0: {a}");
        
}

Console.Clear();
Console.Write("Vvedite kol-vo budushih vvedenih chisel: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Vvedite chisla: ");
InputArray(array);
Console.WriteLine($"Massiv: [{string.Join(", ", array)}]");
Polozh(array);