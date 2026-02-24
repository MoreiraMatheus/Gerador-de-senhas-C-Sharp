namespace gerador_de_senhas
{
    public partial class F_principal : Form {
        public F_principal() {
            InitializeComponent();
        }

        public void btn_gerar_senha_Click(object sender, EventArgs e) {
            string tamanhoSenha = tb_tamanho_senha.Text;
            bool contemLetras = cb_letras.Checked;
            bool contemNumeros = cb_numeros.Checked;
            bool contemSimbolos = cb_simbolos.Checked;

            string senha = Gerador.Gerar(contemLetras, contemNumeros, contemSimbolos, 5);
            MessageBox.Show(senha);

            //TODO Criar botão de copiar senha pra área de transferência
        }

        private void bancoDeSenhasToolStripMenuItem_Click(object sender, EventArgs e) {
            //TODO conectar com o banco de senhas
        }
    }
}
