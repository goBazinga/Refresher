using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    public class StringsAndArray
    {


        public static string ReverseArray(string input)
        {
            var inputArray = input.ToCharArray();
            var median = inputArray.Length / 2;        

            var result = inputArray;           

            for (int i = 0, j = inputArray.Length - 1; i < median; i++, j--)
            {
                var endChar = result[j];                
                result[j] = result[i];
                result[i] = endChar;
            }

            return new String(result);


            //Alternative Implementation
            /*
            int leftIndex = 0;
            int rightIndex = arrayOfChars.Length - 1;

            while (leftIndex < rightIndex)
            {
                // Swap characters
                char temp = arrayOfChars[leftIndex];
                arrayOfChars[leftIndex] = arrayOfChars[rightIndex];
                arrayOfChars[rightIndex] = temp;

                // Move towards middle
                leftIndex++;
                rightIndex--;
            }
            */
        }


        public static string ReverseWords(char[] message, bool alternateSolution)
        {

            //Alternate Implementtion

            if(alternateSolution)
            {
                string input = new string(message);
                string[] words = input.Split(' ');

                int leftIndex = 0;
                int rightIndex = words.Length - 1;

                while (leftIndex < rightIndex)
                {
                    // Swap characters
                    string temp = words[leftIndex];
                    words[leftIndex] = words[rightIndex];
                    words[rightIndex] = temp;

                    // Move towards middle
                    leftIndex++;
                    rightIndex--;

                }
                return string.Join(' ', words);

            }
                       

            // First we reverse all the characters in the entire message array
            ReverseCharacters(message, 0, message.Length - 1);

            // This gives us the right word order,
            // but with each word backward.
            // Now we'll make the words forward again
            // by reversing each word's characters

            // We hold the index of the *start* of the current word
            // as we look for the *end* of the current word
            int currentWordStartIndex = 0;
            for (int i = 0; i <= message.Length; i++)
            {
                // Found the end of the current word!
                if (i == message.Length || message[i] == ' ')
                {
                    // If we haven't exhausted the array our
                    // next word's start is one character ahead
                    ReverseCharacters(message, currentWordStartIndex, i - 1);
                    currentWordStartIndex = i + 1;
                }
            }

            return new string(message);
        }

        public static void ReverseCharacters(char[] message, int leftIndex, int rightIndex)
        {
            // Walk towards the middle, from both sides
            while (leftIndex < rightIndex)
            {
                // Swap the left char and right char
                char temp = message[leftIndex];
                message[leftIndex] = message[rightIndex];
                message[rightIndex] = temp;
                leftIndex++;
                rightIndex--;
            }
        }





    }
       





    }

