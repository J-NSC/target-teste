namespace Soma;

class Program
{
    static void Main()
    {
        int INDICE = 12;
        int SOMA = 0;
        int K = 1;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
            Console.WriteLine(SOMA);
        }

        Console.WriteLine("O valor final de SOMA é: " + SOMA);
    }
}