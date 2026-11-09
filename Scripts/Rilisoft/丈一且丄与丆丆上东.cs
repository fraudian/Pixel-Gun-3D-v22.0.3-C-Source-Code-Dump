using UnityEngine;

namespace Rilisoft
{
    internal class 丈一且丄与丆丆上东 : 丈丕丅丄七丁丒丅上
    {
        // Properties
        protected override bool 丙三丝丏专丘丈丐业 { get; }
        
        // Methods
        protected override bool 一业丟丁上丑丘丕丄()
        {
            Rilisoft.丗下丙丅且丐丞丙世 val_1 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40);
            }
            
            return val_1.且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40);
        }
        public 丈一且丄与丆丆上东()
        {
            mem[1152921542996885584] = 1;
            this = new System.Object();
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_2 != null)
            {
                    val_2.Add(key:  "action", value:  "EventStore");
            }
            else
            {
                    val_2.Add(key:  "action", value:  "EventStore");
            }
            
            val_2.Add(key:  "Type", value:  "EventStore");
            val_2.Add(key:  "Key", value:  "EventStore");
            val_2.Add(key:  "isOffer", value:  true);
            mem[1152921542996885576] = val_2;
        }
        protected override void 与丐丈丐丏一丒三与()
        {
            long val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丕丙丅丆且丒丝不丐(丅丝丗丕专丌丛丄丅:  40);
            if((X21.ContainsKey(key:  "EndTime")) != false)
            {
                    this.set_Item(key:  "EndTime", value:  val_2);
                return;
            }
            
            this.Add(key:  "EndTime", value:  val_2);
        }
    
    }

}
