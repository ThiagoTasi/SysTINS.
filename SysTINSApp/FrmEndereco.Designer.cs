namespace SysTINSApp
{
    partial class FrmEndereco
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtId = new TextBox();
            txtClienteId = new TextBox();
            txtCep = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtUF = new TextBox();
            txtTipoEndereco = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            label11 = new Label();
            btnInserir = new Button();
            btnConsultar = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 63);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 63);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "ClienteId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 155);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 155);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Logradouro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 155);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 248);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Complemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 248);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Bairro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(569, 155);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 7;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(455, 248);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 8;
            label9.Text = "UF";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(594, 248);
            label10.Name = "label10";
            label10.Size = new Size(126, 20);
            label10.TabIndex = 9;
            label10.Text = "Tipo de endereco";
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 87);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 10;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(179, 87);
            txtClienteId.Margin = new Padding(3, 4, 3, 4);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(114, 27);
            txtClienteId.TabIndex = 11;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(14, 179);
            txtCep.Margin = new Padding(3, 4, 3, 4);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(114, 27);
            txtCep.TabIndex = 12;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(179, 179);
            txtLogradouro.Margin = new Padding(3, 4, 3, 4);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(250, 27);
            txtLogradouro.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(455, 179);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(92, 27);
            txtNumero.TabIndex = 14;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(569, 179);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(235, 27);
            txtCidade.TabIndex = 15;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(14, 272);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(172, 27);
            txtComplemento.TabIndex = 16;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(215, 272);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(221, 27);
            txtBairro.TabIndex = 17;
            // 
            // txtUF
            // 
            txtUF.Location = new Point(455, 272);
            txtUF.Margin = new Padding(3, 4, 3, 4);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(114, 27);
            txtUF.TabIndex = 18;
            // 
            // txtTipoEndereco
            // 
            txtTipoEndereco.Location = new Point(594, 272);
            txtTipoEndereco.Margin = new Padding(3, 4, 3, 4);
            txtTipoEndereco.Name = "txtTipoEndereco";
            txtTipoEndereco.Size = new Size(188, 27);
            txtTipoEndereco.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(14, 432);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1144, 212);
            dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ClienteId";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "CEP";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Logradouro";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Numero";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Cidade";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Complemento";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Bairro";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "UF";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Tipo de endereco";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(416, 12);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 21;
            label11.Text = "ENDEREÇOS";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(14, 373);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(86, 31);
            btnInserir.TabIndex = 22;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(439, 373);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 31);
            btnConsultar.TabIndex = 23;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button2_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(890, 393);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(86, 31);
            btnAtualizar.TabIndex = 24;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 679);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(txtTipoEndereco);
            Controls.Add(txtUF);
            Controls.Add(txtBairro);
            Controls.Add(txtComplemento);
            Controls.Add(txtCidade);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCep);
            Controls.Add(txtClienteId);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEndereco";
            Text = "FrmEndereco";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtId;
        private TextBox txtClienteId;
        private TextBox txtCep;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtUF;
        private TextBox txtTipoEndereco;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label11;
        private Button btnInserir;
        private Button btnConsultar;
        private Button btnAtualizar;
    }
}