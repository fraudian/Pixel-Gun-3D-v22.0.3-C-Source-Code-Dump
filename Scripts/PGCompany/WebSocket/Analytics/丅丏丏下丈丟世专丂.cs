using UnityEngine;

namespace PGCompany.WebSocket.Analytics
{
    internal sealed class 丅丏丏下丈丟世专丂 : 丅丒丛上世不丁丑专
    {
        // Fields
        private string <丟万且丞丏丈丛下丙>k__BackingField;
        private int <丑下丙丛东丅下与丂>k__BackingField;
        private System.Collections.Generic.Dictionary<object, object> <三丄上丄专丝丟丄业>k__BackingField;
        private System.Collections.Generic.Dictionary<string, object> <丆丌丞丒丘丞上且丄>k__BackingField;
        private int <三丕丂东丙专上丕丆>k__BackingField;
        
        // Properties
        internal string 丝丞丆三丂丌丟三丂 { get; set; }
        internal int 世丙丕丂丄三专丆丗 { get; set; }
        internal System.Collections.Generic.Dictionary<object, object> 丄丁丌丟业丑下丈丘 { get; set; }
        internal System.Collections.Generic.Dictionary<string, object> 丂专万下下丏丞业丘 { get; set; }
        internal int 一专丘丁七七万与东 { get; set; }
        internal bool 丛丐东且东丅丙丞丒 { get; }
        internal string 丈丒且丈与且丏不七 { get; }
        
        // Methods
        internal string 一丅与丛三丂七丑丗()
        {
            return (string)this.<丟万且丞丏丈丛下丙>k__BackingField;
        }
        internal void 丘万丈与丒丂丁且不(string 丙业与丙丗丝不丈东)
        {
            this.<丟万且丞丏丈丛下丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 专万下上丆丑丐丌不()
        {
            return (int)this.<丑下丙丛东丅下与丂>k__BackingField;
        }
        internal void 丟不丙丞丐万上上与(int 丙业与丙丗丝不丈东)
        {
            this.<丑下丙丛东丅下与丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<object, object> 丒与且丂不丞业东丏()
        {
            return (System.Collections.Generic.Dictionary<System.Object, System.Object>)this.<三丄上丄专丝丟丄业>k__BackingField;
        }
        internal void 与丕丙丛世丌丝丕丏(System.Collections.Generic.Dictionary<object, object> 丙业与丙丗丝不丈东)
        {
            this.<三丄上丄专丝丟丄业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<string, object> 不丄不丏丞与丞丄丐()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.<丆丌丞丒丘丞上且丄>k__BackingField;
        }
        internal void 万业丞丅三一下丌三(System.Collections.Generic.Dictionary<string, object> 丙业与丙丗丝不丈东)
        {
            this.<丆丌丞丒丘丞上且丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丂下一下专专三东不()
        {
            return (int)this.<三丕丂东丙专上丕丆>k__BackingField;
        }
        internal void 丐下丏三丙丑丌丂丂(int 丙业与丙丗丝不丈东)
        {
            this.<三丕丂东丙专上丕丆>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 丟丅上三丝不丞丈丂()
        {
            return (bool)((this.<三丕丂东丙专上丕丆>k__BackingField) > 0) ? 1 : 0;
        }
        internal string 丐世上万丛万丆世且()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.<三丄上丄专丝丟丄业>k__BackingField);
        }
        public override string ToString()
        {
            string[] val_1 = new string[9];
            object[] val_2 = new object[6];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if((this.<丟万且丞丏丈丛下丙>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<丟万且丞丏丈丛下丙>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = this.<丟万且丞丏丈丛下丙>k__BackingField;
            val_2[1] = this.<丑下丙丛东丅下与丂>k__BackingField;
            val_2[2] = this.<三丕丂东丙专上丕丆>k__BackingField;
            val_2[3] = this.三一丕丄万一业丗不();
            val_2[4] = this.丝丞万下丞丗丘丒丆();
            val_2[5] = (true == 0) ? "server UTC" : "local UTC";
            string val_6 = System.String.Format(format:  "Event name = {0}, Request ID = {1}, Error code = {2}, Time event not responding time = {3}, Time event sent date = {4} ({5}), ", args:  val_2);
            if(val_1 == null)
            {
                goto label_23;
            }
            
            if(val_6 != null)
            {
                goto label_24;
            }
            
            goto label_27;
            label_23:
            if(val_6 == null)
            {
                goto label_27;
            }
            
            label_24:
            label_27:
            val_1[0] = val_6;
            val_1[1] = "Player ID = ";
            val_1[2] = "Player ID = ";
            val_1[3] = ", Device ID = ";
            val_1[4] = ", Device ID = ";
            val_1[5] = ", Country = ";
            val_1[6] = ", Country = ";
            val_1[7] = ", Params = ";
            val_1[8] = this.丐世上万丛万丆世且();
            return (string)+val_1;
        }
        public 丅丏丏下丈丟世专丂()
        {
            val_1 = new System.Object();
        }
    
    }

}
