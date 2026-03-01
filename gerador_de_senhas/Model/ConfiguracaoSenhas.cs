using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO fazer essa classe ser a responsável por cuidar das configurações da geração de senha
//Ver como vou usar isso daqui, queria consultar diretamente a classe, porém quando chamo ela não acho os atributos ou metodos
//usar get e set nas propriedades talvez ajude
namespace gerador_de_senhas.Model {
    public class ConfiguracaoSenhas {
        public int tamanhoMinimoSenha = 1;
        public int tamanhoMaximoSenha = 10;

        public bool letrasMinusculas = true;
        public bool letrasMaiusculas = true;
        public bool numeros = true;
        public bool simbolos = true;
        public string listaSimbolos = "!@#$%&*?";
    }
}