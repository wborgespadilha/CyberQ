namespace Projeto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}

/*
 * 
 * Login professor:
 * 
 * usu�rio: professor
 * senha:   1234
 * 
 * Alunos:
 * usu�rio: joao        senha:  123
 * usu�rio: tiago       senha:  123
 * usu�rio: joana       senha:  123
 * usu�rio: guilherme   senha:  123
 * usu�rio: micaela     senha:  123
 * 
 */