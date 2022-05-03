using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinFormsApp._1___Apresentação.Contato
{
    public partial class CadastroDeContatos : Form
    {
        private Contatos contatos;

        public Contatos Contatos
        {
            get
            {
                return contatos;
            }

            set
            {
                contatos = value;
                txtNomeContato.Text = contatos.NomeContato;
                txtEmailContato.Text = contatos.EmailContato;
                txtTelefoneContato.Text = contatos.Telefone;
                txtEmpresaContato.Text = contatos.Empresa;
                txtCargoContato.Text = contatos.Cargo;

            }
        }
        public CadastroDeContatos()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contatos.NomeContato = txtNomeContato.Text;
            Contatos.EmailContato = txtEmailContato.Text;
            Contatos.Telefone  = txtTelefoneContato.Text;
            Contatos.Empresa = txtEmpresaContato.Text;
            Contatos.Cargo = txtCargoContato.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
