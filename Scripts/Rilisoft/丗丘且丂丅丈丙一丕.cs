using UnityEngine;

namespace Rilisoft
{
    public sealed class 丗丘且丂丅丈丙一丕 : EventArgs
    {
        // Fields
        private int <丝东丏丁上下七不丁>k__BackingField;
        
        // Properties
        public int 世东丙丟丄下丌与丈 { get; set; }
        
        // Methods
        public int 丅丂专丁丏丒丙丘丛()
        {
            return (int)this.<丝东丏丁上下七不丁>k__BackingField;
        }
        public void 世三丙且丗丒丛丟丑(int 丙业与丙丗丝不丈东)
        {
            this.<丝东丏丁上下七不丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "clanSilver", value:  this.<丝东丏丁上下七不丁>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 丗丘且丂丅丈丙一丕()
        {
        
        }
    
    }

}
