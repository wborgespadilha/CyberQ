Console.WriteLine("Insira a frase ou palavra");
string frase = Console.ReadLine();

string frase2 = "";

for(int i = frase.Length-1; i >= 0; i--)
{
    frase2 += frase[i];
}

if(frase == frase2)
{
    Console.WriteLine("É um palíndromo");
}
else
{
    Console.WriteLine("Não é um palíndromo");
}