using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace AtividadeEncontroRemoto02
{
    class Program
    {
        static List<Pessoa> pessoas;
        static List<Endereco> enderecos;

        static void Main(string[] args)
        {   

            List<PessoaFisica> listapf = new List<PessoaFisica>(); 
            List<PessoaJuridica> listapj = new List<PessoaJuridica>();

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
                Thread.Sleep(800);
                Console.Clear();
                Console.WriteLine($@"
=============================================
|           SELECIONE AS OPÇÕES             |
|                                           |
|  --------- PESSOA FISICA --------------   |
|  1 - Cadastrar Pessoa Fisica              |
|  2 - Listar Pessoa Fisica                 |
|  3 - Remover Pessoa Fisica                |
|                                           |
|  --------- PESSOA JURIDICA ------------   |
|  4 - Cadastrar Pessoa Juridica            |
|  5 - Listar Pessoa Juridica               |
|  6 - Remover Pessoa Juridica              |                                      
|                                           |
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

                       
                        // // Lista verificador de meses
                        // List<int> d31 = new List<int> {1, 3, 5, 7, 8, 10, 12};
                        // List<int> d30 = new List<int> {4, 6, 9, 11};

                        
                        // Console.WriteLine($"Bem vindo ao sistema de cadastramento de pessoas fisicas ");
                        // Thread.Sleep(500);
                                               
                        // Digitando Nome
                        Console.WriteLine($"Digite o nome..");
                        pf.nome = Console.ReadLine();

                        // // $$$$$$$$$$$ FORMA 01 DE ESCREVER ARQUIVO $$$$$$$$$$$$//

                        // // Streamwriter serve para escrever no arquivo, deve-se chamar a biblioteca System.IO
                        // StreamWriter sw = new StreamWriter($"{pf.nome}.txt"); // Criando o arquivo, neste caso dando o nome do arquivo com o nome da pessoa digitada
                        // // Como não se indicou nenhum caminho, ele irá criar o arquivo na raiz do projeto.
                        // sw.Write(pf.nome); // escrevendo dentro do arquivo
                        // sw.Close(); // Fecha-se o arquivo para que ele não crie varias versões do mesmo conteudo, quando abre deve-se fecha-lo
                        
                        // $$$$$$$$$$$ FORMA 02 DE ESCREVER ARQUIVO $$$$$$$$$$$$//
                        // desta forma evita-se o uso do sw.Close();
                        
                        using (StreamWriter sw = new StreamWriter($"{pf.nome}.txt"))
                        {
                            sw.Write(pf.nome);
                        }

                        // Para leitura do arquivo
                        using (StreamReader sr = new StreamReader($"{pf.nome}.txt"))
                        {
                            // Verificando se tem alguma estrutra na linha do arquivo, verificando se esta vazio
                            string linha;

                            while((linha = sr.ReadLine()) != null) // Lendo cada linha e armazenando na variavel linha, caso haja algum conteudo irá mostrar, Readline ele lê linha por linha.
                            {
                                Console.WriteLine($"{linha}");                            
                            }
                             
                        }

                        // // Digitando CPF
                        // do{
                        //     iniciocpf:
                        //     Console.WriteLine($"Digite o CPF..");
                        //     pf.CPF = Console.ReadLine();

                        //     PessoaFisica cpfrepetido = listapf.Find(cadaitem => cadaitem.CPF == pf.CPF);

                        //     if (cpfrepetido == null){
                        //         Console.WriteLine($"CPF cadastrado com sucesso");
                        //     } else {
                        //         Console.WriteLine($"CPF ja cadastrado");
                        //         goto iniciocpf;
                        //     }
                                                                    
                        // //FAZER VALIDACAO CPF//                        
                        // } while (pf.CPF.Length != 11);

                        // // Digitando Data com validações                        
                        // Console.WriteLine($"Digite a Data de Nascimento Dia, Mes e Ano");
                        // int dia, mes, ano;
                        // // Validando Mês 
                        // do {
                        //     Console.WriteLine($"Mês de Nascimento?");
                        //     mes = Convert.ToInt32(Console.ReadLine());
                        // } while (mes <= 0 || mes > 12);

                        // // Validando ano de 1900 até ano de hoje //
                        // do {
                        //     Console.WriteLine($"Ano ?");
                        //     ano = Convert.ToInt32(Console.ReadLine());
                        // } while (ano < 1900 || ano > DateTime.Now.Year);
                        
                        // // Validando o dia de nascimento de acordo com o mes, incluindo ano bisexto
                        // bool validadordia = true;

                        // do {
                        //     Console.WriteLine($"Dia ?");
                        //     dia = Convert.ToInt32(Console.ReadLine());
                            
                        //     if (d31.Contains(mes)){
                        //         if (dia < 1 || dia > 31){
                        //             validadordia = false;
                        //         } else validadordia = true;
                        //     }
                            
                        //     if (d30.Contains(mes)){
                        //         if (dia < 1 || dia > 30){
                        //             validadordia = false;
                        //         } else validadordia = true;
                        //     }

                        //     if (mes == 2){
                        //         if (DateTime.IsLeapYear(ano) == true){
                        //             if (dia < 1 || dia > 29){
                        //                 validadordia = false;
                        //             }else validadordia=true;
                        //         }
                        //         if (DateTime.IsLeapYear(ano) == false){
                        //             if (dia < 1 || dia > 28){
                        //             validadordia = false;
                        //             }else validadordia=true; 
                        //         }
                        //     }

                        // } while(validadordia == false);

                        // pf.DataNascimento = new DateTime(ano, mes, dia);

                        // // Verificador de Idade da PF cadastrada //
                        // if (pfverificador.ValidarDataNascimento(pf.DataNascimento) == true)
                        // {
                        //     Console.WriteLine($"Cadastro Aprovado - Maior de Idade");

                        //     /// CADASTRANDO ENDERECO DA PESSOA FISICA
                        //     Console.WriteLine($"Digite o Logradouro..");
                        //     end.logradouro = Console.ReadLine();

                        //     Console.WriteLine($"Digite o numero..");
                        //     end.numero = Convert.ToInt32(Console.ReadLine());

                        //     Console.WriteLine($"Digite o Complemento..(Aperte ENTER para vazio)");                        
                        //     end.complemento = Console.ReadLine();

                        //     Console.WriteLine($"O Endereço é Comercial S/N?");
                        //     string endcomercial = Console.ReadLine().ToUpper();

                        //     // Validacao para endereco comercial

                        //     while ((endcomercial.ToUpper() != "S") && (endcomercial.ToUpper() != "N")){
                        //         Console.WriteLine($"Digite Corretamente se o endereço é comercial S ou N");
                        //         endcomercial = Console.ReadLine();
                        //     }
                        //     if (endcomercial == "S"){
                        //         end.EnderecoRJ = true;
                        //     } else {
                        //         end.EnderecoRJ = false;
                        //     }

                        //     pf.endereco = end;  // Passando um objeto inteiro para dentro do pf.endereco

                        //     Console.WriteLine($"Qual o valor da renda desta pessoa ?");
                        //     pf.rendimento = Decimal.Parse(Console.ReadLine());
                        //     listapf.Add(pf);
                        //     Console.Clear();

                        //     string opcaoimposto;    
                                
                        //     validacaoimposto:

                        //     Console.WriteLine("Deseja calcular o imposto a ser tributado desta pessoa ?");
                        //     Console.WriteLine($"Sim ou Não?");

                        //     opcaoimposto = Console.ReadLine();

                            
                        //     if (opcaoimposto.ToUpper() == "SIM")
                        //     {

                        //         /*
                        //         Console.WriteLine("Nome: {0} - CPF: {1} - Data de Nascimento: {2}. ", pf.nome, pf.CPF, pf.DataNascimento);                        
                        //         Console.WriteLine("Rua: " + pf.endereco.logradouro + " Numero: " + pf.endereco.numero + " Complemento: " + pf.endereco.complemento);
                        //         */
                        //         pfverificador.PagarImposto(pf.rendimento);                                                                  

                        //     }  else if ((opcaoimposto.ToUpper() == "NAO") || (opcaoimposto.ToUpper() == "NÃO")) {
                        //         Console.WriteLine($"Imposto não será calculado");
                        //         /*
                        //         Console.WriteLine("Nome: {0} - CPF: {1} - Data de Nascimento: {2}. ", pf.nome, pf.CPF, pf.DataNascimento);                        
                        //         Console.WriteLine("Rua: " + pf.endereco.logradouro + " Numero: " + pf.endereco.numero + " Complemento: " + pf.endereco.complemento);
                        //         */                                
                        //     } else 
                        //     {
                        //         Console.WriteLine("Opcao digitada para calculo de imposto inválida");
                        //         goto validacaoimposto;                                    
                        //     }                                                    
                        // } else

                        // {
                        //     Console.WriteLine($"Menor de Idade - Cadastro Reprovado");
                            
                        // }                   
                            
                        
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

                        PessoaFisica verificador = new PessoaFisica();

                        Console.WriteLine($"Bem vindo a lista de clientes \n");
                        
                        
                        foreach (PessoaFisica cadaitem  in listapf) // por padrao cria como var, como é uso local pode-se usa-lo ou pode-se usar o tipo do objeto
                        {
                            Console.WriteLine($"");                            
                            Console.WriteLine($"Nome: {cadaitem.nome} CPF: {cadaitem.CPF} Data de Nascimento: {cadaitem.DataNascimento}");
                            Console.WriteLine($"Rua: {cadaitem.endereco.logradouro} Numero: {cadaitem.endereco.numero} Complemento: {cadaitem.endereco.complemento}");
                            if (cadaitem.endereco.EnderecoRJ == true){
                                Console.WriteLine($"Endereço Comercial"); 
                            } else Console.WriteLine($"Endereço Residencial");
                            verificador.PagarImposto(cadaitem.rendimento);
                            Console.WriteLine($"-----------------------------------\n");
                              
                        }

                        Thread.Sleep(1200);

                        break;

                        
                    case "3":

                        Console.WriteLine($"Digite o CPF que deseja remover do sistema");
                        string cpfprocurado = Console.ReadLine();
                                             
                        PessoaFisica pessoaEncontrada = listapf.Find(cadaitem => cadaitem.CPF == cpfprocurado); // For each com IF, armazenando o retorno disso na variavel e se nao tiver ninguem não se faz nenhuma remocao

                        if (pessoaEncontrada != null){
                            listapf.Remove(pessoaEncontrada);
                            Console.WriteLine($"Cadastro Removido");
                            
                        } else {
                            Console.WriteLine($"CPF não encontrado");                            
                        }
                        
            
                    break;

            
                    case "4":

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

                            Console.WriteLine($"Digite o nome da empresa");
                            pj1.nome = Console.ReadLine();

                            Console.WriteLine($"Digite a Razão Social");
                            pj1.RazaoSocial = Console.ReadLine();                         
                            
                            Console.WriteLine("Deseja calcular o imposto a ser tributado deste CNPJ ? Sim ou Não? ");

                                string opcaoimposto = Console.ReadLine();

                                if (opcaoimposto.ToUpper() == "SIM")
                                {
                                    Console.WriteLine($"Qual o valor da renda desta empresa ?");
                                    pj1.rendimento = Decimal.Parse(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("CNPJ: {0}", pj1.CNPJ);  
                                    pj1.PagarImposto(pj1.rendimento);
    
                                }  else if ((opcaoimposto.ToUpper() == "NAO") || (opcaoimposto.ToUpper() == "NÃO")) {                               
                                    Console.WriteLine($"Imposto não será calculado");
                                    Thread.Sleep(1000);
                                    Console.Clear();     

                                } else if ((opcaoimposto.ToUpper() != "NAO") || (opcaoimposto.ToUpper() != "NÃO") || (opcaoimposto.ToUpper() == "SIM"))
                                {
                                    Console.WriteLine("Opcao digitada para calculo de imposto inválida");                                    
                                }

                                // Adicionando a lista e verificando se o arquivo existe e depois fazendo a insercao no arquivo CSV
                                 listapj.Add(pj1);
                                 pjverificador.VerificarArquivo(pjverificador.caminho);
                                 pjverificador.Inserir(pj1);  

                        } 
                        
                        else
                        {
                            Console.WriteLine("Validação Incorreta - os 04 antepenultimos numeros devem ser 0001");
                            goto iniciopj;                                
                        }



                        break;

                    

                    case "5":

                        Console.Clear();
                              
                        PessoaJuridica verificadorpj = new PessoaJuridica();

                        if (verificadorpj.Ler().Count > 0) // No caso do arquivo CSV estar vazio, ele não retorna Null, então uma opcao seria verificar se ele é maior que 0 contando as linhas, se for entra no laço
                        {
                            foreach (var item in verificadorpj.Ler())
                            { 
                                Console.WriteLine($"Nome: {item.nome} - Razao Social: {item.RazaoSocial} - CNPJ: {item.CNPJ}");                                                                        
                            }                            
                        } else
                        {
                            Console.WriteLine($"Lista vazia");                            
                        }                        

                    break;


                    case "6":

                        Console.WriteLine($"Digite o CNPJ que deseja remover do sistema");
                        string cnpjprocurado = Console.ReadLine();
                                             
                        PessoaJuridica cnpjencontrado = listapj.Find(cadaitem => cadaitem.CNPJ == cnpjprocurado); // For each com IF, armazenando o retorno disso na variavel e se nao tiver ninguem não se faz nenhuma remocao

                        if (cnpjencontrado != null){
                            listapj.Remove(cnpjencontrado);
                            Console.WriteLine($"Cadastro Removido");
                            
                        } else {
                            Console.WriteLine($"CNPJ não encontrado");                            
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
