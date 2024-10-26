using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {
        private int idEmpleado;
        private string apellidoNombre;
        private string dni;
        private decimal sueldoBruto;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string ApellidoNombre { get => apellidoNombre; set => apellidoNombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public decimal SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }

        public decimal SueldoNeto
        {
            get
            {
                return CalcularSueldoNeto();
            }
        }

        public decimal CalcularSueldoNeto()
        {
            // Calcula el 17% del sueldo bruto
            decimal descuento = SueldoBruto * 0.17m;
            // Resta el descuento del sueldo bruto para obtener el sueldo neto
            decimal sueldoNeto = SueldoBruto - descuento;
            return sueldoNeto;
        }
    }
}
