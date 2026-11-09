using UnityEngine;
internal class 丗七丝丑丁丈丘丑上
{
    // Fields
    private System.Collections.Generic.Dictionary<string, bool> 丁丌丑与万丟专丘专;
    private System.Collections.Generic.Dictionary<string, CategoryNames> 丄丏丐下丕丌丏世丕;
    private System.Collections.Generic.Dictionary<Progress.丗丂下不丞丞丑丙且, System.Func<string, string>> 丑业丕丈丞丄世丏丈;
    private System.Collections.Generic.Dictionary<string, string> 丅丒世丐上不丝丏丏;
    
    // Methods
    internal 丗七丝丑丁丈丘丑上()
    {
        System.Collections.Generic.Dictionary<System.String, System.Boolean> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Boolean>();
        if(val_1 != null)
        {
                val_1.Add(key:  "ShowArmorKeySetting", value:  true);
        }
        else
        {
                val_1.Add(key:  "ShowArmorKeySetting", value:  true);
        }
        
        val_1.Add(key:  "ShowHatKeySetting", value:  true);
        val_1.Add(key:  "ShowWearKeySetting", value:  true);
        this.丁丌丑与万丟专丘专 = val_1;
        System.Collections.Generic.Dictionary<System.String, CategoryNames> val_2 = new System.Collections.Generic.Dictionary<System.String, CategoryNames>();
        val_2.Add(key:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七(), value:  0);
        string val_4 = 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗();
        if(val_2 != null)
        {
                val_2.Add(key:  val_4, value:  0);
        }
        else
        {
                val_2.Add(key:  val_4, value:  0);
        }
        
        val_2.Add(key:  "WeaponManager.KnifesModeWSSN", value:  2);
        val_2.Add(key:  "WeaponManager.SniperModeWSSN", value:  4);
        if(val_2 != null)
        {
                val_2.Add(key:  与丂丏丛丞丞丒丟丄.一丑丛丒丆丞不专且, value:  2);
        }
        else
        {
                val_2.Add(key:  与丂丏丛丞丞丒丟丄.一丑丛丒丆丞不专且, value:  2);
        }
        
        val_2.Add(key:  "WeaponManager.SniperEventWSSN", value:  4);
        val_2.Add(key:  WeaponManager.丘丁丒上丑世丙丟丆(专丆丌丛东一不丑丙:  100), value:  0);
        this.丄丏丐下丕丌丏世丕 = val_2;
        this.丑业丕丈丞丄世丏丈 = new System.Collections.Generic.Dictionary<Progress.丗丂下不丞丞丑丙且, System.Func<System.String, System.String>>(comparer:  new 丌下上上万一丟丗丁());
        System.Collections.Generic.Dictionary<System.String, System.String> val_8 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_8.Add(key:  9.ToString(), value:  与丂丏丛丞丞丒丟丄.丟丕丈丙丈业业专业());
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_8.Add(key:  10.ToString(), value:  与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟());
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_8.Add(key:  7.ToString(), value:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙());
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_8.Add(key:  12.ToString(), value:  "MaskNoneEquipped");
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_18 = 与丂丏丛丞丞丒丟丄.丄丄丏丛且丛丙且丑();
        val_8.Add(key:  6.ToString(), value:  val_18);
        this.丅丒世丐上不丝丏丏 = val_8;
        val_18 = new System.Object();
        this.丑业丕丈丞丄世丏丈.Add(key:  1, value:  new System.Func<System.String, System.String>(object:  this, method:  System.String 丗七丝丑丁丈丘丑上::业东丙丑三与丐世丑(string 下上丐丆丝丟丝丒不)));
        this.丑业丕丈丞丄世丏丈.Add(key:  2, value:  new System.Func<System.String, System.String>(object:  this, method:  System.String 丗七丝丑丁丈丘丑上::丘丅丅丅东与丂丞七(string 下上丐丆丝丟丝丒不)));
        this.丑业丕丈丞丄世丏丈.Add(key:  3, value:  new System.Func<System.String, System.String>(object:  this, method:  System.String 丗七丝丑丁丈丘丑上::丆丄一丟业丙且与丅(string 下上丐丆丝丟丝丒不)));
        this.丑业丕丈丞丄世丏丈.Add(key:  4, value:  new System.Func<System.String, System.String>(object:  this, method:  System.String 丗七丝丑丁丈丘丑上::丘且丞丘丝三丑万丄(string 下上丐丆丝丟丝丒不)));
        this.丑业丕丈丞丄世丏丈.Add(key:  5, value:  new System.Func<System.String, System.String>(object:  this, method:  System.String 丗七丝丑丁丈丘丑上::丐丆业丕下与丂丕不(string 下上丐丆丝丟丝丒不)));
    }
    internal System.Func<string, string> 丟丄专丕丞丐丆一丟(Progress.丗丂下不丞丞丑丙且 丙一丗丂三丕专七丏)
    {
        System.Func<System.String, System.String> val_4;
        var val_5;
        if((this.丑业丕丈丞丄世丏丈.ContainsKey(key:  丙一丗丂三丕专七丏)) != false)
        {
                val_4 = this.丑业丕丈丞丄世丏丈.Item[丙一丗丂三丕专七丏];
            return (System.Func<System.String, System.String>)val_4;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = 丗七丝丑丁丈丘丑上.<>c.<>9__5_0;
        if(val_4 != null)
        {
                return (System.Func<System.String, System.String>)val_4;
        }
        
        System.Func<System.String, System.String> val_3 = null;
        val_4 = val_3;
        val_3 = new System.Func<System.String, System.String>(object:  丗七丝丑丁丈丘丑上.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丗七丝丑丁丈丘丑上.<>c::三丗丘丈丗业丙七与(string 三丟东丕丄丄下下丑));
        丗七丝丑丁丈丘丑上.<>c.<>9__5_0 = val_4;
        return (System.Func<System.String, System.String>)val_4;
    }
    internal int 东丗专且与万丌丈三(string 丛丘丂丈丘下丂一丛)
    {
        if((this.丄丏丐下丕丌丏世丕.ContainsKey(key:  丛丘丂丈丘下丂一丛)) == false)
        {
                return 0;
        }
        
        if(this.丄丏丐下丕丌丏世丕 != null)
        {
                return this.丄丏丐下丕丌丏世丕.Item[丛丘丂丈丘下丂一丛];
        }
        
        return this.丄丏丐下丕丌丏世丕.Item[丛丘丂丈丘下丂一丛];
    }
    internal bool 下丝丝上丈东丏丆与(string 下上丐丆丝丟丝丒不)
    {
        if((this.丁丌丑与万丟专丘专.ContainsKey(key:  下上丐丆丝丟丝丒不)) == false)
        {
                return false;
        }
        
        if(this.丁丌丑与万丟专丘专 != null)
        {
                return this.丁丌丑与万丟专丘专.Item[下上丐丆丝丟丝丒不];
        }
        
        return this.丁丌丑与万丟专丘专.Item[下上丐丆丝丟丝丒不];
    }
    private string 业东丙丑三与丐世丑(string 下上丐丆丝丟丝丒不)
    {
        var val_9;
        var val_10;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((下上丐丆丝丟丝丒不.Equals(value:  12500.ToString())) != false)
        {
                val_9 = "gadget_fraggrenade";
            return (string)丗七丝丑丁丈丘丑上.丝丄丆丞三丒丞丗业(丙丗丕丟七丟上丈丌:  丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  200, 专丆丌丛东一不丑丙:  0), 专丆丌丛东一不丑丙:  105);
        }
        
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  丐七不丄业丟丙丄一.丟丄三丛丆丏丗世丏(七丆丒与丗丌丄且丂:  212, 专丆丌丛东一不丑丙:  105))) != false)
        {
                val_10 = 12500;
            return (string)丗七丝丑丁丈丘丑上.丝丄丆丞三丒丞丗业(丙丗丕丟七丟上丈丌:  丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  200, 专丆丌丛东一不丑丙:  0), 专丆丌丛东一不丑丙:  105);
        }
        
        if((System.String.op_Equality(a:  下上丐丆丝丟丝丒不, b:  丐七不丄业丟丙丄一.丟丄三丛丆丏丗世丏(七丆丒与丗丌丄且丂:  200, 专丆丌丛东一不丑丙:  105))) != false)
        {
                val_10 = 13000;
            return (string)丗七丝丑丁丈丘丑上.丝丄丆丞三丒丞丗业(丙丗丕丟七丟上丈丌:  丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  200, 专丆丌丛东一不丑丙:  0), 专丆丌丛东一不丑丙:  105);
        }
    
    }
    private string 丘丅丅丅东与丂丞七(string 下上丐丆丝丟丝丒不)
    {
        string val_23;
        var val_25;
        if((下上丐丆丝丟丝丒不.Equals(value:  WeaponManager.丘丁丒上丑世丙丟丆(专丆丌丛东一不丑丙:  100))) != false)
        {
                return WeaponManager.七三上丅丘丗专一丌(专丆丌丛东一不丑丙:  100);
        }
        
        if((下上丐丆丝丟丝丒不.Equals(value:  WeaponManager.丘丁丒上丑世丙丟丆(专丆丌丛东一不丑丙:  105))) != false)
        {
                val_23 = 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗();
            string val_6 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23);
            val_25 = 105;
            return WeaponManager.丑丂丅丂丟且三丗丂(丕与丝万丑丏丑东与:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23 = 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗()), 专丆丌丛东一不丑丙:  111);
        }
        
        if((下上丐丆丝丟丝丒不.Equals(value:  WeaponManager.丘丁丒上丑世丙丟丆(专丆丌丛东一不丑丙:  107))) != false)
        {
                val_23 = 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗();
            string val_10 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23);
            val_25 = 107;
            return WeaponManager.丑丂丅丂丟且三丗丂(丕与丝万丑丏丑东与:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23), 专丆丌丛东一不丑丙:  111);
        }
        
        if((下上丐丆丝丟丝丒不.Equals(value:  WeaponManager.丘丁丒上丑世丙丟丆(专丆丌丛东一不丑丙:  108))) != false)
        {
                val_23 = 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗();
            string val_14 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23);
            val_25 = 108;
            return WeaponManager.丑丂丅丂丟且三丗丂(丕与丝万丑丏丑东与:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23), 专丆丌丛东一不丑丙:  111);
        }
        
        if((下上丐丆丝丟丝丒不.Equals(value:  WeaponManager.丘丁丒上丑世丙丟丆(专丆丌丛东一不丑丙:  109))) != false)
        {
                val_23 = 与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗();
            string val_18 = WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23);
            val_25 = 109;
            return WeaponManager.丑丂丅丂丟且三丗丂(丕与丝万丑丏丑东与:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23), 专丆丌丛东一不丑丙:  111);
        }
        
        if((下上丐丆丝丟丝丒不.Equals(value:  WeaponManager.丘丁丒上丑世丙丟丆(专丆丌丛东一不丑丙:  111))) == false)
        {
                return WeaponManager.丆丆七丆万丝丆丑丟(丅丟丛下业丙七业一:  下上丐丆丝丟丝丒不);
        }
        
        val_25 = 111;
        return WeaponManager.丑丂丅丂丟且三丗丂(丕与丝万丑丏丑东与:  WeaponManager.一下一与丂三三丑丑(丅丟丛下业丙七业一:  val_23), 专丆丌丛东一不丑丙:  111);
    }
    private string 丆丄一丟业丙且与丅(string 下上丐丆丝丟丝丒不)
    {
        var val_3;
        if((this.丅丒世丐上不丝丏丏.ContainsKey(key:  下上丐丆丝丟丝丒不)) != false)
        {
                string val_2 = this.丅丒世丐上不丝丏丏.Item[下上丐丆丝丟丝丒不];
            return (string)val_3;
        }
        
        val_3 = "";
        return (string)val_3;
    }
    private string 丘且丞丘丝三丑万丄(string 下上丐丆丝丟丝丒不)
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_1 != null)
        {
                val_1.Add(key:  "GlidersInfo.GLIDER_EQUIPPED_KEY", value:  "Hang_glider");
        }
        else
        {
                val_1.Add(key:  "GlidersInfo.GLIDER_EQUIPPED_KEY", value:  "Hang_glider");
        }
        
        val_1.Add(key:  "GlidersInfo.TRANSPORT_EQUIPPED_KEY", value:  "royale_car_basic");
        if(val_1 != null)
        {
                val_1.Add(key:  "RoyaleHatsVisualInfo.ROYALE_HAT_EQUIPPED_KEY", value:  "");
        }
        else
        {
                val_1.Add(key:  "RoyaleHatsVisualInfo.ROYALE_HAT_EQUIPPED_KEY", value:  "");
        }
        
        val_1.Add(key:  "RoyaleHatsVisualInfo.ROYALE_AVATAR_EQUIPPED_KEY", value:  "EMPTY_ROYALE_AVATAR");
        val_1.Add(key:  "RoyaleHatsVisualInfo.LANDING_TRAIL_EQUIPPED_KEY", value:  "air_trail");
        string val_2 = WeaponManager.丐丙丅丒与不丘业丟();
        if(val_1 != null)
        {
                val_1.Add(key:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY", value:  val_2);
        }
        else
        {
                val_1.Add(key:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY", value:  val_2);
        }
        
        if((val_1.ContainsKey(key:  下上丐丆丝丟丝丒不)) != false)
        {
                string val_4 = val_1.Item[下上丐丆丝丟丝丒不];
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    private string 丐丆业丕下与丂丕不(string 下上丐丆丝丟丝丒不)
    {
        System.Collections.Generic.List<System.String> val_1 = 95622;
        val_1 = new System.Collections.Generic.List<System.String>();
        if(val_1 != 0)
        {
                val_1.Add(item:  "0");
        }
        else
        {
                val_1.Add(item:  "0");
        }
        
        val_1.Add(item:  "1");
        if(val_1 != 0)
        {
                val_1.Add(item:  "2");
        }
        else
        {
                val_1.Add(item:  "2");
        }
        
        val_1.Add(item:  "6");
        if(val_1 != 0)
        {
                val_1.Add(item:  "7");
        }
        else
        {
                val_1.Add(item:  "7");
        }
        
        val_1.Add(item:  "8");
        if(val_1 != 0)
        {
                val_1.Add(item:  "9");
        }
        else
        {
                val_1.Add(item:  "9");
        }
        
        val_1.Add(item:  "10");
        if(val_1 != 0)
        {
                return val_1.Item[UnityEngine.Random.Range(min:  0, max:  val_1.Count)];
        }
        
        return val_1.Item[UnityEngine.Random.Range(min:  0, max:  val_1.Count)];
    }
    internal static string 丝丄丆丞三丒丞丗业(string 丙丗丕丟七丟上丈丌, FilterMaps 专丆丌丛东一不丑丙)
    {
        string val_7;
        var val_8;
        val_7 = 丙丗丕丟七丟上丈丌;
        丕丈丏丝丗下丟丅丂 val_3 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == true)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        bool val_4 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  val_7, value: out  val_3);
        if(val_3 == 0)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        if((val_3.上东丌丂丟不下丒业(专丆丌丛东一不丑丙:  专丆丌丛东一不丑丙)) == true)
        {
                return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        if(val_3.丒万丕七专不丏丞丌() == 12500)
        {
                val_8 = "gadget_fraggrenade";
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }

}
