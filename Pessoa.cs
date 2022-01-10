using System;
using System.IO;

namespace AtividadeEncontroRemoto02
{
    public abstract class Pessoa
    {
        public string nome {get; set;}

        public Endereco endereco {get; set;} // Isso seria um exemplo de composição, onde compomos todas as caracteristicas do Endereco para a classe pessoa, e consequentemente os herdeiros desta.

        public abstract void PagarImposto(decimal valor); //não há implementação

        public void VerificarArquivo(string caminho){
            // Precisa de fazer duas verificacoes se a pasta existe e se o arquivo existe, na propria string ja vai vir as duas informações
            // para facilitar vamos cria-las diretamente nas classes PessoaJuridica e Fisica -- public string caminho {get; private set;} = "Database/PessoaJuridica.csv";

            // criando variavel para obter somente o nome da pasta, separando ela da extensão etc 
            string pasta = caminho.Split("/")[0];  //Neste caso, ele vai pegar tudo na posicao [0] que tem antes da primeira /, exemplo: Database/PessoaJuridica.csv ele retorna o Database

            // biblioteca System.IO

            if (!Directory.Exists(pasta))
            { // por padrão a logica do if retorna true, se quiser pode por == true ou false, mas não precisa, se quiser inverter para retornar um false, usa-se o !Directory.Exists(pasta) e igual a ==false
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho)){
                File.Create(caminho);
            }


            
            
        }

    }

}