using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crear_archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //declarar variable de tipo archivo
            TextWriter archivo;
            //instanciar variable y crear archivo
            archivo = new StreamWriter("archivo.txt");
            //declarar variable de string
            string mensaje;
            //imprimir y leer mensaje escrito en la consola
            Console.WriteLine("Escriba un texto");
            mensaje = Console.ReadLine();
            //escribir en el arhivo el contenido de la variable mensaje
            archivo.WriteLine(mensaje);
            //cerrar arhivo
            archivo.Close();
            //limpiar consola
            Console.Clear();
            //imprimir en la consola
            Console.WriteLine("Se ha guardado el archivo...");
            //Detener la aplicacion al presionar una tecla
            Console.ReadKey();

            /*Fuente LearnWtutorials: https://www.youtube.com/watch?v=UneNyEshsXU */
        }
    }
}
