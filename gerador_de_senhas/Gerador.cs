namespace gerador_de_senhas {
    internal class Gerador {
        public static string Gerar(bool possuiLetras, bool possuiNumeros, bool possuiSimbolos, int tamanho) {
            Random aleatorio = new Random();


            //TODO adicionar uma forma de SEMPRE ter um numero uma letra e um simbolo caso o usuário peça
            string todasAsLetras = "abcdefghijklmnopqrstuvwxyz";
            string todosOsNumeros = "0123456789";
            string todosOsSimbolos = "!@#$%&*?";

            string baseParaSenha = "";
            string senhaGerada = "";

            if (tamanho == 0) {
                MessageBox.Show("Valor não pode ser 0");
            }
            else if(!possuiLetras && !possuiNumeros && !possuiSimbolos){
                MessageBox.Show("Marque ao menos uma caixa");
            }
            else {
                if (possuiLetras) {
                    baseParaSenha += todasAsLetras;
                }
                if (possuiNumeros) {
                    baseParaSenha += todosOsNumeros;
                }
                if (possuiSimbolos) {
                    baseParaSenha += todosOsSimbolos;
                }

                for (int i = 0; i < tamanho; i++) {
                    senhaGerada += baseParaSenha[aleatorio.Next(baseParaSenha.Length)];
                }
            }
            return $"{senhaGerada}";
        }
    }
}
