public class GerenciadorDeVoo
{
    int teste = 0;
    public int numVoo;
    public DateTime dtVoo;

    public GerenciadorDeVoo(int numVoo, DateTime dataVoo)
    {
        this.SetVoo(numVoo);
        this.SetData(dataVoo);        
    }
    public void ProxLivre()
    {
        //retorna o número da próxima cadeira livre

    }
    public void VerificarPoltrona(int numPoltrona)
    {
        //verifica se o número da cadeira recebido como parâmetro está ocupada

    }
    public char OcuparPoltrona()
    {
        //ocupa determinada cadeira do voo, cujo número é recebido como parâmetro, e retorna verdadeiro se a cadeira ainda não estiver
        //ocupada(operação foi bem sucedida) e falso caso contrário

        return 'a';
    }
    public int PoltronasDisponiveis()
    {
        //retorna o número de cadeiras vagas disponíveis (não ocupadas) no voo
        return 0;
    }

    // GET/SET VOO: retorna o número do voo
    public void SetVoo(int numeroVoo)
    {
        this.numVoo = numeroVoo;
    }
    public int GetVoo()
    {
        return this.numVoo;
    }

    // GET/SET DATA: retorna a data do voo
    public void SetData(DateTime dataVoo)
    {
        this.dtVoo = dataVoo;
    }
    public DateTime GetData()
    {
        return this.dtVoo;
    }

}
