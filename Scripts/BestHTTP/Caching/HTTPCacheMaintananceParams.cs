using UnityEngine;

namespace BestHTTP.Caching
{
    public sealed class HTTPCacheMaintananceParams
    {
        // Fields
        private System.TimeSpan <DeleteOlder>k__BackingField;
        private ulong <MaxCacheSize>k__BackingField;
        
        // Properties
        public System.TimeSpan DeleteOlder { get; set; }
        public ulong MaxCacheSize { get; set; }
        
        // Methods
        public System.TimeSpan get_DeleteOlder()
        {
            return (System.TimeSpan)this.<DeleteOlder>k__BackingField;
        }
        private void set_DeleteOlder(System.TimeSpan value)
        {
            this.<DeleteOlder>k__BackingField = value;
        }
        public ulong get_MaxCacheSize()
        {
            return (ulong)this.<MaxCacheSize>k__BackingField;
        }
        private void set_MaxCacheSize(ulong value)
        {
            this.<MaxCacheSize>k__BackingField = value;
        }
        public HTTPCacheMaintananceParams(System.TimeSpan deleteOlder, ulong maxCacheSize)
        {
            this.<DeleteOlder>k__BackingField = deleteOlder;
            this.<MaxCacheSize>k__BackingField = maxCacheSize;
        }
    
    }

}
