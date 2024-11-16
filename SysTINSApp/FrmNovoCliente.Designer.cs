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
            txtNome = new TextBox();
            txtCpf = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnInserir = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 68);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 205);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Data de nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 205);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 205);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 68);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 4;
            label5.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 105);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(330, 27);
            txtNome.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(385, 105);
            txtCpf.Margin = new Padding(3, 4, 3, 4);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(231, 27);
            txtCpf.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(19, 244);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(272, 244);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(573, 244);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(191, 27);
            txtTelefone.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(37, 315);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(839, 200);
            dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome Completo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "CPF";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Data de nascimento";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefone";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(770, 553);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(120, 31);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 11);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 12;
            label6.Text = "CADASTRO DE CLIENTES";
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(btnInserir);
            Controls.Add(dataGridView1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox txtNome;
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
        private Label label6;
    }
}