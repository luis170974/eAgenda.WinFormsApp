namespace eAgenda.WinFormsApp
{
    partial class CadastroCompromisso
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
            this.btnVisualizarCompromissos = new System.Windows.Forms.Button();
            this.btnExcluirCompromissos = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnInserirCompromissos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVisualizarCompromissos
            // 
            this.btnVisualizarCompromissos.Location = new System.Drawing.Point(12, 265);
            this.btnVisualizarCompromissos.Name = "btnVisualizarCompromissos";
            this.btnVisualizarCompromissos.Size = new System.Drawing.Size(145, 41);
            this.btnVisualizarCompromissos.TabIndex = 10;
            this.btnVisualizarCompromissos.Text = "Visualizar";
            this.btnVisualizarCompromissos.UseVisualStyleBackColor = true;
            this.btnVisualizarCompromissos.Click += new System.EventHandler(this.btnVisualizarCompromissos_Click);
            // 
            // btnExcluirCompromissos
            // 
            this.btnExcluirCompromissos.Location = new System.Drawing.Point(12, 196);
            this.btnExcluirCompromissos.Name = "btnExcluirCompromissos";
            this.btnExcluirCompromissos.Size = new System.Drawing.Size(145, 41);
            this.btnExcluirCompromissos.TabIndex = 9;
            this.btnExcluirCompromissos.Text = "Excluir";
            this.btnExcluirCompromissos.UseVisualStyleBackColor = true;
            this.btnExcluirCompromissos.Click += new System.EventHandler(this.btnExcluirContatos_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Location = new System.Drawing.Point(12, 127);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(145, 41);
            this.btnEditarCompromisso.TabIndex = 8;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnInserirCompromissos
            // 
            this.btnInserirCompromissos.Location = new System.Drawing.Point(12, 66);
            this.btnInserirCompromissos.Name = "btnInserirCompromissos";
            this.btnInserirCompromissos.Size = new System.Drawing.Size(145, 41);
            this.btnInserirCompromissos.TabIndex = 7;
            this.btnInserirCompromissos.Text = "Inserir";
            this.btnInserirCompromissos.UseVisualStyleBackColor = true;
            this.btnInserirCompromissos.Click += new System.EventHandler(this.btnInserirCompromissos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(240, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(538, 349);
            this.listBox1.TabIndex = 11;
            // 
            // CadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVisualizarCompromissos);
            this.Controls.Add(this.btnExcluirCompromissos);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.btnInserirCompromissos);
            this.MaximizeBox = false;
            this.Name = "CadastroCompromisso";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCompromisso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarCompromissos;
        private System.Windows.Forms.Button btnExcluirCompromissos;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.Button btnInserirCompromissos;
        private System.Windows.Forms.ListBox listBox1;
    }
}