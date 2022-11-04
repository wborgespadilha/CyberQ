// Importar Classes
using Exemplo_02;

// Lista
List < Produto > produtos = new List < Produto > ();

// Laço de repetição

do
{
    // Instanciar objeto do tipo Produto
    Produto p = new Produto();

    Console.WriteLine("Informe o nome do produto");
    p.Nome = Console.ReadLine();

    Console.WriteLine("Informe o valor do produto");
    p.Valor = Convert.ToDouble(Console.ReadLine());

    // Adicionar na lista
    produtos.Add(p);

    // Limpar Console
    Console.Clear();

    // Continuar o laço
    Console.WriteLine("Deseja continuar?");
    Console.WriteLine("1) SIM");
    Console.WriteLine("2) NÃO");
    int continuar = Convert.ToInt32(Console.ReadLine());

    if(continuar == 2)
    {
        break;
    }

} while (true);

// Limpar Console
Console.Clear();

// Listar produtos
foreach(Produto obj in produtos)
{
    Console.WriteLine(obj.Nome);
    Console.WriteLine(obj.Valor);
    Console.WriteLine("--------");
}

