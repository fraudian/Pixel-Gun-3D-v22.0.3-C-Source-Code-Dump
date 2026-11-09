using UnityEngine;
internal class ItemUpgradePromoInRespawnWindow : MonoBehaviour
{
    // Fields
    private UILabel efficiencyAfterUpgradeLabel;
    private UILabel upgradePriceLabel;
    private UITexture upgradeCurrencyTexture;
    private UnityEngine.GameObject tweenObject;
    private UnityEngine.GameObject upgradeButton;
    private UnityEngine.GameObject upgrBtnEfficiencyLabelObject;
    
    // Methods
    internal PGCompany.丗丟丄丈东丝丕丄世 丐丙丞丑专丝万丌东()
    {
        var val_35;
        string val_36;
        PGCompany.丗丟丄丈东丝丕丄世 val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        string val_1 = 丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7);
        if((System.String.Equals(a:  val_1, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) == false)
        {
            goto label_5;
        }
        
        label_57:
        val_35 = null;
        val_35 = null;
        三丈丟与丏丘丈丐万 val_6 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        val_36 = val_6.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        PGCompany.丟丝东丈丐丙三下丛 val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丟丝东丈丐丙三下丛>(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_36);
        val_37 = val_9;
        if((val_9.且丌丛下东一丌且业(下丅丙一丂丗丅丝七:  val_37)) == true)
        {
                return (PGCompany.丗丟丄丈东丝丕丄世)val_37;
        }
        
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_11 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        val_38 = 0;
        val_39 = 2147483647;
        goto label_15;
        label_46:
        val_40 = null;
        val_40 = null;
        if(val_38 != WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万())
        {
                val_41 = null;
            val_41 = null;
            三丈丟与丏丘丈丐万 val_15 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
            val_36 = val_15.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
            PGCompany.丟丝东丈丐丙三下丛 val_17 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.丟丝东丈丐丙三下丛>(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_36);
            if((val_17.且丌丛下东一丌且业(下丅丙一丂丗丅丝七:  val_17)) != false)
        {
                val_42 = null;
            val_42 = null;
            val_36 = public 三丈丟与丏丘丈丐万 System.Collections.Generic.List<三丈丟与丏丘丈丐万>::get_Item(int index);
            int val_21 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0].丂丕丗丕丆七丆丞与(下丅丙一丂丗丅丝七:  val_20.三丐三丞丘丕不丒专);
            if(val_21 <= val_39)
        {
                if(val_21 < val_39)
        {
                val_11.Clear();
            val_39 = val_21;
        }
        
            val_43 = null;
            val_43 = null;
            三丈丟与丏丘丈丐万 val_23 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
            val_36 = public System.Void System.Collections.Generic.List<三丅丁丗丗丝丂万且>::Add(三丅丁丗丗丝丂万且 item);
            val_11.Add(item:  val_23.三丐三丞丘丕不丒专);
        }
        
        }
        
        }
        
        val_38 = 1;
        label_15:
        val_44 = null;
        val_44 = null;
        if(val_38 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_46;
        }
        
        if(val_11.Count < 1)
        {
            goto label_48;
        }
        
        System.Random val_27 = new System.Random();
        int val_28 = val_11.Count;
        PGCompany.世东三上七丂丌下丑 val_30 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_30 != null)
        {
                return val_30.丐万且丏丙万下专丑(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_11.Item[-751382304].与不丞丑七丘丁丂丛());
        }
        
        return val_30.丐万且丏丙万下专丑(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_11.Item[-751382304].与不丞丑七丘丁丂丛());
        label_5:
        PGCompany.丗丟丄丈东丝丕丄世 val_33 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_1);
        val_37 = val_33;
        if(val_37 == null)
        {
            goto label_57;
        }
        
        if((val_33.且丌丛下东一丌且业(下丅丙一丂丗丅丝七:  val_37)) == true)
        {
                return (PGCompany.丗丟丄丈东丝丕丄世)val_37;
        }
        
        goto label_57;
        label_48:
        val_37 = 0;
        return (PGCompany.丗丟丄丈东丝丕丄世)val_37;
    }
    internal void 三丒丈丁下专丙不丌(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七, bool 丐丏上业丈丂与万丞)
    {
        bool val_41;
        UILabel val_42;
        string val_43;
        丕丑丙丑丙东丌丘丕 val_44;
        var val_45;
        var val_46;
        int val_47;
        var val_48;
        val_41 = 丐丏上业丈丂与万丞;
        val_42 = this;
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        val_43 = 下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七();
        丈丞丕丘丕丗与上一 val_5 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七()), 丞一丁业丄一一业且:  val_43, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  val_41, 丗业丕七且丝丆丝丘:  false);
        if(val_5 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.upgradePriceLabel, 丕丗丘丑丛与丑业丒:  val_5.丟丂丞不专丆万丒世().ToString());
        this.upgrBtnEfficiencyLabelObject.SetActive(value:  false);
        PGCompany.三东丏不丗世丅丌丄 val_9 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  val_5.东与三丌丅三丒丏业());
        val_9.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_5.丟丂丞不专丆万丒世());
        val_43 = this.upgradeCurrencyTexture;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_43, 与万丆丛丒万丝丙丑:  new PGCompany.丌丑丕丙丅丈丈丘丄(丈丄不七三万丄丁不:  val_9));
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        ItemRarity val_12 = (null == null) ? 下丅丙一丂丗丅丝七 : 0;
        if(val_12 == 0)
        {
            goto label_13;
        }
        
        val_44 = val_12.丐上下三丑丈丑丄丟().七丑丌专丒上丒丙七();
        if(val_44 == null)
        {
                丕丑丙丑丙东丌丘丕 val_17 = null;
            val_44 = val_17;
            val_17 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_12.丐上下三丑丈丑丄丟().七丙丛与万且专三三(), 丏丆丐丑专与丄丘丞:  下丅丙一丂丗丅丝七);
        }
        
        val_45 = 0;
        val_46 = BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  val_17);
        if(val_41 == false)
        {
            goto label_19;
        }
        
        val_47 = 0;
        int val_19 = ExperienceController.丞丞丘业东丙丏七丌();
        goto label_22;
        label_13:
        val_48 = 0;
        val_46 = 0;
        goto label_25;
        label_19:
        var val_41 = 0;
        val_41 = val_41 + 1;
        val_47 = val_12.丁丕丁三丁丗不三丟() + 1;
        val_45 = 1;
        label_22:
        val_43 = val_12;
        val_48 = BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  UnityEngine.Mathf.Clamp(value:  val_47, min:  1, max:  下丅丙一丂丗丅丝七.万丙东丙丐丕专丈丕()), 丏丆丐丑专与丄丘丞:  val_43));
        label_25:
        val_41 = this.upgrBtnEfficiencyLabelObject;
        val_41.SetActive(value:  true);
        val_42 = this.efficiencyAfterUpgradeLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_42, 丕丗丘丑丛与丑业丒:  "+"("+") + val_48 - val_46.ToString(format:  "D")(val_48 - val_46.ToString(format:  "D")));
    }
    internal void 丙东丑不丆业丁丟丝(bool 丑丒业丘丑东丕世丅)
    {
        丑丒业丘丑东丕世丅 = 丑丒业丘丑东丕世丅;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeButton, 丏业丟一东丂东丘丛:  丑丒业丘丑东丕世丅);
    }
    private bool 且丌丛下东一丌且业(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
    {
        var val_17;
        var val_18;
        var val_19;
        val_17 = 下丅丙一丂丗丅丝七;
        if(val_17 == null)
        {
            goto label_22;
        }
        
        Rilisoft.OfferItemType val_1 = val_17.不业丙丒丂丞下丆丙();
        if(val_1 == 10)
        {
            goto label_2;
        }
        
        if(val_1 != 20)
        {
            goto label_22;
        }
        
        val_17 = (((PGCompany.丗丟丄丈东丝丕丄世.__il2cppRuntimeField_typeHierarchy + (PGCompany.且万丅丙丛丌丞与丈.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_17) : 0.丁丕丁三丁丗不三丟();
        var val_5 = (val_17 < ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0;
        return (bool)val_18 & 1;
        label_2:
        var val_6 = (null == null) ? (val_17) : 0;
        if(null == null)
        {
            goto label_10;
        }
        
        label_22:
        val_18 = 0;
        return (bool)val_18 & 1;
        label_10:
        if((((val_6.丐上下三丑丈丑丄丟() == null) || (val_6.丁丕丁三丁丗不三丟() >= ExperienceController.丞丞丘业东丙丏七丌())) || (val_6.丐上下三丑丈丑丄丟().与丕丒世七丁万丂丛() == false)) || (val_6.丐上下三丑丈丑丄丟().七丑丌专丒上丒丙七() == null))
        {
            goto label_22;
        }
        
        val_19 = null;
        val_19 = null;
        bool val_17 = (WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_6.业上丙丞丐丄丆丅七())) ^ 1;
        return (bool)val_18 & 1;
    }
    internal void 不丞三丁丘丐一丘丆(bool 丑丒业丘丑东丕世丅)
    {
        丑丒业丘丑东丕世丅 = 丑丒业丘丑东丕世丅;
        this.tweenObject.SetActive(value:  丑丒业丘丑东丕世丅);
    }
    private int 丂丕丗丕丆七丆丞与(三丅丁丗丗丝丂万且 下丅丙一丂丗丅丝七)
    {
        var val_7;
        int val_8;
        丕丑丙丑丙东丌丘丕 val_1 = 下丅丙一丂丗丅丝七.七丑丌专丒上丒丙七();
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_9;
        }
        
        label_10:
        label_9:
        丈丞丕丘丕丗与上一 val_3 = BalanceController.丂丐丌东丆丙东不丄(丞丌东丟且丒丐丑丂:  val_1, 丝三丛且丘不丌丙下:  下丅丙一丂丗丅丝七.三与丛丑且丐丈业丌());
        if(val_3 != null)
        {
                return val_3.丟丂丞不专丆万丒世();
        }
        
        return val_3.丟丂丞不专丆万丒世();
        label_2:
        if(下丅丙一丂丗丅丝七 != null)
        {
                val_7 = 0;
            val_8 = 下丅丙一丂丗丅丝七.七丙丛与万且专三三();
        }
        else
        {
                val_7 = 0;
            val_8 = 0.七丙丛与万且专三三();
        }
        
        丕丑丙丑丙东丌丘丕 val_6 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_8, 丏丆丐丑专与丄丘丞:  下丅丙一丂丗丅丝七);
        if(下丅丙一丂丗丅丝七 != null)
        {
            goto label_9;
        }
        
        goto label_10;
    }
    public ItemUpgradePromoInRespawnWindow()
    {
    
    }

}
