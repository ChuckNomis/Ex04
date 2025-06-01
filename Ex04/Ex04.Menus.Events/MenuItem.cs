using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    internal class MenuItem
    {
        public string m_title { get; }
        private readonly List<MenuItem> r_subItems;
        private readonly Action r_action;

        public IReadOnlyList<MenuItem> SubItems => r_subItems.AsReadOnly();
        public bool HasSubItems => r_subItems.Count > 0;
        public MenuItem Parent { get; private set; }

        public MenuItem(string i_Title)
        {
            m_title = i_Title;
            r_subItems = new List<MenuItem>();
        }

        public MenuItem(string i_Title, Action i_Action)
            : this(i_Title)
        {
            r_action = i_Action;
        }

        public void AddSubItem(MenuItem i_SubItem)
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
