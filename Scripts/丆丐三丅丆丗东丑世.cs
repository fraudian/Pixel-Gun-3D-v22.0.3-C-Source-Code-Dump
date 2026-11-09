using UnityEngine;
internal class 丆丐三丅丆丗东丑世
{
    // Methods
    internal static bool 不与丗不丁丏与丄且(string 丞丅上丏丂且下丅与)
    {
        var val_4;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丅上丏丂且下丅与)) != true)
        {
                if((丆丐三丅丆丗东丑世.丞丒丒三丞且丏东丄(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与)) != false)
        {
                val_4 = (~(丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  丞丅上丏丂且下丅与))) & 1;
            return (bool)val_4;
        }
        
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    internal static System.Collections.Generic.List<string> 丒下丌业与丌丘世丙()
    {
        var val_5;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_5 = null;
        val_5 = null;
        val_1.AddRange(collection:  WeaponManager.丆丘丘丑丌丁世七不);
        val_1.AddRange(collection:  WeaponManager.丗丈丁世且世丂丈丝);
        val_1.AddRange(collection:  WeaponManager.丁丟丟一下专万丒丒);
        val_1.AddRange(collection:  WeaponManager.丆丘下丛不丒丛丌丄);
        Dictionary.Enumerator<TKey, TValue> val_3 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().GetEnumerator();
        label_15:
        if(((-1909414472) & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        if(0 == 0)
        {
            goto label_15;
        }
        
        val_1.Add(item:  ???);
        goto label_15;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    internal static bool 丞丒丒三丞且丏东丄(int 丞世不丒下上上丝丑)
    {
        PGCompany.丙万丙下三下丄丌丄 val_2 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        return 丆丐三丅丆丗东丑世.丞丒丒三丞且丏东丄(丞丅上丏丂且下丅与:  val_2.业上丙丞丐丄丆丅七());
    }
    internal static bool 丞丒丒三丞且丏东丄(string 丞丅上丏丂且下丅与)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丅上丏丂且下丅与)) != false)
        {
                val_7 = 0;
            return (bool)val_7;
        }
        
        val_8 = null;
        val_8 = null;
        if((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  丞丅上丏丂且下丅与)) == true)
        {
            goto label_16;
        }
        
        val_9 = null;
        val_9 = null;
        if(((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  丞丅上丏丂且下丅与)) == true) || ((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  丞丅上丏丂且下丅与)) == true))
        {
            goto label_16;
        }
        
        val_10 = null;
        val_10 = null;
        if((WeaponManager.丁丟丟一下专万丒丒.Contains(item:  丞丅上丏丂且下丅与)) == false)
        {
            goto label_20;
        }
        
        label_16:
        val_7 = 1;
        return (bool)val_7;
        label_20:
        val_11 = null;
        val_11 = null;
        if(WeaponManager.丆丘下丛不丒丛丌丄 != null)
        {
                return WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  丞丅上丏丂且下丅与);
        }
        
        return WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  丞丅上丏丂且下丅与);
    }
    internal static string 三下丏丕丑丘丐丄丛(string 丐丗丝丕上三丞丝上, string 丞一丁业丄一一业且)
    {
        return (string)System.String.Format(format:  "{0}/{1}", arg0:  Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  丐丗丝丕上三丞丝上), arg1:  BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  丞一丁业丄一一业且));
    }
    public 丆丐三丅丆丗东丑世()
    {
    
    }

}
