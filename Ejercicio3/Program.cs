using Ejercicio3;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Crear la clase abstracta Vehiculo con método abstracto Arrancar() y un método no abstracto que
          sea acelerar(). Crear las clases hijas Auto, Moto y Camion que implementen Arrancar().
          En el Main, crear un arreglo de Vehículos y que ejecuten el método arrancar y acelerar.*/

        Vehiculo[] vehiculos = new Vehiculo[3];
        vehiculos[0] = new Auto("Audi", "Negro");
        vehiculos[1] = new Moto("Honda", "Gris");
        vehiculos[2] = new Camion("Iveco", "Blanco");

        foreach (Vehiculo v in vehiculos)
        {
            v.Arrancar();
            v.Acelerar();
            Console.WriteLine("");
        }
    }
}