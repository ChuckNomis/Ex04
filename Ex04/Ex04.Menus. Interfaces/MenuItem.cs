using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private readonly string r_Title;
        private readonly IMenuItemExecutable r_Action;
        private readonly List<MenuItem> r_SubItems = new List<MenuItem>();

        public MenuItem (string i_Title, IMenuItemExecutable i_Action = null)
        {
            r_Title = i_Title;
            r_Action = i_Action;
        }

        public string Title
        {
            get{return r_Title;}
        }

        public bool IsLeaf
        {
            get{return r_Action != null;}
        }

        public IMenuItemExecutable Action
        {
            get { return r_Action; }
        }

        public List<MenuItem> SubItems
        {
            get{return r_SubItems;}
        }

        public void AddSubItem(MenuItem i_SubItem)
        {
            if (IsLeaf)
            {
                throw new InvalidOperationException("Cannot add sub-items to a leaf menu item.");
            }

            r_SubItems.Add(i_SubItem);
        }
    }
}
