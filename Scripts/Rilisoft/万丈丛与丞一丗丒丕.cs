using UnityEngine;

namespace Rilisoft
{
    public sealed class 万丈丛与丞一丗丒丕 : EventArgs
    {
        // Fields
        private bool <上万丄业丆丆且丆世>k__BackingField;
        private bool <丛一世上万丑专丝丂>k__BackingField;
        
        // Properties
        public bool 丈专丂丂世丆万丟丆 { get; set; }
        public bool 丒三东不万丙丙丕丐 { get; set; }
        
        // Methods
        public bool 丏上一丞丝七丙七世()
        {
            return (bool)this.<上万丄业丆丆且丆世>k__BackingField;
        }
        public void 丘东丈专丑一业上七(bool 丙业与丙丗丝不丈东)
        {
            this.<上万丄业丆丆且丆世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool 丅丐丂丄丕丆丘丑东()
        {
            return (bool)this.<丛一世上万丑专丝丂>k__BackingField;
        }
        public void 丛上七丈七三丛万且(bool 丙业与丙丗丝不丈东)
        {
            this.<丛一世上万丑专丝丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.Dictionary<string, object> 丂丆丑世一不丘丏七()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "iamFly", value:  this.<上万丄业丆丆且丆世>k__BackingField);
            val_1.Add(key:  "killedPlayerFly", value:  this.<丛一世上万丑专丝丂>k__BackingField);
            return val_1;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        public 万丈丛与丞一丗丒丕()
        {
        
        }
    
    }

}
