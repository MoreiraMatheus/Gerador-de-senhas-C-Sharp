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
        string senha;
        public F_Banco_de_Senhas() {
            InitializeComponent();
        }

        private void btn_ver_senha1_Click(object sender, EventArgs e) {
            if (tb_senha1.PasswordChar == char.Parse("*")) {
                //TODO Adicionar uma lógica aqui para que a senha fique visível
                tb_senha1.PasswordChar = char.Parse("-");
            }else {
                tb_senha1.PasswordChar = char.Parse("*");
            }
        }

        private void btn_copiar_senha1_Click(object sender, EventArgs e) {
            Clipboard.SetText(tb_senha1.Text);
            MessageBox.Show("Senha copiada para a área de tranferência");
        }
    }
}
