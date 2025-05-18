using EjercicioInterfaces1;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Nos encontramos desarrollando una aplicación administrar, recopilar y procesar información para
        un set de datos de personas que fueron encuestadas con la finalidad de ofrecer una segmentación
        del mercado.
        Se nos requiere que la información se pueda descargar en Excel, PDF y CSV.
        Por lo que se nos ocurre una idea para manejar todos los tipos de Exportables como una sola clase,
        por lo que creamos la Interfaz IExportable con método Exportar(string contenido) y
        se la aplicamos a las clases ExportarPDF, ExportarPDF y ExportarCSV.
        Nuestro main debería permitirnos instanciar cualquier tipo de clase que implemente la interfaz y
        ejecutar el método exportar().*/

        string contenido = "Informe de las personas encuestadas";

        IExportable[] exportador = new IExportable[3];
        exportador[0] = new ExportarExcel();
        exportador[1] = new ExportarPDF();
        exportador[2] = new ExportarCSV();

        foreach(IExportable exportable in exportador)
        {
            exportable.Exportar(contenido);
            Console.WriteLine("");
        }
    }
}