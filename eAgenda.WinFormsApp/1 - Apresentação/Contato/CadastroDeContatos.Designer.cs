namespace eAgenda.WinFormsApp._1___Apresentação.Contato
{
    partial class CadastroDeContatos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.labelNomeContato = new System.Windows.Forms.Label();
            this.labelEmailContato = new System.Windows.Forms.Label();
            this.labelTelefoneContato = new System.Windows.Forms.Label();
            this.labelEmpresaContato = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.txtEmailContato = new System.Windows.Forms.TextBox();
            this.txtTelefoneContato = new System.Windows.Forms.TextBox();
            this.txtEmpresaContato = new System.Windows.Forms.TextBox();
            this.txtCargoContato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(367, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(286, 265);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // labelNomeContato
            // 
            this.labelNomeContato.AutoSize = true;
            this.labelNomeContato.Location = new System.Drawing.Point(14, 23);
            this.labelNomeContato.Name = "labelNomeContato";
            this.labelNomeContato.Size = new System.Drawing.Size(103, 15);
            this.labelNomeContato.TabIndex = 8;
            this.labelNomeContato.Text = "Nome do Contato";
            // 
            // labelEmailContato
            // 
            this.labelEmailContato.AutoSize = true;
            this.labelEmailContato.Location = new System.Drawing.Point(14, 59);
            this.labelEmailContato.Name = "labelEmailContato";
            this.labelEmailContato.Size = new System.Drawing.Size(99, 15);
            this.labelEmailContato.TabIndex = 9;
            this.labelEmailContato.Text = "Email do Contato";
            // 
            // labelTelefoneContato
            // 
            this.labelTelefoneContato.AutoSize = true;
            this.labelTelefoneContato.Location = new System.Drawing.Point(14, 95);
            this.labelTelefoneContato.Name = "labelTelefoneContato";
            this.labelTelefoneContato.Size = new System.Drawing.Size(114, 15);
            this.labelTelefoneContato.TabIndex = 10;
            this.labelTelefoneContato.Text = "Telefone do Contato";
            // 
            // labelEmpresaContato
            // 
            this.labelEmpresaContato.AutoSize = true;
            this.labelEmpresaContato.Location = new System.Drawing.Point(14, 131);
            this.labelEmpresaContato.Name = "labelEmpresaContato";
            this.labelEmpresaContato.Size = new System.Drawing.Size(115, 15);
            this.labelEmpresaContato.TabIndex = 11;
            this.labelEmpresaContato.Text = "Empresa do Contato";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(14, 165);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(102, 15);
            this.labelCargo.TabIndex = 12;
            this.labelCargo.Text = "Cargo do Contato";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(134, 20);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(231, 23);
            this.txtNomeContato.TabIndex = 13;
            // 
            // txtEmailContato
            // 
            this.txtEmailContato.Location = new System.Drawing.Point(134, 56);
            this.txtEmailContato.Name = "txtEmailContato";
            this.txtEmailContato.Size = new System.Drawing.Size(231, 23);
            this.txtEmailContato.TabIndex = 14;
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.Location = new System.Drawing.Point(134, 92);
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(231, 23);
            this.txtTelefoneContato.TabIndex = 15;
            // 
            // txtEmpresaContato
            // 
            this.txtEmpresaContato.Location = new System.Drawing.Point(135, 128);
            this.txtEmpresaContato.Name = "txtEmpresaContato";
            this.txtEmpresaContato.Size = new System.Drawing.Size(231, 23);
            this.txtEmpresaContato.TabIndex = 16;
            // 
            // txtCargoContato
            // 
            this.txtCargoContato.Location = new System.Drawing.Point(135, 162);
            this.txtCargoContato.Name = "txtCargoContato";
            this.txtCargoContato.Size = new System.Drawing.Size(231, 23);
            this.txtCargoContato.TabIndex = 17;
            // 
            // CadastroDeContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 316);
            this.Controls.Add(this.txtCargoContato);
            this.Controls.Add(this.txtEmpresaContato);
            this.Controls.Add(this.txtTelefoneContato);
            this.Controls.Add(this.txtEmailContato);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelEmpresaContato);
            this.Controls.Add(this.labelTelefoneContato);
            this.Controls.Add(this.labelEmailContato);
            this.Controls.Add(this.labelNomeContato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroDeContatos";
            this.Text = "CadastroDeContatos";
  
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label labelNomeContato;
        private System.Windows.Forms.Label labelEmailContato;
        private System.Windows.Forms.Label labelTelefoneContato;
        private System.Windows.Forms.Label labelEmpresaContato;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.TextBox txtEmailContato;
        private System.Windows.Forms.TextBox txtTelefoneContato;
        private System.Windows.Forms.TextBox txtEmpresaContato;
        private System.Windows.Forms.TextBox txtCargoContato;
    }
}