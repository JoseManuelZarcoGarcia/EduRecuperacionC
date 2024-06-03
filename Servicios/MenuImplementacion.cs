using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionSeleccionada = default;

            Console.WriteLine("-----------------");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Alta de objito");
            Console.WriteLine("2. baja de alumno");
            Console.WriteLine("3. listado de alumnos");
            Console.WriteLine("4. listado de alumnos en fichero");
            Console.WriteLine("5. modificar un campo");
            Console.WriteLine(string.Concat("-----------------", "\n"));
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

        public int menuModificarCampoAlumno()
        {
            int opcionSeleccionada = default;

            Console.WriteLine("-----------------");
            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. nombre");
            Console.WriteLine("2. apellido1");
            Console.WriteLine("3. apellido2");
            Console.WriteLine("4. direccion");
            Console.WriteLine("5. telefon");
            Console.WriteLine("6. email");
            Console.WriteLine(string.Concat("-----------------", "\n"));
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

    }
}
