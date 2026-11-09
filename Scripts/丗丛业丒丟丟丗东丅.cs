using UnityEngine;
private sealed class 且东下世丑业丞丂东.丗丛业丒丟丟丗东丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.WWW 丏丐丝世丄丈丝丌丌;
    public UnityEngine.WWWForm 丛丁且丏丁丄上上丄;
    public string 七丙不丅丛丘丗万与;
    public string 丐丆丐七一上专三丑;
    public bool 丝丌丝不丟丞丑丑丗;
    private float 丅丁丕丏上丐东丕丆;
    private bool 一专丞丈丅专丈丛丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 且东下世丑业丞丂东.丗丛业丒丟丟丗东丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_17;
        string val_18;
        bool val_19;
        int val_20;
        var val_21;
        string val_22;
        object val_23;
        var val_24;
        var val_25;
        var val_27;
        val_17 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_48;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丏丐丝世丄丈丝丌丌 == null)
        {
            goto label_3;
        }
        
        val_18 = this.丐丆丐七一上专三丑;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "<color=cyan>Send http: </color><color=yellow>{0}</color>. <color=cyan>Body:</color>\n{1}\n", arg0:  Rilisoft.且东下世丑业丞丂东.丛丐丛丕丏与丒且丆(丛丁且丏丁丄上上丄:  this.丛丁且丏丁丄上上丄, 七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与, 丐丆丐七一上专三丑:  val_18), arg1:  Rilisoft.且东下世丑业丞丂东.丁丏七丆一一丐丅丘(丛丁且丏丁丄上上丄:  this.丛丁且丏丁丄上上丄)));
        val_19 = 1;
        this.丅丁丕丏上丐东丕丆 = UnityEngine.Time.time;
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丏丐丝世丄丈丝丌丌 != null)
        {
                if(this.丏丐丝世丄丈丝丌丌.isDone == false)
        {
            goto label_10;
        }
        
        }
        
        val_19 = false;
        label_8:
        this.一专丞丈丅专丈丛丗 = val_19;
        if(val_19 == 0)
        {
            goto label_11;
        }
        
        label_22:
        val_20 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
        label_3:
        object[] val_6 = new object[1];
        val_18 = this.七丙不丅丛丘丗万与;
        val_17 = val_6;
        val_17[0] = Rilisoft.且东下世丑业丞丂东.丛丐丛丕丏与丒且丆(丛丁且丏丁丄上上丄:  this.丛丁且丏丁丄上上丄, 七丙不丅丛丘丗万与:  val_18, 丐丆丐七一上专三丑:  this.丐丆丐七一上专三丑);
        UnityEngine.Debug.LogFormat(format:  "<color=orange>Skipping {0}</color>", args:  val_6);
        goto label_48;
        label_10:
        if(this.一专丞丈丅专丈丛丗 == true)
        {
            goto label_22;
        }
        
        label_11:
        float val_8 = UnityEngine.Time.time;
        val_8 = val_8 - this.丅丁丕丏上丐东丕丆;
        this.丅丁丕丏上丐东丕丆 = val_8;
        val_21 = null;
        val_22 = "Response text: ";
        val_21 = null;
        if(Rilisoft.且东下世丑业丞丂东.丁丒东丞一丅丈丑东 == false)
        {
            goto label_25;
        }
        
        if(this.丏丐丝世丄丈丝丌丌 == null)
        {
            goto label_26;
        }
        
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.丏丐丝世丄丈丝丌丌.error)) == false)
        {
            goto label_29;
        }
        
        val_23 = this.丏丐丝世丄丈丝丌丌.error;
        val_24 = 1;
        val_22 = "Error text: ";
        goto label_31;
        label_25:
        val_25 = "[response logging is disabled]";
        goto label_54;
        label_26:
        val_25 = "[www is NULL]";
        goto label_54;
        label_29:
        val_23 = 丄丛丏丄不一丆丐丑.上七丐丞丆且丈丒丘(东丞丒丙世丏三下丟:  this.丏丐丝世丄丈丝丌丌);
        label_54:
        val_24 = 0;
        label_31:
        val_18 = "<color=cyan>Response at http: </color><color=yellow>{0}</color>. <color=cyan>Time: {1}</color>. <color=cyan>"("<color=cyan>Response at http: </color><color=yellow>{0}</color>. <color=cyan>Time: {1}</color>. <color=cyan>") + val_22 + "</color>\n{2}"("</color>\n{2}");
        string val_16 = System.String.Format(format:  val_18, arg0:  Rilisoft.且东下世丑业丞丂东.丛丐丛丕丏与丒且丆(丛丁且丏丁丄上上丄:  this.丛丁且丏丁丄上上丄, 七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与, 丐丆丐七一上专三丑:  this.丐丆丐七一上专三丑), arg1:  this.丅丁丕丏上丐东丕丆.ToString(format:  "F2"), arg2:  val_23);
        if(this.丅丁丕丏上丐东丕丆 > Rilisoft.且东下世丑业丞丂东.东丏丗丅丄丑下与专)
        {
            
        }
        else
        {
                val_27 = 0;
        }
        
        val_27 = val_27 & this.丝丌丝不丟丞丑丑丗;
        if(val_27 != true)
        {
                if(val_24 == 0)
        {
            goto label_43;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  val_16);
        label_48:
        val_20 = 0;
        return (bool)val_20;
        label_43:
        UnityEngine.Debug.Log(message:  val_16);
        goto label_48;
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
