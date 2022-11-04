bool dataValida = true;
bool continuar = true;

Console.WriteLine("Insira a data");
string data = Console.ReadLine();

string[] vetor = new string[11];

//Validação de formato
if(data.Contains('/'))
{
    vetor = data.Split('/');

}
else if(data.Contains('-'))
{
    vetor = data.Split('-');
}
else
{
    dataValida = false;
    continuar = false;
}

//Validação de data
if (continuar)
{
    //Ano inválido
    if (Convert.ToInt32(vetor[2]) < 0 || Convert.ToInt32(vetor[2]) > 9999)
    {
        dataValida = false;
    }

    //Mês inválido
    if (Convert.ToInt32(vetor[1]) < 1 || Convert.ToInt32(vetor[1]) > 12)
    {
        dataValida = false;
    }

    //Fevereiro
    if (vetor[1] == "02")
    {
        //Verifica bissexto
        if (Convert.ToInt32(vetor[2]) % 4 == 0)
        {

            if (Convert.ToInt32(vetor[0]) > 29)
            {
                dataValida = false;
            }
        }
        else
        {
            if (Convert.ToInt32(vetor[0]) > 28)
            {
                dataValida = false;
            }
        }
    }

    //Mês par
    else if (Convert.ToInt32(vetor[1]) % 2 == 0)
    {
        if (Convert.ToInt32(vetor[0]) > 31)
        {
            dataValida = false;
        }
    }

    //Mês impar
    else
    {
        if (Convert.ToInt32(vetor[0]) > 30)
        {
            dataValida = false;
        }
    }
}

if (dataValida)
{
    //Dias
    switch(Convert.ToInt32(vetor[0]))
    {
        case 1:
            Console.Write("Primeiro");
            break;
        case 2:
            Console.Write("Segundo");
            break;
        case 3:
            Console.Write("Terceiro");
            break;
        case 4:
            Console.Write("Quarto");
            break;
        case 5:
            Console.Write("Quinto");
            break;
        case 6:
            Console.Write("Sexto");
            break;
        case 7:
            Console.Write("Sétimo");
            break;
        case 8:
            Console.Write("Oitavo");
            break;
        case 9:
            Console.Write("Nove");
            break;
        case 10:
            Console.Write("Dez");
            break;
        case 11:
            Console.Write("Onze");
            break;
        case 12:
            Console.Write("Doze");
            break;
        case 13:
            Console.Write("Treze");
            break;
        case 14:
            Console.Write("Catorze");
            break;
        case 15:
            Console.Write("Quinze");
            break;
        case 16:
            Console.Write("Dezesseis");
            break;
        case 17:
            Console.Write("Dezessete");
            break;
        case 18:
            Console.Write("Dezoito");
            break;
        case 19:
            Console.Write("Dezenove");
            break;
        case 20:
            Console.Write("Vinte");
            break;
        case 21:
            Console.Write("Vinte e Um");
            break;
        case 22:
            Console.Write("Vinte e Dois");
            break;
        case 23:
            Console.Write("Vinte e Três");
            break;
        case 24:
            Console.Write("Vinte e Quatro");
            break;
        case 25:
            Console.Write("Vinte e Cinco");
            break;
        case 26:
            Console.Write("Vinte e Seis");
            break;
        case 27:
            Console.Write("Vinte e Sete");
            break;
        case 28:
            Console.Write("Vinte e Oito");
            break;
        case 29:
            Console.Write("Vinte e Nove");
            break;
        case 30:
            Console.Write("Trinta");
            break;
        case 31:
            Console.Write("Trinta e Um");
            break;
    }

    Console.Write(" de ");

    //Meses
    switch(Convert.ToInt32(vetor[1]))
    {
        case 1:
            Console.Write("Janeiro");
            break;
        case 2:
            Console.Write("Fevereiro");
            break;
        case 3:
            Console.Write("Março");
            break;
        case 4:
            Console.Write("Abril");
            break;
        case 5:
            Console.Write("Maio");
            break;
        case 6:
            Console.Write("Junho");
            break;
        case 7:
            Console.Write("Julho");
            break;
        case 8:
            Console.Write("Agosto");
            break;
        case 9:
            Console.Write("Setembro");
            break;
        case 10:
            Console.Write("Outubro");
            break;
        case 11:
            Console.Write("Novembro");
            break;
        case 12:
            Console.Write("Dezembro");
            break;
    }

    Console.Write(" de ");

    int valor = Convert.ToInt32(vetor[2]);
    bool semMilhar = false;

    //Milhares
    switch (valor / 1000)
    {
        case 1:
            Console.Write("Mil ");
            break;
        case 2:
            Console.Write("Dois mil ");
            break;
        case 3:
            Console.Write("Três mil ");
            break;
        case 4:
            Console.Write("Quatro mil ");
            break;
        case 5:
            Console.Write("Cinco mil ");
            break;
        case 6:
            Console.Write("Seis mil ");
            break;
        case 7:
            Console.Write("Sete mil ");
            break;
        case 8:
            Console.Write("Oito mil ");
            break;
        case 9:
            Console.Write("Nove mil ");
            break;
        default:
            semMilhar = true;
            break;

    }

    bool semCentena = false;

    valor = valor % 1000;

    //Centenas
    switch(valor / 100)
    {
        case 1:

            if (valor - 100 > 0)
            {
                Console.Write("Cento ");
            }
            else
            {
                if(semMilhar == false)
                {
                    Console.Write("e Cem");
                }
                else
                {
                    Console.WriteLine("Cem");
                }
            }
            break;

        case 2:

            if (valor - 200 > 0)
            {
                Console.Write("Duzentos ");
            }
            else
            {
                if (semMilhar == false)
                {
                    Console.Write("e Duzentos");
                }
                else
                {
                    Console.WriteLine("Duzentos");
                }
            }
            break;

        case 3:

            if (valor - 300 > 0)
            {
                Console.Write("Trezentos ");
            }
            else
            {
                if (semMilhar == false)
                {
                    Console.Write("e Trezentos");
                }
                else
                {
                    Console.WriteLine("Trezentos");
                }
            }
            break;

        case 4:

            if (valor - 400 > 0)
            {
                Console.Write("Quatrocentos ");
            }
            else
            {
                if (semMilhar == false)
                {
                    Console.Write("e Quatrocentos");
                }
                else
                {
                    Console.WriteLine("Quatrocentos");
                }
            }

            break;

        case 5:

            if (valor - 500 > 0)
            {
                Console.Write("Quinhentos ");
            }
            else
            {
                if(semMilhar == false)
                {
                    Console.Write("e Quinhentos");
                }
                else
                {
                    Console.Write("Quinhentos");
                }
            }

            break;

        case 6:

            if (valor - 600 > 0)
            {
                Console.Write("Seiscentos ");
            }
            else
            {
                if(semMilhar == false)
                {
                    Console.Write("e Seiscentos");
                }
                else
                {
                    Console.WriteLine("Seiscentos");
                }
            }

            break;

        case 7:

            if (valor - 700 > 0)
            {
                Console.Write("Setecentos ");
            }
            else
            {
                if (semMilhar == false)
                {
                    Console.Write("e Setecentos");
                }
                else
                {
                    Console.WriteLine("Setecentos");
                }
            }

            break;

        case 8:

            if (valor - 800 > 0)
            {
                Console.Write("Oitocentos ");
            }
            else
            {
                if (semMilhar == false)
                {
                    Console.Write("e Oitocentos");
                }
                else
                {
                    Console.WriteLine("Oitocentos");
                }
            }

            break;

        case 9:

            if (valor - 900 > 0)
            {
                Console.Write("Novecentos ");
            }
            else
            {
                if (semMilhar == false)
                {
                    Console.Write("e Novecentos");
                }
                else
                {
                    Console.WriteLine("Novecentos");
                }
            }

            break;

        default:
            semCentena = true;
            break;
    }

    valor = valor % 100;

    bool semDezena = false;

    //Dezenas
    switch(valor/10)
    {
        case 1:

            if (valor - 10 > 0)
            {
                switch(valor)
                {
                    case 11:
                        if(semCentena && semMilhar)
                        {
                            Console.WriteLine("Onze");
                        }
                        else
                        {
                            Console.Write("e Onze");
                        }
                        valor = 0;
                        break;

                    case 12:
                        if (semCentena && semMilhar)
                        { 
                            Console.Write("Doze");
                        }
                        else
                        {
                            Console.WriteLine("e Doze");
                        }
                        valor = 0;
                        break;

                    case 13:
                        if (semCentena && semMilhar)
                        {
                            Console.Write("Treze");
                        }
                        else
                        {
                            Console.WriteLine("e Doze");
                        }
                        valor = 0;
                        break;

                    case 14:
                        if (semCentena && semMilhar)
                        {
                            Console.Write("Catorze");
                        }
                        else
                        {
                            Console.WriteLine("e Catorze");
                        }
                        valor = 0;
                        break;

                    case 15:
                        if (semCentena && semMilhar)
                        {
                            Console.Write("Quinze");
                        }
                        else
                        {
                            Console.WriteLine("e Quinze");
                        }
                        valor = 0;
                        break;

                    case 16:
                        if (semCentena && semMilhar)
                        {
                            Console.Write("Dezesseis");
                        }
                        else
                        {
                            Console.WriteLine("e Dezesseis");
                        }
                        valor = 0;
                        break;

                    case 17:
                        if (semCentena && semMilhar)
                        {
                            Console.WriteLine("dezessete");
                        }
                        else
                        {
                            Console.Write("e Dezessete");
                        }
                        valor = 0;
                        break;

                    case 18:
                        if(semCentena && semMilhar)
                        {
                            Console.WriteLine("Dezoito");
                        }
                        else
                        {
                            Console.Write("e Dezoito");
                        }
                        valor = 0;
                        break;

                    case 19:
                        if (semCentena && semMilhar)
                        {
                            Console.Write("Dezenove");
                        }
                        else
                        {
                            Console.WriteLine("e Dezenove");
                        }
                        valor = 0;
                        break;
                }
            }
            else
            {
                if(semCentena && semMilhar)
                {
                    Console.WriteLine("Dez");
                }
                else
                {
                    Console.Write("e Dez");
                }
            }
            break;

        case 2:

            if (valor - 20 > 0)
            {
                Console.Write("Vinte e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Vinte");
                }
                else
                {
                    Console.Write(" E Vinte");
                }
            }
            break;

        case 3:

            if (valor - 30 > 0)
            {
                Console.Write("Trinta e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Trinta");
                }
                else
                {
                    Console.Write(" E Trinta");
                }
            }
            break;

        case 4:

            if (valor - 40 > 0)
            {
                Console.Write("Quarenta e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Quarenta");
                }
                else
                {
                    Console.Write(" E Quarenta");
                }
            }

            break;

        case 5:

            if (valor - 50 > 0)
            {
                Console.Write("Cinquenta e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Cinquenta");
                }
                else
                {
                    Console.Write(" E Cinquenta");
                }
            }

            break;

        case 6:

            if (valor - 60 > 0)
            {
                Console.Write("Sessenta e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Sessenta");
                }
                else
                {
                    Console.Write(" E Sessenta");
                }
            }

            break;

        case 7:

            if (valor - 70 > 0)
            {
                Console.Write("Setenta e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Setenta");
                }
                else
                {
                    Console.Write(" E Setenta");
                }
            }

            break;

        case 8:

            if (valor - 80 > 0)
            {
                Console.Write("Oitenta e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Oitenta");
                }
                else
                {
                    Console.Write(" E Oitenta");
                }
            }

            break;

        case 9:

            if (valor - 90 > 0)
            {
                Console.Write("Noventa e");
            }
            else
            {
                if (semCentena && semMilhar)
                {
                    Console.WriteLine("Noventa");
                }
                else
                {
                    Console.Write(" E Noventa");
                }
            }

            break;

        default:
            semDezena = true;
            break;
    }

    valor = valor % 10;

    //Unidade
    switch(valor)
    {
        case 1:
            if(semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Um");
            }
            else 
            {
                Console.Write("e Um");
            }
            break;
        case 2:
            if(semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Dois");
            }
            else
            {
                Console.Write("e Dois");
            }
            break;
        case 3:
            if(semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Três");
            }
            else
            {
                Console.Write("e Três");
            }
            break;
        case 4:
            if (semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Quatro");
            }
            else
            {
                Console.Write("e Quatro");
            }
            break;
        case 5:
            if (semDezena && semCentena && semMilhar)
            {
                Console.Write("Cinco");
            }
            else
            {
                Console.WriteLine("e Cinco");
            }
            break;
        case 6:
            if (semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Seis");
            }
            else
            {
                Console.Write("e Seis");
            }
            break;
        case 7:
            if (semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Sete");
            }
            else
            {
                Console.Write("e Sete");
            }
            break;
        case 8:
            if (semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Oito");
            }
            else
            {
                Console.Write("e Oito");
            }
            break;
        case 9:
            if (semDezena && semCentena && semMilhar)
            {
                Console.WriteLine("Nove");
            }
            else
            {
                Console.Write("e Nove");
            }
            break;
    }

    if(Convert.ToInt32(vetor[2]) == 0)
    {
        Console.WriteLine("Zero");
    }

}
else
{
    Console.WriteLine("A data é inválida!");
}

/*
 * Possibilidades (ano):
 * 
 * 1
 * 10
 * (11)
 * 
 * 100
 * 101
 * 110
 * (111)
 *  
 * 1000
 * 1001
 * 1010
 * (1011)
 * 1100
 * 1101
 * 1110
 * (1111)
 * 
 */