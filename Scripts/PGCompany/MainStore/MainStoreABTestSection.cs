using UnityEngine;

namespace PGCompany.MainStore
{
    internal class MainStoreABTestSection : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _headerBackgrounds;
        private TagSpecificObject _headerBackgroundsTagSpecificObject;
        private PGCompany.TimerUI _timer;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.MainStore.世专丟丕丝丝专东一 丞且丌三三万七丛万)
        {
            UnityEngine.GameObject val_11;
            string val_12;
            var val_13;
            string val_14;
            val_11 = this._headerBackgrounds;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
            if(丞且丌三三万七丛万 == null)
            {
                    return;
            }
            
            if(PGCompany.MainStore.世东丒丅下丙丂万丏.丂丑专丑丕丟专丌三() != true)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._headerBackgrounds, 丏业丟一东丂东丘丛:  true);
                if(this._headerBackgroundsTagSpecificObject != null)
            {
                    this._headerBackgroundsTagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  丞且丌三三万七丛万.与不丞丑七丘丁丂丛());
            }
            
            }
            
            val_11 = this._timer;
            if(val_11 == 0)
            {
                    return;
            }
            
            TagSystem.三与下丘七丘丌丏丄 val_5 = 丞且丌三三万七丛万.与不丞丑七丘丁丂丛();
            if(PGCompany.MainStore.世东丒丅下丙丂万丏.丂丑专丑丕丟专丌三() == false)
            {
                goto label_11;
            }
            
            label_25:
            val_12 = PGCompany.MainStore.丗丝丙丏不丄七丌一.丕丈丂丟万东且丕一(丛丝丑丆万不丄丗丏:  val_5, 七丆丝不丈丗业丏万:  0);
            val_13 = 0;
            goto label_14;
            label_11:
            if((val_5.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X10")) == false)
            {
                goto label_16;
            }
            
            val_14 = "Key_11420";
            goto label_17;
            label_16:
            if((丞且丌三三万七丛万.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X3")) == false)
            {
                goto label_19;
            }
            
            val_14 = "Key_11416";
            label_17:
            val_12 = 0;
            label_14:
            this._timer.prefixString = val_12;
            this._timer.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  val_14);
            this._timer.丆三且丆三不世丈丌();
            return;
            label_19:
            TagSystem.三与下丘七丘丌丏丄 val_10 = 丞且丌三三万七丛万.与不丞丑七丘丁丂丛();
            goto label_25;
        }
        public MainStoreABTestSection()
        {
        
        }
    
    }

}
