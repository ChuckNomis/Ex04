using System;

namespace Ex04.Menus.Events
{
    public class MainMenuEvents
    {
        private readonly MenuItemEvents r_RootMenu;

        public MainMenuEvents(string i_Title)
        {
            r_RootMenu = new MenuItemEvents(i_Title);
        }

        public void AddMenuItem(MenuItemEvents i_Item)
        {
            r_RootMenu.AddSubItem(i_Item);
        }

        public void Show()
        {
            navigateMenu(r_RootMenu);
        }

        private void navigateMenu(MenuItemEvents i_CurrentMenu)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"** {i_CurrentMenu.m_title} **");
                Console.WriteLine(new string('-', i_CurrentMenu.m_title.Length + 6));

                for (int i = 0; i < i_CurrentMenu.SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {i_CurrentMenu.SubItems[i].m_title}");
                }
                string backOrExit = i_CurrentMenu.Parent == null ? "Exit" : "Back";
                Console.WriteLine($"0. {backOrExit}");
                Console.Write($"Please enter your choice (1-{i_CurrentMenu.SubItems.Count} or 0 to {backOrExit}): ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice) ||
                    choice < 0 || choice > i_CurrentMenu.SubItems.Count)
                {
                    Console.WriteLine("Invalid input, press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                if (choice == 0)
                {
                    if (i_CurrentMenu.Parent == null)
                        break;
                    else
                        return;
                }

                MenuItemEvents selectedItem = i_CurrentMenu.SubItems[choice - 1];

                if (selectedItem.HasSubItems)
                {
                    navigateMenu(selectedItem);
                }
                else
                {
                    Console.Clear();
                    selectedItem.Activate();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                }
            }
        }
    }
}
