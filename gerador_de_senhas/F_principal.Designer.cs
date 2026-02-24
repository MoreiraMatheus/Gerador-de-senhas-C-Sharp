namespace gerador_de_senhas
{
    partial class F_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btn_gerar_senha = new Button();
            tb_senha_gerada = new TextBox();
            tb_tamanho_senha = new TextBox();
            lb_tamanho = new Label();
            cb_letras = new CheckBox();
            cb_numeros = new CheckBox();
            gb_regras = new GroupBox();
            cb_simbolos = new CheckBox();
            lb_senha_gerada = new Label();
            menuStrip1 = new MenuStrip();
            bancoDeSenhasToolStripMenuItem = new ToolStripMenuItem();
            gb_regras.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_gerar_senha
            // 
            btn_gerar_senha.BackColor = Color.Silver;
            btn_gerar_senha.Cursor = Cursors.Hand;
            btn_gerar_senha.FlatAppearance.BorderSize = 0;
            btn_gerar_senha.FlatStyle = FlatStyle.Flat;
            btn_gerar_senha.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btn_gerar_senha.ForeColor = SystemColors.ActiveCaptionText;
            btn_gerar_senha.Location = new Point(25, 214);
            btn_gerar_senha.Margin = new Padding(4);
            btn_gerar_senha.Name = "btn_gerar_senha";
            btn_gerar_senha.Size = new Size(228, 27);
            btn_gerar_senha.TabIndex = 5;
            btn_gerar_senha.Text = "Gerar senha";
            btn_gerar_senha.UseVisualStyleBackColor = false;
            btn_gerar_senha.Click += btn_gerar_senha_Click;
            // 
            // tb_senha_gerada
            // 
            tb_senha_gerada.Location = new Point(25, 277);
            tb_senha_gerada.Margin = new Padding(4);
            tb_senha_gerada.MaxLength = 20;
            tb_senha_gerada.Name = "tb_senha_gerada";
            tb_senha_gerada.ReadOnly = true;
            tb_senha_gerada.Size = new Size(228, 25);
            tb_senha_gerada.TabIndex = 6;
            // 
            // tb_tamanho_senha
            // 
            tb_tamanho_senha.Location = new Point(159, 43);
            tb_tamanho_senha.Margin = new Padding(4);
            tb_tamanho_senha.MaxLength = 2;
            tb_tamanho_senha.Name = "tb_tamanho_senha";
            tb_tamanho_senha.Size = new Size(50, 25);
            tb_tamanho_senha.TabIndex = 1;
            tb_tamanho_senha.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_tamanho
            // 
            lb_tamanho.AutoSize = true;
            lb_tamanho.Location = new Point(25, 46);
            lb_tamanho.Margin = new Padding(4, 0, 4, 0);
            lb_tamanho.Name = "lb_tamanho";
            lb_tamanho.Size = new Size(126, 18);
            lb_tamanho.TabIndex = 0;
            lb_tamanho.Text = "Tamanho da senha:";
            // 
            // cb_letras
            // 
            cb_letras.AutoSize = true;
            cb_letras.Cursor = Cursors.Hand;
            cb_letras.Location = new Point(19, 27);
            cb_letras.Margin = new Padding(4);
            cb_letras.Name = "cb_letras";
            cb_letras.Size = new Size(116, 22);
            cb_letras.TabIndex = 2;
            cb_letras.Text = "Contém Letras";
            cb_letras.UseVisualStyleBackColor = true;
            // 
            // cb_numeros
            // 
            cb_numeros.AutoSize = true;
            cb_numeros.Cursor = Cursors.Hand;
            cb_numeros.Location = new Point(19, 57);
            cb_numeros.Margin = new Padding(4);
            cb_numeros.Name = "cb_numeros";
            cb_numeros.Size = new Size(136, 22);
            cb_numeros.TabIndex = 3;
            cb_numeros.Text = "Contém Números";
            cb_numeros.UseVisualStyleBackColor = true;
            // 
            // gb_regras
            // 
            gb_regras.Controls.Add(cb_simbolos);
            gb_regras.Controls.Add(cb_letras);
            gb_regras.Controls.Add(cb_numeros);
            gb_regras.ForeColor = SystemColors.ButtonHighlight;
            gb_regras.Location = new Point(25, 77);
            gb_regras.Margin = new Padding(4);
            gb_regras.Name = "gb_regras";
            gb_regras.Padding = new Padding(4);
            gb_regras.Size = new Size(228, 126);
            gb_regras.TabIndex = 2;
            gb_regras.TabStop = false;
            gb_regras.Text = "Regras";
            // 
            // cb_simbolos
            // 
            cb_simbolos.AutoSize = true;
            cb_simbolos.Cursor = Cursors.Hand;
            cb_simbolos.Location = new Point(19, 86);
            cb_simbolos.Margin = new Padding(4);
            cb_simbolos.Name = "cb_simbolos";
            cb_simbolos.Size = new Size(135, 22);
            cb_simbolos.TabIndex = 4;
            cb_simbolos.Text = "Contém Símbolos";
            cb_simbolos.UseVisualStyleBackColor = true;
            // 
            // lb_senha_gerada
            // 
            lb_senha_gerada.AutoSize = true;
            lb_senha_gerada.Location = new Point(25, 255);
            lb_senha_gerada.Margin = new Padding(4, 0, 4, 0);
            lb_senha_gerada.Name = "lb_senha_gerada";
            lb_senha_gerada.Size = new Size(93, 18);
            lb_senha_gerada.TabIndex = 0;
            lb_senha_gerada.Text = "Senha Gerada";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { bancoDeSenhasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(275, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // bancoDeSenhasToolStripMenuItem
            // 
            bancoDeSenhasToolStripMenuItem.ForeColor = Color.White;
            bancoDeSenhasToolStripMenuItem.Name = "bancoDeSenhasToolStripMenuItem";
            bancoDeSenhasToolStripMenuItem.Size = new Size(74, 20);
            bancoDeSenhasToolStripMenuItem.Text = "Ver senhas";
            bancoDeSenhasToolStripMenuItem.Click += bancoDeSenhasToolStripMenuItem_Click;
            // 
            // F_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(275, 351);
            Controls.Add(lb_senha_gerada);
            Controls.Add(gb_regras);
            Controls.Add(lb_tamanho);
            Controls.Add(tb_tamanho_senha);
            Controls.Add(tb_senha_gerada);
            Controls.Add(btn_gerar_senha);
            Controls.Add(menuStrip1);
            Font = new Font("Calibri", 11F);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "F_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de senhas";
            gb_regras.ResumeLayout(false);
            gb_regras.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_gerar_senha;
        private TextBox tb_senha_gerada;
        private TextBox tb_tamanho_senha;
        private Label lb_tamanho;
        private CheckBox cb_letras;
        private CheckBox cb_numeros;
        private GroupBox gb_regras;
        private CheckBox cb_simbolos;
        private Label lb_senha_gerada;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bancoDeSenhasToolStripMenuItem;
    }
}
