using System;
public class Example
{
    public static void Main()
    {
        int Entero = 10;
        Console.WriteLine($"Mi entero es: {Entero}")
        //convertir el valor entero a cadena
        string cadena = Convert.ToString(Entero);
        Console.WriteLine($"El valor entero convertido a cadena es: {cadena}");

    }
}