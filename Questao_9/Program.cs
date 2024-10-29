using Questao_9;

Motor motor1 = new Motor((float)4.0);

Carro fiat_uno = new Carro("123456", "fiat uno", motor1);

Carro chevrolet_supra = new Carro("101010", "Chevrolet Supra", new Motor((float)1.8));

Console.WriteLine($"Modelo: {fiat_uno.Modelo}");
Console.WriteLine($"cilindrada: {fiat_uno.motor.Cilindrada}");
Console.WriteLine($"Velocidade: {fiat_uno.VelocidadeMaxima()}");

fiat_uno.TrocarMotor(new Motor((float)1.0));

Console.WriteLine($"Modelo: {fiat_uno.Modelo}");
Console.WriteLine($"cilindrada: {fiat_uno.motor.Cilindrada}");
Console.WriteLine($"velocidade: {fiat_uno.VelocidadeMaxima()}");

Console.WriteLine();

Console.WriteLine($"Modelo: {chevrolet_supra.Modelo}");
Console.WriteLine($"cilindrada: {chevrolet_supra.motor.Cilindrada}");
Console.WriteLine($"velocidade: {chevrolet_supra.VelocidadeMaxima()}");