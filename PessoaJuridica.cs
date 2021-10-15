using System;

namespace AtividadeEncontroRemoto02
{
    class PessoaJuridica : Pessoa    
    {
        private int IdPJ {get; set;}

        private int CNPJ {get; set;}

        private string RazaoSocial {get; set;}

        public override void PagarImposto(decimal valor)
        {
            
        }
    
    }

}
