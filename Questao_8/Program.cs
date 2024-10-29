using Questao_8;

Pessoa Ronocliudo = new Pessoa("Ronocliudo");
Ronocliudo.set_certidao(new CertidaoNascimento(new DateTime(2024,10,26),Ronocliudo));


Pessoa Mazin = new Pessoa("Mazin");

Console.WriteLine(Ronocliudo.nome);
Console.WriteLine(Ronocliudo.Certidao.dataEmissao);
Console.WriteLine(Mazin.nome);