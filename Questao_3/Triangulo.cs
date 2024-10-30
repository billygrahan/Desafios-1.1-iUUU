using Questao_2;

namespace Questao_3;

public class Triangulo
{
    private Vertice[] triangulo = new Vertice[3];

    public Triangulo(Vertice[] triangulo)
    {
        if (triangulo.Length != 3 || Verifica_Area(triangulo) == (double)0.0)
        {
            throw new ArgumentException("Um triângulo deve ter exatamente 3 vértices que não podem ser colineares!");
        }

        this.triangulo = triangulo;
    }

    public Vertice this[int index]
    {
        get => triangulo[index];
    }

    // Propriedade para Area
    public float Area
    {
        get
        {
            double a = triangulo[0].Distancia(triangulo[1]);
            double b = triangulo[1].Distancia(triangulo[2]);
            double c = triangulo[2].Distancia(triangulo[0]);

            double S = (a + b + c) / 2.0;

            return (float)Math.Sqrt(S * (S - a) * (S - b) * (S - c));
        }
    }

    private float Verifica_Area(Vertice[] triangulo)
    {
        double a = triangulo[0].Distancia(triangulo[1]);
        double b = triangulo[1].Distancia(triangulo[2]);
        double c = triangulo[2].Distancia(triangulo[0]);

        double S = (a + b + c) / 2.0;

        return (float)Math.Sqrt(S * (S - a) * (S - b) * (S - c));
    }

    // Propriedade para Perimetro
    public float Perimetro
    {
        get
        {
            double a = triangulo[0].Distancia(triangulo[1]);
            double b = triangulo[1].Distancia(triangulo[2]);
            double c = triangulo[2].Distancia(triangulo[0]);

            return (float)(a + b + c);
        }
    }

    // Propriedade para Tipo
    public string Tipo
    {
        get
        {
            double a = triangulo[0].Distancia(triangulo[1]);
            double b = triangulo[1].Distancia(triangulo[2]);
            double c = triangulo[2].Distancia(triangulo[0]);

            if (a == b && b == c) return "Equilátero";
            else if (a == c || b == c || a == b) return "Isósceles";
            else return "Escaleno";
        }
    }

    public bool Triangulos_iguais(Triangulo triangulo)
    {
        double a1 = this.triangulo[0].Distancia(this.triangulo[1]);
        double b1 = this.triangulo[1].Distancia(this.triangulo[2]);
        double c1 = this.triangulo[2].Distancia(this.triangulo[0]);

        double a = triangulo[0].Distancia(triangulo[1]);
        double b = triangulo[1].Distancia(triangulo[2]);
        double c = triangulo[2].Distancia(triangulo[0]);

        double[] triangulo_1 = { a1, b1, c1 };
        double[] triangulo_2 = { a, b, c };

        Array.Sort(triangulo_1);
        Array.Sort(triangulo_2);

        return triangulo_1.SequenceEqual(triangulo_2);
    }
}
