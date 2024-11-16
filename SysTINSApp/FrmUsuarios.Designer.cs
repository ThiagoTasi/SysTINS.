namespace SysTINSApp
{
    partial class FrmUsuarios
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
            btnInserir = new Button();
            btnConsultar = new Button();
            btnAtualizar = new Button();
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbNivel = new ComboBox();
            label5 = new Label();
            chkAtivo = new CheckBox();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfSenha = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(122, 303);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(86, 31);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(254, 303);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 31);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(387, 304);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(86, 31);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(106, 389);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(571, 200);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.MinimumWidth = 6;
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Visible = false;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.MinimumWidth = 6;
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.MinimumWidth = 6;
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nivel";
            clnNivel.MinimumWidth = 6;
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 60;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.MinimumWidth = 6;
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 93);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 92);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 164);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 229);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // cmbNivel
            // 
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Location = new Point(539, 195);
            cmbNivel.Margin = new Padding(3, 4, 3, 4);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(138, 28);
            cmbNivel.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 171);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 9;
            label5.Text = "Nível";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Enabled = false;
            chkAtivo.Location = new Point(448, 255);
            chkAtivo.Margin = new Padding(3, 4, 3, 4);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(66, 24);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(122, 120);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(62, 27);
            txtId.TabIndex = 11;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(225, 120);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(452, 27);
            txtNome.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 195);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(393, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(122, 255);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(114, 27);
            txtSenha.TabIndex = 14;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(254, 255);
            txtConfSenha.Margin = new Padding(3, 4, 3, 4);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(114, 27);
            txtConfSenha.TabIndex = 14;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 229);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 7;
            label6.Text = "Confirma Senha";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 633);
            Controls.Add(txtConfSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(chkAtivo);
            Controls.Add(label5);
            Controls.Add(cmbNivel);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnAtualizar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Button btnConsultar;
        private Button btnAtualizar;
        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbNivel;
        private Label label5;
        private CheckBox chkAtivo;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfSenha;
        private Label label6;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}