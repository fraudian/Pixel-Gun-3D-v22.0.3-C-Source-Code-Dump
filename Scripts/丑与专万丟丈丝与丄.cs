using UnityEngine;
internal class 丑与专万丟丈丝与丄
{
    // Fields
    internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>> 丛东一上丅丗丈丝与;
    internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>> 世丆万一丁世丕丌丞;
    internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>> 丆下业丌丄业与一东;
    internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>> 且丙不丟丞丈丛丐丘;
    internal System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<丈丞丕丘丕丗与上一>> 七三丕丘业一丒丘下;
    
    // Methods
    private 丑与专万丟丈丝与丄()
    {
        this.丛东一上丅丗丈丝与 = new System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>();
        this.世丆万一丁世丕丌丞 = new System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>();
        this.丆下业丌丄业与一东 = new System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>();
        this.且丙不丟丞丈丛丐丘 = new System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>();
        this.七三丕丘业一丒丘下 = new System.Collections.Generic.Dictionary<ItemRarity, System.Collections.Generic.List<丈丞丕丘丕丗与上一>>();
    }
    internal bool 丑丕丈丈不不且丑且()
    {
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(source:  this.丛东一上丅丗丈丝与)) == false)
        {
                return false;
        }
        
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(source:  this.世丆万一丁世丕丌丞)) == false)
        {
                return false;
        }
        
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(source:  this.丆下业丌丄业与一东)) == false)
        {
                return false;
        }
        
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<ItemRarity, System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>>(source:  this.且丙不丟丞丈丛丐丘)) == false)
        {
                return false;
        }
        
        return System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<ItemRarity, System.Collections.Generic.List<丈丞丕丘丕丗与上一>>>(source:  this.七三丕丘业一丒丘下);
    }
    internal static bool 一不丝丟丗不丁专丒(System.Collections.Generic.Dictionary<string, object> 丆丟丞丅丘丛七丛丙)
    {
        if((丆丟丞丅丘丛七丛丙.ContainsKey(key:  "WeaponPrices")) == false)
        {
                return false;
        }
        
        if(丆丟丞丅丘丛七丛丙 != null)
        {
                return 丆丟丞丅丘丛七丛丙.ContainsKey(key:  "WeaponUpgradePrices");
        }
        
        return 丆丟丞丅丘丛七丛丙.ContainsKey(key:  "WeaponUpgradePrices");
    }
    internal static 丑与专万丟丈丝与丄 东丝七业丄丑丒世七(System.Collections.Generic.Dictionary<string, object> 丆丟丞丅丘丛七丛丙)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        object val_2 = 0;
        val_15 = 1152921516595658096;
        if((丆丟丞丅丘丛七丛丙.TryGetValue(key:  "WeaponPrices", value: out  val_2)) != false)
        {
                val_16 = 0;
            BalanceController.丒一万丐丏丝丞业丟(上世丏丁世丟世丆业:  null, 专丂丕丗丗东世丞下: ref  (丑与专万丟丈丝与丄)[1152921524512100832].丛东一上丅丗丈丝与);
            val_17 = 0;
            BalanceController.丏丙业丟丘东世三丈(上世丏丁世丟世丆业:  null, 专丂丕丗丗东世丞下: ref  (丑与专万丟丈丝与丄)[1152921524512100832].世丆万一丁世丕丌丞);
        }
        
        if((丆丟丞丅丘丛七丛丙.TryGetValue(key:  "WeaponUpgradePrices", value: out  val_2)) == false)
        {
                return (丑与专万丟丈丝与丄)new 丑与专万丟丈丝与丄();
        }
        
        val_18 = 0;
        BalanceController.三专三七专丘万丕丗(上世丏丁世丟世丆业:  null, 专丂丕丗丗东世丞下: ref  (丑与专万丟丈丝与丄)[1152921524512100832].丆下业丌丄业与一东);
        val_19 = 0;
        BalanceController.不三业丌上丂上丈丞(上世丏丁世丟世丆业:  null, 专丂丕丗丗东世丞下: ref  (丑与专万丟丈丝与丄)[1152921524512100832].且丙不丟丞丈丛丐丘);
        val_15 = val_2;
        val_20 = 0;
        BalanceController.丒不下七丑丌丞丁七(上世丏丁世丟世丆业:  null, 专丂丕丗丗东世丞下: ref  (丑与专万丟丈丝与丄)[1152921524512100832].七三丕丘业一丒丘下);
        return (丑与专万丟丈丝与丄)new 丑与专万丟丈丝与丄();
    }
    internal static 丑与专万丟丈丝与丄 丑丈丙丗丒丌三丌丙()
    {
        return (丑与专万丟丈丝与丄)new 丑与专万丟丈丝与丄();
    }

}
