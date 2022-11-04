string[,] matriz = {
    {"Qual a capital de Santa Catarina?",                      "Blumenau",         "Florianópolis",         "Joinville",        "Florianópolis"},
    {"Nome dado ao conjunto de ossos?",                        "Grayskull",        "Ossada",                "Esqueleto",        "Esqueleto"},
    {"Quanto é: 2 X 4 + 8?",                                   "18",               "16",                    "24",               "16"},
    {"Capital do estado do Paraná?",                           "Curitiba",         "Londrina",              "Maringá",          "Curitiba"},
    {"Qual a capital da Turquia?",                             "Istambul",         "Ancara",                "Esmirna",          "Ancara"},
    {"Cidade onde concentra o maior número de pessoas",        "Tóquio",           "Nova Iorque",           "Pequim",           "Tóquio"},
    {"Qual o idioma mais falado no mundo?",                    "Inglês",           "Mandarim",              "Espanhol",         "Inglês"},
    {"O que é uma pessoa chitosa?",                            "Rude",             "Brincalhona",           "Raivosa",          "Brincalhona"},
    {"O que é Eflúvio",                                        "Um som",           "Um sabor",              "Um aroma",         "Um aroma"},
    {"O que é uma pessoa loquaz?",                             "Fala muito",       "Fala pouco",            "Gaga",             "Fala muito"},
    {"Quando ocorreu a segunda guerra mundial?",               "1939 - 1944",      "1938 - 1944",           "1940 - 1944",      "1939 - 1944"},
    {"De onde é a invenção do chuveiro elétrico?",             "França",           "Brasil",                "Inglaterra",       "Brasil"},
    {"Qual o menor país do mundo?",                           "Vaticano",         "Nauru",                 "Mônaco",           "Vaticano"},
    {"Qual o maior país do mundo?",                           "China",            "Rússia",                "Canadá",           "Rússia"},
    {"Após a Bíblia, qual é o livro mais vendido?",            "Dom Quixote",      "O Pequeno Príncipe",    "Senhor dos anéis", "Dom Quixote"},
    {"Quantos elementos possui a tabela periódica?",           "113",              "109",                   "118",              "118"},
    {"País com a maior expectativa de vida do mundo",          "Austrália",        "Japão",                 "Suécia",           "Japão"},
    {"Quanto tempo a luz do Sol demora para chegar à Terra?",  "12 minutos",       "3 minutos",             "8 minutos",        "8 minutos"},
    {"Qual a montanha mais alta do Brasil?",                   "Pico da Bandeira", "Pico Paraná",           "Pico da Neblina",  "Pico da Neblina"},
    {"Em qual local da Ásia o português é língua oficial?",    "Índia",            "Moçambique",            "Macau",            "Macau"},
    {"Qual destes países é transcontinental?",                 "Rússia",           "Estados Unidos",        "Marrocos",         "Rússia"},
    {"Qual o maior animal terrestre?",                         "Baleia Azul",      "Elefante africano",     "Girafa",           "Elefante africano"},
    {"Com que dois países faz fronteira o Equador?",           "Brasil e Colômbia","Colômbia e Venezuela",  "Colômbia e Peru",  "Colômbia e Peru"},
    {"Que animal gruguleja?",                                  "Pavão",            "Peru",                  "Garça",            "Garça"},
    {"Qual é o maior arquipélago da Terra?",                   "Filipinas",        "Indonésia",             "Maldivas",         "Indonésia"},
    {"Em que oceano fica Madagascar?",                         "Oceano Índico",    "Oceano Atlântico",      "Oceano Pacífico",  "Oceano Índico"},
    {"Qual o metal cujo símbolo químico é o Au?",              "Cobre",            "Ouro",                  "Prata",            "Ouro"},
    {"Quem pintou o teto da capela sistina?",                  "Michelangelo",     "Leonardo da Vinci",     "Donatello",        "Michelangelo"},
    {"O que é filantropo?",                                    "Pessoa egoísta",   "Pessoa caridosa",       "Um poema",         "Pessoa caridosa"},
    {"Qual a população do Brasil?",                            "220 milhões",      "200 milhões",           "212 milhões",      "212 milhões"}
};

string[,] jogadores = new string[50, 4];

// Nome, acertos, pular questões usados, eliminar alternativas usados

int[] perguntasFeitas = new int[15];

bool jogar = true;
bool repetir = true;
bool usadoEliminarPergunta = false;
bool nomeJaUsado = false;

Random random = new Random();

int perguntas = 0;
int indiceJogador = 0;
int indicePerguntas = 0;
int eliminadas = -1;

do
{
    //Validando nome dos jogadores
    while (repetir)
    {
        Console.WriteLine("Insira o nome do jogador");
        string nome = Console.ReadLine();

        nomeJaUsado = false;

        for (int i = 0; i < jogadores.GetLength(0); i++)
        {
            if (jogadores[i, 0] == nome)
            {
                Console.Clear();
                Console.WriteLine("O nome do jogador não pode ser repetido!");
                repetir = true;
                nomeJaUsado = true;
                break;
            }
        }

        if (nomeJaUsado == false)
        {
            jogadores[indiceJogador, 0] = nome;
            jogadores[indiceJogador, 1] = "0";
            repetir = false;
        }

    }
    repetir = true;

    //Fazer as perguntas
    while (perguntas < 11)
    {
        int perguntaSorteada = random.Next(0, 30);

        bool perguntaRepetida = false;

        //Verifica se a pergunta já foi feita
        for (int i = 0; i < perguntasFeitas.GetLength(0); i++)
        {
            if (perguntaSorteada == perguntasFeitas[i])
            {
                perguntaRepetida = true;
            }
        }

        //se não foi feita
        if (perguntaRepetida == false)
        {
            //Adicionamos a pergunta sorteada na lista de perguntas já feitas
            perguntasFeitas[indicePerguntas] = perguntaSorteada;
            indicePerguntas++;

            //Mantemos preso na questão caso digite algo inválido
            bool repetirMesmaPergunta = true;

            while (repetirMesmaPergunta)
            {

                //Não mostrar caso use a opção de eliminar questões
                if (usadoEliminarPergunta == false)
                {

                    Console.WriteLine("Pergunta " + perguntas);
                    Console.WriteLine();
                    Console.WriteLine(matriz[perguntaSorteada, 0]);
                    Console.WriteLine(" 1 - " + matriz[perguntaSorteada, 1]);
                    Console.WriteLine(" 2 - " + matriz[perguntaSorteada, 2]);
                    Console.WriteLine(" 3 - " + matriz[perguntaSorteada, 3]);
                    Console.WriteLine(" 4 - Pular pergunta, 5 - Eliminar alternativas");
                }
                else
                {

                    //Exibe de acordo com a quantidade de respostas inválidas eliminadas
                    //Também é prevenção para caso tenha resposta inválida depois de pedir para eliminar alternativas

                    int erradasImpressas = 0;

                    switch (eliminadas)
                    {
                        case 0:
                            Console.WriteLine(eliminadas + " Questões eliminadas.");
                            Console.WriteLine();
                            Console.WriteLine("Pergunta " + perguntas);
                            Console.WriteLine();
                            Console.WriteLine(matriz[perguntaSorteada, 0]);

                            Console.WriteLine(" 1 - " + matriz[perguntaSorteada, 1]);
                            Console.WriteLine(" 2 - " + matriz[perguntaSorteada, 2]);
                            Console.WriteLine(" 3 - " + matriz[perguntaSorteada, 3]);
                            Console.WriteLine(" 4 - Pular pergunta, 5 - Eliminar alternativas");
                            break;
                        case 1:

                            Console.WriteLine(eliminadas + " Questões eliminadas.");
                            Console.WriteLine();
                            Console.WriteLine("Pergunta " + perguntas);
                            Console.WriteLine();
                            Console.WriteLine(matriz[perguntaSorteada, 0]);


                            for(int i = 1; i < 4; i++)
                            {
                                //Imprime a correta
                                if (matriz[perguntaSorteada, i] == matriz[perguntaSorteada, 4])
                                {
                                    Console.WriteLine(" " + i + " - " + matriz[perguntaSorteada, i]);
                                }
                                else
                                {
                                    //Caso seja eliminada uma, imprime apenas uma
                                    if (matriz[perguntaSorteada, i] != matriz[perguntaSorteada, 4] && erradasImpressas < 1)
                                    {
                                        Console.WriteLine(" " + i + " - " + matriz[perguntaSorteada, i]);
                                        erradasImpressas++;
                                    }
                                }

                            }
                            Console.WriteLine(" 4 - Pular pergunta, 5 - Eliminar alternativas");


                            break;
                        case 2:
                            Console.WriteLine(eliminadas + " Questões eliminadas.");
                            Console.WriteLine();
                            Console.WriteLine("Pergunta " + perguntas);
                            Console.WriteLine();
                            Console.WriteLine(matriz[perguntaSorteada, 0]);


                            for (int i = 1; i < 4; i++)
                            {
                                //Eliminadas as duas, imprime-se somente a correta
                                if (matriz[perguntaSorteada, i] == matriz[perguntaSorteada, 4])
                                {
                                    Console.WriteLine(" " + i + " - " + matriz[perguntaSorteada, i]);
                                }

                            }
                            Console.WriteLine(" 4 - Pular pergunta, 5 - Eliminar alternativas");
                            break;
                    }
                    usadoEliminarPergunta = false;
                } 

                try
                {
                    int resposta = Convert.ToInt32(Console.ReadLine());

                    //Casos para cada resposta
                    switch (resposta)
                    {
                        case 1:
                            if (matriz[perguntaSorteada, 1] == matriz[perguntaSorteada, 4])
                            {
                                Console.Clear();
                                Console.WriteLine("Você acertou a questão!");
                                Console.WriteLine();

                                int acertos = Convert.ToInt32(jogadores[indiceJogador, 1]) + 1;
                                jogadores[indiceJogador, 1] = acertos.ToString();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Você errou a questão!");
                                Console.WriteLine();
                            }

                            perguntas++;
                            repetirMesmaPergunta = false;
                            break;

                        case 2:
                            if (matriz[perguntaSorteada, 2] == matriz[perguntaSorteada, 4])
                            {
                                Console.Clear();
                                Console.WriteLine("Você acertou a questão!");
                                Console.WriteLine();

                                int acertos = Convert.ToInt32(jogadores[indiceJogador, 1]) + 1;
                                jogadores[indiceJogador, 1] = acertos.ToString();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Você errou a questão!");
                                Console.WriteLine();
                            }

                            perguntas++;
                            repetirMesmaPergunta = false;

                            break;

                        case 3:
                            if (matriz[perguntaSorteada, 3] == matriz[perguntaSorteada, 4])
                            {
                                Console.Clear();
                                Console.WriteLine("Você acertou a questão!");
                                Console.WriteLine();

                                int acertos = Convert.ToInt32(jogadores[indiceJogador, 1]) + 1;
                                jogadores[indiceJogador, 1] = acertos.ToString();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Você errou a questão!");
                                Console.WriteLine();
                            }

                            perguntas++;
                            repetirMesmaPergunta = false;

                            break;

                        case 4:

                            //Pula questão
                            if (Convert.ToInt32(jogadores[indiceJogador, 2]) == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Você não pode pular a questão!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Questão pulada.");
                                Console.WriteLine();
                                repetirMesmaPergunta = false;
                                jogadores[indiceJogador, 2] = Convert.ToString(Convert.ToInt32(jogadores[indiceJogador, 2]) + 1);
                            }
                            break;

                        case 5:

                            //Elimina alternativas
                            if (Convert.ToInt32(jogadores[indiceJogador, 3]) == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Você não pode eliminar a questão!");
                                Console.WriteLine();
                            }
                            else
                            {
                                eliminadas = random.Next(0, 3);

                                repetirMesmaPergunta = true;
                                usadoEliminarPergunta = true;

                                jogadores[indiceJogador, 3] = Convert.ToString(Convert.ToInt32(jogadores[indiceJogador, 3]) + 1);
                                Console.Clear();
                            }
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Insira apenas números de 1 a 5!");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas números");
                    Console.WriteLine();

                    repetirMesmaPergunta = true;

                    if(eliminadas != -1)
                    {
                        usadoEliminarPergunta = true;
                    }
                }
            }
        }
    }
    perguntas = 0;


    //Verificando se mais um jogador vai jogar
    while (repetir)
    {
        try
        {
            Console.WriteLine("Você acertou " + jogadores[indiceJogador, 1] + " Perguntas");
            Console.WriteLine("Jogar novamente? 1 - Sim, 2 - Não");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 2)
            {
                jogar = false;
            }

            repetir = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Insira apenas números");
        }
    }

    repetir = true;

    //Trocando o id do jogador e limpando a tela
    indiceJogador++;
    Console.Clear();


    //Limpando a lista de perguntas já feitas e o seu índice
    for (int i = 0; i < perguntasFeitas.GetLength(0); i++)
    {
        perguntasFeitas[i] = -1;
    }
    indicePerguntas = 0;

}
while (jogar);


//Ordenar os valores ORDEM DECRESCENTE
for (int i = 0; i < jogadores.GetLength(0); i++)
{
    for (int j = 0; j < jogadores.GetLength(0); j++)
    {
        if (Convert.ToInt32(jogadores[i, 1]) > Convert.ToInt32(jogadores[j, 1]))
        {
            int temp = Convert.ToInt32(jogadores[j, 1]);
            jogadores[j, 1] = jogadores[i, 1];
            jogadores[i, 1] = temp.ToString();

            string tempStr = jogadores[j, 0];
            jogadores[j, 0] = jogadores[i, 0];
            jogadores[i, 0] = tempStr;
        }
    }
}


//Exibir o ranking
Console.Clear();
Console.WriteLine("Ranking:");

for(int i = 0; i < jogadores.GetLength(0); i++)
{
    if (jogadores[i, 0] != null)
    {
        Console.WriteLine("Nome: " + jogadores[i, 0] + ", acertos: " + jogadores[i, 1]);
    }
}