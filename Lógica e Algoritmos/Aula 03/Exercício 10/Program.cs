string[,] coresRegistradas = new string[10, 2];
string[] coresInseridas = new string[10];

int indiceNovaCor = 0;

for (int i = 0; i < coresInseridas.GetLength(0); i++)
{

    Console.WriteLine("Insira a " + (i + 1) + "º cor:");

    coresInseridas[i] = Console.ReadLine();

    Console.Clear();

}

for (int i = 0; i < 10; i++)
{
    bool existeCor = false;

    for (int j = 0; j < 10; j++)
    {
        //Percorre a lista de inseridos veirificando se há correspondência na lista de registrados
        if (coresInseridas[i] == coresRegistradas[j, 0])
        {
            //Caso tenha incrementa 1 e impede de criar nova cor
            int qtdCor = Convert.ToInt32(coresRegistradas[j, 1]);
            coresRegistradas[j, 1] = Convert.ToString(qtdCor + 1);

            existeCor = true;
            break;
        }
    }

    // Caso não encontre a cor na matriz de registrados
    if (existeCor == false)
    {
        //Cria a nova cor na matriz e incrementa o índice
        //O índice só vai servir para apontar a posição da próxima nova cor a ser cadastrada
        coresRegistradas[indiceNovaCor, 0] = coresInseridas[i];
        coresRegistradas[indiceNovaCor, 1] = "1";
 
        indiceNovaCor++;
    }
}

/*
 *          O segredo é que ele compara a lista de inseridos com os elementos 
 *      Da lista de registro, incrementando se existe ou criando se não existe
 * 
 *          Comparar diretamente a quantia de vezes em que aparece repetido
 *      da lista de inseridos dá duplicata
 * 
 *      for(int i = 0;i < lista.lenght)
 *      {
 *          for(int j = 0; j < lista.lenght; i++);
 *          {
 *              if(i != j)
 *              {
 *                  (lista[i] == lista[j])
 *              }
 *          }
 *      }
 *      
 *          Essa estrutura está incorreta, pois se tivermos a mesma palavra 3 vezes 
 *      ele irá contar como 6 vezes, 4 vezes como 12, 5 como 20, etc.
 *      
 *      
 *          Apesar de que dá para fazer estrutura comparando os resultados e colocando
 *      os valores corretos, mas é hard code demais.
 */


for (int i = 0; i < 10; i++)
{
    if(Convert.ToInt32(coresRegistradas[i, 1]) != 0)
    {
        Console.WriteLine(coresRegistradas[i, 0] + " - " + coresRegistradas[i, 1]);
    }
}

