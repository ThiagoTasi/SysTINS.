namespace SysTINSApp
{
    partial class FrmNovoCliente
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
            txtNomeComp = new TextBox();
            txtCpf = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            dataGridView1 = new DataGridView();
            btnInserir = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 154);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Data de nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 154);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 154);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 51);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "CPF";
            // 
            // txtNomeComp
            // 
            txtNomeComp.Location = new Point(17, 79);
            txtNomeComp.Name = "txtNomeComp";
            txtNomeComp.Size = new Size(289, 23);
            txtNomeComp.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(337, 79);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(203, 23);
            txtCpf.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(17, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(501, 183);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(168, 23);
            txtTelefone.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(32, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(734, 150);
            dataGridView1.TabIndex = 10;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(674, 415);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(105, 23);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome Completo";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "CPF";
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Data de nascimento";
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefone";
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInserir);
            Controls.Add(dataGridView1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtCpf);
            Controls.Add(txtNomeComp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNovoCliente";
            Text = "FrmNovoCliente";
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
        private TextBox txtNomeComp;
        private TextBox txtCpf;
        private DateTimePicker dateTimePicker1;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnInserir;
    }
}