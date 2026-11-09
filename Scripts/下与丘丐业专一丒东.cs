using UnityEngine;
private sealed class ComicsCampaign.下与丘丐业专一丒东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ComicsCampaign 丝且与丝丒丟万丁专;
    public System.Action 丞丂丛七与丟丈专丙;
    private int 丑丌世世丂丑丘丝丆;
    private System.Collections.Generic.List<UnityEngine.UI.RawImage> 与丑东丄且丝丕三丒;
    private UnityEngine.WaitForSecondsRealtime 与三与丑丟专丕丒丟;
    private int 丐丐丝丈丛与世与丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ComicsCampaign.下与丘丐业专一丒东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        int val_26;
        int val_27;
        float val_28;
        int val_29;
        int val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        if((this.丗丏丅丕丆世丁专丟 - 2) < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_58;
        }
        
        this.丑丌世世丂丑丘丝丆 = 0;
        val_26 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_55;
        }
        
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.与丑东丄且丝丕三丒 = 0;
        this.与三与丑丟专丕丒丟 = 0;
        goto label_42;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = this.丐丐丝丈丛与世与丄 + 1;
        this.丐丐丝丈丛与世与丄 = val_27;
        if(val_27 != 30)
        {
            goto label_7;
        }
        
        List.Enumerator<T> val_2 = this.与丑东丄且丝丕三丒.GetEnumerator();
        val_28 = 1f;
        label_11:
        if(((-2004384848) & 1) == 0)
        {
            goto label_9;
        }
        
        val_4 = 0;
        if(val_4.丐丏七丌丕丗业且上() != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_26 = 1152921536962099552;
        if(this.与丑东丄且丝丕三丒.Count != 0)
        {
                if(this.与丑东丄且丝丕三丒.Count != 1)
        {
            goto label_19;
        }
        
        }
        
        val_29 = 2;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  4f);
        goto label_20;
        label_19:
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  6f);
        val_29 = 3;
        label_20:
        this.丗丏丅丕丆世丁专丟 = val_29;
        val_30 = 1;
        return (bool)val_30;
        label_57:
        System.Collections.Generic.List<UnityEngine.UI.RawImage> val_10 = new System.Collections.Generic.List<UnityEngine.UI.RawImage>();
        this.与丑东丄且丝丕三丒 = val_10;
        var val_11 = 1152921536962089312 + ((X24) << 3);
        val_10.Add(item:  (1152921536962089312 + (X24) << 3) + 32);
        val_31 = null;
        val_31 = null;
        val_32 = null;
        val_32 = null;
        if((丛丑且业丗世丈丙丌.下一一且丗丐丕下丟.ContainsKey(key:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) != false)
        {
                val_33 = null;
            val_33 = null;
            val_34 = null;
            val_34 = null;
            if((丛丑且业丗世丈丙丌.下一一且丗丐丕下丟.Item[丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万].Contains(item:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) != false)
        {
                mem2[0] = X24 + 1;
            string val_16 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 + (((long)(int)((X24 + 1))) << 3);
            this.与丑东丄且丝丕三丒.Add(item:  (丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万 + ((long)(int)((X24 + 1))) << 3) + 32);
        }
        
        }
        
        if(this.与丑东丄且丝丕三丒 == null)
        {
            goto label_42;
        }
        
        if(this.与丑东丄且丝丕三丒 != 0)
        {
                System.Collections.Generic.List<UnityEngine.UI.RawImage> val_18 = this.与丑东丄且丝丕三丒 + ((X24) << 3);
        }
        
        val_27 = 0;
        this.与三与丑丟专丕丒丟 = new UnityEngine.WaitForSecondsRealtime(time:  0.03333334f);
        this.丐丐丝丈丛与世与丄 = 0;
        label_7:
        val_28 = UnityEngine.Mathf.InverseLerp(a:  0f, b:  30f, value:  0f);
        List.Enumerator<T> val_21 = this.与丑东丄且丝丕三丒.GetEnumerator();
        val_26 = 1152921536962088288;
        label_54:
        if(((-2004384848) & 1) == 0)
        {
            goto label_52;
        }
        
        val_4 = 0;
        if(val_4.丐丏七丌丕丗业且上() != null)
        {
            goto label_54;
        }
        
        goto label_54;
        label_42:
        val_26 = this.丑丌世世丂丑丘丝丆 + 1;
        mem2[0] = val_26;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_55;
        }
        
        label_5:
        label_55:
        if(val_26 != this.丝且与丝丒丟万丁专.comicFrames.Length)
        {
            goto label_57;
        }
        
        if(this.丞丂丛七与丟丈专丙 != null)
        {
                this.丝且与丝丒丟万丁专.业东丞丑丟丞丏丐丙(丞丂丛七与丟丈专丙:  this.丞丂丛七与丟丈专丙);
        }
        
        label_58:
        val_30 = 0;
        return (bool)val_30;
        label_52:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_30 = 1;
        this.丗丏丅丕丆世丁专丟 = val_30;
        this.丒上七丌业七丟与丐 = this.与三与丑丟专丕丒丟;
        return (bool)val_30;
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
