using UnityEngine;
private sealed class ConnectionAnalyticsSender.且丟三丞丕业下丑世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丙丙业丆七丏一万丏;
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 专丘丐丞与丗业七丐;
    public string 七丙不丅丛丘丗万与;
    private UnityEngine.WaitForSecondsRealtime 上上丕三且丞丅丆丝;
    private UnityEngine.WaitForSecondsRealtime 丙丝丆丐上丒丈丘且;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 不业丗丁丑丈丅一万;
    private UnityEngine.WWW 一丆丂丄下丑丄东丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConnectionAnalyticsSender.且丟三丞丕业下丑世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_38;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_39;
        object val_41;
        string val_42;
        UnityEngine.WaitForSecondsRealtime val_43;
        int val_44;
        var val_45;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>> val_47;
        var val_48;
        var val_50;
        var val_51;
        if(this.丗丏丅丕丆世丁专丟 > 5)
        {
            goto label_1;
        }
        
        var val_38 = 106042628 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_38 = val_38 + 106042628;
        goto (106042628 + (this.丗丏丅丕丆世丁专丟) << 2 + 106042628);
        label_1:
        val_38 = 0;
        return (bool)val_38;
        label_12:
        if(((-946429184) & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        bool val_11 = this.专丘丐丞与丗业七丐.Remove(key:  val_9._value._obj.丐丏七丌丕丗业且上());
        goto label_12;
        label_20:
        if(((-946429184) & 1) == 0)
        {
            goto label_16;
        }
        
        ConfiguredValueTaskAwaiter val_14 = val_8.GetAwaiter();
        if((this.专丘丐丞与丗业七丐.ContainsKey(key:  val_14._value._obj.丐丏七丌丕丗业且上())) == true)
        {
            goto label_20;
        }
        
        this.不业丗丁丑丈丅一万.set_Item(key:  val_14._value._obj.丐丏七丌丕丗业且上(), value:  val_14._value._obj);
        goto label_20;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        goto label_43;
        label_24:
        if(((-946429184) & 1) == 0)
        {
            goto label_22;
        }
        
        ConfiguredValueTaskAwaiter val_19 = val_8.GetAwaiter();
        bool val_21 = this.丙丙业丆七丏一万丏.Remove(key:  val_19._value._obj.丐丏七丌丕丗业且上());
        goto label_24;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        goto label_35;
        label_22:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        val_43 = this.上上丕三且丞丅丆丝;
        val_44 = 5;
        goto label_70;
        label_35:
        val_43 = this.丙丝丆丐上丒丈丘且;
        val_44 = 4;
        goto label_70;
        label_43:
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>>(source:  this.不业丗丁丑丈丅一万)) == false)
        {
            goto label_44;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_23 = this.不业丗丁丑丈丅一万.GetEnumerator();
        label_48:
        if(((-946429184) & 1) == 0)
        {
            goto label_46;
        }
        
        ConfiguredValueTaskAwaiter val_24 = val_8.GetAwaiter();
        string val_25 = val_24._value._obj.丐丏七丌丕丗业且上();
        string val_26 = this.专丘丐丞与丗业七丐.Key;
        goto label_48;
        label_44:
        val_43 = this.上上丕三且丞丅丆丝;
        val_44 = 1;
        goto label_70;
        label_46:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        UnityEngine.WWWForm val_27 = new UnityEngine.WWWForm();
        val_45 = null;
        val_45 = null;
        val_47 = ConnectionAnalyticsSender.<>c.<>9__20_0;
        val_42 = "params";
        if(val_47 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>> val_29 = null;
            val_47 = val_29;
            val_29 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  ConnectionAnalyticsSender.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> ConnectionAnalyticsSender.<>c::专业世丑世丏七丞丅(System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.Dictionary<string, object>> 三丟东丕丄丄下下丑));
            ConnectionAnalyticsSender.<>c.<>9__20_0 = val_47;
            val_42 = val_42;
        }
        
        val_48 = public static System.Collections.Generic.IEnumerable<TResult> System.Linq.Enumerable::Select<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TResult> selector);
        val_41 = System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.不业丗丁丑丈丅一万, selector:  val_29);
        var val_39 = 0;
        val_39 = val_39 + 1;
        val_48 = 0;
        val_39 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_41);
        val_27.AddField(fieldName:  val_42, value:  val_39);
        UnityEngine.WWW val_33 = Rilisoft.与丄丁丄丙丞下下丙.三专世丝丝丈丂东与(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与, 丛丁且丏丁丄上上丄:  val_27, 丐丆丐七一上专三丑:  "", 一丞不一不一与世丙:  0);
        this.一丆丂丄下丑丄东丈 = val_33;
        if(val_33 == null)
        {
            goto label_69;
        }
        
        val_44 = 3;
        goto label_70;
        label_69:
        Dictionary.Enumerator<TKey, TValue> val_34 = this.不业丗丁丑丈丅一万.GetEnumerator();
        label_74:
        if(((-946429184) & 1) == 0)
        {
            goto label_72;
        }
        
        ConfiguredValueTaskAwaiter val_35 = val_8.GetAwaiter();
        bool val_37 = this.专丘丐丞与丗业七丐.Remove(key:  val_35._value._obj.丐丏七丌丕丗业且上());
        goto label_74;
        label_72:
        val_50 = -946429360;
        val_39 = 0;
        val_51 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if( == 1)
        {
            goto label_79;
        }
        
        if(( == 0) || ( == 490))
        {
            goto label_83;
        }
        
        label_82:
        label_83:
        val_43 = this.丙丝丆丐上丒丈丘且;
        val_44 = 2;
        label_70:
        this.丒上七丌业七丟与丐 = val_43;
        val_38 = 1;
        this.丗丏丅丕丆世丁专丟 = val_44;
        return (bool)val_38;
        label_79:
        if( != 0)
        {
            goto label_82;
        }
        
        goto label_83;
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
