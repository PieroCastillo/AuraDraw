using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AuraDraw.App.Functions
{
    public class Item : ICollection<Item>, IList<Item>
    {
        public string Header;
        public List<Item> Items;

        public Item()
        {
            Items = new List<Item>();
        }
        public Item this[int index] {
            
            get { return Items[index]; }
            set { Items[index] = value; } 
        }

        public int Count { get => Items.Count; }

        public bool IsReadOnly { get => false; }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Clear()
        {
            this.Items.Clear();
        }

        public bool Contains(Item item)
        {
            switch (this.Items.Contains(item)){
                case true: 
                    return true;
                case false:
                    return false;
            }
        }

        public void CopyTo(Item[] array, int arrayIndex)
        {
            this.Items.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        public int IndexOf(Item item)
        {
            return item.IndexOf(item);
        }

        public void Insert(int index, Item item)
        {
            this.Items.Insert(index, item);
        }

        public bool Remove(Item item)
        {
            try
            {
                this.Items.Remove(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            this.Items.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }
    }
}
