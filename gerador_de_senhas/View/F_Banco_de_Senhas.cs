using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerador_de_senhas {
    public partial class F_Banco_de_Senhas : Form {
        //List<string> bancoDeSenhas = new List<string>();
        public F_Banco_de_Senhas(string senha) {
            //bancoDeSenhas = banco;
            InitializeComponent();
            tb_senha1.Text = senha;
        }

        private void btn_ver_senha1_Click(object sender, EventArgs e) {
            if (tb_senha1.UseSystemPasswordChar) {
                tb_senha1.UseSystemPasswordChar = false;
            }else {
                tb_senha1.UseSystemPasswordChar = true;
            }
        }

        private void btn_copiar_senha1_Click(object sender, EventArgs e) {
            Clipboard.SetText(tb_senha1.Text);
            MessageBox.Show("Senha copiada para a área de tranferência");
        }
    }
}
