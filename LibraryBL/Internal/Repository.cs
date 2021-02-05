using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryBL.Internal
{
    internal class Repository<T>
    {
        internal IList<T> Tabell
        {
            get { return tabell; }
        }

        internal Repository()
        {
            if (tabell == null)
            {
                tabell = new List<T>();
            }
        }
        static IList<T> tabell;
    }
}
