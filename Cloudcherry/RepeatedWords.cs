using System;
using System.Collections.Generic;
using System.Linq;

namespace Cloudcherry
{
    //class to find the repeated words
    internal class RepeatedWords
    {
        public void FindRepeatedWords(List<RequiredAnswer> requiredAnswersList)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string paragraph = null;

            //make it pargraph so that it will be easy to work
            foreach (var answer in requiredAnswersList)
            {
                paragraph = paragraph + " " + answer.InputText;
            }

            //split sentences into words
            var splitParagraph = paragraph.ToLower().Split(' ');

            foreach (var word in splitParagraph)
            {
                //since most common pronouns, prepositions are of length 3 or less, ignore them
                if (word.Length < 4)
                {
                    continue;
                }
                //if the word is already present in the dict
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                //else
                else
                {
                    wordCount.Add(word, 1);
                }
            }
            //sort the dict in descending order and take top 5 words
            var sortedDict = (from entry in wordCount orderby entry.Value descending select entry).Take(5);

            Console.WriteLine("5 most repeated words are:");
            //print them
            foreach (var itr in sortedDict)
            {
                Console.WriteLine($"\"{itr.Key}\" : Repeated {itr.Value} times");
            }
        }
    }
}