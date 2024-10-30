using Questao_5;
namespace Questao_6;

public class ListaIntervalo
{
    public List<Intervalo> intervalos = new List<Intervalo>();

    /*public ListaIntervalo(List<Intervalo> intervalos)
    {
        this.intervalos = intervalos;
    }*/

    public List<Intervalo> Intervalos
    {
        get
        {
            return intervalos.OrderBy(i => i.DataInicial).ToList();
        }
    }

    public bool Add(Intervalo intervalo)
    {
        foreach (Intervalo i in intervalos)
        {
         if (i.TemIntersecao(intervalo))
            {
                Console.WriteLine($"\nintervalo ({intervalo.DataInicial},{intervalo.DataFinal} não adicionado por fazer interceção com evento ({i.DataInicial},{i.DataInicial})\n");
                return false;
            }
        }
        
        intervalos.Add(intervalo);
        Console.WriteLine($"\nintervalo {intervalo.DataInicial},{intervalo.DataFinal} Adicionado\n");
        return true;
    }
}
