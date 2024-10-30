using Questao_8;

Pessoa Ronocliudo = new Pessoa("Ronocliudo");

Console.WriteLine($"Nome: {Ronocliudo.nome}");
Console.WriteLine(Ronocliudo.Certidao);

CertidaoNascimento certidao_Ronocliudo = new CertidaoNascimento(new DateTime(2024, 10, 26), Ronocliudo);

Console.WriteLine($"Nome: {Ronocliudo.nome}");
Console.WriteLine(Ronocliudo.Certidao.dataEmissao);