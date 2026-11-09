using UnityEngine;
private sealed class 丒丒丛丙不万专三丆.丈下丝与且丈丞丝丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.List<System.Collections.Generic.List<PGCompany.ConfigId>> 三万丟丁万丄一三丛;
    public PGCompany.丒丒丛丙不万专三丆 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List.Enumerator<System.Collections.Generic.List<PGCompany.ConfigId>> 与业丕业业业丌丟丐;
    private System.Collections.Generic.List<PGCompany.ConfigId> 丏丝丏业丐一丑丟丈;
    private float 一丟丐丑丐上下丏丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丒丒丛丙不万专三丆.丈下丝与且丈丞丝丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_3;
        List.Enumerator<System.Collections.Generic.List<PGCompany.ConfigId>> val_4;
        var val_15;
        var val_34;
        var val_35;
        UnityEngine.WaitUntil val_36;
        List.Enumerator<System.Collections.Generic.List<PGCompany.ConfigId>> val_37;
        var val_38;
        System.Func<System.Boolean> val_40;
        int val_41;
        object val_42;
        var val_43;
        var val_46;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_115;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = this.一丟丐丑丐上下丏丘 + val_1;
        this.一丟丐丑丐上下丏丘 = val_1;
        if(val_1 <= 3f)
        {
            goto label_4;
        }
        
        val_34 = 0;
        val_35 = 0;
        val_36 = 0;
        goto label_93;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        List.Enumerator<T> val_2 = this.三万丟丁万丄一三丛.GetEnumerator();
        val_35 = 0;
        val_34 = 0;
        val_37 = this.与业丕业业业丌丟丐;
        mem[1152921555206963920] = val_3;
        val_36 = 0;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_4;
        goto label_7;
        label_2:
        val_35 = 0;
        val_34 = 0;
        val_36 = 0;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_15;
        label_4:
        val_35 = 0;
        val_34 = 0;
        val_36 = 0;
        goto label_10;
        label_93:
        this.丏丝丏业丐一丑丟丈 = 0;
        val_37 = this.与业丕业业业丌丟丐;
        label_7:
        if((val_37 & 1) == 0)
        {
            goto label_14;
        }
        
        string val_5 = val_37.丐丏七丌丕丗业且上();
        this.丏丝丏业丐一丑丟丈 = val_5;
        if(val_5 == (System.Linq.Enumerable.First<System.Collections.Generic.List<PGCompany.ConfigId>>(source:  this.三万丟丁万丄一三丛)))
        {
            goto label_15;
        }
        
        val_38 = null;
        val_38 = null;
        val_40 = 丒丒丛丙不万专三丆.<>c.<>9__48_0;
        if(val_40 == null)
        {
                val_40 = null;
            val_40 = new System.Func<System.Boolean>(object:  丒丒丛丙不万专三丆.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丒丒丛丙不万专三丆.<>c::丐丛不世丌不丕万丘());
            丒丒丛丙不万专三丆.<>c.<>9__48_0 = val_40;
        }
        
        val_36 = new UnityEngine.WaitUntil();
        val_36 = new UnityEngine.WaitUntil(predicate:  null);
        val_41 = 1;
        this.丒上七丌业七丟与丐 = val_36;
        this.丗丏丅丕丆世丁专丟 = val_41;
        return (bool)val_41;
        label_14:
        this.一世丕丕业且且丅丌();
        val_41 = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (bool)val_41;
        label_15:
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丌丞东丅上丁不丗丄() != 1)
        {
            goto label_26;
        }
        
        PGCompany.七丑一上且三世丝三<K, V> val_11 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
        int val_12 = this.丏丝丏业丐一丑丟丈.Count;
        List.Enumerator<T> val_13 = this.丏丝丏业丐一丑丟丈.GetEnumerator();
        goto label_32;
        label_39:
        int val_16 = val_15.丙东专丂世丈丏丁丂();
        string val_17 = PGCompany.丒丒丛丙不万专三丆.丅丙丑丒丈不上丂丘(丞丅上丏丂且下丅与:  val_16);
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_19 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        null.set_Item(key:  "h", value:  this.丝且与丝丒丟万丁专.丆下业丌与七丗世丝(丒丗丁与丅丏丂丕且:  val_17));
        val_4 = PGCompany.丄东专丅丂丝丌且下.丟东丗与世东丅丆一(丈丄丈世一且不不丁:  val_16);
        null.set_Item(key:  "b", value:  val_4);
        val_42 = null;
        val_11.set_Item(key:  val_17, value:  null);
        val_34 = val_34;
        label_32:
        if(((-939502816) & 1) != 0)
        {
            goto label_39;
        }
        
        val_43 = val_35;
        goto label_40;
        label_26:
        this.一世丕丕业且且丅丌();
        goto label_115;
        label_40:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((1 != 1) && (355 == 355))
        {
            
        }
        else
        {
                if( != null)
        {
                val_42 = 0;
            val_43 = 0;
            val_34 = 0;
        }
        else
        {
                val_43 = 0;
        }
        
        }
        
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                object[] val_24 = new object[2];
            val_24[0] = this.丝且与丝丒丟万丁专.GetType();
            val_43 = val_43;
            val_24[1] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_11);
            val_42 = 0;
            UnityEngine.Debug.LogFormat(format:  "[{0}] RetrieveC_onfigsCoroutine => configHashes: {1}", args:  val_24);
        }
        
        PGCompany.七丑一上且三世丝三<K, V> val_26 = PGCompany.七丑一上且三世丝三<System.Object, System.Object>.万世丅七一专丕丞不();
        val_26.set_Item(key:  "list", value:  val_11);
        val_26.set_Item(key:  "platform", value:  PGCompany.丒丒丛丙不万专三丆.丐丑丈丘丑丄专丘丄().ToLowerInvariant());
        val_46 = null;
        val_46 = null;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_30 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.与丟丕丒七丆丕与一, 一丐丗丁丞丆丅丟丄:  val_26);
        this.丝且与丝丒丟万丁专.丕不丛业一丏丏丑且 = true;
        PGCompany.七丑一上且三世丝三<K, V> val_31 = PGCompany.七丑一上且三世丝三<System.Object, System.Object>.万世丅七一专丕丞不();
        val_35 = val_43;
        PGCompany.七丑一上且三世丝三<K, V> val_32 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
        val_36 = 1;
        this.一丟丐丑丐上下丏丘 = 0f;
        label_10:
        if(this.丝且与丝丒丟万丁专.丕不丛业一丏丏丑且 == false)
        {
            goto label_93;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_41 = 1;
        return (bool)val_41;
        label_115:
        val_41 = 0;
        return (bool)val_41;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.与业丕业业业丌丟丐);
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
