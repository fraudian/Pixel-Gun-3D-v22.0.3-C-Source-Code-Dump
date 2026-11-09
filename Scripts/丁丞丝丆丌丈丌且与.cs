using UnityEngine;
private sealed class 丙丆下丐丞一丄与丈.丁丞丝丆丌丈丌且与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁;
    public System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丂丘丁丄丁下丝丅七;
    public PGCompany.丙丆下丐丞一丄与丈 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丙丆下丐丞一丄与丈.丁丞丝丆丌丈丌且与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_30;
        var val_31;
        int val_32;
        var val_35;
        var val_36;
        val_30 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_81;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(PixelTime.丝丗专上三不丄丑丑() < 1)
        {
            goto label_4;
        }
        
        if((this.且丘丏丁丑与丙与丁 == null) || (this.丂丘丁丄丁下丝丅七 == null))
        {
            goto label_48;
        }
        
        if(this.且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙() != 2)
        {
            goto label_27;
        }
        
        List.Enumerator<T> val_3 = this.丂丘丁丄丁下丝丅七.GetEnumerator();
        val_31 = 1152921525631263872;
        label_18:
        if(((-2024948336) & 1) == 0)
        {
            goto label_32;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        int val_7 = val_6.业东丅东丌上丗丑不();
        if(((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  val_6.业东丅东丌上丗丑不())) == false) || ((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().下三东一丐下东与丂(且世丌丆三丙一上丟:  val_6.业东丅东丌上丗丑不())) < 1))
        {
            goto label_18;
        }
        
        int val_14 = val_6.业东丅东丌上丗丑不();
        goto label_18;
        label_4:
        val_32 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_32;
        return (bool)val_32;
        label_27:
        if(this.且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙() != 1)
        {
            goto label_48;
        }
        
        List.Enumerator<T> val_16 = this.且丘丏丁丑与丙与丁.GetEnumerator();
        val_31 = 1152921525631264896;
        label_40:
        if(((-2024948336) & 1) == 0)
        {
            goto label_32;
        }
        
        string val_17 = val_5.丐丏七丌丕丗业且上();
        if(((val_17 == null) || ((Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丝丞东业丌丐与不丕(丏专丒丅丙七三专丐:  val_17.业东丅东丌上丗丑不())) == false)) || (this.且丘丏丁丑与丙与丁.业东丅东丌上丗丑不() != 11015))
        {
            goto label_40;
        }
        
        Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丐与丆丂丟万下万且();
        goto label_40;
        label_32:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_48:
        System.Collections.IEnumerator val_25 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_66:
        var val_31 = 0;
        val_31 = val_31 + 1;
        if(val_25.MoveNext() == false)
        {
            goto label_59;
        }
        
        var val_32 = 0;
        val_32 = val_32 + 1;
        object val_29 = val_25.Current;
        0.丅丞丝丞三丝丒丕丆(丐丅丒专丛丏上与业:  1152921504628731904, 丏业下丈与丑且丌丅:  false);
        goto label_66;
        label_59:
        val_35 = 0;
        val_36 = 0;
        val_30 = val_25;
        if(val_30 != null)
        {
                var val_33 = 0;
            val_33 = val_33 + 1;
            val_30.Dispose();
        }
        
        if( == 1)
        {
            goto label_77;
        }
        
        val_32 = 0;
        if( == false)
        {
                return (bool)val_32;
        }
        
        if(410 != 410)
        {
            goto label_79;
        }
        
        return (bool)val_32;
        label_77:
        if( == false)
        {
            goto label_81;
        }
        
        label_79:
        label_81:
        val_32 = 0;
        return (bool)val_32;
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
