using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7Kyu
{
    public class ListFillterer
    {
        public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            foreach (object item in listOfItems)
            {
                if (item is int)
                {
                    yield return (int)item;
                }
            }
        }
    }
}
