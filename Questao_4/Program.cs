using Questao_2;
using Questao_4;

List<Vertice> vertices = new List<Vertice>
{
    new Vertice(1,1),
    new Vertice(1,2),
    new Vertice(2,2),
    new Vertice(2,1),
};

Poligono poligono = new Poligono(vertices);

Console.WriteLine($"Quantidade de Vertices : {poligono.Qtd_vertices()}");
Console.WriteLine($"Perimetro : {poligono.Perimetro()}");

Console.WriteLine($"Addvertice : {poligono.AddVertice(new Vertice(3, 3))}");

Console.WriteLine($"Quantidade de Vertices : {poligono.Qtd_vertices()}");
Console.WriteLine($"Perimetro : {poligono.Perimetro()}");

poligono.RemoveVertice(3,3);

Console.WriteLine($"Quantidade de Vertices : {poligono.Qtd_vertices()}");
Console.WriteLine($"Perimetro : {poligono.Perimetro()}");