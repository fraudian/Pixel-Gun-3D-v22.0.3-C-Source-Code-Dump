using UnityEngine;

namespace Rilisoft
{
    public sealed class 万与专丑丌一丏与且 : EventArgs
    {
        // Fields
        private string <与丛丏专东与丆丄不>k__BackingField;
        
        // Properties
        public string 三丂不东丗丒丏三丟 { get; set; }
        
        // Methods
        public string 丞一万丗上丄丏丁丈()
        {
            return (string)this.<与丛丏专东与丆丄不>k__BackingField;
        }
        public void 丌丒丂上一世丄丑丝(string 丙业与丙丗丝不丈东)
        {
            this.<与丛丏专东与丆丄不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "myPlayerEffects", value:  this.<与丛丏专东与丆丄不>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 万与专丑丌一丏与且()
        {
        
        }
    
    }

}
