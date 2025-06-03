using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Test;



namespace Ex04.Menus.Test
{
    internal class Program
    {
        static void Main()
        {
            MainMenu m_mainMenu = new Interfaces.MainMenu("Main Menu");

            MenuItem m_LettersAndVersions = new MenuItem("Letters and Versions");
            m_LettersAndVersions.AddSubItem(new MenuItem("ShowMenu Version", new ShowVersion()));
            m_LettersAndVersions.AddSubItem(new MenuItem("Count Lowercase Letter", new CountLowercaseLetters()));

            MenuItem m_CurrentDateOrTime = new MenuItem("ShowMenu Current Date/Time");
            m_CurrentDateOrTime.AddSubItem(new MenuItem("ShowMenu Current Date", new ShowCurrentDate()));
            m_CurrentDateOrTime.AddSubItem(new MenuItem("ShowMenu Current Time", new ShowCurrentTime()));

            m_mainMenu.AddMenuItem(m_LettersAndVersions);
            m_mainMenu.AddMenuItem(m_CurrentDateOrTime);

            m_mainMenu.ShowMenu();
        }
    }
}
/* 
 ﻿using System;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenu delegatesMenu = buildMenuWithDelegates();
            delegatesMenu.Show();
        }

        private static MainMenu buildMenuWithDelegates()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");

            MenuItem lettersAndVersion = new MenuItem("Letters and Version");
            lettersAndVersion.AddSubItem(new MenuItem("Show Version", showVersion));
            lettersAndVersion.AddSubItem(new MenuItem("Count Lowercase Letters", countLowerCase));

            MenuItem showDateTime = new MenuItem("Show Current Date/Time");
            showDateTime.AddSubItem(new MenuItem("Show Current Time", showTime));
            showDateTime.AddSubItem(new MenuItem("Show Current Date", showDate));

            mainMenu.AddMenuItem(lettersAndVersion);
            mainMenu.AddMenuItem(showDateTime);

            return mainMenu;
        }

        private static void showVersion()
        {
            Console.WriteLine("App Version: 25.2.4.4480");
        }

        private static void countLowerCase()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();
            int count = 0;

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} lowercase letters in your text.");
        }

        private static void showTime()
        {
            Console.WriteLine($"Current Time is {DateTime.Now:HH:mm}");
        }

        private static void showDate()
        {
            Console.WriteLine($"Current Date is {DateTime.Now:yyyy-MM-dd}");
        }
    }
}
 */