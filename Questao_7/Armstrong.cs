

namespace Questao_7;

public static class Armstrong
{
    public static bool IsArmstrong(this int num)
    {
        string num_str = num.ToString();
        int[] numeros = new int[num_str.Length];
        
        for (int i = 0; i < num_str.Length; i++)
        {
            numeros[i] = num_str[i] - '0';
        }

        int num_Armstrong = 0;

        foreach (int dig in numeros)
        {
            num_Armstrong += (int)Math.Pow(dig , numeros.Length);
        }

        return num == num_Armstrong;
    }

    public static void Numeros_Armstrong(this int num)
    {
        for (int i = 1; i <= 10000; i++)
        {
            if (i.IsArmstrong())
            {
                Console.WriteLine(i);
            }
        }
    }
}
