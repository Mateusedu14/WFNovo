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
    public partial class FrmVerCadastro : Form
    {
        private Cliente clieenteVindo;

        public FrmVerCadastro(Cliente cli)
        {
            InitializeComponent();
            this.clieenteVindo = cli;


        }

        private void FrmVerCadastro_Load(object sender, EventArgs e)
        {

            lblNome.Text += "" + clieenteVindo.Nome;
            lblEndereco.Text += "" + clieenteVindo.Endereco;
            lblBairro.Text += "" + clieenteVindo.Bairro;
            lblEstado.Text += "" + clieenteVindo.Estado;
            lblTelefone.Text += "" + clieenteVindo.Telefone;
            lblCelular.Text += "" + clieenteVindo.Celular;
            lblEmail.Text += "" + clieenteVindo.Email;


        }
    }
}
