Console.WriteLine("Insira o valor por hora:");
int valorSalarioPorHora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o número de horas trabalhadas normalmente");
int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o número de horas extras do dia da semana");
double horasExtrasTipo1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o número de horas extras do fim de semana ou feriado");
int horasExtrasTipo2 = Convert.ToInt32(Console.ReadLine());

horasTrabalhadas = horasTrabalhadas * valorSalarioPorHora;
horasExtrasTipo1 = horasExtrasTipo1 * valorSalarioPorHora * 1.5;
horasExtrasTipo2 = horasExtrasTipo2 * valorSalarioPorHora * 2;

Console.WriteLine("Valor a ser recebido: " + (horasTrabalhadas + horasExtrasTipo1 + horasExtrasTipo2));
