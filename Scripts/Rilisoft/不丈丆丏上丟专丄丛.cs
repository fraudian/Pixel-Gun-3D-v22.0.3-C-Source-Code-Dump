using UnityEngine;

namespace Rilisoft
{
    public class 不丈丆丏上丟专丄丛 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private const string 丂上丅丂东世丁丁丙 = "lv";
        
        // Methods
        public 不丈丆丏上丟专丄丛(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            if(this.世丑丐丅丆丂丘不丁() != false)
            {
                    return;
            }
            
            this.专丈且丆丄专丒丁丅();
            FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.不丈丆丏上丟专丄丛::专丈且丆丄专丒丁丅()));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.不丈丆丏上丟专丄丛::专丈且丆丄专丒丁丅()));
        }
        private void 专丈且丆丄专丒丁丅()
        {
            var val_16;
            object val_17;
            val_16 = this;
            long val_16 = FriendsController.丝丗专上三不丄丑丑();
            if(val_16 < 1)
            {
                    return;
            }
            
            if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
            {
                    return;
            }
            
            object val_4 = this.业丑丁丆丕丆丂丅万().专上丗万丕丌丈丟万(下上丐丆丝丟丝丒不:  "lv");
            if(val_4 != null)
            {
                    if(val_16 == (System.Convert.ToInt64(value:  val_4)))
            {
                    return;
            }
            
                val_17 = System.Convert.ToInt32(value:  val_4);
                if((UnityEngine.Mathf.Abs(value:  (System.Convert.ToInt32(value:  val_16)) - val_17)) < 120)
            {
                    return;
            }
            
                val_17 = val_16;
                this.业丑丁丆丕丆丂丅万().丂丏一业丑丄丝丐丄(下上丐丆丝丟丝丒不:  "lv", 下下丏一丙不丘丌丞:  val_16);
                val_16 = val_16 - (System.Convert.ToInt64(value:  val_4));
                if(val_16 < 1)
            {
                    return;
            }
            
                if(this.业下不上上丕丑丏世() < 1)
            {
                    return;
            }
            
                if(this.业下不上上丕丑丏世() > 0)
            {
                    return;
            }
            
                this.上不丕丌丄世丆丘丘(且下丆丕丝丄丑三三:  this.业下不上上丕丑丏世());
                return;
            }
            
            val_16 = this.业丑丁丆丕丆丂丅万();
            val_16.丂丏一业丑丄丝丐丄(下上丐丆丝丟丝丒不:  "lv", 下下丏一丙不丘丌丞:  val_16);
        }
        public override void Dispose()
        {
            FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.不丈丆丏上丟专丄丛::专丈且丆丄专丒丁丅()));
            AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.不丈丆丏上丟专丄丛::专丈且丆丄专丒丁丅()));
        }
    
    }

}
