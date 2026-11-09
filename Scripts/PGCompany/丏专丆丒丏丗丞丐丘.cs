using UnityEngine;

namespace PGCompany
{
    internal sealed class 丏专丆丒丏丗丞丐丘 : EventArgs
    {
        // Fields
        private readonly PGCompany.ConfigId <丒且丒业丂丅丅丌丐>k__BackingField;
        private readonly string <丛丗丞七丝丑丞丁且>k__BackingField;
        
        // Properties
        public PGCompany.ConfigId 三丛丘丗不上丛丝东 { get; }
        public string 丗丏丌一且丈七丏三 { get; }
        
        // Methods
        internal 丏专丆丒丏丗丞丐丘(PGCompany.ConfigId 丈丄丈世一且不不丁, string 丒丗丁与丅丏丂丕且)
        {
            this.<丒且丒业丂丅丅丌丐>k__BackingField = 丈丄丈世一且不不丁;
            this.<丛丗丞七丝丑丞丁且>k__BackingField = 丒丗丁与丅丏丂丕且;
        }
        public PGCompany.ConfigId 丐丂丏丑丄丑丛丂丝()
        {
            return (PGCompany.ConfigId)this.<丒且丒业丂丅丅丌丐>k__BackingField;
        }
        public string 丄丛三与丛丐丑业不()
        {
            return (string)this.<丛丗丞七丝丑丞丁且>k__BackingField;
        }
    
    }

}
