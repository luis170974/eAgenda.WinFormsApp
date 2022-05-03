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
    public partial class AtualizacaoItensTarefas : Form
    {

        private readonly Tarefas tarefas;
        public AtualizacaoItensTarefas(Tarefas tarefas)
        {
            InitializeComponent();

            this.tarefas = tarefas;

            labelTituloTarefa.Text = tarefas.Titulo;

            CarregarItensTarefa(tarefas);
        }

        private void CarregarItensTarefa(Tarefas tarefas)
        {
            int i = 0;
            foreach (var item in tarefas.Itens)
            {
                listItensTarefa.Items.Add(item);

                if(item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<ItemTarefa>()
                    .ToList();
            }
        }

        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }
    }
}
