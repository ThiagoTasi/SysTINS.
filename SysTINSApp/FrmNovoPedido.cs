using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTINSApp
{
    public partial class FrmNovoPedido : Form
    {
        public FrmNovoPedido()
        {
            InitializeComponent();
        }

        private void FrmNovoPedido_Load(object sender, EventArgs e)
        {

        }

        private void FrmNovoPedido_Load_1(object sender, EventArgs e)
        {

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Usuario.ObterPorId(Program.UsuarioLogado.Id),
                FrmConsultaCliente.ObterPorId(int.Parse(txtIdCliente.Text))
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbIndentificacao.Enabled = false;
            grbItens.Enabled = true;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
