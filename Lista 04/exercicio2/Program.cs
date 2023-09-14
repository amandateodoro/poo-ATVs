internal class Program
{
    static void Main(string[] args)
    {
        string resposta = "n";
        int contAluno = 1;

        Prova prova = new Prova();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Resposta {i+1} do Aluno {contAluno}");
            char respostaAluno = Convert.ToChar(Console.ReadLine().ToUpper());
            prova.RespostaAluno(respostaAluno);
        }

        Console.WriteLine($"Quantidade de acertos: {prova.Acertos()}");
        Console.WriteLine($"Nota do Aluno: {prova.Nota()}");

        prova.notaMaior = prova;

        Console.WriteLine("Deseja adicionar nova prova?");
        resposta = Console.ReadLine().ToUpper();


        while (resposta.Equals("S") || resposta.Equals("SIM"))
        {
            contAluno++;
            prova = new Prova(prova.notaMaior);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Resposta {i + 1} do Aluno {contAluno}");
                char respostaAluno = Convert.ToChar(Console.ReadLine().ToUpper());
                prova.RespostaAluno(respostaAluno);
            }

            Console.WriteLine($"Quantidade de acertos: {prova.Acertos()}");
            Console.WriteLine($"Nota do Aluno: {prova.Nota()}");

            prova.MaiorNota();
            Console.WriteLine("Deseja adicionar nova prova?");
            resposta = Console.ReadLine().ToUpper();            
        }

        Console.WriteLine($"Maior nota: {prova.notaMaior.notaAluno}");
    }
}
