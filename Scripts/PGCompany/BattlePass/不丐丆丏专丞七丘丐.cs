using UnityEngine;

namespace PGCompany.BattlePass
{
    public class 不丐丆丏专丞七丘丐 : 丗且世丝丏丕丑丈业
    {
        // Methods
        public void 丗三丗丒丏丐且丞丗(ref string 丞丟丂丄下万丈万东, PGCompany.BattlePass.三丛上丁丗丌丆丌东 七丂丙上与丅丘丟丏, bool 丙专丂世七丂专丆丆)
        {
            string val_11;
            var val_12;
            UnityEngine.Object val_13;
            var val_14;
            string val_15;
            if(七丂丙上与丅丘丟丏 == null)
            {
                    return;
            }
            
            if(七丂丙上与丅丘丟丏.丄上丝丌上下丒上丙() == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.丘丄上丏不丝不丐丐 val_2 = 七丂丙上与丅丘丟丏.丄上丝丌上下丒上丙();
            val_11 = val_2.丛丝丁丗且丘丂与万;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            val_13 = 0;
            if(SceneInfoController.丄丘七三上丕世丞业 != 0)
            {
                    val_14 = null;
                val_14 = null;
                PGCompany.BattlePass.丘丄上丏不丝不丐丐 val_5 = 七丂丙上与丅丘丟丏.丄上丝丌上下丒上丙();
                val_13 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_5.丛丝丁丗且丘丂与万);
            }
            
            if(val_13 != 0)
            {
                    val_15 = val_13.七丛一丛专七丈丅专();
            }
            else
            {
                    PGCompany.BattlePass.丘丄上丏不丝不丐丐 val_9 = 七丂丙上与丅丘丟丏.丄上丝丌上下丒上丙();
                val_15 = val_9.丛丝丁丗且丘丂与万;
            }
            
            val_11 = 丞丟丂丄下万丈万东;
            丞丟丂丄下万丈万东 = val_11.Replace(oldValue:  "{5}", newValue:  val_15);
        }
        public 不丐丆丏专丞七丘丐()
        {
        
        }
    
    }

}
