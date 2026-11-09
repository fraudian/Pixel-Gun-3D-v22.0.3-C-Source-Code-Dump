using UnityEngine;

namespace Rilisoft
{
    public class 上专世与世丆丞丐丝 : 丒丆丅丂丂丄丕且东
    {
        // Fields
        private int 不与丂下万一丑下与;
        
        // Properties
        private Player_move_c 丑与不丞专丘七丁且 { get; }
        
        // Methods
        public 上专世与世丆丞丐丝(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
        
        }
        private Player_move_c 一丈不三丄丛世七丘()
        {
            var val_2;
            WeaponManager val_3;
            Player_move_c val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            val_3 = WeaponManager.丟丗丄业丘丗业丗七;
            val_4 = 0;
            if(val_3 == 0)
            {
                    return val_4;
            }
            
            val_5 = null;
            val_5 = null;
            val_3 = WeaponManager.丟丗丄业丘丗业丗七;
            val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            return val_4;
        }
        protected override void 丞丛丝一与丝丒且丕()
        {
            bool val_2 = UnityEngine.Object.op_Inequality(x:  this.一丈不三丄丛世七丘(), y:  0);
            if(val_2 == false)
            {
                    return;
            }
            
            val_2.一丈不三丄丛世七丘().丈七丐专一一业丟专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.上专世与世丆丞丐丝::丈丑丄丗丝丝万丛下()));
        }
        private void 丈丑丄丗丝丝万丛下()
        {
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  1);
        }
        public override void Dispose()
        {
            this.Dispose();
            bool val_2 = UnityEngine.Object.op_Inequality(x:  this.一丈不三丄丛世七丘(), y:  0);
            if(val_2 == false)
            {
                    return;
            }
            
            val_2.一丈不三丄丛世七丘().万丆一丘不丄一东七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.上专世与世丆丞丐丝::丈丑丄丗丝丝万丛下()));
        }
    
    }

}
