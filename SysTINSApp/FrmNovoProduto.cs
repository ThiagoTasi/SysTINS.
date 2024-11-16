using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SysTINSApp
{
    public partial class FrmNovoProduto : Form
    {
        public FrmNovoProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
             Produto produto = new(

                       txtCodBar.Text,
                       txtDescricao.Text,
            Produto.Inserir());
            if (produto.Id > 0)
            {

                MessageBox.Show($"Produto {produto.Nome} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
    }
}
