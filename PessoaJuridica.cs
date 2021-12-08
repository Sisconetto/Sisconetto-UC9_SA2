using System;

namespace AtividadeEncontroRemoto02
{
    class PessoaJuridica : Pessoa    
    {
        public int IdPJ {get; set;}

        public string CNPJ {get; set;}

        public decimal rendimento {get; set;}

        private string RazaoSocial {get; set;}

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


    
    }

}