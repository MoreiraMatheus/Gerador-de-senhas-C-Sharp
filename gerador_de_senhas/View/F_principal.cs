using gerador_de_senhas.Controler;
using gerador_de_senhas.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gerador_de_senhas
{
    public partial class F_principal : Form {
        //TODO criar lista com senhas pra passar pro banco de senhas, por hora usar somente senha única

        //public List<string> bancoDeSenhas = new List<string>();

        ConfiguracaoSenhas configuracaoSenhas = new ConfiguracaoSenhas();
        string senha = " ";

        public F_principal() {
            InitializeComponent();
            cb_letras.Visible = configuracaoSenhas.letrasMinusculas;
            cb_numeros.Visible = configuracaoSenhas.numeros;
            cb_simbolos.Visible = configuracaoSenhas.simbolos;
        }

        private void bancoDeSenhasToolStripMenuItem_Click(object sender, EventArgs e) {
            F_Banco_de_Senhas f_Banco_De_Senhas = new F_Banco_de_Senhas(senha);
            f_Banco_De_Senhas.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e) {
            F_Configuracoes f_Configuracoes = new F_Configuracoes();
            f_Configuracoes.Show();
        }

        public void btn_gerar_senha_Click(object sender, EventArgs e) {
            int tamanhoSenha = Convert.ToInt32(nud_tamanho_senha.Value);
            bool contemLetras = cb_letras.Checked;
            bool contemNumeros = cb_numeros.Checked;
            bool contemSimbolos = cb_simbolos.Checked;

            senha = Gerador.Gerar(contemLetras, contemNumeros, contemSimbolos, tamanhoSenha);
            tb_senha_gerada.Text = senha;
        }
        private void btn_salvar_senha_Click(object sender, EventArgs e) {
            MessageBox.Show("Senha salva no banco");
        }

        private void btn_copiar_senha_Click(object sender, EventArgs e) {
            Clipboard.SetText(senha);
            MessageBox.Show("Senha copiada para a área de tranferência");
        }
    }
}