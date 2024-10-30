namespace Questao_5;

public class Intervalo
{
    public DateTime DataInicial { get;private set; }
    public DateTime DataFinal { get;private set; }

    public Intervalo(DateTime inicio, DateTime final)
    {
        if(inicio >= final) 
            throw new ArgumentException("A data inicial deve ser anterior à data final.");

        DataInicial = inicio;
        DataFinal = final;
    }

    public bool TemIntersecao(Intervalo intervalo2)
    {
        return
            (DataInicial <= intervalo2.DataInicial && intervalo2.DataInicial <= DataFinal) ||
            (intervalo2.DataInicial <= DataInicial && DataInicial <= intervalo2.DataFinal);
    }

    public TimeSpan Duracao
    {
        get => DataFinal - DataInicial;
    }

    public bool Intervalos_iguais(Intervalo intervalo2)
    {
        return (DataInicial == intervalo2.DataInicial && DataFinal == intervalo2.DataFinal);
    }
}
