namespace gerador_de_senhas
{
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        public void btn_gerar_senha_Click(object sender, EventArgs e) {
            string tamanhoSenha = tb_tamanho_senha.Text;
            bool contemLetras = cb_letras.Checked;
            bool contemNumero = cb_numeros.Checked;
            bool contemSimbolos = cb_simbolos.Checked;

            //Apresentar a atual situação
            MessageBox.Show(
                $"Tamanho: {tamanhoSenha}" +
                $"\nContém letra:{contemLetras}" +
                $"\nContém número:{contemNumero}" +
                $"\nContém simbolo:{contemSimbolos}");
            //TODO criar um gerador de senhas simples
        }
    }
}
