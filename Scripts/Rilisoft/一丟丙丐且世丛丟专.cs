using UnityEngine;

namespace Rilisoft
{
    public class 一丟丙丐且世丛丟专 : 不丆丐丞业丂丁丑业
    {
        // Methods
        public 一丟丙丐且世丛丟专(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七, 丕专丟上与丄丈三丏.LobbyItemLockInfo 三丙专三丅丁七下丒, Rilisoft.LobbyItemPlayerInfo 东丛下丗且东丄业下)
        {
            与与一丆专丕丄丆丗.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.一丟丙丐且世丛丟专::业丙丝丄丆丒丗丆丙()));
            this.业丙丝丄丆丒丗丆丙();
        }
        private void 业丙丝丄丆丒丗丆丙()
        {
            int val_2 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丝丂丑丄丑丟丆专();
            if(val_2 <= this.丆丕丑丈三丙丁丗丈())
            {
                    return;
            }
            
            this.丒丏丝业丐丞三丏专(下丝丘丁专丐丅丛丝:  val_2);
        }
        public override void Dispose()
        {
            this.Dispose();
            与与一丆专丕丄丆丗.丑七七丌东不下上丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.一丟丙丐且世丛丟专::业丙丝丄丆丒丗丆丙()));
        }
    
    }

}
