using System;

namespace AtividadeEncontroRemoto02
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pfverificador = new PessoaFisica(); // Este será utilizado apenas para instaciar o seu metodo ValidadorddData

            PessoaFisica pf = new PessoaFisica(); // método construtor, instanciando objeto
            Endereco end = new Endereco();  // instanciando o objeto end, novo endereco

            end.logradouro = "Rua X";
            end.numero = 56;
            end.complemento = "Casa";
            end.EnderecoRJ = false;

            pf.endereco = end;  // Passando um objeto inteiro para dentro do pf.endereco
            pf.CPF = 12343214;
            pf.nome = "Lucas";
            pf.DataNascimento = new DateTime(2000, 06, 15);

            // 1º forma de mostra-los
            //Console.WriteLine(pf.endereco.logradouro);       
            //Console.WriteLine(pf.endereco.numero);       
            //Console.WriteLine(pf.endereco.complemento);  

            // 2º Forma - Ou concatenando para usar neste caso, o çifrão é necessário
            //Console.WriteLine($"Rua: {pf.endereco.logradouro}, {pf.endereco.numero}, {pf.endereco.complemento} ");

            // 3º Forma - Ou 
            Console.WriteLine("Rua: " + pf.endereco.logradouro + " Numero: " + pf.endereco.numero + " Complemento: " + pf.endereco.complemento);

            // 4º Forma - Ou, desta forma ele considera os espaços da margem esquerda, para remove-los basta "encostar" as linhas a esquerda do console.
            //Console.WriteLine($@"
            //Rua: {pf.endereco.logradouro}, 
            //{pf.endereco.numero}");
            
            if (pfverificador.ValidarDataNascimento(pf.DataNascimento) == true)
            {
                Console.WriteLine($"Cadastro Aprovado");
                
            } else
             
            {
                Console.WriteLine($"Menor de Idade - Cadastro Reprovado");
                
            }
            
            Console.WriteLine(pfverificador.ValidarDataNascimento(pf.DataNascimento)); 
            // Neste caso estamos utilizando um outro objeto para verificar e validar a data de nascimento de outro objeto, boas praticas, pois..
            // em API pode dar um erro onde o mesmo objeto criado tem um verificador dele mesmo.     
  
                 


            
        }
    }
}
