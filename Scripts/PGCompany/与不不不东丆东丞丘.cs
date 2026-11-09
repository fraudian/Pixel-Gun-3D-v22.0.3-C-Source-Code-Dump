using UnityEngine;

namespace PGCompany
{
    internal class 与不不不东丆东丞丘 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丗业丈丌丕丆丝下丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.与不不不东丆东丞丘::丝丂上丄上丂丘世且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂东世一丟丁东丈丂(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.与不不不东丆东丞丘::丝丂上丄上丂丘世且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 丝丂上丄上丂丘世且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_10;
            var val_11;
            bool val_12;
            bool val_13;
            var val_14;
            var val_15;
            if(mem[137134216] != 100)
            {
                    if(mem[137134216] != GameConnect.丑丌丛丈丅丅与不业())
            {
                    return;
            }
            
            }
            
            val_10 = null;
            val_10 = null;
            if(GameController.onlineMode != 0)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
                val_12 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
            }
            else
            {
                    val_12 = 0;
            }
            
            if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
            {
                    BattleRoyaleController val_5 = BattleRoyaleController.丑七不且上丗丁一世();
                val_13 = val_5.squadMode;
            }
            else
            {
                    val_13 = 0;
            }
            
            val_14 = null;
            val_14 = null;
            if(GameController.onlineMode != 0)
            {
                    val_15 = null;
                val_15 = null;
                if(GameController.onlineMode != null)
            {
                    if(null == null)
            {
                goto label_33;
            }
            
            }
            
            }
            
            label_37:
            if((((val_13 | val_12) | 0) == 0) && (GameController.onlineMode.InSquad != false))
            {
                    return;
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
            return;
            label_33:
            bool val_11 = GameController.onlineMode.丄丗三丌世东业上丌();
            goto label_37;
        }
        public 与不不不东丆东丞丘()
        {
        
        }
    
    }

}
