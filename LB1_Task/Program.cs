using System;


public class Vector
{
    double x1, y1, x2, y2;    //координати кінців вектора

    //конструктор з параметрами
    public Vector(double x1, double y1, double x2, double y2)   
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }    
    
    //метод, який перевіряє, чи не став вектор точкою
    public bool Correct()
    {
        bool p = false;
        if (x1 != x2 && y1 != y2) p = true;
        return p;
    }    

    //метод, який отримує координати вектора за координатами його кінців
    public (double, double) Koord()
    {
        double a = x2 - x1;
        double b = y2 - y1;
        return (a, b);
    }

    //метод, що обчислює довжину ветора
    public double Length()
    {
        (double a, double b) = Koord();
        double l = Math.Sqrt(a * a + b * b);
        return l;
    }

    //метод, який виводе на екран значення координат
    public void Print()
    { Console.WriteLine($"\nx1={x1} y1={y1} x2={x2} y2={y2}\n"); }
}

class Program
{
    static void Main(string[] args)
    {
        double x1, y1, x2, y2;
        try
        {
            //просимо користувача ввести координати
            Console.WriteLine("Введiть, будь ласка, координати кiнцiв вектора");
            Console.Write("x1="); x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1="); y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2="); x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2="); y2 = Convert.ToDouble(Console.ReadLine());
            //створюємо об'єкт
            Vector v = new Vector(x1, y1, x2, y2);
            //виводимо значення
            v.Print();
            //перевіряємо існування вектора
            if (v.Correct()) //об'єкт існує
            {
                //застосовуємо методи обчислення
                (double a, double b) = v.Koord();
                double l = v.Length();
                //виводимо результат
                Console.WriteLine($"Координати вектора = {a}, {b}\nДовжина вектора = {l:F3}");
            }
            //об'єкт не існує
            else Console.WriteLine("Такого вектора не iснує");

        }
        catch
        {
            //інші можливі виключення
            Console.WriteLine("Помилка!");
        }

    }
}