using UnityEngine;

namespace Rilisoft
{
    public class 不一丞丒丒业七上丅
    {
        // Fields
        private Rilisoft.且丈丞一丞丟与上七 丗且三三世丗丛七下;
        private System.Collections.Generic.List<bool> _queque;
        private bool _useMaxToggleAlgorithm;
        
        // Properties
        public bool 七丙丙丞丂专三丙业 { get; }
        
        // Methods
        public 不一丞丒丒业七上丅()
        {
            this.丗且三三世丗丛七下 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "clan-chest-drop-rules-last-queue-getted-index");
        }
        public 不一丞丒丒业七上丅(System.Collections.Generic.List<bool> 专丐东与丒丕丂丟丘)
        {
            this.丗且三三世丗丛七下 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "clan-chest-drop-rules-last-queue-getted-index");
            this._queque = 专丐东与丒丕丂丟丘;
        }
        public bool 丘三万与丕专三丑一()
        {
            if(this._queque == null)
            {
                    return (bool)(this._queque.Count > 0) ? 1 : 0;
            }
            
            return (bool)(this._queque.Count > 0) ? 1 : 0;
        }
        public System.Nullable<bool> 丗丌丌丙丞丗下丛丕()
        {
            System.Collections.Generic.List<System.Boolean> val_6;
            var val_7;
            val_6 = this;
            if(this.丘三万与丕专三丑一() == false)
            {
                goto label_1;
            }
            
            int val_2 = this.丗且三三世丗丛七下.世三丞丅丑丌丈丈一();
            if((this._queque.Count - 1) <= val_2)
            {
                goto label_4;
            }
            
            label_1:
            val_7 = 0;
            return (System.Nullable<System.Boolean>)val_7;
            label_4:
            val_6 = this._queque;
            int val_6 = val_2;
            val_6 = val_6.Item[val_6];
            val_7 = 0;
            return (System.Nullable<System.Boolean>)val_7;
        }
        public System.Nullable<bool> 丒上世业丏三与丈丄()
        {
            System.Collections.Generic.List<System.Boolean> val_7;
            var val_8;
            val_7 = this;
            if(this.丘三万与丕专三丑一() != false)
            {
                    int val_2 = this.丗且三三世丗丛七下.世三丞丅丑丌丈丈一();
                int val_5 = (val_2 > (this._queque.Count - 2)) ? 0 : (val_2 + 1);
                this.丗且三三世丗丛七下.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  val_5);
                val_7 = this._queque;
                int val_7 = val_5;
                val_7 = val_7.Item[val_7];
                val_8 = 0;
                return (System.Nullable<System.Boolean>)val_8;
            }
            
            val_8 = 0;
            return (System.Nullable<System.Boolean>)val_8;
        }
    
    }

}
