public class Prova
{
    Gabarito gabarito;
    public int notaAluno;
    public Prova notaMaior;
    int contAcertos = 0;
    List<char> respostasAluno = new List<char>();

    public Prova()
    {
        gabarito = new Gabarito();
    }
    public Prova(Prova provamaior)
    {
        gabarito = new Gabarito();
        this.notaMaior = provamaior;
    }
    public void RespostaAluno(char resposta)
    {
        respostasAluno.Add(resposta);
    }

    public int Acertos()
    {
        for (int i = 0; i < 5; i++)
        {
            if (gabarito.RespostaQuestao(i) == respostasAluno[i])
            {
                contAcertos++;
            }
        }
        return contAcertos;
    }

    public int Nota()
    {
        notaAluno = contAcertos * 2;
        return notaAluno;
    }

    public void MaiorNota()
    {
        if (notaAluno > notaMaior.notaAluno)
        {
            notaMaior.notaAluno = notaAluno;
            notaMaior.contAcertos = contAcertos;
            notaMaior.respostasAluno = respostasAluno;
        }
    }
}