using System;
using System.Threading;
using AULA_UC9.Classes;

string? opcao;

do
{
    Console.Clear();

    Console.WriteLine(@"
        1- Cadastrar PJ
        0- Sair
    ");

    opcao = Console.ReadLine();

    PessoaJuridica metodosPj = new PessoaJuridica();

    if (opcao == "1") 
    {
        PessoaJuridica pj = new PessoaJuridica();

        Console.WriteLine("Digite o nome da PJ: ");
        pj.Nome = Console.ReadLine();

        Console.WriteLine("Digite o rendimento da PJ: ");
        pj.Rendimento = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o CNPJ da PJ: ");
        pj.Cnpj = Console.ReadLine();
    
    Console.WriteLine("-------- Pessoa Jurídica ---------");
    Console.WriteLine("Nome ..........: " + pj.Nome);
    Console.WriteLine("Rendimento ....: " + pj.Rendimento);
    Console.WriteLine("CNPJ ..........: " + pj.Cnpj);
    metodosPj.Inserir(pj);

    // Espera o usuário pressionar uma tecla antes de continuar
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
    
    }
    else if (opcao == "0")
    {
        Console.WriteLine("Obrigado por utilizar nosso sistema!:)");

        // Espera o usuário pressionar uma tecla antes de sair
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
    }
    else 
    {
        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente");

        // Espera o usuário pressionar uma tecla antes de sair
                Console.ReadKey();
    }

} while (opcao != "0");