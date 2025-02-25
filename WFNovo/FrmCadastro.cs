using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNovo
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();


            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Estado = cbxEstado.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtEmail.Text;

            FrmVerCadastro frmCadastro = new FrmVerCadastro(cliente);
            frmCadastro.ShowDialog();


        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
