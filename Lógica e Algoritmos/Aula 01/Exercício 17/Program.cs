Console.WriteLine("Insira o nome");
string nomeInserido = Console.ReadLine();

Console.WriteLine("Insira sua idade");
int idadeInserida = Convert.ToInt16(Console.ReadLine());

int anoNascimento = 2022 - idadeInserida;

Console.WriteLine("Olá " + nomeInserido + " Você nasceu em " + anoNascimento + " Caso já tenha feito aniversário este ano.");
