using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Data.Common;


namespace Registro.Formulario
{
    public partial class Empadronadoscs : Form
    {
        public Empadronadoscs()
        {
            InitializeComponent();
        }

        private void btnRegresarM_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos el Formulario Actual
            Form Registros = new Form();
        }

        private void Empadronadoscs_Load(object sender, EventArgs e)
        {
            Conexion conexionb = new Conexion();
            conexionb.Abrir();

            string cadena = "SELECT * FROM Registro";
            SqlCommand comando = new SqlCommand(cadena, conexionb.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            ver.DataSource = tabla;
        }
    }
}
