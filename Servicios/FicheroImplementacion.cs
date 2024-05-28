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

    }
}
