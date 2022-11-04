Console.WriteLine("Informe o e-mail");
string email = Console.ReadLine();

char[] especiais = { '!', '#', '$', '%', '¨', '&', '*', '(', ')', '=', '´', '[', ']', '{', '}', '~', '^', ';', ':', ',', '/', '|', '*', '-', '+', 'ç', '"' };

bool valido = true;

int arrobas = 0;

for (int i = 0; i < email.Length; i++)
{
    if (Char.IsUpper(email[i]))
    {
        valido = false;
    }

    for(int j = 0; j < especiais.Length; j++)
    {
        if (email[i] == especiais[j])
        {
            valido = false;
        }
    }

    if (email[i] == '@')
    {
        arrobas++;
    }

}

if (arrobas != 1)
{
    valido = false;
}
else
{
    string[] vetor = email.Split('@');
    if(!vetor[1].Contains('.'))
    {
        valido = false;
    }
    if (vetor[1].Length < 5)
    {
        valido = false;
    }
}

Console.WriteLine(valido == true ? "E-Mail válido":"E-Mail inválido");