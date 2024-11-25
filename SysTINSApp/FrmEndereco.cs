using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SysTINSApp
{
    public partial class FrmEndereco : Form
    {
        public FrmEndereco()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            Endereco endereco = new(
            txtClienteId.Text,
            txtCep.Text,
            txtLogradouro.Text,
            txtNumero.Text,
            txtComplemento.Text,
            txtBairro.Text,
            txtCidade.Text,
            txtUF.Text
                );
            endereco.Inserir();
            if (endereco.Id > 0)
            {
                txtId.Text = endereco.Id.ToString();
                MessageBox.Show($"Endereco cadastrado com o ID {endereco.Id}");
                btnInserir.Enabled = false;

            }
            else
            {
                MessageBox.Show("Falha ao inserir o endereco!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Endereco endereco = new();
            endereco.Id = int.Parse(txtId.Text);
            endereco.Cep = txtCep.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Complemento = txtComplemento.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.UF = txtUF.Text;
            endereco.TipoEndereco = txtTipoEndereco.Text;

            if (endereco.Atualizar())
            {

                MessageBox.Show("Enderecoo atualizado com sucesso!");
            }

        }

        private void FrmEndereco_Load(object sender, EventArgs e)
        {

        }
    }
}


