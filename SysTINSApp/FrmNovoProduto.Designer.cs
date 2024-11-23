namespace SysTINSApp
{
    partial class FrmNovoProduto
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
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnInserir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 71);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Código de Barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 71);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(11, 107);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(316, 27);
            txtCodBar.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(386, 107);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(250, 27);
            txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 12);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 4;
            label3.Text = "NOVOS PRODUTOS";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(11, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(624, 188);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código de Barras";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 310;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descrição";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 310;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(645, 419);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 29);
            btnInserir.TabIndex = 6;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // FrmNovoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnInserir);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNovoProduto";
            Text = "FrmNovoProduto";
            Load += FrmNovoProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnInserir;
    }
}