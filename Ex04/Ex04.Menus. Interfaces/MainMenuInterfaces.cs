using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Ex04.Menus.Interfaces; 


namespace Ex04.Menus.Interfaces
{
    public class MainMenuInterfaces
    {
        private readonly string r_TitleName; 
        public string TitleName
        {
            get { return r_TitleName; }
        }

        private readonly List<MenuItemInterfaces> r_RootMain; 
        public MainMenuInterfaces (string i_TitleName)
        {
            r_TitleName = i_TitleName;
            r_RootMain = new List<MenuItemInterfaces>();
        }
        public void AddMenuItem(MenuItemInterfaces i_Item)
        {
            r_RootMain.Add(i_Item);
        }

        public void ShowMenu()
        {
            Stack<MenuItemInterfaces> menuStack = new Stack<MenuItemInterfaces>();

            MenuItemInterfaces root = new MenuItemInterfaces(r_TitleName);
            foreach (var item in r_RootMain)
            {
                root.AddSubItem(item);
            }

            menuStack.Push(root);

            while (menuStack.Count > 0)
            {
                MenuItemInterfaces current = menuStack.Peek();
                Console.Clear();
                Console.WriteLine($"** {current.Title} **");
                Console.WriteLine("--------------------");

                for (int i = 0; i < current.SubItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {current.SubItems[i].Title}");
                }

                Console.WriteLine("0. " + (menuStack.Count == 1 ? "Exit" : "Back"));
                Console.Write("Please choose: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 0)
                    {
                        menuStack.Pop();
                        continue;
                    }

                    if (choice < 1 || choice > current.SubItems.Count)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    MenuItemInterfaces selected = current.SubItems[choice - 1];

                    if (selected.IsLeaf)
                    {
                        Console.Clear();
                        selected.Action.Execute();
                        Console.WriteLine("\nPress Enter to return...");
                        Console.ReadLine();
                    }
                    else
                    {
                        menuStack.Push(selected);
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Press Enter to try again.");
                    Console.ReadLine();
                }
            }
        }
    }
}
