using System.Collections.Generic;

namespace CodeWars._7Kyu.ListFilterer
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
