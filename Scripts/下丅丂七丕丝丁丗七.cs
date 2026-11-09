using UnityEngine;
private sealed class 且东下世丑业丞丂东.下丅丂七丕丝丁丗七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.WWW 丏丐丝世丄丈丝丌丌;
    public string 七丙不丅丛丘丗万与;
    public bool 丝丌丝不丟丞丑丑丗;
    private float 丅丁丕丏上丐东丕丆;
    private bool 一专丞丈丅专丈丛丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 且东下世丑业丞丂东.下丅丂七丕丝丁丗七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_16;
        bool val_17;
        int val_18;
        var val_19;
        object val_20;
        object val_21;
        var val_22;
        var val_23;
        var val_25;
        val_16 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_61;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丏丐丝世丄丈丝丌丌 == null)
        {
            goto label_3;
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "<color=cyan>Send http: </color><color=yellow>{0}</color>. ", arg0:  Rilisoft.且东下世丑业丞丂东.与丞东丐东丑业东与(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与)));
        val_17 = 1;
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
        
        val_17 = false;
        label_8:
        this.一专丞丈丅专丈丛丗 = val_17;
        if(val_17 == 0)
        {
            goto label_11;
        }
        
        label_22:
        val_18 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_3:
        object[] val_5 = new object[1];
        val_16 = val_5;
        val_16[0] = Rilisoft.且东下世丑业丞丂东.与丞东丐东丑业东与(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与);
        UnityEngine.Debug.LogFormat(format:  "<color=orange>Skipping {0}</color>", args:  val_5);
        goto label_61;
        label_10:
        if(this.一专丞丈丅专丈丛丗 == true)
        {
            goto label_22;
        }
        
        label_11:
        float val_7 = UnityEngine.Time.time;
        val_7 = val_7 - this.丅丁丕丏上丐东丕丆;
        this.丅丁丕丏上丐东丕丆 = val_7;
        val_19 = null;
        val_20 = "Response text: ";
        val_19 = null;
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
        
        val_21 = this.丏丐丝世丄丈丝丌丌.error;
        val_22 = 1;
        val_20 = "Error text: ";
        goto label_31;
        label_25:
        val_23 = "[response logging is disabled]";
        goto label_67;
        label_26:
        val_23 = "[www is NULL]";
        goto label_67;
        label_29:
        val_21 = 丄丛丏丄不一丆丐丑.上七丐丞丆且丈丒丘(东丞丒丙世丏三下丟:  this.丏丐丝世丄丈丝丌丌);
        label_67:
        val_22 = 0;
        label_31:
        object[] val_12 = new object[4];
        val_12[0] = Rilisoft.且东下世丑业丞丂东.与丞东丐东丑业东与(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与);
        val_12[1] = this.丅丁丕丏上丐东丕丆.ToString(format:  "F2");
        val_12[2] = val_21;
        val_12[3] = val_20;
        string val_15 = System.String.Format(format:  "<color=cyan>Response at http: </color><color=yellow>{0}</color>. <color=cyan>Time: {1}</color>. <color=cyan>{3}</color>\n{2}", args:  val_12);
        if(this.丅丁丕丏上丐东丕丆 > Rilisoft.且东下世丑业丞丂东.东丏丗丅丄丑下与专)
        {
            
        }
        else
        {
                val_25 = 0;
        }
        
        val_25 = val_25 & this.丝丌丝不丟丞丑丑丗;
        if(val_25 != true)
        {
                if(val_22 == 0)
        {
            goto label_56;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  val_15);
        label_61:
        val_18 = 0;
        return (bool)val_18;
        label_56:
        UnityEngine.Debug.Log(message:  val_15);
        goto label_61;
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
