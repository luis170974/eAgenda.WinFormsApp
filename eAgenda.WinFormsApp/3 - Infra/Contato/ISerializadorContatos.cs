using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinFormsApp._3___Infra.Contato
{
    public interface ISerializadorContatos
    {
        List<Contatos> CarregarContatosDoArquivo();

        void GravarContatosEmArquivo(List<Contatos> contatos);
    }
}
