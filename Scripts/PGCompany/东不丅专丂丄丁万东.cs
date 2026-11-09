using UnityEngine;

namespace PGCompany
{
    internal class 东不丅专丂丄丁万东 : 丕万丅丗丏三丙丈丁
    {
        // Methods
        internal override void 下丏且一三丐一丐不()
        {
            object val_15;
            var val_16;
            val_15 = this;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if((X21 + 80) <= 0)
            {
                goto label_3;
            }
            
            val_16 = mem[X21 + 80];
            val_16 = X21 + 80;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            return;
            label_3:
            val_16 = PixelTime.丝丗专上三不丄丑丑();
            if(val_2 == null)
            {
                    return;
            }
            
            label_5:
            if(val_2.专丁丟丏丁丏不丗三() == false)
            {
                    return;
            }
            
            if(val_16 < 1)
            {
                    return;
            }
            
            if(val_2.丗丄上丑丑丅丐丒丌() == true)
            {
                    return;
            }
            
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  1);
            if((System.String.IsNullOrEmpty(value:  val_3 + 24)) != false)
            {
                    val_16 = 0;
            }
            else
            {
                    PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_7 = PGCompany.BattlePass.万丈上下三丅丘丛丒.丌丐与丂丗丒丙三七(丞世不丒下上上丝丑:  2);
                if(val_7 != null)
            {
                    val_16 = val_7.丈丏丁东上与东丙丕().Exists(match:  new System.Predicate<Rilisoft.OfferItem>(object:  this, method:  System.Boolean PGCompany.东不丅专丂丄丁万东::东丐丄东丒一丈不丑(Rilisoft.OfferItem 三丟东丕丄丄下下丑)));
            }
            else
            {
                    val_16 = 0;
            }
            
                BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  (val_16 != 1) ? (1 + 1) : 1);
                PGCompany.BattlePass.BattlePassMainUI.下丐丌丅丗丂丐三七 = val_16 != 0x1 ? (1 + 1) : 1 + 24;
            }
            
            if(PGCompany.BattlePass.BattlePassMainUI.下丐丌丅丗丂丐三七 != null)
            {
                    BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  (val_2.专丟专一丒且丘与丌() == 0) ? (3 + 1) : 3);
            }
            
            val_15 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_15.ForceShowBanner(丌丅丕一丛丛丄一万:  31, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            if((val_16 & 1) == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassChallangesUI.丟丄丐一七东不丁且(丙业与丙丗丝不丈东:  2);
        }
        internal override bool 丅丂与丈下东三不丟()
        {
            return true;
        }
        public 东不丅专丂丄丁万东()
        {
        
        }
        private bool 东丐丄东丒一丈不丑(Rilisoft.OfferItem 三丟东丕丄丄下下丑)
        {
            if(三丟东丕丄丄下下丑 != null)
            {
                    return System.String.op_Equality(a:  三丟东丕丄丄下下丑.Id, b:  三丟东丕丄丄下下丑._priceInGems);
            }
            
            return System.String.op_Equality(a:  三丟东丕丄丄下下丑.Id, b:  三丟东丕丄丄下下丑._priceInGems);
        }
    
    }

}
