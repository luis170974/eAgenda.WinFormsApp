using eAgenda.WinFormsApp._3___Infra.SerializadorEmJson;
using eAgenda.WinFormsApp._3___Infra.Tarefa;
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
    public partial class ListagemTarefas : Form
    {
        private IRepositorioTarefa repositorioTarefa;
        
        public ListagemTarefas()
        {

            SerializadorTarefasEmJsonDotnet serializador = new SerializadorTarefasEmJsonDotnet();

            repositorioTarefa = new RepositorioTarefasEmArquivo(serializador);
            InitializeComponent();
            CarregarTarefas();
            
        }

        private void CarregarTarefas()
        {
            List<Tarefas> tarefasConcluidas = repositorioTarefa.SelecionarTarefasConcluidas();

            listTarefasConcluidas.Items.Clear();

            foreach (Tarefas t in tarefasConcluidas)
            {

                listTarefasConcluidas.Items.Add(t);

            }


            List<Tarefas> tarefasPendentes = repositorioTarefa.SelecionarTarefasPendentes();

            listTarefasPendentes.Items.Clear();

            foreach (Tarefas t in tarefasPendentes)
            {

                listTarefasPendentes.Items.Add(t);

            }

            // testando ordenação
            //var query = tarefasConcluidas.GroupBy(tarefasConcluidas => tarefasConcluidas.PrioridadeTarefa);

            
        }

        private void btnInserirTarefas_Click(object sender, EventArgs e)
        {
            CadastroDeTarefa tela = new CadastroDeTarefa();

            tela.Tarefas = new Tarefas();

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefas);
                CarregarTarefas();
            }


        }

        private void btnEditarTarefas_Click(object sender, EventArgs e)
        {
            Tarefas tarefaSelecionada = (Tarefas)listTarefasPendentes.SelectedItem;

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroDeTarefa tela = new CadastroDeTarefa();

            tela.Tarefas = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefas);
                CarregarTarefas();
            }

        }

        private void btnExcluirTarefas_Click(object sender, EventArgs e)
        {
            Tarefas tarefaSelecionada = (Tarefas)listTarefasPendentes.SelectedItem;

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir a tarefa?", "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        
            if(resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }


        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            Tarefas tarefaSelecionada = (Tarefas)listTarefasPendentes.SelectedItem;

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);

            if(tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarregarTarefas();
            }

            
        }

        private void btnAtualizarItensTarefas_Click(object sender, EventArgs e)
        {
            Tarefas tarefaSelecionada = (Tarefas)listTarefasPendentes.SelectedItem;

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            AtualizacaoItensTarefas tela = new AtualizacaoItensTarefas(tarefaSelecionada);

            if(tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);

                CarregarTarefas();
            }
        }
    }
}
