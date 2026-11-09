using UnityEngine;

namespace Rilisoft
{
    public class 丞东上与丕丑丏丈丕 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private bool 三丙丄不丝丏丁一丕;
        private int 且东丁下丂一世丘丞;
        
        // Methods
        public 丞东上与丕丑丏丈丕(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            this.且东丁下丂一世丘丞 = 0;
            string val_1 = 丕丞且丂丒丄东不丘.丐丙世七丅丅丐下丙();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != false)
            {
                    object[] val_3 = new object[1];
                val_3[0] = val_1.业上丙丞丐丄丆丅七();
                UnityEngine.Debug.LogErrorFormat(format:  "achievement \'{0}\' without value", args:  val_3);
                return;
            }
            
            this.三丙丄不丝丏丁一丕 = 丏丄丑上丛不丈且万.丈东丗与丑丄丆一丘().Contains(item:  一丐丗丁丞丆丅丟丄.丐丙世七丅丅丐下丙());
            this.丛丞业世丒丒世丂丞();
            七丌丞万七万丁丐丙.三业与丑丄丛丗丄上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丞东上与丕丑丏丈丕::丛丞业世丒丒世丂丞()));
            Progress.下业丅丑丌丝丒丅丛.丅不丐丒与丁丄丏世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丞东上与丕丑丏丈丕::丛丞业世丒丒世丂丞()));
            下专世丏丈丞三丗不.上丂丟上三丛丄业一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丞东上与丕丑丏丈丕::丛丞业世丒丒世丂丞()));
        }
        private void 丛丞业世丒丒世丂丞()
        {
            int val_19;
            var val_20;
            int val_21;
            if(this.三丙丄不丝丏丁一丕 == false)
            {
                goto label_1;
            }
            
            if((七丌丞万七万丁丐丙.丗丗丗丐丏丟丅丛专(丝丒丞丙丐一一丅三:  丐丙世七丅丅丐下丙())) == false)
            {
                goto label_5;
            }
            
            string val_4 = 丐丙世七丅丅丐下丙();
            if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上().Contains(item:  val_4)) == true)
            {
                goto label_10;
            }
            
            label_5:
            if((Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  val_4.丐丙世七丅丅丐下丙())) == false)
            {
                goto label_15;
            }
            
            label_10:
            val_19 = 1;
            goto label_20;
            label_1:
            val_19 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  丐丙世七丅丅丐下丙(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            goto label_20;
            label_15:
            val_19 = 0;
            label_20:
            val_20 = null;
            val_20 = null;
            if((下专世丏丈丞三丗不.丆丟丕不丏七且七万.Equals(value:  X22.丐丙世七丅丅丐下丙())) != false)
            {
                    val_19 = 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  val_19.丐丙世七丅丅丐下丙());
            }
            
            if(val_19 < 1)
            {
                goto label_33;
            }
            
            if((this.且东丁下丂一世丘丞 & 2147483648) != 0)
            {
                goto label_30;
            }
            
            val_21 = val_19 - this.且东丁下丂一世丘丞;
            if(val_19 > 1)
            {
                goto label_31;
            }
            
            goto label_33;
            label_30:
            if(this.且专丂丐丟一不丌丟() >= val_19)
            {
                goto label_33;
            }
            
            val_21 = val_19 - this.且专丂丐丟一不丌丟();
            label_31:
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  val_21);
            label_33:
            this.且东丁下丂一世丘丞 = val_19;
        }
        public override void Dispose()
        {
            七丌丞万七万丁丐丙.丐丞七丅世东丆与三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丞东上与丕丑丏丈丕::丛丞业世丒丒世丂丞()));
            Progress.下业丅丑丌丝丒丅丛.丄丄丛丆世丏丅丝丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丞东上与丕丑丏丈丕::丛丞业世丒丒世丂丞()));
            下专世丏丈丞三丗不.且丟不丙世上业一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丞东上与丕丑丏丈丕::丛丞业世丒丒世丂丞()));
        }
    
    }

}
