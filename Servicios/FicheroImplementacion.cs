using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {

        public void escribirFicheroLog(string mensaje)
        {
            StreamWriter sw = null;
            try
            {
                using (sw = new StreamWriter(Controladores.Program.rutaFicheroLog, true))
                {
                    sw.WriteLine(mensaje);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        public void escribirFicheroListadoAlumnos(string ficheroListadoAlumnos)
        {
            StreamWriter sw = null;

            try
            {
                using (sw = new StreamWriter(ficheroListadoAlumnos))
                {
                    foreach(AlumnoDto alumno in Controladores.Program.listaAlumnos)
                    {
                        sw.WriteLine(alumno.ToString(';'));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        public void cargaInicial(string fichero)
        {
            try
            {
                
                string[] lineasDelFichero = File.ReadAllLines(fichero);
                foreach (string s in lineasDelFichero)
                {
                    AlumnoDto alumno = new AlumnoDto();
                    string[] campos = s.Split(";");
                    long idAlum = Convert.ToInt64(campos[0]);
                    alumno.IdAlumno = idAlum;
                    alumno.Nombre = campos[1];
                    alumno.Apellido1 = campos[2];
                    alumno.Apellido1 = campos[3];
                    alumno.Dni = campos[4];
                    alumno.Direccion = campos[5];
                    long telef = Convert.ToInt64(campos[6]);
                    alumno.Telefono = telef;
                    alumno.Email = campos[7];
                    DateTime fechNacim = Convert.ToDateTime(campos[8]);
                    alumno.FechaNacimiento = fechNacim;
                    Controladores.Program.listaAlumnos.Add(alumno);
                }
                /*
                StreamReader sr = new StreamReader(fichero); 
                sr.ReadLine();
                sr.Close();
                */

            }
            catch(IOException io)
            {
                Console.WriteLine(io.Message);
            }
        }
             

    }
}
