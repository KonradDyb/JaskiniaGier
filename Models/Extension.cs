using System.Collections.Generic;
using System.Linq;

namespace JaskiniaGier.Models
{
    public static class Extension
    {
        public static bool IsAny<T>(this IEnumerable<T> data)
        {
            return data != null && data.Any();
        }
    }
}
