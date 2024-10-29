using Questao_5;

Intervalo evento = new Intervalo(new DateTime(2023, 10, 19, 00, 00, 00), new DateTime(2024, 10, 21, 23, 59, 59));

Console.WriteLine($"{evento.Tempo().Days} dias, {evento.Tempo().Hours} horas e {evento.Tempo().Minutes} minutos");