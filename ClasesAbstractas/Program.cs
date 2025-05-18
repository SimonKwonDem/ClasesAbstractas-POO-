
using Figuras.Semana5;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Crear una clase abstracta Figura con un método abstracto CalcularArea(). Crear las clases
        Cuadrado, Círculo y Triángulo que hereden de Figura e implementen el método abstracto según su
        operación para calcular el área.*/

        Triangulo tr = new Triangulo(2,7);
        Circulo cr = new Circulo(4);
        Cuadrado cua = new Cuadrado(5);

        tr.CalcularArea();
        tr.MostrarArea();
        Console.WriteLine("");
        cr.CalcularArea();
        cr.MostrarArea();
        Console.WriteLine("");
        cua.CalcularArea();
        cua.MostrarArea();
    }
}