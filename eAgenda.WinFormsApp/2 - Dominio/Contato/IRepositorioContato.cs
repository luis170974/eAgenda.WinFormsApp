using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinFormsApp._2___Dominio.Contato
{
    public interface IRepositorioContato
    {
        void Inserir(Contatos novoContato);
        void Editar(Contatos contatos);
        void Excluir(Contatos Contato);

        List<Contatos> SelecionarTodos();
    }
}
