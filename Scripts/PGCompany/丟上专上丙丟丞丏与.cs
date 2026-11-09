using UnityEngine;

namespace PGCompany
{
    internal class 丟上专上丙丟丞丏与 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().万一丒东丝丄丗丑不(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.一专丌上丗三丆丈丐>(object:  this, method:  System.Void PGCompany.丟上专上丙丟丞丏与::上丙七丅不丙且东上(object 不丟丗丏丛丕不丁丌, Rilisoft.一专丌上丗三丆丈丐 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丒万且东且下丅丄丈(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.一专丌上丗三丆丈丐>(object:  this, method:  System.Void PGCompany.丟上专上丙丟丞丏与::上丙七丅不丙且东上(object 不丟丗丏丛丕不丁丌, Rilisoft.一专丌上丗三丆丈丐 丗丛不丁丑专专丂且)));
        }
        private void 上丙七丅不丙且东上(object 不丟丗丏丛丕不丁丌, Rilisoft.一专丌上丗三丆丈丐 丗丛不丁丑专专丂且)
        {
            bool val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_17;
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            val_10 = static_value_082C7088;
            if(val_10 != GameConnect.丑丌丛丈丅丅与不业())
            {
                    return;
            }
            
            if(val_10.InSquad != false)
            {
                    if(丗丛不丁丑专专丂且.丆世一丄丞专丗不东() == false)
            {
                    return;
            }
            
            }
            
            val_11 = null;
            val_11 = null;
            if(SquadController.丄丘七三上丕世丞业 != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_13 = SquadController.丄丘七三上丕世丞业.丛丟万丅与丐万东丆();
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
                goto label_28;
            }
            
            }
            
            }
            
            label_40:
            val_10 = System.Math.Max(val1:  0, val2:  0);
            if(568 != 0)
            {
                    if(val_10 != 568)
            {
                    return;
            }
            
            }
            
            if((val_7 + 792) != 0)
            {
                    val_17 = mem[val_7 + 792];
                val_17 = val_7 + 792;
                if(val_17 != 丗丛不丁丑专专丂且.丙丒丄丈丏万丛丈丛())
            {
                    return;
            }
            
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
            return;
            label_28:
            int val_9 = GameController.onlineMode + 544.且丌世丈下丄三丅丅();
            goto label_40;
        }
        public 丟上专上丙丟丞丏与()
        {
        
        }
    
    }

}
