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
 * usuário: professor
 * senha:   1234
 * 
 * Alunos:
 * usuário: joao        senha:  123
 * usuário: tiago       senha:  123
 * usuário: joana       senha:  123
 * usuário: guilherme   senha:  123
 * usuário: micaela     senha:  123
 * 
 */