using UnityEngine;

namespace Rilisoft
{
    public sealed class 世丅世丂丝且丏丌东 : EventArgs
    {
        // Fields
        private int <丁丌且世下丘上丆丂>k__BackingField;
        
        // Properties
        public int 东丅丗丄丒与丐丏万 { get; set; }
        
        // Methods
        public int 三丘丅不丏丛专丟丁()
        {
            return (int)this.<丁丌且世下丘上丆丂>k__BackingField;
        }
        public void 丑丂丘丄与与且丗丂(int 丙业与丙丗丝不丈东)
        {
            this.<丁丌且世下丘上丆丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "waveNumber", value:  this.<丁丌且世下丘上丆丂>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 世丅世丂丝且丏丌东()
        {
        
        }
    
    }

}
