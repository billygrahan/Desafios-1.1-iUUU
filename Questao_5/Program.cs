using Questao_5;

Intervalo evento = new Intervalo(new DateTime(2023, 10, 19, 00, 00, 00), new DateTime(2023, 10, 21, 23, 59, 59));
Intervalo evento2 = new Intervalo(new DateTime(2024, 10, 19, 00, 00, 00), new DateTime(2024, 10, 21, 23, 59, 59));

Console.WriteLine($"Duracao evento :{evento.Duracao.Days} dias, {evento.Duracao.Hours} horas e {evento.Duracao.Minutes} minutos");
Console.WriteLine($"Duracao evento2 :{evento2.Duracao.Days} dias, {evento2.Duracao.Hours} horas e {evento2.Duracao.Minutes} minutos");
Console.WriteLine($"intersessao de evento com evento2 : {evento.TemIntersecao(evento2)}");
Console.WriteLine($"são iguais : {evento.Intervalos_iguais(evento2)}");