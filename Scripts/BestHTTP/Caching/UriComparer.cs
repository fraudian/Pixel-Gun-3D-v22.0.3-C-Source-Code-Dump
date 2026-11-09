using UnityEngine;

namespace BestHTTP.Caching
{
    public sealed class UriComparer : IEqualityComparer<System.Uri>
    {
        // Methods
        public bool Equals(System.Uri x, System.Uri y)
        {
            return (bool)((System.Uri.Compare(uri1:  x, uri2:  y, partsToCompare:  61, compareFormat:  3, comparisonType:  4)) == 0) ? 1 : 0;
        }
        public int GetHashCode(System.Uri uri)
        {
            if(uri == null)
            {
                
            }
        
        }
        public UriComparer()
        {
        
        }
    
    }

}
