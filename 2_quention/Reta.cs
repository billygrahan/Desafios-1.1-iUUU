
namespace _2_quention;

public class Reta
{
    private Vertice[] vertices = new Vertice[2];

    public Reta(Vertice v1, Vertice v2)
    {
        vertices = [v1, v2];
    }

    public void Distancia()
    {
        Console.WriteLine( 

            Math.Sqrt( Math.Pow(vertices[0].X - vertices[1].X , 2) + Math.Pow(vertices[0].Y - vertices[1].Y , 2) ) 
            
            );
    }

    public void Vertices_iguais()
    {
        if (vertices[0].X == vertices[1].X && vertices[0].Y == vertices[1].Y) Console.WriteLine($"os vertices são iguais! \t v = [{vertices[0].X} , {vertices[0].Y}]");

        else Console.WriteLine($"Os vertices são diferentes! \t v1 = [{vertices[0].X} , {vertices[0].Y}] ; v2 = [{vertices[1].X} , {vertices[1].Y}]");
    }
}
