
namespace Questao_9;

public class Motor
{
    public float Cilindrada { get; private set; }

    public Carro? carro { get; set; }

    public Motor(float Cilindrada)
    {
        this.Cilindrada = Cilindrada;
    }

    public Motor(float Cilindrada, Carro carro)
    {
        this.Cilindrada = Cilindrada;
        this.carro = carro;
    }
}
