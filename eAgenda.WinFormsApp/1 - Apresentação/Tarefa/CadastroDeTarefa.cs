using eAgenda.WinFormsApp.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinFormsApp._1___Apresentação.Tarefa
{
    public partial class CadastroDeTarefa : Form
    {
        private Tarefas tarefas;
        public CadastroDeTarefa()
        {
            InitializeComponent();
        }

        public Tarefas Tarefas
        {
            get
            {
                return tarefas;
            }

            set
            {
                tarefas = value;
                txtNumero.Text = tarefas.Numero.ToString();
                txtTitulo.Text = tarefas.Titulo;
                comboBoxPrioridade.Text = tarefas.PrioridadeTarefa.ToString();
            
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefas.Titulo = txtTitulo.Text;
        }


    }
}
