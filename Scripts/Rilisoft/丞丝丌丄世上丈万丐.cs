using UnityEngine;

namespace Rilisoft
{
    public class 丞丝丌丄世上丈万丐 : 丞专七丛丛丌世丈丕
    {
        // Methods
        public 丞丝丌丄世上丈万丐(Rilisoft.七上丄万丟丈丏丁与 一丐丗丁丞丆丅丟丄, Rilisoft.AchievementProgressData 丕丞且丂丒丄东不丘)
        {
            null = null;
            Rilisoft.AchievementsManager.丁丄与下丄丌丈下丟.万丂丝丁东丑丕丌丌(丙世三一丐丗丄丁万:  this.世丑丈丝上且丆丟丏());
        }
        private System.Collections.IEnumerator 世丑丈丝上且丆丟丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丞丝丌丄世上丈万丐.丏丞丏丐丐丒丄上丐();
        }
        private void 丝丐丞丘且上丒上丂(string 世丐丗专丅三丝丑丆)
        {
            this.丙上丟丏且丐丌不丒();
        }
        private void 丙上丟丏且丐丌不丒()
        {
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance) == 0)
            {
                    return;
            }
            
            int val_5 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.世且丞丑专丞与丐丈().Count;
            if(this.且专丂丐丟一不丌丟() >= val_5)
            {
                    return;
            }
            
            this.上不丕丌丄世丆丘丘(且下丆丕丝丄丑三三:  val_5);
        }
        public override void Dispose()
        {
            Rilisoft.PetsManager.丗丞七上专三丟丘丐(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void Rilisoft.丞丝丌丄世上丈万丐::丝丐丞丘且上丒上丂(string 世丐丗专丅三丝丑丆)));
        }
    
    }

}
