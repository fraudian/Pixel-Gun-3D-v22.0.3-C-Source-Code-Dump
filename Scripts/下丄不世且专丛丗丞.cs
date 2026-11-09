using UnityEngine;
private sealed class LevelArt.下丄不世且专丛丗丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LevelArt 丝且与丝丒丟万丁专;
    private UnityEngine.Texture 丒丝丆丒丑丛丗下不;
    private float 专一丄与三丈丕下丝;
    private float 丒上丐丂丛丛七一七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelArt.下丄不世且专丛丗丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_21;
        var val_22;
        int val_23;
        float val_24;
        int val_25;
        float val_26;
        float val_27;
        var val_28;
        var val_29;
        var val_30;
        string val_32;
        var val_33;
        var val_34;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        val_21 = this;
        this.丒丝丆丒丑丛丗下不 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_4;
        }
        
        val_22 = 52;
        mem[52] = 3670081;
        val_23 = mem[52];
        val_24 = 1;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_25 = 0;
        this.丝且与丝丒丟万丁专.三上丞丛世丈专万丕 = true;
        return (bool)val_25;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_1 = UnityEngine.Time.time;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_24 = this.丝且与丝丒丟万丁专;
            val_26 = this.丝且与丝丒丟万丁专._delayShowComics;
        }
        else
        {
                val_24 = 2.479598E-39f;
            val_26 = 2.479598E-39f;
        }
        
        val_1 = val_1 - this.专一丄与三丈丕下丝;
        val_1 = val_1 / val_26;
        val_1 = this.丝且与丝丒丟万丁专.丒丝丙丈丒丆七七专 + val_1;
        this.丝且与丝丒丟万丁专.丒丝丙丈丒丆七七专 = val_1;
        this.专一丄与三丈丕下丝 = UnityEngine.Time.time;
        val_27 = UnityEngine.Time.time;
        if((val_27 - this.丒上丐丂丛丛七一七) < 0)
        {
                if(this.丝且与丝丒丟万丁专.不与丗丟丄东专丈下 == false)
        {
            goto label_14;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.不与丗丟丄东专丈下 = false;
        }
        else
        {
                mem[64] = 0;
        }
        
        val_21 = this;
        this.丝且与丝丒丟万丁专.丒丝丙丈丒丆七七专 = 1f;
        bool val_5 = UnityEngine.Object.op_Inequality(x:  this.丒丝丆丒丑丛丗下不, y:  0);
        if(val_5 == false)
        {
            goto label_20;
        }
        
        int val_20 = this.丝且与丝丒丟万丁专.万七丟丟丅丞业下丗;
        val_20 = val_20 & 3;
        if(val_20 == 0)
        {
            goto label_20;
        }
        
        this.丒丝丆丒丑丛丗下不 = 0;
        label_4:
        val_22 = this.丝且与丝丒丟万丁专;
        val_24 = 0;
        val_23 = this.丝且与丝丒丟万丁专.万七丟丟丅丞业下丗 + 1;
        mem2[0] = val_23;
        label_5:
        UnityEngine.Texture val_7 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_5.丁丒丂丅与专丌丑丕(丙丐一丕丗万丁下一:  val_23));
        this.丒丝丆丒丑丛丗下不 = val_7;
        if(val_7 == 0)
        {
            goto label_24;
        }
        
        if(this.丝且与丝丒丟万丁专.丈下下丒东丏一丘七.Count == 4)
        {
                this.丝且与丝丒丟万丁专.丈下下丒东丏一丘七.Clear();
        }
        
        this.丝且与丝丒丟万丁专.丈下下丒东丏一丘七.Add(item:  this.丒丝丆丒丑丛丗下不);
        val_28 = null;
        val_28 = null;
        val_29 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 == false)
        {
            goto label_31;
        }
        
        val_30 = null;
        val_32 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        var val_10 = (this.丝且与丝丒丟万丁专 + 52) - 1;
        val_33 = null;
        goto label_34;
        label_24:
        0.丙专丒与丌不丁丙丝();
        label_3:
        val_25 = 0;
        return (bool)val_25;
        label_20:
        val_27 = 2.479598E-39f;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_27);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_25 = 1;
        return (bool)val_25;
        label_31:
        val_34 = null;
        val_32 = 丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万;
        val_33 = null;
        label_34:
        string val_13 = System.String.Format(format:  "{0}_{1}", arg0:  val_32, arg1:  (this.丝且与丝丒丟万丁专 + 52) - 1);
        val_21 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_13);
        if(val_21 == null)
        {
                val_21 = System.String.alignConst;
        }
        
        this.丝且与丝丒丟万丁专.丅丌东一上万业且丒 = val_21;
        if((val_13.Equals(value:  val_21)) != false)
        {
                this.丝且与丝丒丟万丁专.丅丌东一上万业且丒 = System.String.alignConst;
        }
        
        UnityEngine.AsyncOperation val_16 = UnityEngine.Resources.UnloadUnusedAssets();
        this.丝且与丝丒丟万丁专.丒丝丙丈丒丆七七专 = 0f;
        this.专一丄与三丈丕下丝 = UnityEngine.Time.time;
        this.丒上丐丂丛丛七一七 = UnityEngine.Time.time;
        label_14:
        val_25 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
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
