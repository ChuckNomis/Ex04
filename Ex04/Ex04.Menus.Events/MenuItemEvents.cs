using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItemEvents
    {
        public string m_title { get; }
        private readonly List<MenuItemEvents> r_subItems;
        private readonly Action r_action;

        public IReadOnlyList<MenuItemEvents> SubItems => r_subItems.AsReadOnly();
        public bool HasSubItems => r_subItems.Count > 0;
        public MenuItemEvents Parent { get; private set; }

        public MenuItemEvents(string i_Title)
        {
            m_title = i_Title;
            r_subItems = new List<MenuItemEvents>();
        }

        public MenuItemEvents(string i_Title, Action i_Action)
            : this(i_Title)
        {
            r_action = i_Action;
        }

        public void AddSubItem(MenuItemEvents i_SubItem)
        {
            i_SubItem.Parent = this;
            r_subItems.Add(i_SubItem);
        }

        internal void Activate()
        {
            r_action?.Invoke();
        }
    }
}
