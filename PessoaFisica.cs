using System;

namespace AtividadeEncontroRemoto02
{
    class PessoaFisica : Pessoa {
        
        private int Idfisica {get; set;}

        private int CPF {get; set;}

        private string DataNascimento {get; set;}

        public override void PagarImposto(decimal valor)
        {
        
        }
    }

}
