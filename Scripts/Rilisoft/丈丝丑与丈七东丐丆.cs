using UnityEngine;

namespace Rilisoft
{
    public class 丈丝丑与丈七东丐丆 : 丞专七丛丛丌世丈丕
    {
        // Methods
        public 丈丝丑与丈七东丐丆(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            var val_7;
            Rilisoft.丁丄与下丄丌丈下丟 val_8;
            System.Nullable<RatingLeague> val_2 = this.丈丕丈且上丞下丌丆().丈三与世丟下丅丄专();
            if(((-1090014728) & 1) != 0)
            {
                    val_7 = null;
                val_7 = null;
                val_8 = Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟;
                val_8.万丂丝丁东丑丕丌丌(丙世三一丐丗丄丁万:  this.丑丐丘丏业丙下丆丌());
                return;
            }
            
            object[] val_4 = new object[1];
            val_8 = val_4;
            val_8[0] = this.丈丕丈且上丞下丌丆().业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "achievement \'{0}\' without value", args:  val_4);
        }
        private System.Collections.IEnumerator 丑丐丘丏业丙下丆丌()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丈丝丑与丈七东丐丆.上丒世丂丟丁不丘丁();
        }
        private void 世丕丆丒丕丝下业丘()
        {
            System.Nullable<RatingLeague> val_2 = this.丈丕丈且上丞下丌丆().丈三与世丟下丅丄专();
            if( != RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏())
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().且专丂丐丟一不丌丟() >= this.东丑专丟丅丄业丆丁())
            {
                    return;
            }
            
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  1);
        }
        public override void Dispose()
        {
            var val_3;
            RatingSystem.不上丗东丞不丌丐世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丈丝丑与丈七东丐丆::世丕丆丒丕丝下业丘()));
            val_3 = null;
            val_3 = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.Remove(丙世三一丐丗丄丁万:  this.丑丐丘丏业丙下丆丌());
        }
    
    }

}
