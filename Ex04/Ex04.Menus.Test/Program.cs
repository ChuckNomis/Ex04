using System;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MainMenuEvents delegatesMenu = buildMenuEvents();
            delegatesMenu.Show();
            buildMenuIntefaces();
        }
        private static void buildMenuIntefaces()
        {
            MainMenuInterfaces m_mainMenu = new Interfaces.MainMenuInterfaces("Main Menu");

            MenuItemInterfaces m_LettersAndVersions = new MenuItemInterfaces("Letters and Versions");
            m_LettersAndVersions.AddSubItem(new MenuItemInterfaces("ShowMenu Version", new ShowVersion()));
            m_LettersAndVersions.AddSubItem(new MenuItemInterfaces("Count Lowercase Letter", new CountLowercaseLetters()));

            MenuItemInterfaces m_CurrentDateOrTime = new MenuItemInterfaces("ShowMenu Current Date/Time");
            m_CurrentDateOrTime.AddSubItem(new MenuItemInterfaces("ShowMenu Current Date", new ShowCurrentDate()));
            m_CurrentDateOrTime.AddSubItem(new MenuItemInterfaces("ShowMenu Current Time", new ShowCurrentTime()));

            m_mainMenu.AddMenuItem(m_LettersAndVersions);
            m_mainMenu.AddMenuItem(m_CurrentDateOrTime);

            m_mainMenu.ShowMenu();
        }

        private static MainMenuEvents buildMenuEvents()
        {
            MainMenuEvents mainMenu = new MainMenuEvents("Main Menu");

            MenuItemEvents lettersAndVersion = new MenuItemEvents("Letters and Version");
            lettersAndVersion.AddSubItem(new MenuItemEvents("Show Version", DelegatesFunctions.showVersion));
            lettersAndVersion.AddSubItem(new MenuItemEvents("Count Lowercase Letters", DelegatesFunctions.countLowerCase));

            MenuItemEvents showDateTime = new MenuItemEvents("Show Current Date/Time");
            showDateTime.AddSubItem(new MenuItemEvents("Show Current Time", DelegatesFunctions.showTime));
            showDateTime.AddSubItem(new MenuItemEvents("Show Current Date", DelegatesFunctions.showDate));

            mainMenu.AddMenuItem(lettersAndVersion);
            mainMenu.AddMenuItem(showDateTime);

            return mainMenu;
        }
    }
}
