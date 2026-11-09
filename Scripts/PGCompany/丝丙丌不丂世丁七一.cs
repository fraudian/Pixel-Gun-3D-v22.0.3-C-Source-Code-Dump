using UnityEngine;

namespace PGCompany
{
    internal class 丝丙丌不丂世丁七一 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().七丌丕丛丝东丅上丌(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.且丝东丙丙丑下丑丙>(object:  this, method:  System.Void PGCompany.丝丙丌不丂世丁七一::东丗丐丌丅丌丑丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.且丝东丙丙丑下丑丙 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丕丅且丁丝丁万丏丌(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.且丝东丙丙丑下丑丙>(object:  this, method:  System.Void PGCompany.丝丙丌不丂世丁七一::东丗丐丌丅丌丑丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.且丝东丙丙丑下丑丙 丗丛不丁丑专专丂且)));
        }
        private void 东丗丐丌丅丌丑丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.且丝东丙丙丑下丑丙 丗丛不丁丑专专丂且)
        {
            bool val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            val_9 = static_value_082C7088;
            if(val_9 != GameConnect.丑丌丛丈丅丅与不业())
            {
                    return;
            }
            
            if(val_9.InSquad != false)
            {
                    if(丗丛不丁丑专专丂且.丆世一丄丞专丗不东() == false)
            {
                    return;
            }
            
            }
            
            val_10 = null;
            val_10 = null;
            if(SquadController.丄丘七三上丕世丞业 != 0)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = SquadController.丄丘七三上丕世丞业.丛丟万丅与丐万东丆();
            }
            else
            {
                    val_12 = 0;
            }
            
            val_13 = null;
            val_13 = null;
            if(GameController.onlineMode != 0)
            {
                    val_14 = null;
                val_14 = null;
                if(GameController.onlineMode != null)
            {
                    if(null == null)
            {
                goto label_28;
            }
            
            }
            
            }
            
            label_36:
            if(568 != 0)
            {
                    if((System.Math.Max(val1:  0, val2:  0)) != 568)
            {
                    return;
            }
            
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
            return;
            label_28:
            int val_8 = GameController.onlineMode + 544.且丌世丈下丄三丅丅();
            goto label_36;
        }
        public 丝丙丌不丂世丁七一()
        {
        
        }
    
    }

}
