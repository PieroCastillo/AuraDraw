using System;
using System.Collections.Generic;
using System.Text;

namespace AuraDraw.App.Functions
{
    public class Document
    {
        public Document()
        {

        }
        public List<Item> Items { get; set; }
        public List<Item> ItemsProperty;
        public void AddItem(Item ItemToAdd)
        {
            Items.Add(ItemToAdd);
        } 
    }
}
