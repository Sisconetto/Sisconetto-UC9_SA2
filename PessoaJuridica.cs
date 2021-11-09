using System;

namespace AtividadeEncontroRemoto02
{
    class PessoaJuridica : Pessoa    
    {
        public int IdPJ {get; set;}

        public string CNPJ {get; set;}

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

        }


    
    }

}