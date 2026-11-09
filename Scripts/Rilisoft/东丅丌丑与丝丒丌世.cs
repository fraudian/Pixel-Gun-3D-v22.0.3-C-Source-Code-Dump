using UnityEngine;

namespace Rilisoft
{
    public sealed class 东丅丌丑与丝丒丌世 : EventArgs
    {
        // Fields
        private string <丛丐万世与丗丆丐一>k__BackingField;
        
        // Properties
        public string 一丘东丌丑且丏一丙 { get; set; }
        
        // Methods
        public string 丕丆丞丂业东与上丅()
        {
            return (string)this.<丛丐万世与丗丆丐一>k__BackingField;
        }
        public void 下东丅世丅专丝专丌(string 丙业与丙丗丝不丈东)
        {
            this.<丛丐万世与丗丆丐一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "map", value:  this.<丛丐万世与丗丆丐一>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 东丅丌丑与丝丒丌世()
        {
        
        }
    
    }

}
