﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Dtos
{
    internal class AlumnoDto
    {
        //Atributos
            private long idAlumno;
            private string nombre = "aaa";
            private string apellido1 = "aaa";
            private string apellido2 = "aaa";
            private string dni = "aaa";
            private string direccion = "aaa";
            private long telefono = 999999999;
            private string email = "aaa";

        //Getter and Setter

        public long IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        //Constructores
        //public AlumnoDto() { }


    }
}