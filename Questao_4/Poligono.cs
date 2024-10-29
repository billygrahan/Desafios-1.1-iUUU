using Questao_2;
namespace Questao_4;

public class Poligono
{
    private List<Vertice> vertices_poligono = new List<Vertice>();

    public Poligono(List<Vertice> vertices)
    {
        vertices_poligono = (vertices.Count >= 3) ? vertices : 
            throw new ArgumentOutOfRangeException(nameof(vertices), "A quantidade de vertices deve ser maior ou igual a 3.");
    }

    public bool AddVertice(Vertice vertice)
    {
        if (vertices_poligono.IndexOf(vertice) != -1) return false;
        else
        {
            vertices_poligono.Add(vertice);
            return true;
        }
    }

    public void RemoveVertice(int x, int y)
    {
        if (vertices_poligono.Count <= 3)
            throw new ArgumentOutOfRangeException(nameof(vertices_poligono), "Remoção não concedida! O polígono não pode ter menos de 3 vértices!");

        if (vertices_poligono.RemoveAll(vertice => vertice.X == x && vertice.Y == y) > 0)
            Console.WriteLine($"Vértice ({x}, {y}) removido com sucesso.");
        else
            Console.WriteLine($"Vértice ({x}, {y}) não encontrado no polígono.");
    }


    public float Perimetro()
    {
        double perimetro = 0;
        int qtd = Qtd_vertices();
        for (int i = 0; i < qtd; i++)
        {
            perimetro += (i == qtd - 1) ? 
                vertices_poligono[i].Distancia(vertices_poligono[0]) 
                : vertices_poligono[i].Distancia(vertices_poligono[i + 1]);
        }
        return (float)perimetro;
    }

    public int Qtd_vertices()
    {
        return (int)vertices_poligono.Count;
    }
}

