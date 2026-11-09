using UnityEngine;
public class WeaponSkinSettings : ScriptableObject
{
    // Fields
    private System.Collections.Generic.List<string> materialNames_GENERATED;
    public string nameLocalizationKey;
    private string _weaponPrefabName;
    private string _skinName;
    private string _weaponTag;
    private int _weaponIndex;
    
    // Properties
    internal PGCompany.丟丝东丈丐丙三下丛 ItemWeapon { get; }
    internal ItemRarity Rarity { get; }
    internal int SkinIndex { get; }
    internal bool AvailableForPurchase { get; }
    internal 丈丞丕丘丕丗与上一 PurchasePrice { get; }
    public bool IsDefault { get; }
    public string WeaponPrefabName { get; }
    public string SkinName { get; }
    internal string WeaponTag { get; }
    internal int WeaponIndex { get; }
    
    // Methods
    internal PGCompany.丟丝东丈丐丙三下丛 get_ItemWeapon()
    {
        PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.一丌世丑丄东丞丘三<PGCompany.丟丝东丈丐丙三下丛>(丞世不丒下上上丝丑:  this.WeaponIndex);
        }
        
        return val_1.一丌世丑丄东丞丘三<PGCompany.丟丝东丈丐丙三下丛>(丞世不丒下上上丝丑:  this.WeaponIndex);
    }
    internal ItemRarity get_Rarity()
    {
        var val_4;
        ItemRarity val_2 = 0;
        val_4 = null;
        val_4 = null;
        bool val_3 = BalanceController.东丐丌东丙丛丑上丆.TryGetValue(key:  this.SkinIndex, value: out  val_2);
        return val_2;
    }
    internal int get_SkinIndex()
    {
        PGCompany.丂且专丕丞一上与一 val_1 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  146, 丞一丁业丄一一业且:  this.name);
        }
        
        return val_1.丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  146, 丞一丁业丄一一业且:  this.name);
    }
    internal bool get_AvailableForPurchase()
    {
        null = null;
        bool val_2 = BalanceController.丆丘丈世丞专三专丙.Contains(item:  this.SkinIndex);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    internal 丈丞丕丘丕丗与上一 get_PurchasePrice()
    {
        var val_5;
        var val_6;
        var val_7;
        丈丞丕丘丕丗与上一 val_2 = 0;
        val_5 = null;
        val_5 = null;
        if((BalanceController.丕且不丗丁一丆下世.TryGetValue(key:  this.SkinIndex, value: out  val_2)) != false)
        {
                val_6 = val_2;
            return (丈丞丕丘丕丗与上一)val_6;
        }
        
        val_7 = null;
        val_7 = null;
        丈丞丕丘丕丗与上一 val_4 = null;
        val_6 = val_4;
        val_4 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  44, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        return (丈丞丕丘丕丗与上一)val_6;
    }
    public bool get_IsDefault()
    {
        return System.String.op_Equality(a:  this.SkinName.ToLower(), b:  "default");
    }
    public string get_WeaponPrefabName()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._weaponPrefabName)) == false)
        {
                return (string)this._weaponPrefabName;
        }
        
        this.上丆万不专东丒丟丙();
        return (string)this._weaponPrefabName;
    }
    public string get_SkinName()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._skinName)) == false)
        {
                return (string)this._skinName;
        }
        
        this.上丆万不专东丒丟丙();
        return (string)this._skinName;
    }
    internal string get_WeaponTag()
    {
        string val_5;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._weaponTag)) == false)
        {
            goto label_3;
        }
        
        三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.WeaponPrefabName);
        if(val_3 == null)
        {
            goto label_6;
        }
        
        string val_4 = val_3.与不丞丑七丘丁丂丛();
        goto label_7;
        label_3:
        val_5 = this._weaponTag;
        return val_5;
        label_6:
        val_5 = "";
        label_7:
        this._weaponTag = val_5;
        return val_5;
    }
    internal int get_WeaponIndex()
    {
        int val_4 = this._weaponIndex;
        if(val_4 > 0)
        {
                return val_4;
        }
        
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.WeaponPrefabName);
        if(val_2 != null)
        {
                int val_3 = val_2.业东丅东丌上丗丑不();
        }
        else
        {
                val_4 = 0;
        }
        
        this._weaponIndex = val_4;
        return val_4;
    }
    private void 上丆万不专东丒丟丙()
    {
        var val_9;
        string val_1 = this.name;
        int val_9 = val_1.IndexOf(value:  "_");
        if((val_9 & 2147483648) != 0)
        {
            goto label_2;
        }
        
        val_9 = val_9 + 1;
        this._weaponPrefabName = val_1.Substring(startIndex:  0, length:  val_9);
        if(val_1 == null)
        {
            goto label_4;
        }
        
        val_9 = val_1.Length;
        goto label_5;
        label_2:
        UnityEngine.Debug.LogError(message:  "Не верное имя настроке скина оружия: "("Не верное имя настроке скина оружия: ") + val_1);
        UnityEngine.Debug.LogError(message:  "Формат имени: [id оружия]_[имя скина]");
        return;
        label_4:
        val_9 = 0.Length;
        label_5:
        this._skinName = val_1.Substring(startIndex:  val_9, length:  val_9 - val_9);
    }
    internal System.Collections.Generic.List<UnityEngine.Material> 丗丈上丕丌丕且丆丏()
    {
        System.Collections.Generic.List<UnityEngine.Material> val_2 = new System.Collections.Generic.List<UnityEngine.Material>(capacity:  this.materialNames_GENERATED.Count);
        List.Enumerator<T> val_3 = this.materialNames_GENERATED.GetEnumerator();
        label_5:
        if((1754218552 & 1) == 0)
        {
            goto label_3;
        }
        
        val_2.Add(item:  UnityEngine.Resources.Load<UnityEngine.Material>(path:  "WeaponSkinsV2/WeaponSkinAssets/"("WeaponSkinsV2/WeaponSkinAssets/") + 0.丐丏七丌丕丗业且上()));
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_2;
    }
    public WeaponSkinSettings()
    {
        this.materialNames_GENERATED = new System.Collections.Generic.List<System.String>();
    }

}
