public class Gabarito
{
    List<char> alternativasCorretas = new List<char>();

    public Gabarito()
    {
        alternativasCorretas.Add('A'); //posição 0, questão 1
        alternativasCorretas.Add('B'); //posição 1, questão 2
        alternativasCorretas.Add('C'); //posição 2, questão 3
        alternativasCorretas.Add('D'); //posição 3, questão 4
        alternativasCorretas.Add('E'); //posição 4, questão 5

    }
    public char RespostaQuestao(int numeroQuestao)
    {
        return alternativasCorretas[numeroQuestao];
    }
}