namespace eAgenda.WinFormsApp
{
    partial class AgendaEletronica
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
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.btnInserirContatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTarefas
            // 
            this.btnTarefas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTarefas.Location = new System.Drawing.Point(336, 235);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(145, 41);
            this.btnTarefas.TabIndex = 8;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompromissos.Location = new System.Drawing.Point(336, 163);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(145, 41);
            this.btnCompromissos.TabIndex = 7;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // btnInserirContatos
            // 
            this.btnInserirContatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserirContatos.Location = new System.Drawing.Point(336, 91);
            this.btnInserirContatos.Name = "btnInserirContatos";
            this.btnInserirContatos.Size = new System.Drawing.Size(145, 41);
            this.btnInserirContatos.TabIndex = 6;
            this.btnInserirContatos.Text = "Contatos";
            this.btnInserirContatos.UseVisualStyleBackColor = true;
            this.btnInserirContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // AgendaEletronica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.btnInserirContatos);
            this.Name = "AgendaEletronica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendaEletronica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Button btnInserirContatos;
    }
}