using System;

namespace AtividadeEncontroRemoto02
{
    public abstract class Pessoa
    {
        public string nome {get; set;}

        public Endereco endereco {get; set;} // Isso seria um exemplo de composição, onde compomos todas as caracteristicas do Endereco para a classe pessoa, e consequentemente os herdeiros desta.

        public float ImpostoAPagar {get; set;}

        public abstract void PagarImposto(decimal valor); //não há implementação

    }

}