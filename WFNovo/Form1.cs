namespace WFNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {

            if (lblNome.Text.Contains("Bot�o Clicado"))
            {
                lblNome.Text = "Clicou De novo";
            }
            else
                lblNome.Text = "Bot�o Clicado";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
