
namespace Linq
{
    public static class MedianLINQ
    {
        public static T Median<T>(this IEnumerable<T>? source)//основу содрал у Microsoft 
        {
            if (source is null || !source.Any() || source.ToList().Count < 3)
            {
                throw new InvalidOperationException("Cannot compute median for a null or empty set or in sequence less 3 elements");
            }

            var sourceList = source.ToList(); 
           
            int medianIndex = sourceList.Count / 2;
            return sourceList[medianIndex];            
        }
    }
}
 