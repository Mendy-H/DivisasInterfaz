namespace DivisasInterfaz
{
    public partial class Form1 : Form
    {
        private Divisas conversor = new Divisas();

        private bool LeerPesos()
        {
            if (float.TryParse(txtPesos.Text, out float valor) && valor >= 0)
            {
                conversor.Pesos = valor;
                return true;
            }
            MessageBox.Show("Ingresa una cantidad válida.");
            txtPesos.Focus();
            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LeerPesos())
                txtResultado.Text = conversor.Euro().ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LeerPesos())
                txtResultado.Text = conversor.Dolar().ToString("F2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LeerPesos())
                txtResultado.Text = conversor.Libra().ToString("F2");
        }

        private void btnYen_Click(object sender, EventArgs e)
        {
            if (LeerPesos())
                txtResultado.Text = conversor.Yen().ToString("F2");
        }
    }
}
