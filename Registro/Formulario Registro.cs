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

namespace Registro.Formulario
{
    public partial class Formulario_Registro : Form
    {
        public Formulario_Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion Conexionb = new Conexion();
            Conexionb.Abrir();

            string Primernombre = PrimerNombre.Text;
            string Segundonombre = SegundoNombre.Text;
            string Primerapellido = PrimerApellido.Text;
            string Segundoapellido = SegundoApellido.Text;
            string Cui = CUI.Text;
            string FechadeNacimiento = FechaNacimiento.Text;
            string pais = Pais.Text;
            string departamento = Departamento.Text;
            string municipio = Municipio.Text;
            string Correo = CorreoElectronico.Text;

            string cadena = "insert into Registro(PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Cui,FechadeNacimiento,Pais,Departamento,Municipio,Correo) values('" + PrimerNombre.Text + "','" + SegundoNombre.Text + "','" + PrimerApellido.Text + "','" + SegundoApellido.Text + "','" + CUI.Text + "','" + FechaNacimiento.Text + "','" + Pais.Text + "','" + Departamento.Text + "','" + Municipio.Text + "','" + CorreoElectronico.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, Conexionb.conectarbd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha Empadronado Correctamento");

            PrimerNombre.Text = "";
            SegundoNombre.Text = "";
            PrimerApellido.Text = "";
            SegundoApellido.Text = "";
            CUI.Text = "";
            FechaNacimiento.Text = "";
            Pais.Text = "";
            Departamento.Text = "";
            Municipio.Text = "";
            CorreoElectronico.Text = "";





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos el Formulario Actual
            Form Registros = new Form();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Formulario_Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
