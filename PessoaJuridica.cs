using System;
using System.Collections.Generic;
using System.IO;

namespace AtividadeEncontroRemoto02
{
    class PessoaJuridica : Pessoa    
    {
        public int IdPJ {get; set;}

        public string CNPJ {get; set;}

        public decimal rendimento {get; set;}

        public string RazaoSocial {get; set;}

        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";

        public bool ValidarCNPJ(string CNPJ)        
        {
            if ((CNPJ.Length != 14) || (CNPJ.Substring(8, 4) != "0001")) // (CNPJ.Substring(8, 4) - o 8 seria a posição inicial e o 4 seriam os proximos digitos a partir da posição inicial
            {
                return false;                
            }

            return true;

        }

        public override void PagarImposto(decimal valor)
        {

            decimal imposto = 0;
            decimal ValorImposto = 0;

            if (valor > 0 && valor <= 5000 )
            {
                imposto = 0.06m;
                ValorImposto = valor - (valor*imposto);
                Console.WriteLine("Valor Renda: R${0}", valor);                
                Console.WriteLine("O valor do imposto a ser descontado de uma renda no valor de R${0} é de {1}%, sendo o valor final de  R${2} ", valor, imposto*100, ValorImposto);
                

            } else if (valor > 5000 && valor <= 10000)
            { 
                imposto = 0.08m;
                ValorImposto = valor - (valor*imposto);

                Console.WriteLine("Valor Renda: R${0}", valor);   
                Console.WriteLine("O valor do imposto a ser descontado de uma renda no valor de R${0} é de {1}%, sendo o valor final de  R${2} ", valor, imposto*100, ValorImposto);

            } else if (valor > 10000)
            {
                imposto = 0.1m;
                ValorImposto = valor - (valor*imposto);

                Console.WriteLine("Valor Renda: R${0}", valor);   
                Console.WriteLine("O valor do imposto a ser descontado de uma renda no valor de R${0} é de {1}%, sendo o valor final de  R${2} ", valor, imposto*100, ValorImposto);
                
            } else
            {
                Console.WriteLine($"Valor digitado incorretamente");
                
            }
        
        }

        //Metodo para preparar os objetos para serem salvos em formatos CSV, transformando em string para serem salvos   
        public string PrepararCSV(PessoaJuridica pj){
            return $"{pj.CNPJ};{pj.nome};{pj.RazaoSocial}";
        }

        public void Inserir(PessoaJuridica pj){
            // neste caso, o metodo para salvar a string no arquivo e um array de string, sendo assim tem que ser tbm um array de string, mesmo que seja salvo em apenas uma linha.

            string[] linhas = {PrepararCSV(pj)};

            File.AppendAllLines(caminho, linhas);    // Vai salvar as linhas que estamos passando dentro do arquivo AppendAllLines(Path/caminho, conteudo a ser salvo);
        }

        //Metodo para ler o arquivo
        public List<PessoaJuridica> Ler()        
        {
            List<PessoaJuridica> listapj = new List<PessoaJuridica>();

            string [] linhas = File.ReadAllLines(caminho); // ele trará as linhas confomre estão descritas no arquivo, ou seja 20069548000133;Lois;Kuco

            // Como estamos trabalhando com orientação a objetos, transformaremos todas as linhas em objetos, neste caso iremos ler uma por uma e usar o metodo split e adiciona-los aos objetos.
            foreach (var cadalinha in linhas){

                string [] atributos = cadalinha.Split(";"); // Separando cada um dos conteudos e salvando em uma linha de string, nome na posicao {0}, e assim por diante..

                PessoaJuridica cadapj = new PessoaJuridica();
                cadapj.CNPJ = atributos[0];
                cadapj.nome = atributos[1];
                cadapj.RazaoSocial = atributos[2];

                listapj.Add(cadapj);

            }

            return listapj;

        }


    
    }

}