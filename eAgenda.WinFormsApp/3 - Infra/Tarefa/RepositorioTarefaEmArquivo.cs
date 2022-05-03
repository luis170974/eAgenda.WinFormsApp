using eAgenda.WinFormsApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinFormsApp._3___Infra.Tarefa
{
    public class RepositorioTarefasEmArquivo : IRepositorioTarefa
    {
        private readonly ISerializadorTarefas serializador;
        List<Tarefas> tarefas;
        private int contador = 0;

        public RepositorioTarefasEmArquivo(ISerializadorTarefas serializador)
        {
            this.serializador = serializador;

            tarefas = serializador.CarregarTarefasDoArquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Numero);
        }

        public void Inserir(Tarefas novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Editar(Tarefas tarefa)
        {
            foreach (var item in tarefas)
            {
                if(item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    break;
                }
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Excluir(Tarefas tarefa)
        {
            tarefas.Remove(tarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AdicionarItens(Tarefas tarefaSelecionada, List<ItemTarefa> itens)
        {
            foreach(var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AtualizarItens(Tarefas tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
                tarefaSelecionada.ConcluirItem(item);

            foreach (var item in itensPendentes)
                tarefaSelecionada.MarcarPendente(item);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public List<Tarefas> SelecionarTodos()
        {
            return tarefas;
        }

        public List<Tarefas> SelecionarTarefasConcluidas()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() == 100).ToList();
        }

        public List<Tarefas> SelecionarTarefasPendentes()
        {
            return tarefas.Where(x => x.CalcularPercentualConcluido() < 100).ToList();
        }
    
    }
}
