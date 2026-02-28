using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gerador_de_senhas
{
    public partial class F_principal : Form {
        public List<string> bancoDeSenhas = new List<string>();
        string senha = " ";

        public F_principal() {
            InitializeComponent();
        }

        private void bancoDeSenhasToolStripMenuItem_Click(object sender, EventArgs e) {
            F_Banco_de_Senhas f_Banco_De_Senhas = new F_Banco_de_Senhas(bancoDeSenhas);
            f_Banco_De_Senhas.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e) {
            F_Configuracoes f_Configuracoes = new F_Configuracoes();
            f_Configuracoes.Show();
        }

        public void btn_gerar_senha_Click(object sender, EventArgs e) {
            int tamanhoSenha = Convert.ToInt32(tb_tamanho_senha.Text);
            bool contemLetras = cb_letras.Checked;
            bool contemNumeros = cb_numeros.Checked;
            bool contemSimbolos = cb_simbolos.Checked;

            senha = Gerador.Gerar(contemLetras, contemNumeros, contemSimbolos, tamanhoSenha);
            tb_senha_gerada.Text = senha;
        }
        private void btn_salvar_senha_Click(object sender, EventArgs e) {
            bancoDeSenhas.Add(senha);
            MessageBox.Show("Senha salva no banco");
        }

        private void btn_copiar_senha_Click(object sender, EventArgs e) {
            Clipboard.SetText(senha);
            MessageBox.Show("Senha copiada para a área de tranferência");
        }

        private void tb_tamanho_senha_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(tb_tamanho_senha.Text, out int numero)) {
                if (numero > 10) {
                    tb_tamanho_senha.Text = "10";
                }
            }
            else {
                tb_tamanho_senha.Text = "0";
            }
        }
    }
}