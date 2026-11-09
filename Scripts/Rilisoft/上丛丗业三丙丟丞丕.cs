using UnityEngine;

namespace Rilisoft
{
    public sealed class 上丛丗业三丙丟丞丕 : EventArgs
    {
        // Fields
        private int <丞丅丂下丐丑业万丆>k__BackingField;
        
        // Properties
        public int 丐丆一丈丑一丐丑业 { get; set; }
        
        // Methods
        public int 与丈不丟上丈丅不业()
        {
            return (int)this.<丞丅丂下丐丑业万丆>k__BackingField;
        }
        public void 下丙丏丟丞与丂下丝(int 丙业与丙丗丝不丈东)
        {
            this.<丞丅丂下丐丑业万丆>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "clanValor", value:  this.<丞丅丂下丐丑业万丆>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 上丛丗业三丙丟丞丕()
        {
        
        }
    
    }

}
