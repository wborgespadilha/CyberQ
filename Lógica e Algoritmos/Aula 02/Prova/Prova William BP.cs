bool usaClube = false;
bool usaPlano = false;
bool continuarCadastro = true;

double homens = 0;
double mulheres = 0;
double registros = 0;

string maiorFaltante = "ninguem";
int maiorFaltas = 0;

double maiorSalarioHomens = 0;
string maiorSalarioHNome = "nenhum";

double maiorSalarioMulheres = 0;
string maiorSalarioMNome = "nenhum";

int qntdClube = 0;
int qntdPlano = 0;


do
{
    try
    {
        //Validação nome vazio

        Console.WriteLine("Insira o nome");
        string nome = Console.ReadLine();

        if (nome == "")
        {
            Console.WriteLine("O nome não pode ser vazio!");
            Console.WriteLine();
            continue;
        }

        //Validação menor de idade

        Console.WriteLine("Insira a idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 15)
        {
            Console.WriteLine("A idade não pode ser menor que 15");
            Console.WriteLine();
            continue;
        }

        //Verificação de cargo inválido e atribuição do salário base

        Console.WriteLine("Selecione o cargo:");
        Console.WriteLine("1 - Desenvolvedor");
        Console.WriteLine("2 - Analista");
        Console.WriteLine("3 - Arquiteto");
        Console.WriteLine("4 - Gerente de projetos");

        int cargo = Convert.ToInt32(Console.ReadLine());

        double salario = 0;

        switch (cargo)
        {
            case 1:
                salario = 3000;
                break;

            case 2:
                salario = 4500;
                break;

            case 3:
                salario = 7000;
                break;

            case 4:
                salario = 8500;
                break;

            default:
                Console.WriteLine("Cargo inválido!");
                Console.WriteLine();
                continue;
                break;
        }

        //Validando o gênero e adicionando ao contador total

        Console.WriteLine("Selecione o gênero: 1 - Homem, 2 - Mulher");

        int genero = Convert.ToInt32(Console.ReadLine());

        switch (genero)
        {
            case 1:
                homens++;
                break;
            case 2:
                mulheres++;
                break;
            default:
                Console.WriteLine("Gênero inválido!");
                Console.WriteLine();
                continue;
                break;
        }

        //Validando as horas extras e adicionando o valor ao salário

        Console.WriteLine("Insira as horas extras");
        int horasExtras = Convert.ToInt32(Console.ReadLine());

        if (horasExtras < 0)
        {
            Console.WriteLine("Não são aceitos valores negativos!");
            Console.WriteLine();
            continue;
        }

        switch (cargo)
        {
            case 1:
                salario += 30 * horasExtras;
                break;

            case 2:
                salario += 45 * horasExtras;
                break;

            case 3:
                salario += 70 * horasExtras;
                break;

            case 4:
                salario += 85 * horasExtras;
                break;
        }

        //Validando as faltas, adicionando o bônus, e guardando o maior faltante

        Console.WriteLine("Insira a quantidade de faltas:");
        int faltas = Convert.ToInt32(Console.ReadLine());

        if (faltas < 0 || faltas > 31)
        {
            Console.WriteLine("O número de faltas deve ser entre 0 e 31");
            Console.WriteLine();
            continue;
        }

        if (faltas == 0)
        {
            salario += 100;
        }

        if (faltas > maiorFaltas)
        {
            maiorFaltas = faltas;
            maiorFaltante = nome;
        }

        //Verificando se usa o plano de saúde

        Console.WriteLine("Se adere ao plano de saúde escreva 1, insira 2 se não adere");

        int planoSaude = Convert.ToInt32(Console.ReadLine());

        if (planoSaude == 1)
        {
            qntdPlano += 1;
            salario -= 300;
            usaPlano = true;
        }

        //Verificando se faz parte do clube

        Console.WriteLine("Se adere ao clube escreva 1, insira 2 se não adere");

        int clube = Convert.ToInt32(Console.ReadLine());

        if (clube == 1)
        {
            qntdClube += 1;
            salario -= 100;
            usaClube = true;
        }

        //Identificando os maiores salários

        switch (genero)
        {
            case 1:
                if (salario > maiorSalarioHomens)
                {
                    maiorSalarioHomens = salario;
                    maiorSalarioHNome = nome;
                }
                break;

            case 2:
                if (salario > maiorSalarioMulheres)
                {
                    maiorSalarioMulheres = salario;
                    maiorSalarioMNome = nome;
                }
                break;
        }

        //Somando aos registros realizados

        registros++;

        //Exibindo os dados

        Console.WriteLine();
        Console.WriteLine($"Nome: {nome}, Salário líquido:{salario:C2}");
        Console.WriteLine(usaClube == true ? "Usa o clube, paga R$ 100,00" : "Não usa o clube");
        Console.WriteLine(usaPlano == true ? "Usa o plano, paga R$ 300.00" : "Não usa o plano");
        Console.WriteLine();

        //Solicitando confirmação de continuação

        Console.WriteLine("Para continuar inserindo aperte enter, para parar digite qualquer coisa");
        string continueCheck = Console.ReadLine();

        if (continueCheck != "")
        {
            continuarCadastro = false;
        }

        Console.Clear();

    }
    catch (Exception ex)
    {
        //Try - catch para validação de input de mesmo tipo
        Console.WriteLine(ex.Message);
    }

}
while (continuarCadastro);

Console.WriteLine();
Console.WriteLine("Registros efetuados: " + registros);
Console.WriteLine($"Homens: {homens} - {(homens/registros):P2}, Mulheres: {mulheres} - {(mulheres/registros):P2}");
Console.WriteLine($"Maior faltante: {maiorFaltante}, faltas: {maiorFaltas}");
Console.WriteLine($"Mulher com maior salário: {maiorSalarioMNome}, salário: {maiorSalarioMulheres:C2}");
Console.WriteLine($"Homem com maior salário: {maiorSalarioHNome}, salário: {maiorSalarioHomens:C2}");
Console.WriteLine($"Colaboradores com: Plano de saúde - {qntdPlano}, Clube - {qntdClube}");