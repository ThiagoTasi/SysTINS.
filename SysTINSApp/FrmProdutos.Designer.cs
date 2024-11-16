namespace SysTINSApp
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodigoBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            gpProdutos = new GroupBox();
            cmbCategoria = new ComboBox();
            npEstoqueMinimo = new NumericUpDown();
            btnCosultar = new Button();
            btnAdicionar = new Button();
            btnEditar = new Button();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            txtDesconto = new TextBox();
            txtValorUnit = new TextBox();
            txtUnidadeVenda = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            txtNewCatSigla = new TextBox();
            txtNewCat = new TextBox();
            label10 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            gpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigoBarras, clnDescricao, clnValorUnit, clnUnidadeVenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnData });
            dgvProdutos.Location = new Point(14, 469);
            dgvProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(1103, 293);
            dgvProdutos.TabIndex = 9;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.MinimumWidth = 6;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 125;
            // 
            // clnCodigoBarras
            // 
            clnCodigoBarras.HeaderText = "Código de Barras";
            clnCodigoBarras.MinimumWidth = 6;
            clnCodigoBarras.Name = "clnCodigoBarras";
            clnCodigoBarras.ReadOnly = true;
            clnCodigoBarras.Width = 200;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.MinimumWidth = 6;
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.MinimumWidth = 6;
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 120;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.MinimumWidth = 6;
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 130;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.MinimumWidth = 6;
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 250;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.HeaderText = "Estoque Minimo";
            clnEstoqueMinimo.MinimumWidth = 6;
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            clnEstoqueMinimo.Width = 130;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.MinimumWidth = 6;
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 125;
            // 
            // clnData
            // 
            clnData.HeaderText = "Data Cadastro";
            clnData.MinimumWidth = 6;
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            clnData.Width = 160;
            // 
            // gpProdutos
            // 
            gpProdutos.Controls.Add(cmbCategoria);
            gpProdutos.Controls.Add(npEstoqueMinimo);
            gpProdutos.Controls.Add(btnCosultar);
            gpProdutos.Controls.Add(btnAdicionar);
            gpProdutos.Controls.Add(btnEditar);
            gpProdutos.Controls.Add(label7);
            gpProdutos.Controls.Add(label6);
            gpProdutos.Controls.Add(label8);
            gpProdutos.Controls.Add(label3);
            gpProdutos.Controls.Add(label5);
            gpProdutos.Controls.Add(label4);
            gpProdutos.Controls.Add(label9);
            gpProdutos.Controls.Add(label2);
            gpProdutos.Controls.Add(txtId);
            gpProdutos.Controls.Add(txtCodBar);
            gpProdutos.Controls.Add(txtDescricao);
            gpProdutos.Controls.Add(txtDesconto);
            gpProdutos.Controls.Add(txtValorUnit);
            gpProdutos.Controls.Add(txtUnidadeVenda);
            gpProdutos.Location = new Point(39, 74);
            gpProdutos.Margin = new Padding(3, 4, 3, 4);
            gpProdutos.Name = "gpProdutos";
            gpProdutos.Padding = new Padding(3, 4, 3, 4);
            gpProdutos.Size = new Size(643, 353);
            gpProdutos.TabIndex = 8;
            gpProdutos.TabStop = false;
            gpProdutos.Text = "Produtos";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(43, 212);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(322, 28);
            cmbCategoria.TabIndex = 5;
            cmbCategoria.TextChanged += cmbCategoria_TextChanged;
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(351, 143);
            npEstoqueMinimo.Margin = new Padding(3, 4, 3, 4);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(66, 27);
            npEstoqueMinimo.TabIndex = 4;
            // 
            // btnCosultar
            // 
            btnCosultar.Location = new Point(417, 284);
            btnCosultar.Margin = new Padding(3, 4, 3, 4);
            btnCosultar.Name = "btnCosultar";
            btnCosultar.Size = new Size(86, 31);
            btnCosultar.TabIndex = 8;
            btnCosultar.Text = "&Consultar";
            btnCosultar.UseVisualStyleBackColor = true;
            btnCosultar.Click += btnCosultar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(193, 284);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(86, 31);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(309, 284);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 119);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 2;
            label7.Text = "Estoque Mínimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 183);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 2;
            label6.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 260);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 2;
            label8.Text = "Desconto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 44);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(193, 117);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 2;
            label5.Text = "Unidade de Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 117);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 2;
            label4.Text = "Valor Unitário";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 44);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 2;
            label9.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 44);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Código de barras";
            // 
            // txtId
            // 
            txtId.Location = new Point(43, 68);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(79, 27);
            txtId.TabIndex = 1;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(141, 67);
            txtCodBar.Margin = new Padding(3, 4, 3, 4);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(159, 27);
            txtCodBar.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(321, 68);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(276, 27);
            txtDescricao.TabIndex = 1;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(43, 285);
            txtDesconto.Margin = new Padding(3, 4, 3, 4);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(133, 27);
            txtDesconto.TabIndex = 6;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(43, 141);
            txtValorUnit.Margin = new Padding(3, 4, 3, 4);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(133, 27);
            txtValorUnit.TabIndex = 2;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(193, 141);
            txtUnidadeVenda.Margin = new Padding(3, 4, 3, 4);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "EX: Caixa";
            txtUnidadeVenda.Size = new Size(133, 27);
            txtUnidadeVenda.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 23);
            label1.Name = "label1";
            label1.Size = new Size(222, 47);
            label1.TabIndex = 7;
            label1.Text = "Produtos";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtNewCatSigla);
            panel1.Controls.Add(txtNewCat);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(701, 92);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 248);
            panel1.TabIndex = 10;
            panel1.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 100);
            label12.Name = "label12";
            label12.Size = new Size(42, 20);
            label12.TabIndex = 3;
            label12.Text = "Sigla";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(43, 41);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 3;
            label11.Text = "Nome";
            // 
            // txtNewCatSigla
            // 
            txtNewCatSigla.Location = new Point(43, 123);
            txtNewCatSigla.Margin = new Padding(3, 4, 3, 4);
            txtNewCatSigla.Name = "txtNewCatSigla";
            txtNewCatSigla.Size = new Size(109, 27);
            txtNewCatSigla.TabIndex = 2;
            // 
            // txtNewCat
            // 
            txtNewCat.Location = new Point(43, 65);
            txtNewCat.Margin = new Padding(3, 4, 3, 4);
            txtNewCat.Name = "txtNewCat";
            txtNewCat.Size = new Size(221, 27);
            txtNewCat.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Cursor = Cursors.No;
            label10.Location = new Point(130, 12);
            label10.Name = "label10";
            label10.Size = new Size(115, 22);
            label10.TabIndex = 1;
            label10.Text = "Nova Categoria";
            // 
            // button2
            // 
            button2.Location = new Point(203, 188);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(158, 31);
            button2.TabIndex = 0;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(13, 189);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 31);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 779);
            Controls.Add(panel1);
            Controls.Add(dgvProdutos);
            Controls.Add(gpProdutos);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            gpProdutos.ResumeLayout(false);
            gpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigoBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnData;
        private GroupBox gpProdutos;
        private ComboBox cmbCategoria;
        private NumericUpDown npEstoqueMinimo;
        private Button btnCosultar;
        private Button btnAdicionar;
        private Button btnEditar;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label2;
        private TextBox txtId;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private TextBox txtDesconto;
        private TextBox txtValorUnit;
        private TextBox txtUnidadeVenda;
        private Label label1;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private TextBox txtNewCatSigla;
        private TextBox txtNewCat;
        private Label label10;
        private Button button1;
        private Button button2;
    }
}