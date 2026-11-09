using UnityEngine;

namespace Rilisoft
{
    public class 一丏丟丄丒丝丁丁丐 : 丞专七丛丛丌世丈丕
    {
        // Methods
        public 一丏丟丄丒丝丁丁丐(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            Rilisoft.七上丄万丟丈丏丁与 val_8;
            System.Object[] val_9;
            val_8 = 一丐丗丁丞丆丅丟丄;
            System.Nullable<CategoryNames> val_2 = this.丈丕丈且上丞下丌丆().一业丙下丛丙世丑丐();
            if(((-1093507720) & 1) != 0)
            {
                    val_9 = Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂();
                System.EventHandler<Rilisoft.下丝丅世上与丌丗丛> val_4 = null;
                val_8 = val_4;
                val_4 = new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void Rilisoft.一丏丟丄丒丝丁丁丐::七丛丐与丑丈一万丁(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且));
                val_9.丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  val_4);
                return;
            }
            
            object[] val_5 = new object[1];
            val_9 = val_5;
            val_9[0] = this.丈丕丈且上丞下丌丆().业上丙丞丐丄丆丅七();
            UnityEngine.Debug.LogErrorFormat(format:  "achievement \'{0}\' without value", args:  val_5);
        }
        private void 七丛丐与丑丈一万丁(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
        {
            System.Nullable<CategoryNames> val_3 = this.丈丕丈且上丞下丌丆().一业丙下丛丙世丑丐();
            if(丗丛不丁丑专专丂且.丄丄世七三业丝丛丘() != (-1093346536))
            {
                    return;
            }
            
            this.丌专丙三业丙丟丝一(丏业下一丑丄丐丘三:  1);
        }
        public override void Dispose()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void Rilisoft.一丏丟丄丒丝丁丁丐::七丛丐与丑丈一万丁(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        }
    
    }

}
