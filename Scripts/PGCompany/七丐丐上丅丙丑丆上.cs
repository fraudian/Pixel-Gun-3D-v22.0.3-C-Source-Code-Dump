using UnityEngine;

namespace PGCompany
{
    internal class 七丐丐上丅丙丑丆上 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丈与业丘下丝丐东(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.七丐丐上丅丙丑丆上::东且丆世丂丗丂丒业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丞东与丕丂丞丄丌丌(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.七丐丐上丅丙丑丆上::东且丆世丂丗丂丒业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 东且丆世丂丗丂丒业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_13;
            var val_14;
            var val_15;
            bool val_16;
            bool val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if(mem[137134216] != 100)
            {
                    if(mem[137134216] != GameConnect.丑丌丛丈丅丅与不业())
            {
                    return;
            }
            
            }
            
            val_13 = null;
            val_13 = null;
            val_14 = 1152921504848912384;
            if(GameController.onlineMode != 0)
            {
                    val_15 = null;
                val_15 = null;
                val_16 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
                val_16 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
            }
            else
            {
                    val_16 = 0;
            }
            
            if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
            {
                    BattleRoyaleController val_5 = BattleRoyaleController.丑七不且上丗丁一世();
                val_17 = val_5.squadMode;
            }
            else
            {
                    val_17 = 0;
            }
            
            val_18 = null;
            val_18 = null;
            if(GameController.onlineMode != 0)
            {
                    val_19 = null;
                val_19 = null;
                if(GameController.onlineMode != null)
            {
                    if(null == null)
            {
                goto label_33;
            }
            
            }
            
            }
            
            label_53:
            var val_8 = (val_17 | val_16) | 0;
            if((val_8 == 0) && (GameController.onlineMode.InSquad != false))
            {
                    return;
            }
            
            if((val_8 != 0) && (GameController.onlineMode.InSquad != false))
            {
                    val_20 = null;
                val_20 = null;
                if(SquadController.丄丘七三上丕世丞业 != 0)
            {
                    val_21 = null;
                val_21 = null;
                val_22 = SquadController.丄丘七三上丕世丞业.丛丟万丅与丐万东丆();
            }
            else
            {
                    val_22 = 0;
            }
            
                if(null != 0)
            {
                    if(val_22 < 136135888)
            {
                    return;
            }
            
            }
            
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
            return;
            label_33:
            bool val_14 = GameController.onlineMode.丄丗三丌世东业上丌();
            goto label_53;
        }
        public 七丐丐上丅丙丑丆上()
        {
        
        }
    
    }

}
