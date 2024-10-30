namespace Questao_8;

public class Pessoa
{
    public string nome { get; set; }

    private CertidaoNascimento? certidao;
    
    /*
    public Pessoa(string nome, CertidaoNascimento Certidao)
    {
        this.nome = nome;
        this.Certidao = Certidao;
    }
    */
    
    public Pessoa(string nome)
    {
        this.nome = nome;
    }

    public CertidaoNascimento? Certidao
    {
        get => certidao;
        set
        {
            if (certidao == null)
            {
                certidao = value;
            }
            else
            {
                throw new InvalidOperationException("A pessoa já possui uma certidão de nascimento.");
            }
        }
    }
}

