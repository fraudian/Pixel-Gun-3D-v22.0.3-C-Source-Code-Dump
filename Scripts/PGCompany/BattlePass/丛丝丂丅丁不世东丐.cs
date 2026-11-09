using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丛丝丂丅丁不世东丐
    {
        // Fields
        private static System.Collections.Generic.Dictionary<PGCompany.BattlePass.丛丛丞丞丂万一丂七, System.Type> 世丂上丌丞且丁七丏;
        
        // Methods
        public static PGCompany.BattlePass.丂世下世丈下一丈丝 下丙丗丟丂下丏不丟(PGCompany.BattlePass.丛丛丞丞丂万一丂七 丁丅丈丌丟世丗丗丟)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if((PGCompany.BattlePass.丛丝丂丅丁不世东丐.世丂上丌丞且丁七丏.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) != false)
            {
                    val_6 = null;
                val_6 = null;
                if((System.Activator.CreateInstance(type:  PGCompany.BattlePass.丛丝丂丅丁不世东丐.世丂上丌丞且丁七丏.Item[丁丅丈丌丟世丗丗丟])) == null)
            {
                    return (PGCompany.BattlePass.丂世下世丈下一丈丝)val_7;
            }
            
            }
            
            val_7 = 0;
            return (PGCompany.BattlePass.丂世下世丈下一丈丝)val_7;
        }
        public 丛丝丂丅丁不世东丐()
        {
        
        }
        private static 丛丝丂丅丁不世东丐()
        {
            System.Collections.Generic.Dictionary<PGCompany.BattlePass.丛丛丞丞丂万一丂七, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.BattlePass.丛丛丞丞丂万一丂七, System.Type>();
            val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.BattlePass.丛丝丂丅丁不世东丐.世丂上丌丞且丁七丏 = val_1;
        }
    
    }

}
