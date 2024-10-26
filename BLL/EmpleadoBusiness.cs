using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DAL;
using Entity;

namespace BLL
{
    public class EmpleadoBusiness
    {
        private EmpleadoDao empleadoDao = new EmpleadoDao();

        public void AgregarEmpleado(Empleado empleado)
        {
            using (var trx = new TransactionScope())
            try
            {
                if (empleado.ApellidoNombre.Length < 5)
                {
                    throw new Exception("El Apellido, Nombre incorecto!");
                }
                if (empleado.Dni.Length != 11)
                {
                    throw new Exception("El DNI debe ser de 11 numeros.");
                }
                if(empleado.SueldoBruto < 100000)
                {
                    throw new Exception("El monto no debe ser menor a $100.000");                    
                }
                empleadoDao.Agregar(empleado);
                trx.Complete();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void GuardarEmpleados(List<Empleado> empleados)
        {
            using (var trx = new TransactionScope())
            {
                foreach (Empleado empleado in empleados)
                {
                    AgregarEmpleado(empleado);
                }
                trx.Complete();

            }
        }

        public List<Empleado> Listar()
        {
            try
            {
                return empleadoDao.Listar();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
