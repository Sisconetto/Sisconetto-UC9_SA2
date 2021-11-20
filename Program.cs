using System;
using System.IO;
using System.Threading;


namespace AtividadeEncontroRemoto02
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@$" 
=============================================
|                 BEM VINDO                 |
|    SISTEMA DE CADASTRAMENTO DE PESSOAS    |
|           FISICAS E JURIDICAS             |
============================================"); //@ é para printar na tela exatemente como esta aqui no codigo

            Console.Clear();
            Thread.Sleep(3000);

            Console.WriteLine($"Iniciando");
            Thread.Sleep(500);

            for (int x = 0; x <10; x++)
            {
                Console.Write($".");
                Thread.Sleep(500);            
            }

            Thread.Sleep(500);
            Console.Clear();
               
            string opcao;


            do        
            {
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine($@"
=============================================
|           SELECIONE AS OPÇÕES             |
|                                           |
|  1 - PESSOA FISICA                        |
|                                           |
|  2 - PESSOA JURIDICA                      |
|                                           |
|  0 - SAIR                                 |
|                                           |
============================================");

                Console.WriteLine($"Digite a Opcao: ");                
                opcao = Console.ReadLine();
                Console.Clear();
                
                switch(opcao)
                {
                    case "1":                      

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

                        // Verificador de Idade da PF cadastrada //
                        
                        if (pfverificador.ValidarDataNascimento(pf.DataNascimento) == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado");

                                string opcaoimposto;
                            
                                Console.WriteLine("Deseja calcular o imposto a ser tributado desta pessoa ?");
                                Console.WriteLine($"Sim ou Não?");

                                opcaoimposto = Console.ReadLine();

                                if (opcaoimposto.ToUpper() == "SIM")
                                {
                                    Console.WriteLine($"Qual o valor da renda desta pessoa ?");
                                    decimal renda = Decimal.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("Nome: {0} - CPF: {1} - Data de Nascimento: {2}. ", pf.nome, pf.CPF, pf.DataNascimento);                        
                                    Console.WriteLine("Rua: " + pf.endereco.logradouro + " Numero: " + pf.endereco.numero + " Complemento: " + pf.endereco.complemento);
                                    pf.PagarImposto(renda);                                                                        
 
                                }  else if ((opcaoimposto.ToUpper() == "NAO") || (opcaoimposto.ToUpper() == "NÃO")) {
                                    Console.WriteLine($"Imposto não será calculado");
                                    Console.WriteLine("Nome: {0} - CPF: {1} - Data de Nascimento: {2}. ", pf.nome, pf.CPF, pf.DataNascimento);                        
                                    Console.WriteLine("Rua: " + pf.endereco.logradouro + " Numero: " + pf.endereco.numero + " Complemento: " + pf.endereco.complemento);                                
                                } else 
                                {
                                    Console.WriteLine("Opcao digitada para calculo de imposto inválida");                                    
                                }                    
                                                        
                        } else

                        {
                            Console.WriteLine($"Menor de Idade - Cadastro Reprovado");
                            
                        }
                        
                        // Console.WriteLine(pfverificador.ValidarDataNascimento(pf.DataNascimento)); 
                        // Neste caso estamos utilizando um outro objeto para verificar e validar a data de nascimento de outro objeto, boas praticas, pois..
                        // em API pode dar um erro onde o mesmo objeto criado tem um verificador dele mesmo.
                        

                        

                        // 1º forma de mostra-los
                        //Console.WriteLine(pf.endereco.logradouro);       
                        //Console.WriteLine(pf.endereco.numero);       
                        //Console.WriteLine(pf.endereco.complemento);  

                        // 2º Forma - Ou concatenando para usar neste caso, o çifrão é necessário
                        //Console.WriteLine($"Rua: {pf.endereco.logradouro}, {pf.endereco.numero}, {pf.endereco.complemento} ");

                        // 3º Forma - Ou 
                        
                        // Console.WriteLine("Nome: {0} - CPF: {1} - Idade: {2} ");                        
                        // Console.WriteLine("Rua: " + pf.endereco.logradouro + " Numero: " + pf.endereco.numero + " Complemento: " + pf.endereco.complemento);

                        // 4º Forma - Ou, desta forma ele considera os espaços da margem esquerda, para remove-los basta "encostar" as linhas a esquerda do console.
                        //Console.WriteLine($@"
                        //Rua: {pf.endereco.logradouro}, 
                        //{pf.endereco.numero}");



                        
                        break;
                    
                    case "2":

                        // ################################# ATIVIDADE ONLINE 04 ############################################ //
                        // Criar classe filha de pessoa juridica com CNPJ e razao social e somente permitir o cadastro com 14 numeros
                        // sendo os 04 antepenultimos numeros 0001. Caso forem diferentes enviar mensagem de erro.

                        PessoaJuridica pjverificador = new PessoaJuridica();
                        PessoaJuridica pj1 = new PessoaJuridica();

                        iniciopj:

                        Console.WriteLine($"Digite o numero do CNPJ (14 digitos)");
                        pj1.CNPJ = Console.ReadLine();
                            
                        while (pj1.CNPJ.Length != 14)
                        {
                            Console.WriteLine($"Digite o numero do CNPJ corretamente - (14 digitos)");
                            pj1.CNPJ = Console.ReadLine();
                        }

                        if (pjverificador.ValidarCNPJ(pj1.CNPJ) == true)
                        {
                            Console.WriteLine($"Validação Correta - Cadastro realizado");   
                            Console.WriteLine("Deseja calcular o imposto a ser tributado deste CNPJ ? Sim ou Não? ");

                                string opcaoimposto = Console.ReadLine();

                                if (opcaoimposto.ToUpper() == "SIM")
                                {
                                    Console.WriteLine($"Qual o valor da renda desta empresa ?");
                                    decimal renda = Decimal.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("CNPJ: {0}", pj1.CNPJ);  
                                    pj1.PagarImposto(renda);
    
                                }  else if ((opcaoimposto.ToUpper() == "NAO") || (opcaoimposto.ToUpper() == "NÃO")) {
                                    Console.WriteLine("CNPJ: {0}", pj1.CNPJ);                                
                                    Console.WriteLine($"Imposto não será calculado");     

                                } else 
                                {
                                    Console.WriteLine("Opcao digitada para calculo de imposto inválida");                                    
                                }     
                                
                        } 
                        
                        else
                        {
                            Console.WriteLine("Validação Incorreta - os 04 antepenultimos numeros devem ser 0001");
                            goto iniciopj;                                
                        }

                        break;

                    case "0":
                        Console.Clear();
                        Console.ResetColor();

                        Thread.Sleep(500);

                        Console.WriteLine($"Encerrando o programa");
                        

                        for (int x=0;x<10;x++)
                        {
                            Console.Write(".");
                            Thread.Sleep(500);
                        }
                        break; 

                    default:                      
                        Console.WriteLine($"Opção digitada incorretamente");
                        Console.WriteLine($"Refaça a operação");
                        Thread.Sleep(1000);                        
                        Console.Clear();  
                        
                        break;                     

                     
            }

        } while (opcao != "0");   
            
        }
    }
}
