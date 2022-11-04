Console.WriteLine("Insira uma palavra");

string palavra = Console.ReadLine();

string chars = "";

for (int i = 0; i < palavra.Length; i++)
{
    if(i % 2 == 0)
    {
        chars += palavra[i].ToString().ToUpper();
    }
    else
    {
        chars += palavra[i].ToString().ToLower();
    }
}

Console.WriteLine(chars);