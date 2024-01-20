

//INICIO DO PROJETO: preciso das variaveis descrevendo os animais

string especieAnimal = "";
string idAnimal = "";
string idadeAnimal = "";
string descricaoFisicaAnimal = "";
string descricaoPersonalidadeAnimal = "";
string apelidoAnimal = "";
string doacaoSugestao = "";

// variaveis para dados

int maxPet = 6; //quantidade de animais
string? lerResultado; //variavel do tipo anulavel
string selecaoMenu = ""; //variavel de entrada do usuario e saida do loop
decimal donacaoDecimal = 0.00m;

// criar uma matriz para os dados dos animais

string[,] nossoAnimais = new string[maxPet, 7]; //7 caracteristicas 

// criar dados de entrada para o array nossoAnimais

for(int i = 0; i < maxPet; i++)
{
    switch(i)
    {
        case 0:
        especieAnimal = "cao";
        idAnimal = "c1";
        idadeAnimal = "2";
        descricaoFisicaAnimal = "tamanho medio, femea, golden retriveir, pesa 30kg";
        descricaoPersonalidadeAnimal = "amorosa, brincalhona e adora trilhas";
        apelidoAnimal = "lola";
        doacaoSugestao ="85.00";
        break;

        case 1:
        especieAnimal = "cao";
        idAnimal = "c2";
        idadeAnimal = "9";
        descricaoFisicaAnimal = "grande porte, macho, golden retrivier, peos 50kg";
        descricaoPersonalidadeAnimal = "adoravel, manso, inteligente e otimo guarda";
        apelidoAnimal = "gus";
        doacaoSugestao ="49.99";

        break;

        case 2:
        especieAnimal = "gato";
        idAnimal = "g3";
        idadeAnimal = "1";
        descricaoFisicaAnimal = "pequeno porte, jovem femea, pesa 3 kg";
        descricaoPersonalidadeAnimal = "amigavel";
        apelidoAnimal = "neiva";
        doacaoSugestao ="40.00";

        break;

        case 3:
        especieAnimal = "gato";
        idAnimal = "g4";
        idadeAnimal = "3";
        descricaoFisicaAnimal = "tamanho medio, pelagem amarela, macho, 8 kg, acima do peso";
        descricaoPersonalidadeAnimal = "preguiçoso e inteligente, comilão";
        apelidoAnimal = "girfield";
        doacaoSugestao ="";

        break;

        default:
        especieAnimal = "";
        idAnimal = "";
        idadeAnimal = "";
        descricaoFisicaAnimal = "";
        descricaoPersonalidadeAnimal = "";
        apelidoAnimal = "";
        doacaoSugestao ="";

        break;
    }

    nossoAnimais[i, 0] = "ID #: " + idAnimal;
    nossoAnimais[i, 1] = "Especie: " + especieAnimal;
    nossoAnimais[i, 2] = "Idade: " + idadeAnimal;
    nossoAnimais[i, 3] = "Apelido: " + apelidoAnimal;
    nossoAnimais[i, 4] = "Descrição fisica: " + descricaoFisicaAnimal;
    nossoAnimais[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
    
    if(!decimal.TryParse(doacaoSugestao, out donacaoDecimal))
{
    donacaoDecimal = 45.00m;
}nossoAnimais[i, 6] = $"Sugestão para Doação:   {doacaoSugestao:C2}";
}




//Exibir as opções do menu superior

do{
    Console.Clear();

    Console.WriteLine("Bem vindo ao Manhoso PetFriend app. O menu principal com as opções:");
    Console.WriteLine("1. Lista de todas as informações correntes dos Pets");
    Console.WriteLine("2. Exibe todos os cachorros e suas caracteristicas especificas.");
    Console.WriteLine();
    Console.WriteLine("Entre com o numero da sua opção (ou escreva sair para deixar o app)");

    lerResultado = Console.ReadLine();
    if (lerResultado != null)
    {
        selecaoMenu = lerResultado.ToLower();
    }

    //usar o switch-case para processa a seleção do menu
    switch(selecaoMenu)
    {
        case "1":
        //lista todas info dos pest
        for(int i = 0; i < maxPet; i ++)
        {
            if(nossoAnimais[i, 0] != "ID #: ")
            {
                Console.WriteLine();
                for(int j = 0; j < 6; j++)
                {
                    Console.WriteLine(nossoAnimais[i, j]);
                }
            }
        }
        Console.WriteLine("\n\rAperte Enter para continuar");
        lerResultado = Console.ReadLine();

        break;

        case "2":
        //Exibe todos os cachorros e suas caracteristicas especificas
        string caracteristicasCao = "";

        while(caracteristicasCao == "")
        {
            Console.WriteLine($"\nInsira uma caracteristica desejada do cão para");
            lerResultado = Console.ReadLine();
            if(lerResultado != null)
            {
                caracteristicasCao =lerResultado.ToLower().Trim();
            }
        }

        bool nenhumCaoAchado = true;
        string descricaoCao = "";

        //laço para encontrar o cão
        for(int i = 0; i < maxPet; i++)
        {
            bool achadoCao = true;
            if(nossoAnimais[i, 1].Contains("cao"))
            {
                if(achadoCao == true)
                {
                    descricaoCao = nossoAnimais[i, 4] + "\n" + nossoAnimais[i, 5];

                    if (descricaoCao.Contains(caracteristicasCao))
                    {
                        Console.WriteLine($"\nNosso cao {nossoAnimais[i, 3]} foi encontrado!");
                        Console.WriteLine(descricaoCao);

                        nenhumCaoAchado = false;
                    }
                }
            }
        }

        if(nenhumCaoAchado)
        {
            Console.WriteLine("Nenhum dos nossos ca~es foir achado" + caracteristicasCao);
        }

        Console.WriteLine("\n\rAperte Enter para continuar");
        lerResultado = Console.ReadLine();

        break;

        default:
            break;
    }

}while(selecaoMenu != "sair");
