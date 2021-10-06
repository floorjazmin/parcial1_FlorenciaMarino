using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1
{
    class Alumnos
    {
        private String nombre;
        private String apellido;
        private int DNI;
        private int legajo;
        private String carrera;
        private int añoDeInscripcion;
        private int añoNacimiento;
        private String mailContacto;


        public Alumnos(String pNombre, String pApellido, int pDNI, int pLegajo, String pCarrera, int pAñoDeInscripcion, int pAñoNacimiento, string pMailContacto)
        {

            this.nombre = pNombre;
            this.apellido = pApellido;
            this.DNI = pDNI;
            this.legajo = pLegajo;
            this.carrera = pCarrera;
            this.añoDeInscripcion = pAñoDeInscripcion;
            this.añoNacimiento = pAñoNacimiento;
            this.mailContacto = pMailContacto;
        }   
    }
}
