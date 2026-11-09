using UnityEngine;

namespace Rilisoft
{
    public sealed class 三丁丘一一上丏下丆 : EventArgs
    {
        // Fields
        private CategoryNames <丌丒丁且东专上丝不>k__BackingField;
        private string <与丛丏专东与丆丄不>k__BackingField;
        private int <一万丂丟不丛丟下世>k__BackingField;
        
        // Properties
        public CategoryNames 丞丏万丏一下上丁丝 { get; set; }
        public string 三丂不东丗丒丏三丟 { get; set; }
        public int 三丌上丁一丟丐丟丈 { get; set; }
        
        // Methods
        public CategoryNames 丄丄世七三业丝丛丘()
        {
            return (CategoryNames)this.<丌丒丁且东专上丝不>k__BackingField;
        }
        public void 丛丒丌世万丒上七一(CategoryNames 丙业与丙丗丝不丈东)
        {
            this.<丌丒丁且东专上丝不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public string 丞一万丗上丄丏丁丈()
        {
            return (string)this.<与丛丏专东与丆丄不>k__BackingField;
        }
        public void 丌丒丂上一世丄丑丝(string 丙业与丙丗丝不丈东)
        {
            this.<与丛丏专东与丆丄不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public int 丝一丙丘专七丕不上()
        {
            return (int)this.<一万丂丟不丛丟下世>k__BackingField;
        }
        public void 丂丙丗丗三与丌丙世(int 丙业与丙丗丝不丈东)
        {
            this.<一万丂丟不丛丟下世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "weaponSlot", value:  this.<丌丒丁且东专上丝不>k__BackingField);
            val_1.Add(key:  "myPlayerEffects", value:  this.<与丛丏专东与丆丄不>k__BackingField);
            val_1.Add(key:  "itemIndex", value:  this.<一万丂丟不丛丟下世>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 三丁丘一一上丏下丆()
        {
        
        }
    
    }

}
