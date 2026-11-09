using UnityEngine;

namespace Rilisoft
{
    public sealed class 丛丐丁丝丌丁三丟专 : EventArgs
    {
        // Fields
        private int <下业丏丁丒丈丄丏丅>k__BackingField;
        private int <丂业丏且世专下丕三>k__BackingField;
        
        // Properties
        internal int 丂专七不丐与下丛万 { get; set; }
        internal int 万丗丏东且万专丕丁 { get; set; }
        
        // Methods
        internal int 丄三丒丗丏万丛丞丈()
        {
            return (int)this.<下业丏丁丒丈丄丏丅>k__BackingField;
        }
        internal void 业丅不丆丗丏业丂丒(int 丙业与丙丗丝不丈东)
        {
            this.<下业丏丁丒丈丄丏丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丙万丂与丗专丏三丁()
        {
            return (int)this.<丂业丏且世专下丕三>k__BackingField;
        }
        internal void 上东万丅丈专丒丈丏(int 丙业与丙丗丝不丈东)
        {
            this.<丂业丏且世专下丕三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "fillAmount", value:  this.<下业丏丁丒丈丄丏丅>k__BackingField);
            val_1.Add(key:  "itemRarity", value:  this.<丂业丏且世专下丕三>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 丛丐丁丝丌丁三丟专()
        {
        
        }
    
    }

}
