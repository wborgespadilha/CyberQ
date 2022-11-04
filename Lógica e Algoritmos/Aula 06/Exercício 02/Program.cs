using System.Collections;

var cidades = new ArrayList();
var cidadesJaUsadas = new ArrayList();
var qtdCidadesJaUsadas = new ArrayList();

bool continuar = true;

while(continuar)
{

    Console.WriteLine("Insira a cidade ou sair para parar");
    string cidade = Console.ReadLine();

    if(cidade == "sair")
    {
        continuar = false;
        continue;
    }

    cidades.Add(cidade);

    Console.Clear();

}


for(int i = 0; i < cidades.Count; i++)
{

    bool cidadeUsada = false;

    for (int j = 0; j < cidadesJaUsadas.Count; j++)
    {
        if (cidadesJaUsadas.Contains(cidades[i]))
        {
            qtdCidadesJaUsadas[j] = Convert.ToInt32(qtdCidadesJaUsadas[j]) + 1;
            cidadeUsada = true;
        }
    }

    if(cidadeUsada == false)
    {
        cidadesJaUsadas.Add(cidades[i]);
        qtdCidadesJaUsadas.Add(1);
    }

}


for(int i = 0; i < cidadesJaUsadas.Count; i++)
{

    Console.WriteLine(cidadesJaUsadas[i] + " - " + qtdCidadesJaUsadas[i]);

}