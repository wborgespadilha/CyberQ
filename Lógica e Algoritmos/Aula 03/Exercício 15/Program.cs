string[,] produtos =
{
    {"Sabão crá crá", "14,90"},
    {"Sabão cri cri", "27,00"},
    {"Gelatina sabor água", "10,00"},
    {"Cebola em barra", "15,90"},
    {"Carvão azul","20,50"},
    {"Água sanitária","3,80"},
    {"Detergente","7,90"},
    {"Wafer de sabão","9,50"},
    {"Banha de cavalo","27,80"},
    {"Facão tramontina","50,00"}
};

int[] estoque = {5,9,12,65,7,24,9,42,90,3};
int[] comprados = new int[10];

bool continuar = true;

do
{
    Console.WriteLine("Selecione um produto:");

    for (int i = 0; i < produtos.GetLength(0); i++)
    {
        Console.WriteLine(i + " - " + produtos[i, 0] + " - R$ " + produtos[i, 1] + " - Disponíveis: " + estoque[i]);
    }

    try
    {
        Console.WriteLine();
        Console.WriteLine("Ou digite 13 para finalizar a compra");
        int produto = Convert.ToInt32(Console.ReadLine());

        if (produto == 13)
        {
            continuar = false;
            continue;
        }

        Console.WriteLine("Digite a quantidade");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        if (quantidade > estoque[produto])
        {
            Console.WriteLine("Não temos tantos(as) " + produtos[produto, 0] + " disponíveis!");
            Console.WriteLine();
        }
        else
        {
            comprados[produto] = quantidade;
            estoque[produto] -= quantidade;
        }
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Insira apenas números");
        Console.WriteLine();
    }

}
while(continuar);

Console.Clear();
Console.WriteLine("Produtos comprados:");
Console.WriteLine();

double total = 0;
double subtotal = 0;

for (int i = 0; i < produtos.GetLength(0); i++)
{
    if (comprados[i] != 0)
    {
        subtotal = Convert.ToDouble(produtos[i, 1]) * comprados[i];
        Console.WriteLine(comprados[i] + " " + produtos[i, 0] + " - R$ " + subtotal);
        total += subtotal;
    }
}
Console.WriteLine();
Console.WriteLine("Total da compra: R$ " + total);