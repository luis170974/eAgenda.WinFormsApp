namespace eAgenda.WinFormsApp._1___Apresentação.Contato
{
    partial class ListagemContatos
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
            this.btnExcluirContatos = new System.Windows.Forms.Button();
            this.btnEditarContatos = new System.Windows.Forms.Button();
            this.btnInserirContatos = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExcluirContatos
            // 
            this.btnExcluirContatos.Location = new System.Drawing.Point(12, 167);
            this.btnExcluirContatos.Name = "btnExcluirContatos";
            this.btnExcluirContatos.Size = new System.Drawing.Size(145, 41);
            this.btnExcluirContatos.TabIndex = 18;
            this.btnExcluirContatos.Text = "Excluir";
            this.btnExcluirContatos.UseVisualStyleBackColor = true;
            this.btnExcluirContatos.Click += new System.EventHandler(this.btnExcluirContatos_Click);
            // 
            // btnEditarContatos
            // 
            this.btnEditarContatos.Location = new System.Drawing.Point(12, 110);
            this.btnEditarContatos.Name = "btnEditarContatos";
            this.btnEditarContatos.Size = new System.Drawing.Size(145, 41);
            this.btnEditarContatos.TabIndex = 17;
            this.btnEditarContatos.Text = "Editar";
            this.btnEditarContatos.UseVisualStyleBackColor = true;
            this.btnEditarContatos.Click += new System.EventHandler(this.btnEditarContatos_Click);
            // 
            // btnInserirContatos
            // 
            this.btnInserirContatos.Location = new System.Drawing.Point(12, 55);
            this.btnInserirContatos.Name = "btnInserirContatos";
            this.btnInserirContatos.Size = new System.Drawing.Size(145, 41);
            this.btnInserirContatos.TabIndex = 16;
            this.btnInserirContatos.Text = "Inserir";
            this.btnInserirContatos.UseVisualStyleBackColor = true;
            this.btnInserirContatos.Click += new System.EventHandler(this.btnInserirContatos_Click);
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(190, 55);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(565, 334);
            this.listContatos.TabIndex = 19;
            // 
            // ListagemContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.btnExcluirContatos);
            this.Controls.Add(this.btnEditarContatos);
            this.Controls.Add(this.btnInserirContatos);
            this.Name = "ListagemContatos";
            this.Text = "ListagemContatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirContatos;
        private System.Windows.Forms.Button btnEditarContatos;
        private System.Windows.Forms.Button btnInserirContatos;
        private System.Windows.Forms.ListBox listContatos;
    }
}