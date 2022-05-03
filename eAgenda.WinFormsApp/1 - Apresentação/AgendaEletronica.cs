using eAgenda.WinFormsApp._1___Apresentação.Contato;
using eAgenda.WinFormsApp._1___Apresentação.Tarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinFormsApp
{
    public partial class AgendaEletronica : Form
    {
        public AgendaEletronica()
        {
            InitializeComponent();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos telaCadastroContato = new ListagemContatos();

            telaCadastroContato.ShowDialog();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            CadastroCompromisso cadastroCompromisso = new CadastroCompromisso();

            cadastroCompromisso.ShowDialog();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefas listagemTarefas = new ListagemTarefas();

            listagemTarefas.ShowDialog();
        }

        

        
    }
}
