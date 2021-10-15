using System;

namespace AtividadeEncontroRemoto02
{
    public abstract class Pessoa
    {
        private string nome {get; set;}

        private string Endereco {get; set;}

        private bool EnderecoRJ {get; set;}

        private float ImpostoAPagar {get; set;}

        public virtual void PagarImposto(decimal valor)
        {
            
        }


    }

}