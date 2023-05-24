using Registro.Formulario;

namespace Registro
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Formulario_Registro();
            this.Hide();  // Ocultamos el Formulario Actual
            form1.ShowDialog(); // Muestra el Formulario #2 Registros
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form1 = new Empadronadoscs();
            this.Hide();  // Ocultamos el Formulario Actual
            form1.ShowDialog(); // Muestra el Formulario #2 Registros
            this.Show();
        }
    }
}