bool continueRegister = true;

double registeredUsers = 0;
double maleUsers = 0;
int femaleUsers = 0;

int lowestAge = 0;
int biggestAge = 0;
int youngerSex = 0;
int oldestSex = 0;
string youngerState = null;
string oldestState = null;
string youngerUser = null;
string oldestUser = null;

int RS = 0,
    SC = 0,
    PR = 0,
    RJ = 0,
    MG = 0,
    ES = 0,
    SP = 0, 
    MS = 0, 
    GO = 0, 
    DF = 0, 
    MT = 0, 
    MA = 0, 
    PI = 0, 
    CE = 0, 
    RN = 0, 
    PB = 0, 
    PE = 0, 
    AL = 0, 
    SE = 0, 
    BA = 0, 
    TO = 0, 
    PA = 0, 
    AP = 0, 
    RR = 0, 
    AM = 0, 
    RO = 0, 
    AC = 0;

do
{
    try
    {

        Console.WriteLine("Insira o nome");
        string userName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Insira a idade");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Digite o estado:");
        Console.WriteLine("RS, SC, PR");
        Console.WriteLine("RJ, MG, ES, SP");
        Console.WriteLine("MS, GO, DF, MT");
        Console.WriteLine("MA, PI, CE, RN");
        Console.WriteLine("PB, PE, AL, SE");
        Console.WriteLine("BA, TO, PA, AP");
        Console.WriteLine("RR, AM, RO, AC");

        string userState = Console.ReadLine().ToUpper();

        switch(userState)
        {
            case "RS":
                RS++;
                break;

            case "SC":
                SC++;
                break;

            case "PR":
                PR++;
                break;

            case "RJ":
                RJ++;
                break;

            case "MS":
                MS++;
                break;

            case "ES":
                ES++;
                break;

            case "SP":
                SP++;
                break;

            case "MG":
                MG++;
                break;

            case "GO":
                GO++;
                break;

            case "DF":
                DF++;
                break;

            case "MT":
                MT++;
                break;

            case "MA":
                MA++;
                break;

            case "PI":
                PI++;
                break;

            case "CE":
                CE++;
                break;

            case "RN":
                RN++;
                break;

            case "PB":
                PB++;
                break;

            case "PE":
                PE++;
                break;

            case "AL":
                AL++;
                break;

            case "SE":
                SE++;
                break;

            case "BA":
                BA++;
                break;

            case "TO":
                TO++;
                break;

            case "PA":
                PA++;
                break;

            case "AP":
                AP++;
                break;

            case "RR":
                RR++;
                break;

            case "AM":
                AM++;
                break;

            case "RO":
                RO++;
                break;

            case "AC":
                AC++;
                break;

            default:
                Console.WriteLine("Estado inválido!");
                Console.WriteLine();
                continue;
                break;

        }

       

        Console.Clear();
        Console.WriteLine("Insira o gênero");
        Console.WriteLine("1 - Homem, 2 - Mulher");

        int userSex = Convert.ToInt32(Console.ReadLine());

        switch (userSex)
        {
            case 1:
                maleUsers++;
                break;

            case 2:
                femaleUsers++;
                break;

            default:
                Console.WriteLine("Sexo inválido!");
                Console.WriteLine();
                continue;
                break;
        }

        registeredUsers++;

        if(lowestAge == 0)
        {
            lowestAge = userAge;
            youngerUser = userName;
            youngerSex = userSex;
            youngerState = userState;
        }

        if(userAge < lowestAge)
        {
            lowestAge = userAge;
            youngerUser = userName;
            youngerSex = userSex;
            youngerState = userState;
        }

        if(userAge > biggestAge)
        {
            biggestAge = userAge;
            oldestUser = userName;
            oldestSex = userSex;
            oldestState = userState;
        }


        Console.Clear();
        Console.WriteLine("Para continuar pressione enter, para parar digite qualquer coisa.");

        string continueCheck = Console.ReadLine();

        if (continueCheck != "")
        {
            continueRegister = false;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
while (continueRegister);

Console.WriteLine($"Usuários cadastrados: {registeredUsers}");
Console.WriteLine($"Homens: {maleUsers} = {(maleUsers/registeredUsers):P2}, Mulheres: {femaleUsers} = {(femaleUsers/registeredUsers):P2}");
Console.WriteLine("Pessoas por estado:");

if (RS != 0) { Console.WriteLine($"RS: {RS}"); }
if (SC != 0) { Console.WriteLine($"SC: {SC}"); }
if (PR != 0) { Console.WriteLine($"PR: {PR}"); }

if (RJ != 0) { Console.WriteLine($"RJ: {RJ}"); }
if (MG != 0) { Console.WriteLine($"MG: {MG}"); }
if (ES != 0) { Console.WriteLine($"ES: {ES}"); }
if (SP != 0) { Console.WriteLine($"SP: {SP}"); }

if (MS != 0) { Console.WriteLine($"MS: {MS}"); }
if (GO != 0) { Console.WriteLine($"GO: {GO}"); }
if (DF != 0) { Console.WriteLine($"DF: {DF}"); }
if (MT != 0) { Console.WriteLine($"MT: {MT}"); }
if (MA != 0) { Console.WriteLine($"MA: {MA}"); }

if (PI != 0) { Console.WriteLine($"PI: {PI}"); }
if (CE != 0) { Console.WriteLine($"CE: {CE}"); }
if (RN != 0) { Console.WriteLine($"RN: {RN}"); }
if (PB != 0) { Console.WriteLine($"PB: {PB}"); }
if (PE != 0) { Console.WriteLine($"PE: {PE}"); }
if (AL != 0) { Console.WriteLine($"AL: {AL}"); }
if (SE != 0) { Console.WriteLine($"ES: {ES}"); }
if (BA != 0) { Console.WriteLine($"BA: {BA}"); }

if (TO != 0) { Console.WriteLine($"TO: {TO}"); }
if (PA != 0) { Console.WriteLine($"PA: {PA}"); }
if (AP != 0) { Console.WriteLine($"AP: {AP}"); }
if (RR != 0) { Console.WriteLine($"RR: {RR}"); }
if (AM != 0) { Console.WriteLine($"AM: {AM}"); }
if (RO != 0) { Console.WriteLine($"RO: {RO}"); }

if (AC != 0) { Console.WriteLine($"AC: {AC}"); }

Console.WriteLine($"Pessoa mais jovem: {youngerUser}, idade:{lowestAge}, estado: {youngerState}, gênero:{(youngerSex == 1 ? "Homem" : "Mulher")}");
Console.WriteLine($"Pessoa mais velha: {oldestUser}, idade:{biggestAge}, estado: {oldestState}, gênero:{(oldestSex == 1 ? "Homem" : "Mulher")}");