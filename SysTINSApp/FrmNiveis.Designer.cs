namespace SysTINSApp
{
    partial class FrmNiveis
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
            txtId = new TextBox();
            xtId = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtSigla = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(46, 63);
            txtId.Name = "txtId";
            txtId.Size = new Size(61, 27);
            txtId.TabIndex = 0;
            // 
            // xtId
            // 
            xtId.AutoSize = true;
            xtId.Location = new Point(45, 40);
            xtId.Name = "xtId";
            xtId.Size = new Size(22, 20);
            xtId.TabIndex = 1;
            xtId.Text = "Id";
            xtId.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 123);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 146);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 27);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 213);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Sigla";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(45, 236);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(125, 27);
            txtSigla.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 21);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "NIVEIS";
            // 
            // FrmNiveis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSigla);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(xtId);
            Controls.Add(txtId);
            Name = "FrmNiveis";
            Text = "FrmNiveis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label xtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtSigla;
        private Label label1;
    }
}