string[,] alunos = new string[50, 5];
//Nome, nota 1, nota 2, situação, media

bool cadastrar = true;
bool repetir = false;
int pointer = 0;

do
{
    Console.WriteLine("Insira o nome do aluno");
    string nome = Console.ReadLine();

    alunos[pointer, 0] = nome;

    try
    {
        Console.WriteLine("Insira a primeira nota");
        double primeiraNota = Convert.ToDouble(Console.ReadLine());

        alunos[pointer, 1] = primeiraNota.ToString();

        Console.WriteLine("Insira a segunda nota");
        double segundaNota = Convert.ToDouble(Console.ReadLine());


        alunos[pointer, 2] = segundaNota.ToString();

        double situação = (primeiraNota + segundaNota) / 2;

        alunos[pointer, 4] = situação.ToString();

        if (situação >= 7)
        {
            Console.WriteLine("Aprovado");
            alunos[pointer, 3] = "Aprovado";
        }
        else
        {
            Console.WriteLine("Reprovado");
            alunos[pointer, 3] = "Reprovado";
        }

        pointer++;
    }
    catch(Exception ex)
    {
        Console.Clear();
        Console.WriteLine("Digite apenas números nas notas");
        Console.WriteLine();
        continue;
    }

    do
    {
        try
        {


            Console.WriteLine();
            Console.WriteLine("Continuar inserindo?\n1 - Sim\n2 - Não");
            int selecao = Convert.ToInt32(Console.ReadLine());

            if (selecao == 2)
            {
                cadastrar = false;
            }
            repetir = false;

            Console.Clear();

        }
        catch(Exception ex)
        {
            repetir = true;
            Console.Clear();
            Console.WriteLine("Insira apenas números");
        }
    }   
    while (repetir);
}
while (cadastrar);

int cadastrados = 0;
int aprovados = 0;
int reprovados = 0;

double somaMedias = 0;
double maiorMedia = 0;

for(int i = 0; i < alunos.GetLength(0); i++)
{
    if (alunos[i,0] != null)
    {

        cadastrados++;
        if (alunos[i,3] == "Aprovado")
        {
            aprovados++;
        }
        else
        {
            reprovados++;
        }
        if(Convert.ToDouble(alunos[i, 4]) >= maiorMedia)
        {
            maiorMedia = Convert.ToDouble(alunos[i, 4]);
        }
        somaMedias += Convert.ToDouble(alunos[i,4]);
    }
}

double mediaGeral = somaMedias / cadastrados;

//Ordenar os valores
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(0); j++)
    {
        if (Convert.ToDouble(alunos[i, 4]) > Convert.ToDouble(alunos[j, 4]))
        {
            int temp = Convert.ToInt32(alunos[j, 4]);
            alunos[j, 4] = alunos[i, 4];
            alunos[i, 4] = temp.ToString();

            string tempStr = alunos[j, 0];
            alunos[j, 0] = alunos[i, 0];
            alunos[i, 0] = tempStr;

            tempStr = alunos[j, 1];
            alunos[j, 1] = alunos[i, 1];
            alunos[i, 1] = tempStr;

            tempStr = alunos[j, 2];
            alunos[j, 2] = alunos[i, 2];
            alunos[i, 2] = tempStr;

            tempStr = alunos[j, 3];
            alunos[j, 3] = alunos[i, 3];
            alunos[i, 3] = tempStr;

        }
    }
}

Console.WriteLine("Alunos com a maior média");
Console.WriteLine();

for(int i = 0; i < alunos.GetLength(0); i++)
{
    if(Convert.ToDouble(alunos[i,4]) >= maiorMedia)
    {
        Console.WriteLine($"Aluno: {alunos[i, 0]}, Nota 1: {alunos[i, 1]}, Nota 2: {alunos[i, 2]}, Media: {alunos[i, 4]}, Situação: {alunos[i, 3]}");
    }
}

Console.WriteLine();
Console.WriteLine("Lista de alunos:");
Console.WriteLine();

for (int i = 0; i < alunos.GetLength(0); i++)
{
    if (alunos[i, 0] != null)
    {
        Console.WriteLine($"Aluno: {alunos[i, 0]}, Nota 1: {alunos[i, 1]}, Nota 2: {alunos[i, 2]}, Media: {alunos[i, 4]}, Situação: {alunos[i, 3]}");
    }
}