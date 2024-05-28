using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class AlumnoImplementacion : AlumnoInterfaz
    {

        public void altaAlumno()
        {
            try
            {
                AlumnoDto nuevoAlumno = new AlumnoDto();

                nuevoAlumno.IdAlumno = Util.Utilidades.idAutogeneradoAlumno();

                Console.WriteLine("Escriba su nombre");
                nuevoAlumno.Nombre = Console.ReadLine();

                Console.WriteLine("Escriba su primer apellido");
                nuevoAlumno.Apellido1 = Console.ReadLine();

                Console.WriteLine("Escriba su segundo apellido");
                nuevoAlumno.Apellido2 = Console.ReadLine();

                Console.WriteLine("Escriba su dni");
                nuevoAlumno.Dni = Console.ReadLine();

                Console.WriteLine("Escriba su telefono");
                nuevoAlumno.Telefono = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Escriba su direccion");
                nuevoAlumno.Direccion = Console.ReadLine();

                Console.WriteLine("Escriba su email");
                nuevoAlumno.Email = Console.ReadLine();

                Controladores.Program.listaAlumnos.Add(nuevoAlumno);
            }
            catch (Exception ex)
            {

            }
            finally { }

           
        }

    }
}
