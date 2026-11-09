using UnityEngine;
private sealed class 且丆丟一丒专且上不.丟丕丕丂三丐丆丏丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 且丆丟一丒专且上不 丝且与丝丒丟万丁专;
    private int 业丝丈丁丙丆业丌丗;
    private UnityEngine.WaitForSecondsRealtime 丐丁丄上丛专丙丞下;
    private System.Collections.Generic.List<丙且上东下丏丏丟下> 万丐三丝且万丆丈丑;
    private float 与丘丙丗三丈丛丒业;
    private int 不上一丝丗丘丄下丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 且丆丟一丒专且上不.丟丕丕丂三丐丆丏丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_14;
        System.Collections.Generic.List<丙且上东下丏丏丟下> val_15;
        int val_16;
        var val_17;
        var val_18;
        int val_19;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_29;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.业丝丈丁丙丆业丌丗 = 上丑三丁丄丛丁万丑.丂不丂丐丄丞丛丙丐();
        this.丐丁丄上丛专丙丞下 = new UnityEngine.WaitForSecondsRealtime(time:  0.33f);
        val_14 = null;
        val_14 = null;
        val_15 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且(), 丙丑丄与丅丐一不东:  true);
        this.万丐三丝且万丆丈丑 = val_15;
        int val_13 = this.业丝丈丁丙丆业丌丗;
        float val_14 = 1f;
        val_16 = 0;
        int val_5 = val_13 - 1;
        val_13 = val_5 - ((val_5 / val_13) * val_13);
        val_13 = val_13 + 1;
        val_14 = val_14 / (float)val_13;
        mem[1152921540008389648] = val_14;
        mem[1152921540008389652] = 0;
        if(val_15 != null)
        {
            goto label_26;
        }
        
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_10;
        label_27:
        int val_15 = this.不上一丝丗丘丄下丁;
        val_15 = val_15 - ((val_15 / this.业丝丈丁丙丆业丌丗) * this.业丝丈丁丙丆业丌丗);
        if(val_15 == 0)
        {
                val_17 = null;
            val_17 = null;
            int val_16 = this.不上一丝丗丘丄下丁;
            val_16 = val_16 / this.业丝丈丁丙丆业丌丗;
            float val_17 = (float)val_16;
            val_17 = this.与丘丙丗三丈丛丒业 * val_17;
            MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            Restrict();
        }
        
        val_18 = null;
        val_18 = null;
        丙且上东下丏丏丟下 val_8 = this.万丐三丝且万丆丈丑.SyncRoot.Item[this.不上一丝丗丘丄下丁];
        if(val_9.toggle.value == false)
        {
            goto label_25;
        }
        
        label_10:
        val_16 = this.不上一丝丗丘丄下丁 + 1;
        mem2[0] = val_16;
        val_15 = mem[this.万丐三丝且万丆丈丑];
        val_15 = this.万丐三丝且万丆丈丑.SyncRoot;
        if(val_15 != null)
        {
            goto label_26;
        }
        
        label_9:
        label_26:
        if(val_16 < val_15.Count)
        {
            goto label_27;
        }
        
        if((this.丝且与丝丒丟万丁专.<七丆世丁丄丌丏丏且>k__BackingField) == 1)
        {
                this.丝且与丝丒丟万丁专.<七丆世丁丄丌丏丏且>k__BackingField = 0;
            this.丝且与丝丒丟万丁专.丅丘丌丂且与丙丘且();
        }
        
        label_29:
        val_19 = 0;
        return (bool)val_19;
        label_25:
        val_19 = 1;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一世下丏世下丗丒专(丞一丁业丄一一业且:  val_8.丞一丁业丄一一业且).gameObject.SendMessage(methodName:  "OnClick", value:  0, options:  1);
        this.丗丏丅丕丆世丁专丟 = val_19;
        this.丒上七丌业七丟与丐 = this.丐丁丄上丛专丙丞下;
        return (bool)val_19;
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
