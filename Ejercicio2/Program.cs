using Ejercicio2;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Crear una clase abstracta Empleado con los atributos Nombre, SueldoBase, y un método abstracto
          CalcularSueldo(). Se debe crear las clases hijas EmpleadoTiempoCompleto y
          EmpleadoMedioTiempo.
          El empleado de tiempo completo calcula su sueldo según su sueldo base + bono de presentismo.
          El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra si supero las
          20 horas semanales.*/

        EmpleadoTiempoCompleto eTc = new EmpleadoTiempoCompleto("Juan", 2000, 200, 22);
        EmpleadoMedioTiempo eMt = new EmpleadoMedioTiempo("Simon", 1000,300, 24);
        eMt.CalcularSueldo();
        eTc.CalcularSueldo();

    }
}