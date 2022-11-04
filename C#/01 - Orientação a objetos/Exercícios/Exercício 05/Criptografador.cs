using System;

namespace Exercício_05
{
    internal class Criptografador
    {

        private int rot = 1;

        public void Iniciar()
        {
            bool operar = true;

            do
            {
                try
                {

                    Console.WriteLine("1) Criptografar\n2) Descriptografar\n3) Sair");
                    int selecao = Convert.ToInt32(Console.ReadLine());

                    switch (selecao)
                    {
                        case 1:
                            Console.WriteLine("Insira o termo");
                            string termo = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("O termo criptografado é:");
                            Console.WriteLine(Criptografar(termo));
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("Insira o termo");
                            termo = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("O termo descriptografado é:");
                            Console.WriteLine(Descriptografar(termo));
                            Console.WriteLine();
                            break;

                        case 3:
                            operar = false;
                            break;
                           
                        default:
                            Console.Clear();
                            Console.WriteLine("Insira 1 ou 2!");
                            Console.WriteLine();
                            break;

                    }
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Insira apenas 1 ou 2!");
                    Console.WriteLine();
                }

            }
            while(operar);
        }

        private string Criptografar(string termo)
        {
            string saida = "";
            char caractereNovo;

            termo = termo.ToLower();

            foreach(Char caractere in termo)
            {
                int ascii = caractere;
                //Apenas soma a rotação caso a soma seja menor que z
                if (ascii + rot < 122)
                {
                    int unicode = (ascii + rot);
                    caractereNovo = (char) unicode;
                }
                // caso a soma ultrapasse z, volta para o começo (a = 96) e soma o a quantidade de caracteres que ultrapassou z
                else
                {
                    int unicode = ((rot + ascii) % 122) + 96;
                    caractereNovo = (char) unicode;
                }
                saida += caractereNovo;
            }

            return saida;

        }

        private string Descriptografar(string termo)
        {
            string saida = "";
            char caractereNovo;

            termo = termo.ToLower();

            foreach (Char caractere in termo)
            {
                int ascii = caractere;

                //Caso a diferença seja maior ou igual à a, apenas diminui
                if (ascii - rot >= 97) 
                {
                    int unicode = ascii - rot;
                    caractereNovo = (char) unicode;
                }
                //Caso seja menor que a, avança 26 letra e daí diminui
                else
                {
                    int unicode = (ascii + 26 - rot);
                    caractereNovo = (char) unicode;
                }
                saida += caractereNovo;
            }

            return saida;

        }

    }
}
