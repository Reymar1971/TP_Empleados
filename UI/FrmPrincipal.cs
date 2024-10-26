using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using Microsoft.Identity.Client;

namespace UI
{
    public partial class FrmPrincipal : Form
    {
        private List<Empleado> borradorEmpleados = new List<Empleado>();
        private EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnPruebaBD_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BDConexion"].ConnectionString);

            using (connection)
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void Listar()
        {
            try
            {
                DgvListado.DataSource = empleadoBusiness.Listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar()
        {
            TxtApellidoNombre.Clear();
            TxtDni.Clear();
            TxtSueldoBruto.Text = "0";
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Width = 120;
            DgvListado.Columns[1].HeaderText = "Apellido, Nombre";
            DgvListado.Columns[2].Width = 100;
            DgvListado.Columns[2].HeaderText = "Nro.Documento";
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[3].HeaderText = "Sueldo Bruto";
            DgvListado.Columns[4].Width = 100;
            DgvListado.Columns[4].HeaderText = "Sueldo Neto";

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ApellidoNombre = TxtApellidoNombre.Text;
            empleado.Dni = TxtDni.Text;
            empleado.SueldoBruto = Convert.ToDecimal(TxtSueldoBruto.Text);
            
            borradorEmpleados.Add(empleado);
            this.Limpiar();
            MessageBox.Show("Se agrego un Empleado a la lista");
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (borradorEmpleados.Count==0)
                {
                    throw new Exception("La lista de empleados está vacía.");
                }
                           
                    empleadoBusiness.GuardarEmpleados(borradorEmpleados);
                    MessageBox.Show("Se guardaron todos los Empleados correctamente!");
                    borradorEmpleados = new List<Empleado>();
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            borradorEmpleados = new List<Empleado>();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.Listar();
            this.Formato();
        }
    }
}
