
namespace Questao_1;

public class Piramide
{
    public int N { get; set; }

    public Piramide(int N)
    {
        this.N = (N > 0) ? N : throw new ArgumentOutOfRangeException(nameof(N), "O valor de N deve ser maior ou igual a 1.");
    }

    public void Desenha()
    {
        for (int j = 1; j <= N; j++)
        {
            for (int i = 1; i <= (N + (N - 1)); i++)
            {
                if (i <= N && i > (N - j)) Console.Write(j - (N - i));
                
                else if (i > N && i < (N + j)) Console.Write(j - (i - N));
                
                else Console.Write(" ");
                
            }
            
            Console.WriteLine("");
        }
        
    }


}

