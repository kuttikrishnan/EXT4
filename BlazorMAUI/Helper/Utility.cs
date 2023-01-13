using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMAUI.Helper
{
    public static class Utility
    {
        public static IEnumerable<T> Postorder<T>(this IEnumerable<T> nodes, Func<T, IEnumerable<T>> children)
        {
            //https://stackoverflow.com/questions/55598403/traversing-a-nested-hierarchy-of-any-depth-from-bottom-up
            foreach (T node in nodes)
            {
                foreach (T descendant in children(node).Postorder(children))
                    yield return descendant;
                yield return node;
            }
        }

    }
}
