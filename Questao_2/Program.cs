using Questao_2;

Vertice vertice_1 = new Vertice(3,2);
Vertice vertice_2 = new Vertice(3, 4);

Console.Write("distancia entre os vertices 1 e 2: ");
Console.WriteLine(vertice_1.Distancia(vertice_2));

Console.Write("Vertice 1 é igual ao vertice 2: ");
Console.WriteLine(vertice_2.Vertices_iguais(vertice_1));

vertice_2.Move(3, 2);

Console.Write("\ndistancia entre os vertices 1 e 2 (apos o Move() do vertice 2 para (3, 2) ): ");
Console.WriteLine(vertice_1.Distancia(vertice_2));

Console.Write("Vertice 1 é igual ao vertice 2: ");
Console.WriteLine(vertice_2.Vertices_iguais(vertice_1));
