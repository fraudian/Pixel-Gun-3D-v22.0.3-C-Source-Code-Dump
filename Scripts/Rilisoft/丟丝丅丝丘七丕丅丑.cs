using UnityEngine;

namespace Rilisoft
{
    public sealed class 丟丝丅丝丘七丕丅丑 : EventArgs
    {
        // Fields
        private int <七丒上世丙下丈丟丞>k__BackingField;
        private Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 <业丈专丗不丈丞丙丌>k__BackingField;
        
        // Properties
        internal int 丟丂丕丅丕不不世三 { get; set; }
        internal Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 丗丌世丘东丝丒丆东 { get; set; }
        
        // Methods
        internal int 丟三丒七不丘丛上丁()
        {
            return (int)this.<七丒上世丙下丈丟丞>k__BackingField;
        }
        internal void 东且与丁丌丐丄丏东(int 丙业与丙丗丝不丈东)
        {
            this.<七丒上世丙下丈丟丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 丕七专东上万丌上下()
        {
            return (丌丟丐丞三丘三丏丈)this.<业丈专丗不丈丞丙丌>k__BackingField;
        }
        internal void 丏丝丈下丐与丕丕丒(Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 丙业与丙丗丝不丈东)
        {
            this.<业丈专丗不丈丞丙丌>k__BackingField = 丙业与丙丗丝不丈东;
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
        public 丟丝丅丝丘七丕丅丑()
        {
        
        }
    
    }

}
