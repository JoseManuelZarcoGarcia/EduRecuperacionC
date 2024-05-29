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
            do
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
            } while (Controladores.Program.listaAlumnos.Count<3);
        }


        public void bajaAlumno()
        {
            string salirBajaAlumno = "n";
            do
            {
                Console.WriteLine("Indique el dni del alumno a borrar ");
                string dniPedido = Console.ReadLine();
                AlumnoDto alumnoABorrar = new AlumnoDto();

                foreach(AlumnoDto alumno in Controladores.Program.listaAlumnos)
                {
                    if (alumno.Dni.Equals(dniPedido))
                    {
                        alumnoABorrar = alumno;
                        break;
                    }
                }
                /* borramos al alumno fuera del bucle foreach xq si hay 4 alumnos y borramos el 3,
                * el 4 pasa a ser el 3 y el bucle da error al buscar el 4. 
                * esto pasa xq el foreach tine un controlador que nosotros no controlamos
                */
                Controladores.Program.listaAlumnos.Remove(alumnoABorrar);

                Console.WriteLine("Si quiere seguir borrando alumnos escriba s ");
                salirBajaAlumno = Console.ReadLine();

            } while (salirBajaAlumno=="s");

        }

    }
}
