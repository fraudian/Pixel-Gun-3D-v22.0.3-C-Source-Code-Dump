using UnityEngine;
internal static class 丑东丘丙丝专万丟上
{
    // Fields
    private static System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> 世上一一丘丗丝丑上;
    
    // Methods
    internal static bool 专丈丝丕丁下专丟丌(string 丞专东丏丈下丛丞且)
    {
        var val_6;
        var val_17;
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        WeaponSounds val_2 = UnityEngine.Resources.Load<WeaponSounds>(path:  "Weapons/"("Weapons/") + 丞专东丏丈下丛丞且);
        if(val_2 == 0)
        {
            goto label_41;
        }
        
        List.Enumerator<T> val_4 = val_2.InShopEffects.GetEnumerator();
        label_10:
        if(((-322546112) & 1) == 0)
        {
            goto label_6;
        }
        
        val_17 = null;
        val_17 = null;
        val_18 = 丑东丘丙丝专万丟上.世上一一丘丗丝丑上;
        if((val_18.Contains(item:  val_6.丙东专丂世丈丏丁丂())) == false)
        {
            goto label_10;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_42;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((((val_2.isDamageHeal == true) || (val_2.isCharging == true)) || (val_2.isDash == true)) || (val_2.harpoon == true))
        {
            goto label_42;
        }
        
        val_18 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丙丂丏丛丌丏下丝不:  val_2.丌上丗丕不七世丅丁())) > (val_18.丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())))
        {
            goto label_42;
        }
        
        val_19 = null;
        val_19 = null;
        val_18 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 1)
        {
                if(val_2.categoryNabor != 3)
        {
            goto label_42;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        val_18 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 == 2)
        {
            goto label_37;
        }
        
        val_21 = null;
        val_21 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丅丛丗丒丏丕丞丒丐 != 4)
        {
            goto label_41;
        }
        
        label_37:
        if(val_2.categoryNabor != 5)
        {
            goto label_42;
        }
        
        label_41:
        val_22 = 1;
        return (bool)val_22;
        label_42:
        val_22 = 0;
        return (bool)val_22;
    }
    internal static string 七丘不丘丛丐丗丏且(int 丞世不丒下上上丝丑)
    {
        var val_16;
        if((PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丄专丂上且丌且丅丛() != null) && ((PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丄专丂上且丌且丅丛().丈下丈丑七一下一一().Item[丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丒丐下丙上丂丐一丑(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())].世上丁丈丞丆丕丟丑()) != null))
        {
                System.Collections.Generic.List<System.Int32> val_12 = PGCompany.Matchmaking.Server.不丌三丝业万三丐丑.丑七不且上丗丁一世().丙世丁丘丘丆丗丅丐();
            if(val_12 != null)
        {
                if(val_12.Count > 丞世不丒下上上丝丑)
        {
                string val_15 = "Weapon" + val_12.Item[丞世不丒下上上丝丑];
            return (string)val_16;
        }
        
        }
        
        }
        
        val_16 = "";
        return (string)val_16;
    }
    private static 丑东丘丙丝专万丟上()
    {
        System.Collections.Generic.List<丈不三丛七丑丈丑丆> val_1 = new System.Collections.Generic.List<丈不三丛七丑丈丑丆>();
        if(val_1 != null)
        {
                val_1.Add(item:  47);
            val_1.Add(item:  60);
            val_1.Add(item:  30);
            val_1.Add(item:  69);
            val_1.Add(item:  52);
            val_1.Add(item:  40);
            val_1.Add(item:  74);
            val_1.Add(item:  64);
            val_1.Add(item:  63);
            val_1.Add(item:  46);
            val_1.Add(item:  70);
            val_1.Add(item:  72);
            val_1.Add(item:  73);
            val_1.Add(item:  57);
            val_1.Add(item:  24);
        }
        else
        {
                val_1.Add(item:  47);
            val_1.Add(item:  60);
            val_1.Add(item:  30);
            val_1.Add(item:  69);
            val_1.Add(item:  52);
            val_1.Add(item:  40);
            val_1.Add(item:  74);
            val_1.Add(item:  64);
            val_1.Add(item:  63);
            val_1.Add(item:  46);
            val_1.Add(item:  70);
            val_1.Add(item:  72);
            val_1.Add(item:  73);
            val_1.Add(item:  57);
            val_1.Add(item:  24);
        }
        
        val_1.Add(item:  107);
        丑东丘丙丝专万丟上.世上一一丘丗丝丑上 = val_1;
    }

}
