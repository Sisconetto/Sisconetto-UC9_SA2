using System;

namespace AtividadeEncontroRemoto02
{
    class PessoaFisica : Pessoa {
        
        private int Idfisica {get; set;}

        public int CPF {get; set;}

        public DateTime DataNascimento {get; set;}

        public override void PagarImposto(decimal valor)
        {
        
        }

        public bool ValidarDataNascimento(DateTime DataNasc){

            DateTime DataAtual = DateTime.Today;

            double anos = (DataAtual - DataNascimento).TotalDays/365;

            if (anos >= 18){

                return true;
                
            } else {

                return false;
            }

        }

    }

}