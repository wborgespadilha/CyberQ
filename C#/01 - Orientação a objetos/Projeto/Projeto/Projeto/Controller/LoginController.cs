using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Controller
{
    internal class LoginController
    {

        private string path = @"C:\Empresas.txt";

        public int NumeroEmpresas()
        {
            try
            {

                int quantidadeLinhas = 0;

                if (!File.Exists(path))
                {
                    using (FileStream fileStream = File.Create(path)) ;
                    return quantidadeLinhas;
                }
                else
                {

                    StreamReader streamReaderLineCounter = new StreamReader(path);

                    // Pegando a quantidade de linhas
                    string arquivo = streamReaderLineCounter.ReadToEnd();
                    string[] linhas = arquivo.Split('\n');
                    quantidadeLinhas = linhas.Count();

                    streamReaderLineCounter.Close();

                }
                //Com nada escrito retorna 1 linha, por isso subtrai 1
                return quantidadeLinhas - 1;
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Erro ao enumerar as empresas");
                Console.WriteLine();
                return 0;
            }
        }

        public void MostrarEmpresas()
        {
            try
            {

                using (StreamReader streamReader = File.OpenText(path))
                {
                    StreamReader streamReaderLineCounter = new StreamReader(path);

                    // Pegando a quantidade de linhas para iterar
                    string arquivo = streamReaderLineCounter.ReadToEnd();
                    string[] linhas = arquivo.Split('\n');
                    int quantidadeLinhas = linhas.Count();

                    streamReaderLineCounter.Close();

                    int i = 1;

                    // Iterando lendo cada linha
                    while (i < quantidadeLinhas)
                    {
                        Console.WriteLine(streamReader.ReadLine());
                        i++;
                    }

                    streamReader.Close();
                }
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Erro ao mostrar as empresas");
                Console.WriteLine();
            }
        }

        public void CadastrarEmpresa(string NomeEmpresa)
        {
            try
            {

                if (!File.Exists(path))
                {
                    using (FileStream fileStream = File.Create(path)) ;
                }

                using StreamWriter arquivo = File.AppendText(path);
                {
                    arquivo.WriteLine(NomeEmpresa, true);
                }
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Erro ao cadastrar a empresa:");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

        }

        public bool EmpresaValida(string NomeEmpresa)
        {
            try
            {

                if (!File.Exists(path))
                {
                    return false;
                }
                else
                {

                    using (StreamReader streamReader = File.OpenText(path))
                    {
                        StreamReader streamReaderLineCounter = new StreamReader(path);

                        // Pegando a quantidade de linhas para iterar
                        string arquivo = streamReaderLineCounter.ReadToEnd();
                        string[] linhas = arquivo.Split('\n');
                        int quantidadeLinhas = linhas.Count();

                        streamReaderLineCounter.Close();

                        int i = 0;

                        // Iterando lendo cada linha
                        while (i < quantidadeLinhas)
                        {
                            Console.WriteLine(linhas[i]);
                            if (streamReader.ReadLine() == NomeEmpresa)
                            {
                                return true;
                            }
                            i++;
                        }

                        streamReader.Close();
                    }

                    Console.Clear();

                }
                return false;
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Erro ao validar a empresa:");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                return false;
            }
        }
    }
}
