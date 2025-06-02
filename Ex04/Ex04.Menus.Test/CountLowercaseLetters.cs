using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class CountLowercaseLetters : IMenuItemExecutable
    {
        public void Execute()
        {
            Console.WriteLine("please enter a sentence: "); 
            string    m_sentenceInput = Console.ReadLine();
            int       m_countLowerLetter = 0;

            foreach(char letter in m_sentenceInput)
            {
                if (char.IsLower(letter))
                {
                    m_countLowerLetter++;
                }
            }

            Console.WriteLine($"The number of lowercase letter in the sentence is: {m_countLowerLetter}");
        }
    }
}
