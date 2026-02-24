namespace gerador_de_senhas {
    internal class Gerador {
        public static string Gerar(bool letras, bool numeros, bool simbolos, int tamanho) {
            Random aleatorio = new Random();

            //TODO adicionar uma forma de SEMPRE ter um numero uma letra e um simbolo caso o usuário peça
            string todasAsLetras = "abcdefghijklmnopqrstuvwxyz";
            string todosOsNumeros = "0123456789";
            string todosOsSimbolos = "!@#$%&*?";

            string baseParaSenha = "";
            string senhaGerada = "";

            if (letras) {
                baseParaSenha += todasAsLetras;
            }
            if (numeros) {
                baseParaSenha += todosOsNumeros;
            }
            if (simbolos) {
                baseParaSenha += todosOsSimbolos;
            }

            for (int i=0; i<tamanho; i++) {
                senhaGerada += baseParaSenha[aleatorio.Next(baseParaSenha.Length)];
            }

            return $"{senhaGerada}";
        }
    }
}
