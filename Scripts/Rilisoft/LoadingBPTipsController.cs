using UnityEngine;

namespace Rilisoft
{
    public class LoadingBPTipsController : Singleton<Rilisoft.LoadingBPTipsController>
    {
        // Fields
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 丙三丏丄丙丟不丏丟;
        
        // Methods
        internal void 下丟丞不丁业丌丛下(LoadingTipsView 丞万一业万丕丏且丄, System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丑下三万万丝七丕丂, bool 丛业丑丝丘丟七与丑 = False)
        {
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_2;
            if(丛业丑丝丘丟七与丑 == false)
            {
                goto label_1;
            }
            
            val_2 = this.丙三丏丄丙丟不丏丟;
            if(val_2 == null)
            {
                    return;
            }
            
            label_6:
            丞万一业万丕丏且丄.丕不丝下丞丌不丆丆(丟专三丙丒丄丂下与:  val_2);
            return;
            label_1:
            val_2 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(丑东与丅丐丅丂丞业:  丑下三万万丝七丕丂);
            this.丙三丏丄丙丟不丏丟 = val_2;
            if(val_2 != null)
            {
                goto label_6;
            }
        
        }
        public LoadingBPTipsController()
        {
        
        }
    
    }

}
