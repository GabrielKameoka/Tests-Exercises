using System;

namespace JanelaDeTamanhoFixo;

class Program
{
    //ex: numeros = {1, 4, 2, 10, 23, 3}, k = 4
    static int JanelaDeTamanhoFixo(int[] numeros, int k)
    {
        int somaMax = 0;
        int janelaSoma = 0;

        for (int i = 0; i < k; i++)
            janelaSoma += numeros[i]; //primeira janela: soma os 4 primeiros números (numeros {1 + 4 + 2 + 10} = 17)

        somaMax = janelaSoma; //aloca o resultado da soma em somaMax (17)

        //janela deslizante
        for (int i = k; i < numeros.Length; i++)
        {
            janelaSoma = janelaSoma + numeros[i] - numeros[i - k]; //adiciona o próximo elemento (números[i]) e remove o elemento que saiu da janela 
            somaMax = Math.Max(somaMax, janelaSoma);
            //Compara somaMax e janelaSoma.
            //Se janelaSoma for maior, somaMax passa a ser janelaSoma.
            //Se não for, somaMax continua igual.
        }
        return somaMax;
    }
    
    static void Main(string[] args)
    {
        int[] numeros = {1, 4, 2, 10, 23, 3};
        Console.WriteLine(JanelaDeTamanhoFixo(numeros, 4));
    }
}