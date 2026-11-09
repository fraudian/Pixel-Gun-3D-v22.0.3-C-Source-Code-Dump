using UnityEngine;

namespace PGCompany
{
    public sealed class ClanStoreTabSelectableButton : SelectableButton
    {
        // Methods
        public override void Select(bool 丛丁三七丅且丝丏丙)
        {
            var val_13;
            if(((this.GetComponent<PGCompany.ClanStoreTabButton>()) != null) && ((val_1.<丂世丟丌三三业下世>k__BackingField) == 6))
            {
                    val_13 = Rilisoft.Singleton<ClansController>.Instance;
                if((val_13.丈丝丒丌丛丙丐丐世(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  3)) != false)
            {
                    InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9105"), arg0:  丑丁世丒丅丄丈丑丙.七与丑下丅万丗不丞(丅专与丒丈丗丒丘丌:  3)), 丂三丟丂丈丐丆丗丟:  (float)Rilisoft.Singleton<ClansController>.Instance.丈丄一丈丆且丕丞丌(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  3), 丛丒丟一万上丒丁七:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9101"));
                return;
            }
            
            }
            
            this.Select(丛丁三七丅且丝丏丙:  丛丁三七丅且丝丏丙);
        }
        public ClanStoreTabSelectableButton()
        {
        
        }
    
    }

}
