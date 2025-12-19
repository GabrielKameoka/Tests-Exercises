using System;
namespace reverseWordsExercise;
class Program
{
    public static string ReverseWords(string word)
    {
        //transforma a string recebida para um array de caracteres
        char[] charArray = word.ToCharArray();
        int left = 0;
        int right = word.Length - 1; //sempre começa no final da palavra

        //enquanto os ponteiros não se cruzam
        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp; 
            
            left++;
            right--;
        }
        
        return new string(charArray);
    }
    
    static void Main(string[] args)
    {
        Console.Write("Enter a Word: ");
        string word = Console.ReadLine();
        
        Console.WriteLine(ReverseWords(word));
    }
}