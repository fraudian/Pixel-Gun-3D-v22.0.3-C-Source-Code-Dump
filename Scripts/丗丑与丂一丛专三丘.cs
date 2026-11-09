using UnityEngine;
private sealed class WeaponManager.丗丑与丂一丛专三丘
{
    // Fields
    public string[] 业丗且丝三丞丕下且;
    public WeaponManager.不丂丝丝万与丑一丑 东丟且丗且三专丙丁;
    
    // Methods
    public WeaponManager.丗丑与丂一丛专三丘()
    {
    
    }
    internal string[] 世专且丁丘且丘丒三()
    {
        System.String[] val_7;
        var val_8;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.Int32> val_10;
        var val_11;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.String> val_13;
        val_7 = this.业丗且丝三丞丕下且;
        if(val_7 != null)
        {
                return (System.String[])val_6;
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = WeaponManager.<>c.<>9__473_4;
        if(val_10 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.Int32> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.Int32>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WeaponManager.<>c::丞丁丏业丞丘丄丏丅(System.Collections.Generic.KeyValuePair<int, string> 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__473_4 = val_10;
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = WeaponManager.<>c.<>9__473_5;
        if(val_13 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.String> val_4 = null;
            val_13 = val_4;
            val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.String>(object:  WeaponManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String WeaponManager.<>c::业一丏丄万丌七丕丗(System.Collections.Generic.KeyValuePair<int, string> 三丟东丕丄丄下下丑));
            WeaponManager.<>c.<>9__473_5 = val_13;
        }
        
        TSource[] val_6 = System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.String>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, System.String>, System.Int32>(source:  WeaponManager.世万东丘丈丒与丌七(专丆丌丛东一不丑丙:  this.东丟且丗且三专丙丁.丛丝丁丕不丛丙万万), keySelector:  val_2), selector:  val_4));
        this.业丗且丝三丞丕下且 = val_6;
        return (System.String[])val_6;
    }

}
