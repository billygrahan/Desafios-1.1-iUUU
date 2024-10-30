namespace Questao_8;

public class CertidaoNascimento
{
    public DateTime dataEmissao { get; private set; }
    public Pessoa pessoa { get; private set; }

    public CertidaoNascimento(DateTime dataEmissao, Pessoa pessoa)
    {
        this.dataEmissao = dataEmissao;
        this.pessoa = (pessoa.Certidao == null) ? pessoa
            : throw new InvalidOperationException("A pessoa já possui uma certidão de nascimento.");

        pessoa.Certidao = this; // Usa o `set` da propriedade para atribuir a certidão
        Console.WriteLine($"\nCriada Certidão de {pessoa.nome}\n");
    }
}
