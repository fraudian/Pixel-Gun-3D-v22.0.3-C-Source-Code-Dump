using UnityEngine;
internal class 东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 : ICloneable
{
    // Fields
    internal System.Collections.Generic.Dictionary<int, PGCompany.DataObjects.IntInterval> 丏丆丂丘丆世丘下丅;
    internal int 上七丛丝丏丌丅七且;
    internal PGCompany.DataObjects.IntInterval 一丞东丅一上丒万且;
    
    // Methods
    public object Clone()
    {
        int val_10;
        var val_11;
        val_10 = this.上七丛丝丏丌丅七且;
        .上七丛丝丏丌丅七且 = val_10;
        if(this.一丞东丅一上丒万且 != null)
        {
                object val_2 = this.一丞东丅一上丒万且.Clone();
        }
        
        .一丞东丅一上丒万且 = 0;
        if(this.丏丆丂丘丆世丘下丅 == null)
        {
            goto label_5;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, PGCompany.DataObjects.IntInterval> val_3 = null;
        val_10 = val_3;
        val_3 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.DataObjects.IntInterval>();
        .丏丆丂丘丆世丘下丅 = val_10;
        Dictionary.Enumerator<TKey, TValue> val_4 = this.丏丆丂丘丆世丘下丅.GetEnumerator();
        label_13:
        if((481739592 & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
        object val_7 = val_5._value._obj.Clone();
        val_11 = 0;
        (东下上东丅丂丘丗丙.丂七丄不专下丘丂丟)[1152921543743336368].丏丆丂丘丆世丘下丅.Add(key:  val_5._value._obj.丙东专丂世丈丏丁丂(), value:  null);
        goto label_13;
        label_5:
        .丏丆丂丘丆世丘下丅 = 0;
        return (object)new 东下上东丅丂丘丗丙.丂七丄不专下丘丂丟();
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (object)new 东下上东丅丂丘丗丙.丂七丄不专下丘丂丟();
    }
    public 东下上东丅丂丘丗丙.丂七丄不专下丘丂丟()
    {
    
    }

}
