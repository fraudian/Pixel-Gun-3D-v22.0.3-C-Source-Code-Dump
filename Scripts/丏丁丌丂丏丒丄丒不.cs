using UnityEngine;
private sealed class EditorListBuilder.丏丁丌丂丏丒丄丒不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public EditorListBuilder 丝且与丝丒丟万丁专;
    private UnityEngine.WWW 丏万丒不三三丟三且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EditorListBuilder.丏丁丌丂丏丒丄丒不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        EditorListBuilder val_32;
        UnityEngine.WWWForm val_33;
        var val_34;
        int val_35;
        string val_36;
        string val_39;
        val_32 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_19;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WWWForm val_1 = null;
        val_33 = val_1;
        val_1 = new UnityEngine.WWWForm();
        int val_2 = ProtocolListGetter.丅三专丐丗丅与丆丑();
        val_34 = null;
        val_34 = null;
        val_1.AddField(fieldName:  "app_version", value:  System.String.Format(format:  "{0}:{1}", arg0:  val_2, arg1:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒));
        val_32 = this.丝且与丝丒丟万丁专.applyWindow;
        UnityEngine.WWW val_5 = Rilisoft.与丄丁丄丙丞下下丙.三专世丝丝丈丂东与(七丙不丅丛丘丗万与:  val_32.GetPromoActionUrl(), 丛丁且丏丁丄上上丄:  val_1, 丐丆丐七一上专三丑:  "", 一丞不一不一与世丙:  0);
        this.丏万丒不三三丟三且 = val_5;
        if(val_5 == null)
        {
                return (bool)val_35;
        }
        
        this.丒上七丌业七丟与丐 = val_5;
        val_35 = 1;
        this.丗丏丅丕丆世丁专丟 = val_35;
        return (bool)val_35;
        label_1:
        val_33 = this.丏万丒不三三丟三且;
        this.丗丏丅丕丆世丁专丟 = 0;
        if((System.String.IsNullOrEmpty(value:  val_33.error)) != false)
        {
                object val_9 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丄丛丏丄不一丆丐丑.上七丐丞丆且丈丒丘(东丞丒丙世丏三下丟:  this.丏万丒不三三丟三且));
            UnityEngine.Debug.LogWarning(message:  "GetPromoActionsData promoActionsData = null");
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  "GetPromoActionsData error: "("GetPromoActionsData error: ") + this.丏万丒不三三丟三且.error);
            val_32.下丞下丘丄丅世一与();
        }
        
        label_19:
        val_35 = 0;
        return (bool)val_35;
        label_34:
        if(((-1818919008) & 1) == 0)
        {
            goto label_29;
        }
        
        val_36 = val_2.丐丏七丌丕丗业且上();
        if((val_36 != null) && (null != null))
        {
                val_36 = 0;
        }
        
        this.丝且与丝丒丟万丁专.丝丞与丙与丂上万业.Add(item:  val_36);
        goto label_34;
        label_29:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_9.ContainsKey(key:  "topSellers_up")) == false)
        {
            goto label_60;
        }
        
        object val_19 = val_9.Item["topSellers_up"];
        if(val_19 == null)
        {
            goto label_60;
        }
        
        List.Enumerator<T> val_20 = val_19.GetEnumerator();
        label_52:
        if(((-1818919008) & 1) == 0)
        {
            goto label_47;
        }
        
        val_39 = val_2.丐丏七丌丕丗业且上();
        if((val_39 != null) && (null != null))
        {
                val_39 = 0;
        }
        
        this.丝且与丝丒丟万丁专.丒且下上丗世丟丑丙.Add(item:  val_39);
        goto label_52;
        label_47:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_60:
        if((val_9.ContainsKey(key:  "discounts_up")) != false)
        {
                object val_23 = val_9.Item["discounts_up"];
        }
        
        if(val_32 != null)
        {
                val_32.丘丛丒丂且万丑丒三();
        }
        else
        {
                0.丘丛丒丂且万丑丒三();
        }
        
        this.丝且与丝丒丟万丁专.世丕丁丑丌下三专丙 = false;
        return (bool)val_35;
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
