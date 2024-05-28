using EduRecuperacionC.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Util
{
    internal static class Utilidades
    {

        public static string construirNombreLog()
        {
            string nombreLog = "aaa";

            try
            {
                DateTime fechaActual = DateTime.Now;
                string fecha = fechaActual.ToString("ddMMyy");
                nombreLog = string.Concat("log-", fecha, ".txt");
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha habido un error al construir el nombre del fichero log");
                throw;
            }
            return nombreLog;

        }

        public static long idAutogeneradoAlumno() 
        {
            List < AlumnoDto > nuevaListaAlumnos = Controladores.Program.listaAlumnos;

            int tamanyoLista = nuevaListaAlumnos.Count;
            long nuevaId;
            if (tamanyoLista > 0)
            {
                nuevaId = nuevaListaAlumnos[tamanyoLista - 1].IdAlumno + 1;
            }
            else
            {
                nuevaId = 1;
            }

            return nuevaId;
        }
    }
}
