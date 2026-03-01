namespace gerador_de_senhas {
    partial class F_Configuracoes {
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
            gb_tamanho = new GroupBox();
            lb_maximo = new Label();
            trackBar_maximo = new TrackBar();
            lb_minimo = new Label();
            trackBar_minimo = new TrackBar();
            gb_configs = new GroupBox();
            textBox1 = new TextBox();
            lb_simbolos = new Label();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            gb_tamanho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_maximo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_minimo).BeginInit();
            gb_configs.SuspendLayout();
            SuspendLayout();
            // 
            // gb_tamanho
            // 
            gb_tamanho.Controls.Add(lb_maximo);
            gb_tamanho.Controls.Add(trackBar_maximo);
            gb_tamanho.Controls.Add(lb_minimo);
            gb_tamanho.Controls.Add(trackBar_minimo);
            gb_tamanho.ForeColor = Color.White;
            gb_tamanho.Location = new Point(26, 21);
            gb_tamanho.Name = "gb_tamanho";
            gb_tamanho.Size = new Size(356, 180);
            gb_tamanho.TabIndex = 0;
            gb_tamanho.TabStop = false;
            gb_tamanho.Text = "Tamanho Senha";
            // 
            // lb_maximo
            // 
            lb_maximo.AutoSize = true;
            lb_maximo.Font = new Font("Segoe UI", 11F);
            lb_maximo.Location = new Point(26, 100);
            lb_maximo.Name = "lb_maximo";
            lb_maximo.Size = new Size(63, 20);
            lb_maximo.TabIndex = 3;
            lb_maximo.Text = "Máximo";
            // 
            // trackBar_maximo
            // 
            trackBar_maximo.Location = new Point(26, 123);
            trackBar_maximo.Maximum = 20;
            trackBar_maximo.Minimum = 1;
            trackBar_maximo.Name = "trackBar_maximo";
            trackBar_maximo.Size = new Size(304, 45);
            trackBar_maximo.TabIndex = 2;
            trackBar_maximo.Value = 10;
            // 
            // lb_minimo
            // 
            lb_minimo.AutoSize = true;
            lb_minimo.Font = new Font("Segoe UI", 11F);
            lb_minimo.Location = new Point(26, 29);
            lb_minimo.Name = "lb_minimo";
            lb_minimo.Size = new Size(60, 20);
            lb_minimo.TabIndex = 1;
            lb_minimo.Text = "Mínimo";
            // 
            // trackBar_minimo
            // 
            trackBar_minimo.Location = new Point(26, 52);
            trackBar_minimo.Maximum = 20;
            trackBar_minimo.Minimum = 1;
            trackBar_minimo.Name = "trackBar_minimo";
            trackBar_minimo.Size = new Size(304, 45);
            trackBar_minimo.TabIndex = 0;
            trackBar_minimo.Value = 1;
            // 
            // gb_configs
            // 
            gb_configs.Controls.Add(checkBox4);
            gb_configs.Controls.Add(checkBox3);
            gb_configs.Controls.Add(textBox1);
            gb_configs.Controls.Add(lb_simbolos);
            gb_configs.Controls.Add(checkBox2);
            gb_configs.Controls.Add(checkBox1);
            gb_configs.ForeColor = Color.White;
            gb_configs.Location = new Point(26, 217);
            gb_configs.Name = "gb_configs";
            gb_configs.Size = new Size(356, 196);
            gb_configs.TabIndex = 1;
            gb_configs.TabStop = false;
            gb_configs.Text = "Configurações";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "!@#$%&*?";
            // 
            // lb_simbolos
            // 
            lb_simbolos.AutoSize = true;
            lb_simbolos.Font = new Font("Segoe UI", 9F);
            lb_simbolos.Location = new Point(26, 133);
            lb_simbolos.Name = "lb_simbolos";
            lb_simbolos.Size = new Size(98, 15);
            lb_simbolos.TabIndex = 5;
            lb_simbolos.Text = "Lista de simbolos";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(26, 60);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Letras Maiusculas";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(26, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Letras Minusculas";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(26, 85);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(75, 19);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Números";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Location = new Point(26, 110);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(75, 19);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "Símbolos";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // F_Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(409, 437);
            Controls.Add(gb_configs);
            Controls.Add(gb_tamanho);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_Configuracoes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configurações";
            gb_tamanho.ResumeLayout(false);
            gb_tamanho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_maximo).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_minimo).EndInit();
            gb_configs.ResumeLayout(false);
            gb_configs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_tamanho;
        private Label lb_minimo;
        private TrackBar trackBar_minimo;
        private Label lb_maximo;
        private TrackBar trackBar_maximo;
        private GroupBox gb_configs;
        private TextBox textBox1;
        private Label lb_simbolos;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}