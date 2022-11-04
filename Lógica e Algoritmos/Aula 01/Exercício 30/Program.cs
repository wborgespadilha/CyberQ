Console.WriteLine("Primeira questão: Normalmente, quantos litros de sangue uma pessoa tem? ");
Console.WriteLine("Resposta 1: Tem entre 2 a 4 litros");
Console.WriteLine("Resposta 2: Tem entre 4 a 6 litros");

int resposta = Convert.ToInt32(Console.ReadLine());
int acertos = 0;

if(resposta == 1)
{
    Console.WriteLine("Resposta errada!");
}
else if(resposta == 2)
{
    Console.WriteLine("Certa resposta!");
    acertos++;
}

Console.WriteLine("Segunda questão: De quem é a famosa frase “Penso, logo existo” ?");
Console.WriteLine("Resposta 1: Descartes");
Console.WriteLine("Resposta 2: Sócrates ");

resposta = Convert.ToInt32(Console.ReadLine());

if (resposta == 1)
{
    Console.WriteLine("Certa resposta!");
    acertos++;
}
else if (resposta == 2)
{
    Console.WriteLine("Resposta errada!");
}

Console.WriteLine("Terceira questão: Quais o menor e o maior país do mundo?");
Console.WriteLine("Resposta 1: Nauru e China");
Console.WriteLine("Resposta 2: Vaticano e Rússia");

resposta = Convert.ToInt32(Console.ReadLine());

if (resposta == 1)
{
    Console.WriteLine("Resposta errada!");
}
else if (resposta == 2)
{
    Console.WriteLine("Certa resposta!");
    acertos++;
}

Console.WriteLine("Quarta questão: Qual o nome do presidente do Brasil que ficou conhecido como Jango?");
Console.WriteLine("Resposta 1: João Goulart");
Console.WriteLine("Resposta 2: Jânio Quadros");

resposta = Convert.ToInt32(Console.ReadLine());

if (resposta == 1)
{
    Console.WriteLine("Certa resposta!");
    acertos++;
}
else if (resposta == 2)
{
    Console.WriteLine("Resposta errada!");
}

Console.WriteLine("Quinta questão: Qual o livro mais vendido no mundo, exceto a Bíblia?");
Console.WriteLine("Resposta 1: O Senhor dos Anéis");
Console.WriteLine("Resposta 2: Dom Quixote");

resposta = Convert.ToInt32(Console.ReadLine());

if (resposta == 1)
{
    Console.WriteLine("Resposta errada!");
}
else if (resposta == 2)
{
    Console.WriteLine("Certa resposta!");
    acertos++;
}

Console.WriteLine("Você acertou um total de " + acertos + " questões.");