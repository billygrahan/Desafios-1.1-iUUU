using System;
using System.Globalization;
using System.Text.RegularExpressions;

public class Cliente
{
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public float RendaMensal { get; private set; }
    public char EstadoCivil { get; private set; }
    public int Dependentes { get; private set; }

    public Cliente()
    {
        Console.WriteLine("\n=================================================================================");
        Nome = SolicitarNome();
        CPF = SolicitarCPF();
        DataNascimento = SolicitarDataNascimento();
        RendaMensal = SolicitarRendaMensal();
        EstadoCivil = SolicitarEstadoCivil();
        Dependentes = SolicitarDependentes();
        Console.WriteLine("=================================================================================\n");
    }

    private string SolicitarNome()
    {
        string nome;
        do
        {
            Console.Write("Digite o Nome (mínimo 5 caracteres): ");
            nome = Console.ReadLine();
            if (nome.Length < 5)
                Console.WriteLine("o nome deve ter pelo menos 5 caracteres. XXXXXXXXXXXXXXXXXXXXXXXXX");
        } while (nome.Length < 5);

        return nome;
    }

    private string SolicitarCPF()
    {
        string cpf;
        do
        {
            Console.Write("Digite o CPF (11 dígitos): ");
            cpf = Console.ReadLine();
            if (!ValidarCPF(cpf))
                Console.WriteLine("CPF inválido. XXXXXXXXXXXXX");
        } while (!ValidarCPF(cpf));

        return cpf;
    }

    private bool Numeros_Iguais(string cpf)
    {
        for (int i = 1; i < cpf.Length; i++)
        {
            if (cpf[i] != (char)cpf[0])
                break;

            if (i == cpf.Length - 1)
                return true;
        }
        return false;
    }
    private bool ValidarCPF(string cpf)
    {
        if (cpf.Length != 11 || !cpf.All(char.IsDigit) || Numeros_Iguais(cpf)) return false;

        int[] pesos1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] pesos2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        int soma1 = 0;
        int soma2 = 0;

        for (int i = 0; i < 9; i++)
        {
            soma1 += (cpf[i] - '0') * pesos1[i];
            soma2 += (cpf[i] - '0') * pesos2[i];
        }

        int Primeiro_Digito = (soma1 % 11 < 2) ? 0 : 11 - (soma1 % 11);

        soma2 += Primeiro_Digito * pesos2[9];

        int Segundo_Digito = (soma2 % 11 < 2) ? 0 : 11 - (soma2 % 11);

        return Primeiro_Digito == cpf[9] - '0' && Segundo_Digito == cpf[10] - '0';
    }

    private DateTime SolicitarDataNascimento()
    {
        DateTime dataNascimento;
        while (true)
        {
            Console.Write("Digite a Data de Nascimento (DD/MM/AAAA): ");
            string dataNascimento_str = Console.ReadLine();

            if (! (DateTime.TryParseExact(dataNascimento_str, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento) ))
            {
                Console.WriteLine("data no formato incorreto. XXXXXXXXXXXXXXXXXXXXXXXXXXX");
                continue;
            }

            if ( dataNascimento >= DateTime.Now.AddYears(-18))
            {
                Console.WriteLine("cliente deve ter pelo menos 18 anos. XXXXXXXXXXXXXXXXXXXXXXXXX");
                continue;
            }

            break;
        }

        return dataNascimento;
    }

    private float SolicitarRendaMensal()
    {
        float rendaMensal;
        while (true)
        {
            Console.Write("Digite a Renda Mensal (usar vírgula para casas decimais): ");
            string rendaMesnsalstr = Console.ReadLine();
            if (!(float.TryParse(rendaMesnsalstr, NumberStyles.Float, CultureInfo.CurrentCulture, out rendaMensal) || rendaMensal < 0))
            {
                Console.WriteLine("renda inválida. Deve ser um valor positivo com duas casas decimais. XXXXXXXXXXXXXXXXXXXXXXXXX");
                continue;
            }
            break;
        }

        return rendaMensal;
    }

    private char SolicitarEstadoCivil()
    {
        char estadoCivil;
        do
        {
            Console.Write("Digite o Estado Civil (C, S, V, D). obs: a letra é submetida altomaticamente (não precisa apertar enter) :");
            estadoCivil = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (estadoCivil != 'C' && estadoCivil != 'S' && estadoCivil != 'V' && estadoCivil != 'D')
                Console.WriteLine("estado civil inválido. Deve ser C, S, V ou D. XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        } while (estadoCivil != 'C' && estadoCivil != 'S' && estadoCivil != 'V' && estadoCivil != 'D');

        return estadoCivil;
    }

    private int SolicitarDependentes()
    {
        int dependentes;
        do
        {
            Console.Write("Digite o número de Dependentes (0 a 10): ");
            string dependentes_str = Console.ReadLine();
            if (!(int.TryParse(dependentes_str, out dependentes) || dependentes < 0 || dependentes > 10))
                Console.WriteLine("número de dependentes inválido. Deve ser entre 0 e 10. XXXXXXXXXXXXXXXXXXXXXXXXXXX");
        } while (dependentes < 0 || dependentes > 10 || dependentes == null);

        return dependentes;
    }

    public void ImprimirDados()
    {
        //Console.WriteLine("\n=================================================================================\n");

        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Renda Mensal: {RendaMensal}");
        Console.WriteLine($"Estado Civil: {EstadoCivil}");
        Console.WriteLine($"Dependentes: {Dependentes}");

        //Console.WriteLine("\n=================================================================================\n");
    }
}
