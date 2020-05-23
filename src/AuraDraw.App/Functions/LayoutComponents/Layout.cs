using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AuraDraw.App.Functions;
using Avalonia.Collections;

namespace AuraDraw.App.Functions.LayoutComponents
{
    public class Layout : Item
    {
        
    }
    public class Layouts : ICollection<Layout>
    {
        public Collection<Layout> Layouts_ = new Collection<Layout>();
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Layout item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Layout item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Layout[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Layout> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Layout item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
