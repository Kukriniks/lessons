using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        foreach (var word in GetWordIterator(GetWords(3,100)))
        {
            Console.WriteLine(word);
        }       
    }

    static IEnumerable<string> GetWordIterator(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 4)
            {
                yield return words[i];
            }
        }
    }
     static string[] GetWords(int wordCount, int DictionaryCount)
    { 
        Dictionary<int,string> myDict = new Dictionary<int,string>();

        Random random = new Random();
        for (int i = 0; i < DictionaryCount; i++) //add DictionaryCount words to dictionary
        {
            string word = (random.Next(900, 100_000)).ToString();
            myDict.Add(i, word);
        }

        string[] fromDictionary = new string[wordCount];

        for (int i = 0; i < wordCount; i++) //add wordCount random words from dictionary to the string array
        {
             myDict.TryGetValue(random.Next(0, myDict.Count),out fromDictionary[i]);
        }
        return fromDictionary;
    }
}