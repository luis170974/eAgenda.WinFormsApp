using eAgenda.WinFormsApp.Dominio;
using System.Collections.Generic;

namespace eAgenda.WinFormsApp._3___Infra.Tarefa
{
    public interface ISerializadorTarefas
    {
        List<Tarefas> CarregarTarefasDoArquivo();

        void GravarTarefasEmArquivo(List<Tarefas> tarefas);
    }
}