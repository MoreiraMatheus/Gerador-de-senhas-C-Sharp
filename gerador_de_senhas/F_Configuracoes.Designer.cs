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
            lb_letras = new Label();
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
            gb_tamanho.Location = new Point(26, 27);
            gb_tamanho.Name = "gb_tamanho";
            gb_tamanho.Size = new Size(450, 160);
            gb_tamanho.TabIndex = 0;
            gb_tamanho.TabStop = false;
            gb_tamanho.Text = "Tamanho Senha";
            // 
            // lb_maximo
            // 
            lb_maximo.AutoSize = true;
            lb_maximo.Font = new Font("Segoe UI", 11F);
            lb_maximo.Location = new Point(26, 90);
            lb_maximo.Name = "lb_maximo";
            lb_maximo.Size = new Size(63, 20);
            lb_maximo.TabIndex = 3;
            lb_maximo.Text = "Máximo";
            // 
            // trackBar_maximo
            // 
            trackBar_maximo.Location = new Point(114, 90);
            trackBar_maximo.Maximum = 20;
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
            trackBar_minimo.Location = new Point(114, 29);
            trackBar_minimo.Maximum = 20;
            trackBar_minimo.Name = "trackBar_minimo";
            trackBar_minimo.Size = new Size(304, 45);
            trackBar_minimo.TabIndex = 0;
            // 
            // gb_configs
            // 
            gb_configs.Controls.Add(textBox1);
            gb_configs.Controls.Add(lb_simbolos);
            gb_configs.Controls.Add(checkBox2);
            gb_configs.Controls.Add(checkBox1);
            gb_configs.Controls.Add(lb_letras);
            gb_configs.ForeColor = Color.White;
            gb_configs.Location = new Point(26, 207);
            gb_configs.Name = "gb_configs";
            gb_configs.Size = new Size(450, 152);
            gb_configs.TabIndex = 1;
            gb_configs.TabStop = false;
            gb_configs.Text = "Configurações";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 6;
            // 
            // lb_simbolos
            // 
            lb_simbolos.AutoSize = true;
            lb_simbolos.Font = new Font("Segoe UI", 11F);
            lb_simbolos.Location = new Point(26, 91);
            lb_simbolos.Name = "lb_simbolos";
            lb_simbolos.Size = new Size(71, 20);
            lb_simbolos.TabIndex = 5;
            lb_simbolos.Text = "Simbolos";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(227, 42);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Maiusculas";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(114, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Minusculas";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lb_letras
            // 
            lb_letras.AutoSize = true;
            lb_letras.Font = new Font("Segoe UI", 11F);
            lb_letras.Location = new Point(26, 39);
            lb_letras.Name = "lb_letras";
            lb_letras.Size = new Size(48, 20);
            lb_letras.TabIndex = 0;
            lb_letras.Text = "Letras";
            // 
            // F_Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(505, 393);
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
        private Label lb_letras;
        private TextBox textBox1;
        private Label lb_simbolos;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}