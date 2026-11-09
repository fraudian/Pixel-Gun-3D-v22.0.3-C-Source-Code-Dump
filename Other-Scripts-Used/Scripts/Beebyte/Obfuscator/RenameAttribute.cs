using UnityEngine;

namespace Beebyte.Obfuscator
{
    public class RenameAttribute : Attribute
    {
        // Fields
        private readonly string target;
        
        // Methods
        private RenameAttribute()
        {
        
        }
        public RenameAttribute(string target)
        {
            this.target = target;
        }
        public string GetTarget()
        {
            return (string)this.target;
        }
    
    }

}
