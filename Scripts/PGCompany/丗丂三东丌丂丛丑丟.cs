using UnityEngine;

namespace PGCompany
{
    internal class 丗丂三东丌丂丛丑丟 : 丂丏丑丈丕三丙丛丑
    {
        // Properties
        internal override bool 丄丈丅一丂丈丄东专 { get; }
        
        // Methods
        internal override bool 丐丝丝丝丞三与丘丒()
        {
            return true;
        }
        internal override void 丈且东丑丂且万丒丅()
        {
        
        }
        internal override void 丏丟业下与丝丕丈丘()
        {
        
        }
        protected override void 丅丘丙丒丆丄三丝丌()
        {
            var val_21;
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
            if(ClansTutorialController.上且世丘丝三丄丈丗() == false)
            {
                    return;
            }
            
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  (Rilisoft.Singleton<NotificationMessageController>.Instance.丅丅上丛万万丛与丐()) + this.丂丁丏一丙丛业且丌());
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
            {
                    var val_11 = ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟业丅世丟丗丄丞万()) < 2) ? 1 : 0;
            }
            else
            {
                    val_21 = 0;
            }
            
            if((val_21 & (Rilisoft.Singleton<ClansController>.Instance.上丘丑丄丝丂丝七三())) != false)
            {
                    this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丂丁丏一丙丛业且丌() + 1);
            }
            
            PGCompany.ClanLootBoxController val_17 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance;
            if(val_17 == null)
            {
                    return;
            }
            
            if(val_17.丕丟丏丟丙丗丞丈上() == false)
            {
                    return;
            }
            
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丂丁丏一丙丛业且丌() + 1);
        }
        public 丗丂三东丌丂丛丑丟()
        {
        
        }
    
    }

}
