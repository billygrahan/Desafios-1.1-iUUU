using _2_quention;

Vertice vertice_1 = new Vertice(3,2);
Vertice vertice_2 = new Vertice(3, 4);

Reta reta = new Reta(vertice_1, vertice_2);

reta.Distancia();
reta.Vertices_iguais();

vertice_2.Move(3, 2);

reta.Distancia();
reta.Vertices_iguais();
