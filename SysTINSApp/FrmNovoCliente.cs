using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SysTINSApp
{
    public partial class FrmNovoCliente : Form
    {
        public FrmNovoCliente()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(

                       txtNome.Text,
                       txtCpf.Text,
                       txtTelefone.Text,
                       txtEmail.Text,
                       txtData de nascimento.dateTimePicker1,
            Cliente.Inserir();
            if (cliente.Id > 0)
            {
               
                MessageBox.Show($"Cliente {cliente.Nome} inserido com sucesso");
                btnInserir.Enabled = false;
            }
        }
    }
    }
