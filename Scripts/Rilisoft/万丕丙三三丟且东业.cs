using UnityEngine;

namespace Rilisoft
{
    public class 万丕丙三三丟且东业 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private int 且丐丑丕丘不万丁丂;
        
        // Methods
        public 万丕丙三三丟且东业(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            var val_16;
            var val_17;
            this.且丐丑丕丘不万丁丂 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丈丕丈且上丞下丌丆().东与三丌丅三丒丏业())) == false)
            {
                goto label_4;
            }
            
            label_19:
            object[] val_4 = new object[1];
            val_4[0] = this.丈丕丈且上丞下丌丆().业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "achievement \'{0}\' without value", args:  val_4);
            return;
            label_4:
            val_16 = null;
            val_16 = null;
            if((System.String.op_Inequality(a:  this.丈丕丈且上丞下丌丆().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                goto label_15;
            }
            
            val_17 = null;
            val_17 = null;
            if((System.String.op_Inequality(a:  this.丈丕丈且上丞下丌丆().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == true)
            {
                goto label_19;
            }
            
            label_15:
            this.且丄不丄不丕业三丘(丏丂不专上丘丂不丅:  this.丈丕丈且上丞下丌丆().东与三丌丅三丒丏业());
            Progress.丑丅专一业丙丝丄丁.丆丄世东东丝丝一世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.万丕丙三三丟且东业::且丄不丄不丕业三丘(string 丏丂不专上丘丂不丅)));
        }
        private void 且丄不丄不丕业三丘(string 丏丂不专上丘丂不丅)
        {
            int val_8;
            if((丏丂不专上丘丂不丅.Equals(value:  this.丈丕丈且上丞下丌丆().东与三丌丅三丒丏业())) == false)
            {
                    return;
            }
            
            string val_8 = this.丈丕丈且上丞下丌丆().东与三丌丅三丒丏业();
            int val_7 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  val_8);
            val_8 = this.且丐丑丕丘不万丁丂;
            if(val_8 == 1)
            {
                    val_8 = val_7;
                this.且丐丑丕丘不万丁丂 = val_7;
            }
            
            val_8 = val_7 - val_8;
            if(val_8 >= 1)
            {
                    this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  val_8);
            }
            
            this.且丐丑丕丘不万丁丂 = val_7;
        }
        public override void Dispose()
        {
            Progress.丑丅专一业丙丝丄丁.丒一世与三东世不丒(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.万丕丙三三丟且东业::且丄不丄不丕业三丘(string 丏丂不专上丘丂不丅)));
        }
    
    }

}
