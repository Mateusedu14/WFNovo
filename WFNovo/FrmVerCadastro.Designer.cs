namespace WFNovo
{
    partial class FrmVerCadastro
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
            lblEmail = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            lblEstado = new Label();
            lblBairro = new Label();
            lblEndereco = new Label();
            lblNome = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(70, 329);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(70, 300);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(48, 15);
            lblCelular.TabIndex = 13;
            lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(70, 271);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(59, 15);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(70, 242);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(46, 15);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(70, 213);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(44, 15);
            lblBairro.TabIndex = 10;
            lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(70, 184);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(62, 15);
            lblEndereco.TabIndex = 9;
            lblEndereco.Text = "Endereço:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(70, 155);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            // 
            // FrmVerCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 598);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblBairro);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Name = "FrmVerCadastro";
            Text = "FrmVerCadastro";
            Load += FrmVerCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblCelular;
        private Label lblTelefone;
        private Label lblEstado;
        private Label lblBairro;
        private Label lblEndereco;
        private Label lblNome;
    }
}