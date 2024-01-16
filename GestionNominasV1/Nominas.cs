using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV1
{
    public class Nominas
    {
        //MIEMBROS PRIVADOS DE LA CLASE 
        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salarioHora;

        //PROPIEDADES
        /// <summary>
        /// Nombre del empleado
        /// </summary>
        public string NombreEmpleado
        {
            get
            {
                //Control de contenido
                if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre del trabajador no establecido");

                //Devolucion del valor 
                return _nombre;
            }
            set 
            {
                //Validaciion de los datos a establecer 
                if (string.IsNullOrEmpty(value)) throw new Exception("El nombre del trabajador no puede ser null o cadena vacia");

                //Establecimiento del valor al miembro privado 
                _nombre = value;
            }
        }


    }
}
