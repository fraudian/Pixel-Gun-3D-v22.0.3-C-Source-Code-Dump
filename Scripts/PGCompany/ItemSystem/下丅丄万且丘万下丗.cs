using UnityEngine;

namespace PGCompany.ItemSystem
{
    internal class 下丅丄万且丘万下丗 : 丒三丟丝丗与不丈丞, 业且丗丐丛丆丈丙丈
    {
        // Methods
        public bool 东一三一万且丕世不(PGCompany.三东丏不丗世丅丌丄 丗丟上上丒丐丗丞丙)
        {
            var val_9;
            var val_10;
            if((丗丟上上丒丐丗丞丙 == null) || (丗丟上上丒丐丗丞丙.不业丙丒丂丞下丆丙() != 1460))
            {
                goto label_2;
            }
            
            PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_2 = PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  丗丟上上丒丐丗丞丙, 与不丕丆丈不丙丟丛:  0);
            if(val_2 == null)
            {
                    return (bool)val_9;
            }
            
            System.Collections.Generic.List<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒> val_3 = val_2.上与与专业丞丙丌下();
            val_10 = null;
            val_10 = null;
            if((下丅丄万且丘万下丗.<>c.<>9__0_0) == null)
            {
                goto label_6;
            }
            
            label_13:
            var val_7 = ((val_3.FindAll(match:  下丅丄万且丘万下丗.<>c.<>9__0_0).Count) >= 丗丟上上丒丐丗丞丙.丂丁丏一丙丛业且丌()) ? 1 : 0;
            return (bool)val_9;
            label_2:
            val_9 = 1;
            return (bool)val_9;
            label_6:
            下丅丄万且丘万下丗.<>c.<>9__0_0 = new System.Predicate<PGCompany.LootBoxSystem.丗上丆专不上丏丏丒>(object:  下丅丄万且丘万下丗.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 下丅丄万且丘万下丗.<>c::丐丘丘丗三一三上丞(PGCompany.LootBoxSystem.丗上丆专不上丏丏丒 丗七丟丈三不丕一三));
            if(val_3 != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        public 下丅丄万且丘万下丗()
        {
        
        }
    
    }

}
