using UnityEngine;

namespace Rilisoft
{
    public sealed class 世丘丗三不丄丕丝不 : EventArgs
    {
        // Fields
        private Player_move_c.丐上丅与业下丈下丗 <业丈专丗不丈丞丙丌>k__BackingField;
        private float <七丒上世丙下丈丟丞>k__BackingField;
        
        // Properties
        internal Player_move_c.丐上丅与业下丈下丗 丗丌世丘东丝丒丆东 { get; set; }
        public float 丟丂丕丅丕不不世三 { get; set; }
        
        // Methods
        internal Player_move_c.丐上丅与业下丈下丗 丕七专东上万丌上下()
        {
            return (丐上丅与业下丈下丗)this.<业丈专丗不丈丞丙丌>k__BackingField;
        }
        internal void 丏丝丈下丐与丕丕丒(Player_move_c.丐上丅与业下丈下丗 丙业与丙丗丝不丈东)
        {
            this.<业丈专丗不丈丞丙丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public float 丟三丒七不丘丛上丁()
        {
            return (float)this.<七丒上世丙下丈丟丞>k__BackingField;
        }
        public void 东且与丁丌丐丄丏东(float 丙业与丙丗丝不丈东)
        {
            this.<七丒上世丙下丈丟丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "amount", value:  this.<七丒上世丙下丈丟丞>k__BackingField);
            val_1.Add(key:  "cause", value:  this.<业丈专丗不丈丞丙丌>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 世丘丗三不丄丕丝不()
        {
        
        }
    
    }

}
