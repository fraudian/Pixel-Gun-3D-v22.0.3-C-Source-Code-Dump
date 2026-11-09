using UnityEngine;

namespace Rilisoft
{
    public class EnableIfPetIsState : PetStateMonitor
    {
        // Fields
        private UnityEngine.GameObject _objectToHide;
        
        // Methods
        protected override void 上丌丑丒丒世丌丒丘()
        {
            UnityEngine.GameObject val_3;
            var val_4;
            if(this._objectToHide != 0)
            {
                    val_3 = this._objectToHide;
                val_4 = null;
            }
            else
            {
                    val_3 = this.gameObject;
                val_4 = null;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
        }
        protected override void 丆与下世丝丆丗丆且()
        {
            UnityEngine.GameObject val_3;
            var val_4;
            if(this._objectToHide != 0)
            {
                    val_3 = this._objectToHide;
                val_4 = null;
            }
            else
            {
                    val_3 = this.gameObject;
                val_4 = null;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
        }
        public EnableIfPetIsState()
        {
        
        }
    
    }

}
