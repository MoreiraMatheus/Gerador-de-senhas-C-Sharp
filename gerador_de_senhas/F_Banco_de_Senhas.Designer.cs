namespace gerador_de_senhas {
    partial class F_Banco_de_Senhas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            tb_senha1 = new TextBox();
            btn_copiar_senha1 = new Button();
            btn_ver_senha1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_senha1);
            groupBox1.Controls.Add(btn_copiar_senha1);
            groupBox1.Controls.Add(btn_ver_senha1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(33, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 63);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Visualizar Senhas";
            // 
            // tb_senha1
            // 
            tb_senha1.Location = new Point(16, 22);
            tb_senha1.Name = "tb_senha1";
            tb_senha1.ReadOnly = true;
            tb_senha1.Size = new Size(150, 23);
            tb_senha1.TabIndex = 0;
            tb_senha1.UseSystemPasswordChar = true;
            // 
            // btn_copiar_senha1
            // 
            btn_copiar_senha1.BackColor = Color.Silver;
            btn_copiar_senha1.FlatAppearance.BorderSize = 0;
            btn_copiar_senha1.FlatStyle = FlatStyle.Flat;
            btn_copiar_senha1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_copiar_senha1.ForeColor = Color.Black;
            btn_copiar_senha1.Location = new Point(277, 21);
            btn_copiar_senha1.Name = "btn_copiar_senha1";
            btn_copiar_senha1.Size = new Size(75, 23);
            btn_copiar_senha1.TabIndex = 2;
            btn_copiar_senha1.Text = "Copiar";
            btn_copiar_senha1.UseVisualStyleBackColor = false;
            btn_copiar_senha1.Click += btn_copiar_senha1_Click;
            // 
            // btn_ver_senha1
            // 
            btn_ver_senha1.BackColor = Color.Silver;
            btn_ver_senha1.FlatAppearance.BorderSize = 0;
            btn_ver_senha1.FlatStyle = FlatStyle.Flat;
            btn_ver_senha1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_ver_senha1.ForeColor = Color.Black;
            btn_ver_senha1.Location = new Point(183, 21);
            btn_ver_senha1.Name = "btn_ver_senha1";
            btn_ver_senha1.Size = new Size(75, 23);
            btn_ver_senha1.TabIndex = 1;
            btn_ver_senha1.Text = "Ver senha";
            btn_ver_senha1.UseVisualStyleBackColor = false;
            btn_ver_senha1.Click += btn_ver_senha1_Click;
            // 
            // F_Banco_de_Senhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(437, 124);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_Banco_de_Senhas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banco de Senhas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btn_ver_senha1;
        private TextBox tb_senha1;
        private Button btn_copiar_senha1;
    }
}