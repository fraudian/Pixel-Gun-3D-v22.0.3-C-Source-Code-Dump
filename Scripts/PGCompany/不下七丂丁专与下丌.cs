using UnityEngine;

namespace PGCompany
{
    internal class 不下七丂丁专与下丌 : 丕万丅丗丏三丙丈丁
    {
        // Methods
        internal override void 下丏且一三丐一丐不()
        {
            var val_7;
            var val_8;
            val_7 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if((X21 + 80) <= 0)
            {
                goto label_3;
            }
            
            if(val_7 != null)
            {
                goto label_5;
            }
            
            return;
            label_3:
            val_8 = PixelTime.丝丗专上三不丄丑丑();
            if(val_7 == null)
            {
                    return;
            }
            
            label_5:
            if(val_7.专丁丟丏丁丏不丗三() == false)
            {
                    return;
            }
            
            if(val_8 < 1)
            {
                    return;
            }
            
            if(val_7.丗丄上丑丑丅丐丒丌() == true)
            {
                    return;
            }
            
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  2);
            val_7 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_7.ForceShowBanner(丌丅丕一丛丛丄一万:  31, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        internal override bool 丅丂与丈下东三不丟()
        {
            return true;
        }
        public 不下七丂丁专与下丌()
        {
        
        }
    
    }

}
