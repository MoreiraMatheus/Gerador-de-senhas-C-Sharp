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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(33, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 145);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Visualizar Senhas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(350, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "ver senha";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 23);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(350, 61);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "ver senha";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 23);
            textBox3.TabIndex = 4;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(350, 100);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "ver senha";
            button3.UseVisualStyleBackColor = true;
            // 
            // F_Banco_de_Senhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(669, 218);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_Banco_de_Senhas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banco de Senhas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button3;
        private TextBox textBox3;
        private Button button2;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
    }
}