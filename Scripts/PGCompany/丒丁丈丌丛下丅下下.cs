using UnityEngine;

namespace PGCompany
{
    internal sealed class 丒丁丈丌丛下丅下下 : 丞丛上丛丟东世丝丞
    {
        // Methods
        internal override bool 专丄丏丞丈丞丞不丒()
        {
            var val_5;
            var val_12;
            var val_13;
            var val_14;
            val_12 = null;
            val_12 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与() == null)
            {
                goto label_4;
            }
            
            val_13 = null;
            val_13 = null;
            List.Enumerator<T> val_3 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().GetEnumerator();
            label_17:
            if(((-818079856) & 1) == 0)
            {
                goto label_9;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if((((val_6 == null) || (val_6 == null)) || (val_6.七丑丌专丒上丒丙七() == null)) || (val_6.七丑丌专丒上丒丙七().丈一下下丞世三丑丄() > ExperienceController.丞丞丘业东丙丏七丌()))
            {
                goto label_17;
            }
            
            val_14 = 1;
            goto label_18;
            label_9:
            val_14 = 0;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_14;
            label_4:
            val_14 = 0;
            return (bool)val_14;
        }
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丝丕东丂丏丄丛三一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.丒丁丈丌丛下丅下下::丐上丌专丝丏七三且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 丐上丌专丝丏七三且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丐上丌专丝丏七三且();
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丟世丁丛业丐业丙丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.丒丁丈丌丛下丅下下::丐上丌专丝丏七三且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        public 丒丁丈丌丛下丅下下()
        {
        
        }
    
    }

}
