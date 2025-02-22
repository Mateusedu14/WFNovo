namespace WFNovo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (userName != string.Empty && password != string.Empty)

            {
                FrmCadastro frmCadastro = new FrmCadastro();
                frmCadastro.ShowDialog();

            }
           else
            {
                MessageBox.Show("Os campos não podem estar vazios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
