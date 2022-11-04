DateTime[] matriz = new DateTime[0];

//DANDO ERRO COM A DECLARAÇÃO /\

string[] nomes = new string[400];
string[] vetor = new string[3];

int cadastrados = 0;

bool executar = true;

do
{
    try
    {
        Console.WriteLine();
        Console.WriteLine("Selecione a opção\n1 - Cadastrar\n2 - Aniversariantes\n3 - Procurar Aniversariantes\n4 - Estatísticas\n5 - Sair");
        int selecao = Convert.ToInt32(Console.ReadLine());

        switch (selecao)
        {
            case 1:

                Console.WriteLine("Insira o nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira a data de nascimento");
                string data = Console.ReadLine();

                if (data.Contains("/"))
                {
                    vetor = data.Split("/");
                }
                else if (data.Contains("-"))
                {
                    vetor = data.Split("-");
                }

                nomes[cadastrados] = nome;
                matriz[cadastrados] = new DateTime(Convert.ToInt32(vetor[2]), Convert.ToInt32(vetor[1]), Convert.ToInt32(vetor[0]));

                cadastrados++;

                Console.Clear();

                break;

            case 2:

                DateTime dataHora = DateTime.Now;

                Console.Clear();
                Console.WriteLine("Aniversariantes deste mês: ");

                for (int i = 1; i < matriz.GetLength(0); i++)
                {
                    if (matriz[i].Month == dataHora.Month)
                    {
                        Console.WriteLine(nomes[i]);
                    }
                }

                break;

            case 3:

                Console.WriteLine("Insira o mês (números)");
                int mes = Convert.ToInt32(Console.ReadLine());

                if (mes > 12 || mes < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Mês inválido!");
                    continue;
                }

                Console.Clear();
                Console.WriteLine("Aniversariantes do mês " + mes + ": ");

                for (int i = 1; i < matriz.Length; i++)
                {
                    if (matriz[i].Month == mes)
                    {
                        Console.WriteLine(nomes[i]);
                    }
                }

                break;

            case 4:

                Console.Clear();
                for (int i = 1; i < 13; i++)
                {
                    int num = 0;

                    for (int j = 0; j < matriz.Length; j++)
                    {
                        if (matriz[j].Month == i)
                        {
                            num++;
                        }
                    }
                    Console.WriteLine("Aniversariantes do mês " + i + " - " + num);
                }

                break;

            case 5:

                executar = false;

                break;

            default:

                Console.Clear();
                Console.WriteLine("Insira apenas números de 1 a 6!");

                break;
        }
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Número ou data inválida!");
    }

}
while (executar);