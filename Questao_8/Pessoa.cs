namespace Questao_8;

public class Pessoa
{
    public string nome { get; set; }

    public CertidaoNascimento? Certidao { get; private set; }

    public Pessoa(string nome)
    {
        this.nome = nome;
    }

    /*
    public Pessoa(string nome, CertidaoNascimento Certidao)
    {
        this.nome = nome;
        this.Certidao = Certidao;
    }
    */

    public void SetCertidao(CertidaoNascimento Certidao)
    {
        this.Certidao = (this.Certidao == null) ? Certidao 
            : throw new InvalidOperationException("A pessoa já possui uma certidão de nascimento.");

    }
}
