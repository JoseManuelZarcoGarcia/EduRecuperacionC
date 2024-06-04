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
        MenuInterfaz mi = new MenuImplementacion();

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

                Console.WriteLine("Escriba su fecha de nacimiento");
                nuevoAlumno.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());

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

        public void modificarCampoAlumno()
        {
            Console.WriteLine("escriba el dni a buscar");
            string dniValidador = Console.ReadLine();
            bool cerrarMenu2 = true;
            AlumnoDto alumnoBuscado = new AlumnoDto();
            foreach(AlumnoDto alumno in Controladores.Program.listaAlumnos)
            {

                if(alumno.Dni.Equals(dniValidador))
                {
                    alumnoBuscado = alumno;
                    Console.WriteLine(alumno.Dni.ToString());
                }
            }

            string respuesta = "n";
            do
            {
                int nuevaOpcionSeleccionada = mi.menuModificarCampoAlumno();
                switch (nuevaOpcionSeleccionada)
                {
                    case 1:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Escriba el nombre");
                        Console.WriteLine("-----------------");
                        alumnoBuscado.Nombre = Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Escriba el apellido1");
                        Console.WriteLine("-----------------");
                        alumnoBuscado.Apellido1 = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Escriba el apellido2");
                        Console.WriteLine("-----------------");
                        alumnoBuscado.Apellido2 = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Escriba la direccion");
                        Console.WriteLine("-----------------");
                        alumnoBuscado.Direccion= Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Escriba el telefon");
                        Console.WriteLine("-----------------");
                        alumnoBuscado.Telefono= Convert.ToInt64(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Escriba el email");
                        Console.WriteLine("-----------------");
                        alumnoBuscado.Email = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("Escriba la fecha de nacimiento");
                        Console.WriteLine("-----------------");
                        alumnoBuscado.FechaNacimiento= Convert.ToDateTime(Console.ReadLine());
                        break;
                    default:
                        break;
                }

                Console.WriteLine("si quiere seguir cambiando pulse s");
                respuesta = Console.ReadLine();
                

            } while (respuesta == "s");
            

        }

    }
}
