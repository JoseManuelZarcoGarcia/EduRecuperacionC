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
            Console.WriteLine(string.Concat("-----------------", "\n"));
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

    }
}
