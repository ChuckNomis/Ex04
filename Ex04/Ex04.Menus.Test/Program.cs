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
