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
            txtCliId = new TextBox();
            txtCep = new TextBox();
            txtLogra = new TextBox();
            txtNum = new TextBox();
            txtCidade = new TextBox();
            txtCompl = new TextBox();
            txtBair = new TextBox();
            txtUF = new TextBox();
            txtTipEnd = new TextBox();
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
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "ClienteId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 116);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Logradouro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 116);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 186);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 5;
            label6.Text = "Complemento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 186);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Bairro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(498, 116);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 7;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(398, 186);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 8;
            label9.Text = "UF";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(520, 186);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 9;
            label10.Text = "Tipo de endereco";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 10;
            // 
            // txtCliId
            // 
            txtCliId.Location = new Point(157, 65);
            txtCliId.Name = "txtCliId";
            txtCliId.Size = new Size(100, 23);
            txtCliId.TabIndex = 11;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(12, 134);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 12;
            // 
            // txtLogra
            // 
            txtLogra.Location = new Point(157, 134);
            txtLogra.Name = "txtLogra";
            txtLogra.Size = new Size(219, 23);
            txtLogra.TabIndex = 13;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(398, 134);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(81, 23);
            txtNum.TabIndex = 14;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(498, 134);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(206, 23);
            txtCidade.TabIndex = 15;
            // 
            // txtCompl
            // 
            txtCompl.Location = new Point(12, 204);
            txtCompl.Name = "txtCompl";
            txtCompl.Size = new Size(151, 23);
            txtCompl.TabIndex = 16;
            // 
            // txtBair
            // 
            txtBair.Location = new Point(188, 204);
            txtBair.Name = "txtBair";
            txtBair.Size = new Size(194, 23);
            txtBair.TabIndex = 17;
            // 
            // txtUF
            // 
            txtUF.Location = new Point(398, 204);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(100, 23);
            txtUF.TabIndex = 18;
            // 
            // txtTipEnd
            // 
            txtTipEnd.Location = new Point(520, 204);
            txtTipEnd.Name = "txtTipEnd";
            txtTipEnd.Size = new Size(165, 23);
            txtTipEnd.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(12, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1001, 159);
            dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ClienteId";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "CEP";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Logradouro";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Numero";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Cidade";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Complemento";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Bairro";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "UF";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Tipo de endereco";
            Column10.Name = "Column10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(364, 9);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 21;
            label11.Text = "ENDEREÇOS";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(12, 280);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 22;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(384, 280);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 23;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button2_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(779, 295);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 24;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // FrmEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 509);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(txtTipEnd);
            Controls.Add(txtUF);
            Controls.Add(txtBair);
            Controls.Add(txtCompl);
            Controls.Add(txtCidade);
            Controls.Add(txtNum);
            Controls.Add(txtLogra);
            Controls.Add(txtCep);
            Controls.Add(txtCliId);
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
        private TextBox txtCliId;
        private TextBox txtCep;
        private TextBox txtLogra;
        private TextBox txtNum;
        private TextBox txtCidade;
        private TextBox txtCompl;
        private TextBox txtBair;
        private TextBox txtUF;
        private TextBox txtTipEnd;
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