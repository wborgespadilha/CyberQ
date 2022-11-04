Console.WriteLine("Insira a palavra ou a frase:");
string frase = Console.ReadLine();

char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

char[] consoantes = {'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z',
    'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', };

char[] especiais = { '!', '@', '#', '$', '%', '¨', '&', '*', '(', ')', '-', '=', '´', '[', ']', '{', '}', '~', '^', ';', ':', '.', ',', '/', '|', '*', '-', '+', 'ç', '"','_'};

int numConsoantes = 0;
int numVogais = 0;
int caracteresEspeciais = 0;
int numNumeros = 0;
int maiusculos = 0;
int minusculos = 0;
int espacos = 0;

for (int i = 0; i < frase.Length; i++)
{
    espacos += frase[i] == ' ' ? 1 : 0;

    for (int j = 0; j < vogais.Length; j++)
    {
        if (frase[i] == vogais[j])
        {
            numVogais++;
            break;
        }
    }

    for (int j = 0; j < consoantes.Length; j++)
    {
        if (frase[i] == consoantes[j])
        {
            numConsoantes++;
            break;
        }
    }

    if (Char.IsNumber(frase[i]))
    {
        numNumeros++;
    }

    if (Char.IsLower(frase[i]))
    {
        minusculos++;
    }

    if (Char.IsUpper(frase[i]))
    {
        maiusculos++;
    }

    for (int j = 0; j < especiais.Length; j++)
    {
        if (frase[i] == especiais[j])
        {
            caracteresEspeciais++;
            break;
        }
    }

}

Console.WriteLine("Consoantes: " + numConsoantes);
Console.WriteLine("Vogais: " + numVogais);
Console.WriteLine("Caracteres Especiais: " + caracteresEspeciais);
Console.WriteLine("Números: " + numNumeros);
Console.WriteLine("Maiúscilas: " + maiusculos);
Console.WriteLine("Minúsculas: " + minusculos);
Console.WriteLine("Espaços:" + espacos);