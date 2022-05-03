using eAgenda.WinFormsApp._2___Dominio.Contato;
using eAgenda.WinFormsApp._3___Infra.Contato;
using eAgenda.WinFormsApp._3___Infra.SerializadorEmJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinFormsApp._1___Apresentação.Contato
{
    public partial class ListagemContatos : Form
    {

        private IRepositorioContato repositorioContato;

        public ListagemContatos()
        {

            SerializadorContatosEmJsonDotnet serializador = new SerializadorContatosEmJsonDotnet();

            repositorioContato = new RepositorioContatoEmArquivo(serializador);
            InitializeComponent();
            CarregarContatos();

        }

        private void CarregarContatos()
        {

           List<Contatos> contatos = repositorioContato.SelecionarTodos();

            foreach(var item in contatos)
                Console.WriteLine(contatos);


        }

        private void btnInserirContatos_Click(object sender, EventArgs e)
        {
            CadastroDeContatos telaCadastroContatos = new CadastroDeContatos();

            telaCadastroContatos.Contatos = new Contatos(String string string string string string);

            DialogResult resultado = telaCadastroContatos.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(telaCadastroContatos.Contatos);
                CarregarContatos();
            }
        }

            private void btnEditarContatos_Click(object sender, EventArgs e)
            {
                Contatos contatoSelecionado = (Contatos)listContatos.SelectedItem;

                if (contatoSelecionado == null)
                {
                    MessageBox.Show("Selecione uma contato primeiro", "Edição de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                CadastroDeContatos telaCadastroContato = new CadastroDeContatos();

                telaCadastroContato.Contatos = contatoSelecionado;

                DialogResult resultado = telaCadastroContato.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    repositorioContato.Editar(telaCadastroContato.Contatos);
                    CarregarContatos();
                }
            }

            private void btnExcluirContatos_Click(object sender, EventArgs e)
            {
                Contatos contatoSelecionado = (Contatos)listContatos.SelectedItem;

                if (contatoSelecionado == null)
                {
                    MessageBox.Show("Selecione uma contato primeiro", "Edição de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Deseja excluir o contato?", "Exclusão de Contato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    repositorioContato.Excluir(contatoSelecionado);
                    CarregarContatos();
                }

                // testando ordenação
                //var query = tarefasConcluidas.GroupBy(tarefasConcluidas => tarefasConcluidas.PrioridadeTarefa);


            }
        }
    }


