using UnityEngine;
[Serializable]
internal class AlmanachWeaponSet
{
    // Fields
    internal string id;
    internal System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> weapons;
    internal Rilisoft.OfferItem reward;
    
    // Properties
    internal bool IsCompleted { get; }
    internal int PurchasedCount { get; }
    internal string Name { get; }
    internal string NameDefault { get; }
    
    // Methods
    internal bool get_IsCompleted()
    {
        return (bool)(this.PurchasedCount >= this.weapons.Count) ? 1 : 0;
    }
    internal int get_PurchasedCount()
    {
        var val_2;
        System.Func<PGCompany.丟丝东丈丐丙三下丛, System.Boolean> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = AlmanachWeaponSet.<>c.<>9__6_0;
        if(val_4 != null)
        {
                return System.Linq.Enumerable.Count<PGCompany.丟丝东丈丐丙三下丛>(source:  this.weapons, predicate:  System.Func<PGCompany.丟丝东丈丐丙三下丛, System.Boolean> val_1 = null);
        }
        
        val_4 = val_1;
        val_1 = new System.Func<PGCompany.丟丝东丈丐丙三下丛, System.Boolean>(object:  AlmanachWeaponSet.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AlmanachWeaponSet.<>c::丐丕丅三丘丄丄不丄(PGCompany.丟丝东丈丐丙三下丛 三丟东丕丄丄下下丑));
        AlmanachWeaponSet.<>c.<>9__6_0 = val_4;
        return System.Linq.Enumerable.Count<PGCompany.丟丝东丈丐丙三下丛>(source:  this.weapons, predicate:  val_1);
    }
    internal string get_Name()
    {
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "col_" + this.id + "_d");
    }
    internal string get_NameDefault()
    {
        return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  System.String.Format(format:  "col_{0}_d", arg0:  this.id));
    }
    public AlmanachWeaponSet()
    {
        this.weapons = new System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛>();
    }

}
