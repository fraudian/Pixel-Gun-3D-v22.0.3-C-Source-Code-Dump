using UnityEngine;

namespace Rilisoft
{
    public class 专丗丗专丆与丑三业 : 丞专七丛丛丌世丈丕
    {
        // Fields
        private int 丈丛与东且丒专丐一;
        private bool 丛丒丞丕丙丟丕丛丒;
        
        // Methods
        public 专丗丗专丆与丑三业(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void Rilisoft.专丗丗专丆与丑三业::且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        }
        private void 且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            int val_2 = this.丈丛与东且丒专丐一;
            val_2 = val_2 + 1;
            this.丈丛与东且丒专丐一 = val_2;
            if(this.丛丒丞丕丙丟丕丛丒 != false)
            {
                    return;
            }
            
            this.丛丒丞丕丙丟丕丛丒 = true;
            val_3 = null;
            val_3 = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.万丂丝丁东丑丕丌丌(丙世三一丐丗丄丁万:  this.丁丙下丆丑丘丕丄下());
        }
        private System.Collections.IEnumerator 丁丙下丆丑丘丕丄下()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 专丗丗专丆与丑三业.丅丅万上丂丝丒世丞();
        }
        public override void Dispose()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void Rilisoft.专丗丗专丆与丑三业::且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        }
    
    }

}
