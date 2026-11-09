using UnityEngine;

namespace Rilisoft
{
    public sealed class 丄丞不丈业丌业专丅 : EventArgs
    {
        // Fields
        private string <且丈丁专东丆丄丂与>k__BackingField;
        private 丌不丞世丛丆一三下 <上丑丒丐丄丛七与丅>k__BackingField;
        
        // Properties
        public string 丒三丝一上丙专丗丒 { get; set; }
        public 丌不丞世丛丆一三下 丙丙万丂丛丝丙丑丝 { get; set; }
        
        // Methods
        public string 不业丙丒丂丞下丆丙()
        {
            return (string)this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        public void 东丝丕专丒丏三三与(string 丙业与丙丗丝不丈东)
        {
            this.<且丈丁专东丆丄丂与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public 丌不丞世丛丆一三下 丑丑丐专丄一丈丆丂()
        {
            return (丌不丞世丛丆一三下)this.<上丑丒丐丄丛七与丅>k__BackingField;
        }
        public void 丕下丐专丟丅丆丈丛(丌不丞世丛丆一三下 丙业与丙丗丝不丈东)
        {
            this.<上丑丒丐丄丛七与丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "type", value:  this.<且丈丁专东丆丄丂与>k__BackingField.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
            val_1.Add(key:  "lootBoxType", value:  this.<上丑丒丐丄丛七与丅>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 丄丞不丈业丌业专丅()
        {
        
        }
    
    }

}
