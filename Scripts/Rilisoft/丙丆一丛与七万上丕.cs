using UnityEngine;

namespace Rilisoft
{
    public class 丙丆一丛与七万上丕 : 丞专七丛丛丌世丈丕
    {
        // Methods
        public 丙丆一丛与七万上丕(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            if(this.丈丕丈且上丞下丌丆().且三业丘不丆丙丒三() != null)
            {
                    if(this.丈丕丈且上丞下丌丆().且三业丘不丆丙丒三().Count > 0)
            {
                    Player_move_c.丂丕世丘丙丆丟丘丏(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.丙丆一丛与七万上丕::丙丒专丝丈且且丝丞(bool 万且万且丑丗且丌丆)));
                return;
            }
            
            }
            
            object[] val_7 = new object[1];
            val_7[0] = this.丈丕丈且上丞下丌丆().业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "achievement \'{0}\' without value", args:  val_7);
        }
        private void 丙丒专丝丈且且丝丞(bool 万且万且丑丗且丌丆)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            if(万且万且丑丗且丌丆 == false)
            {
                    return;
            }
            
            val_9 = 1152921505286238208;
            val_10 = null;
            val_10 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗() == 0)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            WeaponSounds val_4 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            int val_5 = val_4.categoryNabor - 1;
            val_9 = this.丈丕丈且上丞下丌丆().且三业丘不丆丙丒三();
            if((val_9.Contains(item:  new System.Nullable<CategoryNames>() {HasValue = false})) == false)
            {
                    return;
            }
            
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  1);
        }
        public override void Dispose()
        {
            Player_move_c.丏丕丟七万丟专专专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.丙丆一丛与七万上丕::丙丒专丝丈且且丝丞(bool 万且万且丑丗且丌丆)));
        }
    
    }

}
