using eAgenda.WinFormsApp._3___Infra.Contato;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinFormsApp._3___Infra.SerializadorEmJson
{
    public class SerializadorContatosEmJsonDotnet : ISerializadorContatos
    {

            private const string arquivoContatos = @"C:\temp\Contatos.json";

            public List<Contatos> CarregarContatosDoArquivo()
            {
                if (File.Exists(arquivoContatos) == false)
                    return new List<Contatos>();

                string contatosJson = File.ReadAllText(arquivoContatos);

                JsonSerializerSettings settings = new JsonSerializerSettings();

                settings.Formatting = Formatting.Indented;

                return JsonConvert.DeserializeObject<List<Contatos>>(contatosJson, settings);
            }

            public void GravarContatosEmArquivo(List<Contatos> contatos)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();

                settings.Formatting = Formatting.Indented;

                string contatosJson = JsonConvert.SerializeObject(contatos, settings);

                File.WriteAllText(arquivoContatos, contatosJson);
            }
        }
    }
