string[,] matriz =
{
    {"Brasilia","0"},
    {"Moscou","6"},
    {"Los Angeles","-4"},
    {"Johannesburgo","5"},
    {"Sydney","13"},
    {"Xangai","11"},
    {"Anadyr","15"},
    {"Madrid","5"},
    {"Anchorage","-5"},
    {"Berlim","5"},
};

DateTime dataHora = DateTime.Now;


for(int i = 0; i < matriz.GetLength(0); i++)
{
    string horario = dataHora.ToString(":mm:ss");
    int hora = Convert.ToInt32(dataHora.ToString("HH"));

    hora = hora + Convert.ToInt32(matriz[i,1]);
    hora = hora % 24;

    Console.WriteLine(matriz[i, 0] + " - " + hora + horario);
}
