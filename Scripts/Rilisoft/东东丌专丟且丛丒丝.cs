using UnityEngine;

namespace Rilisoft
{
    public class 东东丌专丟且丛丒丝 : 丞专七丛丛丌世丈丕
    {
        // Methods
        public 东东丌专丟且丛丒丝(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            string val_1 = 丕丞且丂丒丄东不丘.丐丙世七丅丅丐下丙();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != false)
            {
                    object[] val_3 = new object[1];
                val_3[0] = val_1.业上丙丞丐丄丆丅七();
                UnityEngine.Debug.LogErrorFormat(format:  "achievement \'{0}\' without value", args:  val_3);
                return;
            }
            
            this.丛丞业世丒丒世丂丞();
            丌丝世丞世丛丆丅丟.丂丌丑丑丞专不专丞(下上丐丆丝丟丝丒不:  val_1.丐丙世七丅丅丐下丙(), 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void Rilisoft.东东丌专丟且丛丒丝::丛丞业世丒丒世丂丞()));
        }
        private void 丛丞业世丒丒世丂丞()
        {
            int val_2 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  丐丙世七丅丅丐下丙(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            if(this.丙万丙丂一丝丁丂下() < 1)
            {
                goto label_4;
            }
            
            int val_6 = this.丙万丙丂一丝丁丂下() - 1;
            if(val_2 >= (X21.丝且丘与丅专丈丛丘()[((long)(int)((val_5 - 1))) << 2]))
            {
                goto label_8;
            }
            
            return;
            label_4:
            if(this.且专丂丐丟一不丌丟() == val_2)
            {
                    return;
            }
            
            label_8:
            this.上不丕丌丄世丆丘丘(且下丆丕丝丄丑三三:  val_2);
        }
        public override void Dispose()
        {
            丌丝世丞世丛丆丅丟.丟三丅丂丞与一丒上(下上丐丆丝丟丝丒不:  丐丙世七丅丅丐下丙(), 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void Rilisoft.东东丌专丟且丛丒丝::丛丞业世丒丒世丂丞()));
        }
    
    }

}
