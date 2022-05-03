
using eAgenda.WinFormsApp._3___Infra.Tarefa;
using eAgenda.WinFormsApp.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace eAgenda.WinFormsApp._3___Infra.SerializadorEmJson
{
        public class SerializadorTarefasEmJsonDotnet : ISerializadorTarefas
        {
            private const string arquivoTarefas = @"C:\temp\tarefas2.json";

            public List<Tarefas> CarregarTarefasDoArquivo()
            {
                if (File.Exists(arquivoTarefas) == false)
                    return new List<Tarefas>();

                string tarefasJson = File.ReadAllText(arquivoTarefas);

                JsonSerializerSettings settings = new JsonSerializerSettings();

                settings.Formatting = Formatting.Indented;

                return JsonConvert.DeserializeObject<List<Tarefas>>(tarefasJson, settings);
            }

            public void GravarTarefasEmArquivo(List<Tarefas> tarefas)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();

                settings.Formatting = Formatting.Indented;

                string tarefasJson = JsonConvert.SerializeObject(tarefas, settings);

                File.WriteAllText(arquivoTarefas, tarefasJson);
            }
        }
    }

