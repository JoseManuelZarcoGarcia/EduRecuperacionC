using EduRecuperacionC.Dtos;
using EduRecuperacionC.Servicios;
using EduRecuperacionC.Util;

namespace EduRecuperacionC.Controladores
{

    class Program
    {
        public static string rutaCarpetaLog = "C:\\Users\\csi22-jzarcia\\source\\repos\\logs\\";
        public static string rutaFicheroLog = string.Concat(rutaCarpetaLog, Util.Utilidades.construirNombreLog());
        public static List<AlumnoDto> listaAlumnos = new List<AlumnoDto>();

        static void Main(string[] args)
        {
            //Utilidades util = new Utilidades();
            //string rutaFicheroLog = string.Concat(rutaCarpetaLog, util.construirNombreLog());

            //cerrar menu
            //alta de objeto

            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            AlumnoInterfaz al = new AlumnoImplementacion();
            bool cerrarMenu = true;
            int opcionSeleccionada;
            string ficheroListadoAlumnos = "C:\\Users\\csi22-jzarcia\\source\\repos\\ficheroListadoAlumnos\\patata.txt";

            do
            {
                try
                {
                    // dni - nombre
                    opcionSeleccionada = mi.mostrarMenu();
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            cerrarMenu = false;
                            fi.escribirFicheroLog("se ha seleccionado cerra menu");
                            break;
                        case 1:
                            al.altaAlumno();
                            fi.escribirFicheroLog("se ha seleccionado alta de objeto");
                            break;
                        case 2:
                            al.bajaAlumno();
                            fi.escribirFicheroLog("se ha seleccionada baja de alumno");
                            break;
                        case 3:
                            foreach (AlumnoDto alumno in listaAlumnos)
                            {
                               Console.WriteLine(alumno.ToString());
                            }
                            fi.escribirFicheroLog("se ha seleccionada listado de alumnos");
                            break;
                        case 4:
                            fi.escribirFicheroListadoAlumnos(ficheroListadoAlumnos);
                            fi.escribirFicheroLog("se ha seleccionada baja de alumno");
                            break;
                        default:
                            Console.WriteLine("El valor dado no es valido");
                            fi.escribirFicheroLog("se ha seleccionado una opcion no valida");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    try {
                        fi.escribirFicheroLog("Ha ocurrido un error en el menu");
                        fi.escribirFicheroLog(ex.Message);
                    }
                    catch(IOException exIO)
                    {

                    }
                }
            } while (cerrarMenu);

        }

    }

}