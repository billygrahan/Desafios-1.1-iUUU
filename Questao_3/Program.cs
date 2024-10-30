using Questao_2;
using Questao_3;
Vertice[] vertices_1 = [
    new Vertice(1, 1), 
    new Vertice(1, 2), 
    new Vertice(2, 1)
    ];

Vertice[] vertices_2 = [
    new Vertice(4, 5),
    new Vertice(4, 3),
    new Vertice(7, 3)
    ];

Triangulo triangulo_1 = new Triangulo(vertices_1);
Triangulo triangulo_2 = new Triangulo(vertices_2);

Console.WriteLine($"Area triangulo 1 : { triangulo_1.Area}");
Console.WriteLine($"Perimetro triangulo 1: {triangulo_1.Perimetro}");
Console.WriteLine($"Tipo triangulo 1 : {triangulo_1.Tipo} \n");

Console.WriteLine($"Area triangulo 2 : {triangulo_2.Area}");
Console.WriteLine($"Perimetro triangulo 2: {triangulo_2.Perimetro}");
Console.WriteLine($"Tipo triangulo 2 : {triangulo_2.Tipo} \n");

Console.WriteLine($"Os triangulos 1 e 2 são iguais : {triangulo_1.Triangulos_iguais(triangulo_2)}");


//Console.WriteLine($"{triangulo_1[0].X} , {triangulo_1[0].Y}");