using System;

namespace _14_OOP_Static;
// Static anahtar kelimesi bir,bir elemanın (alan ozellık veya meto) bağlı olduğu
// bir örneği (nesne) olmadan kullanılabilir.ve üretilen tüm nesneler bu elemanın 
// değerine bağlı olur
public class MathOperatıon
{
    public double Area(int r)
    {
        return double.Pi * r * r;
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static double Pi;
}
