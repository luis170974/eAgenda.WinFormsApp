using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinFormsApp.Dominio
{
    [Serializable]
    public class Tarefas : EntidadeBase
    {
        private List<ItemTarefa> itens = new List<ItemTarefa>();

        public Tarefas()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefas(int n, string t) : this()
        {
            Numero = n;
            Titulo = t;
            DataConclusao = null;
        }

        public int Numero { get; set; }

        public string Titulo { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataConclusao { get; set; }

        public List<ItemTarefa> Itens { get  { return itens; } }

        public PrioridadeTarefa PrioridadeTarefa { get; set; }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Número: {Numero}, Título: {Titulo}, Percentual: {percentual}, Prioridade: {PrioridadeTarefa}, " +
                    $"Concluida: {DataConclusao.Value.ToShortDateString()}";
            }

            return $"Número: {Numero}, Título : {Titulo}, Percentual: {percentual}, Prioridade: {PrioridadeTarefa}";
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if(Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }

        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }


        public decimal CalcularPercentualConcluido()
        {
            if(itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);


        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("O titulo é obrigatório!");

            if(string.IsNullOrEmpty(Itens.ToString()))
                sb.AppendLine("Algum item é obrigatório");

            if (sb.Length == 0)
                sb.AppendLine("REGISTRO_VALIDO");

            return sb.ToString();
        }
    }


}

