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
    public partial class CadastroItensTarefa : Form
    {

        private readonly Tarefas tarefas;


        public CadastroItensTarefa(Tarefas tarefas)
        {
            InitializeComponent();
            this.tarefas = tarefas;

            labelTituloTarefa.Text = tarefas.Titulo;

            foreach(ItemTarefa item in tarefas.Itens)
                listItensTarefa.Items.Add(item);
        }

        public List<ItemTarefa> ItensAdicionados
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .ToList();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados
                                    .Select(x => x.Titulo)
                                    .ToList();

            if(titulos.Count == 0 || titulos.Contains(txtTituloItem.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa();

                itemTarefa.Titulo = txtTituloItem.Text;

                listItensTarefa.Items.Add(itemTarefa);
            }
        }
    }
}
