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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtId = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            txtValorUnit = new TextBox();
            txtEstoqueMinimo = new TextBox();
            txtClassDesc = new TextBox();
            txtUnidVend = new TextBox();
            txtCateg = new TextBox();
            txtDataCad = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 87);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 87);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Código Barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 87);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Descricao";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 203);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Valor Unitário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 308);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 4;
            label5.Text = "Unidade Venda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 311);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 5;
            label6.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 203);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 6;
            label7.Text = "Estoque Minimo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 203);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 7;
            label8.Text = "Classe Desconto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 308);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 8;
            label9.Text = "Data Cadastro";
            // 
            // txtId
            // 
            txtId.Location = new Point(26, 127);
            txtId.Name = "txtId";
            txtId.Size = new Size(50, 27);
            txtId.TabIndex = 9;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(142, 127);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(189, 27);
            txtCodBar.TabIndex = 10;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(369, 127);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(201, 27);
            txtDescricao.TabIndex = 11;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(26, 242);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(125, 27);
            txtValorUnit.TabIndex = 12;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(198, 242);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(125, 27);
            txtEstoqueMinimo.TabIndex = 13;
            // 
            // txtClassDesc
            // 
            txtClassDesc.Location = new Point(445, 242);
            txtClassDesc.Name = "txtClassDesc";
            txtClassDesc.Size = new Size(125, 27);
            txtClassDesc.TabIndex = 14;
            // 
            // txtUnidVend
            // 
            txtUnidVend.Location = new Point(26, 343);
            txtUnidVend.Name = "txtUnidVend";
            txtUnidVend.Size = new Size(125, 27);
            txtUnidVend.TabIndex = 15;
            // 
            // txtCateg
            // 
            txtCateg.Location = new Point(206, 343);
            txtCateg.Name = "txtCateg";
            txtCateg.Size = new Size(125, 27);
            txtCateg.TabIndex = 16;
            // 
            // txtDataCad
            // 
            txtDataCad.Location = new Point(410, 343);
            txtDataCad.Name = "txtDataCad";
            txtDataCad.Size = new Size(125, 27);
            txtDataCad.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 9);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 18;
            label10.Text = "PRODUTOS";
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(929, 450);
            Controls.Add(label10);
            Controls.Add(txtDataCad);
            Controls.Add(txtCateg);
            Controls.Add(txtUnidVend);
            Controls.Add(txtClassDesc);
            Controls.Add(txtEstoqueMinimo);
            Controls.Add(txtValorUnit);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodBar);
            Controls.Add(txtId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
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
        private TextBox txtId;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private TextBox txtValorUnit;
        private TextBox txtEstoqueMinimo;
        private TextBox txtClassDesc;
        private TextBox txtUnidVend;
        private TextBox txtCateg;
        private TextBox txtDataCad;
        private Label label10;
    }
}