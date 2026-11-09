using UnityEngine;
private sealed class 丄且丗且下上七世丂.一丞三丈三三与下丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁;
    public System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七;
    public PGCompany.丄且丗且下上七世丂 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丄且丗且下上七世丂.一丞三丈三三与下丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_19;
        PGCompany.丄且丗且下上七世丂 val_20;
        int val_21;
        var val_24;
        var val_25;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_62;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_20 = this.丝且与丝丒丟万丁专;
        if(PixelTime.丝丗专上三不丄丑丑() < 1)
        {
            goto label_4;
        }
        
        if((this.且丘丏丁丑与丙与丁 == null) || (this.丂丘丁丄丁下丝丅七 == null))
        {
            goto label_29;
        }
        
        this.丝且与丝丒丟万丁专.<专东丘丗丝丈丟丟丑>k__BackingField = this.且丘丏丁丑与丙与丁;
        if(this.且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙() != 1)
        {
            goto label_29;
        }
        
        List.Enumerator<T> val_3 = this.且丘丏丁丑与丙与丁.GetEnumerator();
        label_20:
        if(((-2029798064) & 1) == 0)
        {
            goto label_12;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(((val_6 == null) || ((Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丝丞东业丌丐与不丕(丏专丒丅丙七三专丐:  val_6.业东丅东丌上丗丑不())) == false)) || (this.且丘丏丁丑与丙与丁.业东丅东丌上丗丑不() != 11015))
        {
            goto label_20;
        }
        
        Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丐与丆丂丟万下万且();
        goto label_20;
        label_4:
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_29:
        System.Collections.IEnumerator val_14 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_47:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_40;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        object val_18 = val_14.Current;
        0.丅丞丝丞三丝丒丕丆(丐丅丒专丛丏上与业:  1152921504628731904, 丏业下丈与丑且丌丅:  false);
        goto label_47;
        label_40:
        val_24 = 0;
        val_25 = 0;
        val_20 = 1152921504621703168;
        val_19 = val_14;
        if(val_19 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_19.Dispose();
        }
        
        if( == 1)
        {
            goto label_58;
        }
        
        val_21 = 0;
        if( == false)
        {
                return (bool)val_21;
        }
        
        if(302 != 302)
        {
            goto label_60;
        }
        
        return (bool)val_21;
        label_58:
        if( == false)
        {
            goto label_62;
        }
        
        label_60:
        label_62:
        val_21 = 0;
        return (bool)val_21;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
