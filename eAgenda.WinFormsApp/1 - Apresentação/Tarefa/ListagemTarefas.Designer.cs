namespace eAgenda.WinFormsApp._1___Apresentação.Tarefa
{
    partial class ListagemTarefas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTarefasPendentes = new System.Windows.Forms.ListBox();
            this.btnCadastrarItens = new System.Windows.Forms.Button();
            this.btnAtualizarItensTarefas = new System.Windows.Forms.Button();
            this.btnExcluirTarefas = new System.Windows.Forms.Button();
            this.btnEditarTarefas = new System.Windows.Forms.Button();
            this.btnInserirTarefas = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(215, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 288);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefasConcluidas);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Concluidas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefasConcluidas
            // 
            this.listTarefasConcluidas.FormattingEnabled = true;
            this.listTarefasConcluidas.ItemHeight = 15;
            this.listTarefasConcluidas.Location = new System.Drawing.Point(6, 14);
            this.listTarefasConcluidas.Name = "listTarefasConcluidas";
            this.listTarefasConcluidas.Size = new System.Drawing.Size(547, 244);
            this.listTarefasConcluidas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTarefasPendentes);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Pendentes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTarefasPendentes
            // 
            this.listTarefasPendentes.FormattingEnabled = true;
            this.listTarefasPendentes.ItemHeight = 15;
            this.listTarefasPendentes.Location = new System.Drawing.Point(6, 14);
            this.listTarefasPendentes.Name = "listTarefasPendentes";
            this.listTarefasPendentes.Size = new System.Drawing.Size(547, 229);
            this.listTarefasPendentes.TabIndex = 1;
            // 
            // btnCadastrarItens
            // 
            this.btnCadastrarItens.Location = new System.Drawing.Point(18, 267);
            this.btnCadastrarItens.Name = "btnCadastrarItens";
            this.btnCadastrarItens.Size = new System.Drawing.Size(145, 41);
            this.btnCadastrarItens.TabIndex = 17;
            this.btnCadastrarItens.Text = "Cadastrar Itens";
            this.btnCadastrarItens.UseVisualStyleBackColor = true;
            this.btnCadastrarItens.Click += new System.EventHandler(this.btnCadastrarItens_Click);
            // 
            // btnAtualizarItensTarefas
            // 
            this.btnAtualizarItensTarefas.Location = new System.Drawing.Point(18, 328);
            this.btnAtualizarItensTarefas.Name = "btnAtualizarItensTarefas";
            this.btnAtualizarItensTarefas.Size = new System.Drawing.Size(145, 41);
            this.btnAtualizarItensTarefas.TabIndex = 16;
            this.btnAtualizarItensTarefas.Text = "Atualizar Itens";
            this.btnAtualizarItensTarefas.UseVisualStyleBackColor = true;
            this.btnAtualizarItensTarefas.Click += new System.EventHandler(this.btnAtualizarItensTarefas_Click);
            // 
            // btnExcluirTarefas
            // 
            this.btnExcluirTarefas.Location = new System.Drawing.Point(18, 207);
            this.btnExcluirTarefas.Name = "btnExcluirTarefas";
            this.btnExcluirTarefas.Size = new System.Drawing.Size(145, 41);
            this.btnExcluirTarefas.TabIndex = 15;
            this.btnExcluirTarefas.Text = "Excluir";
            this.btnExcluirTarefas.UseVisualStyleBackColor = true;
            this.btnExcluirTarefas.Click += new System.EventHandler(this.btnExcluirTarefas_Click);
            // 
            // btnEditarTarefas
            // 
            this.btnEditarTarefas.Location = new System.Drawing.Point(18, 146);
            this.btnEditarTarefas.Name = "btnEditarTarefas";
            this.btnEditarTarefas.Size = new System.Drawing.Size(145, 41);
            this.btnEditarTarefas.TabIndex = 14;
            this.btnEditarTarefas.Text = "Editar";
            this.btnEditarTarefas.UseVisualStyleBackColor = true;
            this.btnEditarTarefas.Click += new System.EventHandler(this.btnEditarTarefas_Click);
            // 
            // btnInserirTarefas
            // 
            this.btnInserirTarefas.Location = new System.Drawing.Point(18, 86);
            this.btnInserirTarefas.Name = "btnInserirTarefas";
            this.btnInserirTarefas.Size = new System.Drawing.Size(145, 41);
            this.btnInserirTarefas.TabIndex = 13;
            this.btnInserirTarefas.Text = "Inserir";
            this.btnInserirTarefas.UseVisualStyleBackColor = true;
            this.btnInserirTarefas.Click += new System.EventHandler(this.btnInserirTarefas_Click);
            // 
            // ListagemTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCadastrarItens);
            this.Controls.Add(this.btnAtualizarItensTarefas);
            this.Controls.Add(this.btnExcluirTarefas);
            this.Controls.Add(this.btnEditarTarefas);
            this.Controls.Add(this.btnInserirTarefas);
            this.Name = "ListagemTarefas";
            this.Text = "ListagemTarefas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listTarefasConcluidas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listTarefasPendentes;
        private System.Windows.Forms.Button btnCadastrarItens;
        private System.Windows.Forms.Button btnAtualizarItensTarefas;
        private System.Windows.Forms.Button btnExcluirTarefas;
        private System.Windows.Forms.Button btnEditarTarefas;
        private System.Windows.Forms.Button btnInserirTarefas;
    }
}