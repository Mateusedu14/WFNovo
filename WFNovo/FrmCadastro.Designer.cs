namespace WFNovo
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTop = new Label();
            lblNome = new Label();
            lblEndereco = new Label();
            lblBairro = new Label();
            lblEstado = new Label();
            lblTelefone = new Label();
            lblCelular = new Label();
            lblEmail = new Label();
            txtBairro = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCelular = new TextBox();
            txtTelefone = new TextBox();
            cbxEstado = new ComboBox();
            btnGravar = new Button();
            btnNovo = new Button();
            btnVer = new Button();
            SuspendLayout();
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop.Location = new Point(72, 9);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(264, 15);
            lblTop.TabIndex = 0;
            lblTop.Text = "Preencha os campos e clique em Gravar Dados";
            lblTop.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(64, 54);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(64, 83);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(62, 15);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(64, 112);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(44, 15);
            lblBairro.TabIndex = 3;
            lblBairro.Text = "Bairro:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(64, 141);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(46, 15);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(64, 170);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(59, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(64, 199);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(48, 15);
            lblCelular.TabIndex = 6;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(64, 228);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(125, 109);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(150, 23);
            txtBairro.TabIndex = 8;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(126, 80);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(150, 23);
            txtEndereco.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 23);
            txtNome.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(126, 196);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(150, 23);
            txtCelular.TabIndex = 12;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(126, 167);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 23);
            txtTelefone.TabIndex = 13;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "MG", "SP ", "RJ" });
            cbxEstado.Location = new Point(126, 138);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(88, 23);
            cbxEstado.TabIndex = 14;
            cbxEstado.SelectedIndexChanged += cbxEstado_SelectedIndexChanged;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(47, 269);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(101, 38);
            btnGravar.TabIndex = 15;
            btnGravar.Text = "Gravar Cadastro";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += button1_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(154, 269);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(101, 38);
            btnNovo.TabIndex = 16;
            btnNovo.Text = "Novo Cadastro";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += button1_Click_1;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(261, 269);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(101, 38);
            btnVer.TabIndex = 17;
            btnVer.Text = "Ver Contatos";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 391);
            Controls.Add(btnVer);
            Controls.Add(btnNovo);
            Controls.Add(btnGravar);
            Controls.Add(cbxEstado);
            Controls.Add(txtTelefone);
            Controls.Add(txtCelular);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtEndereco);
            Controls.Add(txtBairro);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Controls.Add(lblTop);
            Name = "FrmCadastro";
            Text = "Cadastro de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTop;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblBairro;
        private Label lblEstado;
        private Label lblTelefone;
        private Label lblCelular;
        private Label lblEmail;
        private TextBox txtBairro;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private TextBox txtTelefone;
        private ComboBox cbxEstado;
        private Button btnGravar;
        private Button btnNovo;
        private Button btnVer;
    }
}