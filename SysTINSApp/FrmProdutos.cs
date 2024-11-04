using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;

namespace SysTINSApp
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }
        private void FrmProdutos_Load(object sender, EventArgs e)
        {

            // carregando o datagrid de usuários
            CarregaGridProdutos);
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produtos produtos = new(
                txtCodBarras.Text,
                txtDescricao.Text,
                txtValorUnit.Text,
                txtUnidadeVenda.Text,
                txtCategoriaId.Text,
                txtEstoqueMinimo.Text,
                txtClasseDesconto.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            produtos.Inserir();
            if (produtos.Id > 0)
            {
                // carrega grid
                CarregaGridUsuarios();
                MessageBox.Show($"Produtos {produtos.CodBarras} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
        private void CarregaGridProdutos()
        {
            dgvProdutos.Rows.Clear();
            var listaDeProdutos = Produto.ObterLista();
            int linha = 0;
            foreach (var produto in listaDeProdutos)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[linha].Cells[0].Value = produto.CodBarras;
                dgvProdutos.Rows[linha].Cells[1].Value = produto.Descricao;
                dgvProdutos.Rows[linha].Cells[2].Value = produto.ValorUnit;
                dgvProdutos.Rows[linha].Cells[3].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[linha].Cells[4].Value = produto.CategoriaId;
                dgvProdutos.Rows[linha].Cells[4].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[linha].Cells[4].Value = produto.ClasseDesconto;


                linha++;
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvProdutos.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvProdutos.Rows[linhaAtual].Cells[0].Value);
            var usuario = Produto.ObterPorId(idUser);
            txtCodBarras.Text = produto.CodBarras.ToString();
            txtDescricao.Text = produto.Descricao;
            txtValorUnit.Text =´produto.ValorUnit;
            chkAtivo.Checked = usuario.Ativo;
            cmbNivel.SelectedValue = usuario.Nivel.Id;
            btnAtualizar.Enabled = true;

            //MessageBox.Show(idUser.ToString());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();
            usuario.Id = int.Parse(txtId.Text);
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue));
            if (usuario.Atualizar())
            {
                CarregaGridUsuarios();
                MessageBox.Show("Usuário atualizado com sucesso!");
            }

        }
    }
}

    }
}
