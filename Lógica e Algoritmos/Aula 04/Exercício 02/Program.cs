Console.WriteLine("Insira um verbo terminado em AR");

string palavra = Console.ReadLine();

string raiz = palavra.Substring(0,palavra.Length - 2);

Console.WriteLine(raiz);

Console.WriteLine("Eu " + raiz + "o");
Console.WriteLine("Tu " + raiz + "as");
Console.WriteLine("Ele " + raiz + "a");
Console.WriteLine("Ela " + raiz + "a");
Console.WriteLine("Nós " + raiz + "amos");
Console.WriteLine("Vós " + raiz + "ais");
Console.WriteLine("Eles " + raiz + "am");
