using UnityEngine;

namespace Rilisoft
{
    public abstract class 丒丆丅丂丂丄丕且东 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private int 不与丂下万一丑下与;
        
        // Properties
        internal Player_move_c 丑与不丞专丘七丁且 { get; }
        
        // Methods
        public 丒丆丅丂丂丄丕且东(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            null = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.万丂丝丁东丑丕丌丌(丙世三一丐丗丄丁万:  this.丛丙世丞丌丄业丙丅());
        }
        internal Player_move_c 一丈不三丄丛世七丘()
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
        private System.Collections.IEnumerator 丛丙世丞丌丄业丙丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丒丆丅丂丂丄丕且东.专丏一下丝丞丝丞丈();
        }
        protected abstract void 丞丛丝一与丝丒且丕(); // 0
        public override void Dispose()
        {
            null = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.Remove(丙世三一丐丗丄丁万:  this.丛丙世丞丌丄业丙丅());
        }
    
    }

}
