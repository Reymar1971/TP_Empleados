using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpleadoDao
    {
        public void Agregar(Empleado empleado)
        {
            SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());

            try
            {
                using (conn)
                {
                    conn.Open();
                    string query = "INSERT INTO EMPLEADOS(APELLIDO_NOMBRE,DNI,SUELDO_BRUTO) VALUES(@ApellidoNombre,@Dni,@SueldoBruto)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApellidoNombre", empleado.ApellidoNombre);
                        cmd.Parameters.AddWithValue("@Dni", empleado.Dni);
                        cmd.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Empleado> Listar()
        {
            try
            {
                List<Empleado> empleados = new List<Empleado>();
                SqlConnection conn = new SqlConnection(BDConfiguracion.getConectionBD());
                using (conn)
                {
                    conn.Open();
                    string query = "SELECT ID_EMPLEADO,APELLIDO_NOMBRE,DNI,SUELDO_BRUTO FROM EMPLEADOS";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleado empleado = new Empleado();
                                empleado.IdEmpleado = reader.GetInt32(0);
                                empleado.ApellidoNombre = reader.GetString(1);
                                empleado.Dni = reader.GetString(2);
                                empleado.SueldoBruto = reader.GetDecimal(3);
                                empleado.CalcularSueldoNeto();
                                empleados.Add(empleado);
                            }
                        }
                    }
                }
                return empleados;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }

    
}
