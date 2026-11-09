using UnityEngine;

namespace Rilisoft
{
    public sealed class 与丛上三丌丄三下丅 : EventArgs
    {
        // Fields
        private string <上七东下丏不丕丐丑>k__BackingField;
        private ItemRarity <丑与丛与万丐专东与>k__BackingField;
        
        // Properties
        internal string 下丄丈不与世丐业专 { get; set; }
        internal ItemRarity 且丐丟专丛丗丏上丙 { get; set; }
        
        // Methods
        internal string 业上丙丞丐丄丆丅七()
        {
            return (string)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        internal void 丒丞东丈丁丄丑丅且(string 丙业与丙丗丝不丈东)
        {
            this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal ItemRarity 七东与丄丕丁丛世三()
        {
            return (ItemRarity)this.<丑与丛与万丐专东与>k__BackingField;
        }
        internal void 一世下丐丝丞与上丅(ItemRarity 丙业与丙丗丝不丈东)
        {
            this.<丑与丛与万丐专东与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "id", value:  this.<上七东下丏不丕丐丑>k__BackingField);
            val_1.Add(key:  "rarity", value:  this.<丑与丛与万丐专东与>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 与丛上三丌丄三下丅()
        {
        
        }
    
    }

}
