using System;
using System.Text;

namespace ReverseWordsInString;

public class Program
{
    public static string ReverseWords(string s)
    {
        StringBuilder result = new StringBuilder();
        int left = 0, right = 0;
        int n = s.Length;

        //enquanto o ponteiro da direita não é o final da string
        while (right < s.Length)
        {
            //Avançamos o ponteiro right até encontrar um espaço ou o final da string.
            //Isso identifica o final da palavra atual.
            while (right < n && s[right] != ' ')
                right++;

            //right - 1 é o último caractere da palavra atual
            //left é o primeiro caracere, então percorrerá do right - 1 até left invertendo-os na nova string
            for (int i = right - 1; i >= left; i--)
                result.Append(s[i]);

            if (right < n && s[right] == ' ')
            {
                result.Append(' ');
                right++;
                left = right;
            }
        }
        
        return result.ToString();
    }


    public static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(ReverseWords(s));
    }
}