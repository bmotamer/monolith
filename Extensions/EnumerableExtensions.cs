using System.Collections.Generic;
using System.Linq;

namespace Monolith.Extensions
{
    
    public static class EnumerableExtensions
    {
        
        public static bool UnorderedSequenceEqual<T>(this IEnumerable<T> lhs, IEnumerable<T> rhs)
        {
            return lhs.OrderBy((item) => item).SequenceEqual(rhs.OrderBy((item) => item));
        }
        
    }
    
}