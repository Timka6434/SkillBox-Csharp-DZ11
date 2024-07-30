using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_Csharp_DZ11.Models
{
    internal class AbstractDbManager<T>
    {
        public void Add(ObservableCollection<T> collection, T item)
        {
            if(collection == null) throw new ArgumentNullException(nameof(collection));

            collection.Add(item);
        }

        public void Remove(ObservableCollection<T> collection) 
        {
            foreach(var unit  in collection)
            {
                collection.Remove(unit);
            }
        }
    }
}
