

namespace Questao_2;

public class Vertice
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Vertice(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public void Move(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public double Distancia(Vertice vertice)
    {
        return
            (double)( Math.Sqrt( Math.Pow(X - vertice.X, 2) + Math.Pow(Y - vertice.Y, 2) ) );
    }

    public bool Vertices_iguais(Vertice vertice)
    {
        if (X == vertice.X && Y == vertice.Y)
            return true;
            //Console.WriteLine($"os vertices são iguais! \t v = [{X} , {Y}]");

        else 
            return false;
            //Console.WriteLine($"Os vertices são diferentes! \t v1 = [{X} , {Y}] ; v2 = [{vertice.X} , {vertice.Y}]");
    }
}

