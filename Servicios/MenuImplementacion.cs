using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        FicheroInterfaz fi = new FicheroImplementacion();
        public int mostrarMenu()
        {
            int opcionSeleccionada = default;
            try
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("0. Cerrar Menu");
                Console.WriteLine("1. Alta de objito");
                Console.WriteLine(string.Concat("-----------------", "\n"));
                opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

                return opcionSeleccionada;
            }
            catch (Exception ex)
            {
                fi.escribirFicheroLog("Error");
                throw;
            }
            finally
            {
                
            }
            
        }

    }
}
