using System.Collections.Generic;

namespace eAgenda.WinFormsApp.Dominio
{
    public interface IRepositorioTarefa
    {
        void Inserir(Tarefas novaTarefa);
        void Editar(Tarefas tarefas);

        void Excluir(Tarefas tarefas);

        void AdicionarItens(Tarefas tarefaSelecionada, List<ItemTarefa> itens);

        void AtualizarItens(Tarefas tarefaSelecionada, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes);

        List<Tarefas> SelecionarTodos();

        List<Tarefas> SelecionarTarefasConcluidas();

        List<Tarefas> SelecionarTarefasPendentes();

    }
}
