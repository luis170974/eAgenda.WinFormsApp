using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WinFormsApp
{
    [Serializable]
    public class Contatos
    {

        public int Numero { get; set; }
        public string NomeContato { get; set; }

        public DateTime dataCriacaoContato { get; set; }
        public string EmailContato { get; set; }

        public string Telefone { get; set; }

        public string Empresa { get; set; }

        public string Cargo { get; set; }


        public Contatos(string nome, string email, string telefone, string empresa, string cargo)
        {
            NomeContato = nome;
            EmailContato = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public override string ToString()
        {
            
            return $"Nome contato: {NomeContato}, Email contato : {EmailContato}, Telefone: {Telefone}, Empresa: {Empresa}, Cargo: {Cargo}";
        }

        public string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(NomeContato))
                sb.AppendLine("O nome do contato é obrigatório!");

            if (EmailEstaValido(ValidarEmail) == false)
                sb.AppendLine("Insira um endereço de email válido!");

            if (TelefoneEstaValido() == false)
                sb.AppendLine("O número precisa seguir um dos seguintes formatos: 99999-0000 ou 99999 0000 ou 999990000");

            if (string.IsNullOrEmpty(Empresa))
                sb.AppendLine("O nome da empresa é obrigatório!");

            if (string.IsNullOrEmpty(Cargo))
                sb.AppendLine("O nome do cargo é obrigatório");

            if (sb.Length == 0)
                sb.AppendLine("REGISTRO_VALIDO");

            return sb.ToString();
        }

        private bool EmailEstaValido(Func<bool> validacao)
        {
            bool emailEstaValido = validacao();

            return emailEstaValido;
        }
        private bool ValidarEmail()
        {
            bool emailEstaValido = System.Net.Mail.MailAddress.TryCreate(EmailContato, out _);

            return emailEstaValido;
        }

        private bool TelefoneEstaValido()
        {
            bool telefoneEstaValido = false;

            string telefoneProcessado = Telefone.Replace("-", string.Empty)
                                                    .Replace(" ", string.Empty);

            if(telefoneProcessado.Length < 9)
                return telefoneEstaValido;

            telefoneEstaValido = System.Text.RegularExpressions.Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");

            return telefoneEstaValido;
        }
    }
    
}

