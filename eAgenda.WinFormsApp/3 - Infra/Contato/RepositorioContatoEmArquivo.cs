using eAgenda.WinFormsApp._2___Dominio.Contato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinFormsApp._3___Infra.Contato
{
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {

        private readonly ISerializadorContatos serializador;
        List<Contatos> contato;
        private int contador = 0;

        public RepositorioContatoEmArquivo(ISerializadorContatos serializador)
        {
            this.serializador = serializador;

            contato = serializador.CarregarContatosDoArquivo();

            if (contato.Count > 0)
                contador = contato.Max(x => x.Numero);
        }

        public void Inserir(Contatos novoContato)
        {
            novoContato.Numero = ++contador;
            contato.Add(novoContato);

            serializador.GravarContatosEmArquivo(contato);
        }

        public void Editar(Contatos editarContato)
        {
            foreach (var item in contato)
            {
                if (item.Numero == editarContato.Numero)
                {
                    item.NomeContato = editarContato.NomeContato;
                    item.EmailContato = editarContato.EmailContato;
                    item.Telefone = editarContato.Telefone;
                    item.Empresa = editarContato.Empresa;
                    item.Cargo = editarContato.Cargo;

                    break;
                }
            }

            serializador.GravarContatosEmArquivo(contato);
        }

        public void Excluir(Contatos contatos)
        {
            contato.Remove(contatos);

            serializador.GravarContatosEmArquivo(contato);
        }

        public List<Contatos> SelecionarTodos()
        {
            return contato;
        }

    }
}
