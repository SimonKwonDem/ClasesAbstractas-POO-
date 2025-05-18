using EjercicioInterfaces2;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Crear una interfaz IVehiculo con el método Conducir().
         Implementar las clases Auto, Moto y Bicicleta. Adaptar el método conducir para cada clase. */ 
        
        IVehiculo[] vehiculos = new IVehiculo[3];
        vehiculos[0] = new Auto("Audi", "Verde");
        vehiculos[1] = new Moto("Yamaha", 998);
        vehiculos[2] = new Bicicleta("Venzo",26);

        foreach(IVehiculo vehiculo in vehiculos)
        {
            vehiculo.Conducir();
            Console.WriteLine("");
        }
        
    }
}