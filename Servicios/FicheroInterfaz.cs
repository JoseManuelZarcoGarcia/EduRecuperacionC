using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface FicheroInterfaz
    {

        public void escribirFicheroLog(string mensaje);

        public void escribirFicheroListadoAlumnos(string ficheroListadoAlumnos);

        public void cargaInicial(string fichero);

    }
}
