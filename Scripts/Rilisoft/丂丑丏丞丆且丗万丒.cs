using UnityEngine;

namespace Rilisoft
{
    public class 丂丑丏丞丆且丗万丒 : 丞专七丛丛丌世丈丕
    {
        // Methods
        public 丂丑丏丞丆且丗万丒(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            var val_9;
            var val_10;
            Rilisoft.七上丄万丟丈丏丁与 val_1 = this.丈丕丈且上丞下丌丆();
            val_9 = null;
            val_9 = null;
            if((System.String.op_Inequality(a:  val_1.<且丂东七丘不丑丆下>k__BackingField, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
            {
                    Rilisoft.七上丄万丟丈丏丁与 val_3 = this.丈丕丈且上丞下丌丆();
                val_10 = null;
                val_10 = null;
                if((System.String.op_Inequality(a:  val_3.<且丂东七丘不丑丆下>k__BackingField, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    object[] val_5 = new object[1];
                Rilisoft.七上丄万丟丈丏丁与 val_6 = this.丈丕丈且上丞下丌丆();
                val_5[0] = val_6.<上七东下丏不丕丐丑>k__BackingField;
                UnityEngine.Debug.LogErrorFormat(format:  "achievement \'{0}\' without value", args:  val_5);
                return;
            }
            
            }
            
            Rilisoft.七上丄万丟丈丏丁与 val_7 = this.丈丕丈且上丞下丌丆();
            this.且丄不丄不丕业三丘(丏丂不专上丘丂不丅:  val_7.<且丂东七丘不丑丆下>k__BackingField);
            Progress.丑丅专一业丙丝丄丁.丆丄世东东丝丝一世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.丂丑丏丞丆且丗万丒::且丄不丄不丕业三丘(string 丏丂不专上丘丂不丅)));
        }
        private void 且丄不丄不丕业三丘(string 丏丂不专上丘丂不丅)
        {
            Rilisoft.七上丄万丟丈丏丁与 val_1 = this.丈丕丈且上丞下丌丆();
            if((丏丂不专上丘丂不丅.Equals(value:  val_1.<且丂东七丘不丑丆下>k__BackingField)) == false)
            {
                    return;
            }
            
            Rilisoft.七上丄万丟丈丏丁与 val_4 = this.丈丕丈且上丞下丌丆();
            int val_5 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  val_4.<且丂东七丘不丑丆下>k__BackingField);
            if(val_5 <= this.业丑丁丆丕丆丂丅万().且专丂丐丟一不丌丟())
            {
                    return;
            }
            
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  val_5 - this.业丑丁丆丕丆丂丅万().且专丂丐丟一不丌丟());
        }
        public override void Dispose()
        {
            Progress.丑丅专一业丙丝丄丁.丒一世与三东世不丒(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.丂丑丏丞丆且丗万丒::且丄不丄不丕业三丘(string 丏丂不专上丘丂不丅)));
        }
    
    }

}
