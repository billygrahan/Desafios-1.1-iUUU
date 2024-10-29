
namespace Questao_9;

public class Carro
{
    public string Placa { get; private set; }
    public string Modelo { get; private set; }
    public Motor motor { get; set; }

    public Carro(Motor motor)
    {
        this.motor = (motor.carro == null) ? motor : throw new InvalidOperationException("O motor ja está instalado em um carro!");
    }

    public string VelocidadeMaxima()
    {
        if (motor == null) return "O carro não possui Motor";
        else if (motor.Cilindrada <= 1.0) return "140 Km/h";
        else if (motor.Cilindrada <= 1.6) return "160 Km/h";
        else if (motor.Cilindrada <= 2.0) return "180 Km/h";
        else return "220 Km/h";
    }
}
