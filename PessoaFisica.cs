using System;

namespace AtividadeEncontroRemoto02
{
    class PessoaFisica : Pessoa {
        
        private int Idfisica {get; set;}

        public string CPF {get; set;}
        
        public decimal rendimento {get; set;}

        public decimal impostoApagar {get; set;}

        public DateTime DataNascimento {get; set;}

        public override void PagarImposto(decimal valor)
        {

            decimal imposto = 0;
            decimal ValorImposto = 0;

            if (valor > 0 && valor <= 1500 )
            {
                ValorImposto = valor - (valor*imposto);
                Console.WriteLine("Valor Renda: R${0}", valor);                
                Console.WriteLine("O valor do imposto a ser descontado de uma renda no valor de R${0} é de {1}%, sendo o valor final de  R${2} ", valor, imposto, ValorImposto);
                

            } else if (valor > 1500 && valor <= 5000)
            { 
                imposto = 0.03m;
                ValorImposto = valor - (valor*imposto);

                Console.WriteLine("Valor Renda: R${0}", valor);   
                Console.WriteLine("O valor do imposto a ser descontado de uma renda no valor de R${0} é de {1}%, sendo o valor final de  R${2} ", valor, imposto*100, ValorImposto);

            } else if (valor > 5000)
            {
                imposto = 0.05m;
                ValorImposto = valor - (valor*imposto);

                Console.WriteLine("Valor Renda: R${0}", valor);   
                Console.WriteLine("O valor do imposto a ser descontado de uma renda no valor de R${0} é de {1}%, sendo o valor final de  R${2} ", valor, imposto*100, ValorImposto);
                
            } else
            {
                Console.WriteLine($"Valor digitado incorretamente");
                
            }
        
        }

        public bool ValidarDataNascimento(DateTime DataNasc){

            DateTime DataAtual = DateTime.Today;

            double anos = (DataAtual - DataNasc).TotalDays/365;

            if (anos >= 18){

                return true;
                
            } else {

                return false;
            }

        }

    }

}