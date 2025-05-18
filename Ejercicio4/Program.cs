using Ejercicio4;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Nos encontramos trabajando en el Museo Argentino de Ciencias Naturales "Bernardino
        Rivadavia" y nos solicitaron un desarrollo para almacenar el sonido de diversos animales.
        Ayuda: Deberíamos tener en el Main un arreglo de animales y ejecutar un método que tengan
        todos en común para escuchar los diversos sonidos catalogados por los científicos.*/

        Animal[] animales = new Animal[4];
        animales[0] = new Perro("Tobi", "Ruliento", "Marrón");
        animales[1] = new Gato("Michi", "Rayado", "Naranja");
        animales[2] = new Perro("José", "Manchas", "Blanco");
        animales[3] = new Gato("Bernardo", "Pelado", "Gris");

        foreach(Animal animals in animales)
        {
            animals.SonidoCaracteristico();
            Console.WriteLine("");
        }

    }
}