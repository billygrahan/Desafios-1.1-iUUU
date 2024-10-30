using Questao_5;
using Questao_6;

Intervalo evento1 = new Intervalo(new DateTime(2026, 10, 19, 00, 00, 00), new DateTime(2026, 10, 21, 23, 59, 59));
Intervalo evento2 = new Intervalo(new DateTime(2024, 10, 19, 00, 00, 00), new DateTime(2024, 10, 21, 23, 59, 59));
Intervalo evento3 = new Intervalo(new DateTime(2024, 10, 24, 00, 00, 00), new DateTime(2024, 10, 26, 23, 59, 59));
Intervalo evento4 = new Intervalo(new DateTime(2024, 10, 21, 00, 00, 00), new DateTime(2024, 10, 24, 23, 59, 59));

ListaIntervalo eventos =  new ListaIntervalo();

eventos.Add(evento1);
eventos.Add(evento2);
eventos.Add(evento3);
eventos.Add(evento4);

foreach (Intervalo evento in eventos.intervalos) 
    Console.WriteLine($"(inicio : {evento.DataInicial} , Fim : {evento.DataFinal})");

foreach (Intervalo evento in eventos.Intervalos) 
    Console.WriteLine($"(inicio : {evento.DataInicial} , Fim : {evento.DataFinal})");