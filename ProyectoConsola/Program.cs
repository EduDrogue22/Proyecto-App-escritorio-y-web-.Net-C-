using Conexion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            SERVICIO_LIMPIEZAEntities db = new SERVICIO_LIMPIEZAEntities();

            int id;
            string nombre;

            Console.WriteLine("Actualizar nombre usuario");

            Console.WriteLine("Ingrese id del usuario: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre usuario: ");
            nombre = Console.ReadLine();

            var update = new USUARIO()
            {
                ID_USER = id,
                NOMBRE_USER = nombre
            };

            USUARIO use = db.USUARIO.Find(update.ID_USER);

            if(use != null)
            {
                use.NOMBRE_USER = nombre;

                db.SaveChanges();

                Console.WriteLine("Bienvenido {0}", nombre);

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El usuario no existe");
                Console.ReadKey();
            }
        }
    }
}
