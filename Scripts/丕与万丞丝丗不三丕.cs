using UnityEngine;
private sealed class 三一丈七且丄与丝东.丕与万丞丝丗不三丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丒丘三丁丄丘丅丂三;
    public Rilisoft.三一丈七且丄与丝东 丝且与丝丒丟万丁专;
    private Rilisoft.三一丈七且丄与丝东.与丈下丒三丏丒丆丏 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 三一丈七且丄与丝东.丕与万丞丝丗不三丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        三一丈七且丄与丝东.与丈下丒三丏丒丆丏 val_12;
        var val_13;
        string val_14;
        int val_15;
        var val_16;
        System.Collections.Generic.List<Rilisoft.GameEventData> val_17;
        System.Collections.Generic.List<Rilisoft.GameEventData> val_18;
        var val_19;
        var val_20;
        val_11 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new 三一丈七且丄与丝东.与丈下丒三丏丒丆丏();
        .丒丘三丁丄丘丅丂三 = this.丒丘三丁丄丘丅丂三;
        val_12 = this.丄丌丂东丘丗一万且;
        this.丄丌丂东丘丗一万且.丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        if(this.丝且与丝丒丟万丁专.且丞丄丂丏丝三丙丌() == false)
        {
            goto label_6;
        }
        
        System.Action<System.Boolean> val_3 = null;
        val_11 = val_3;
        val_3 = new System.Action<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Void 三一丈七且丄与丝东.与丈下丒三丏丒丆丏::上专东丌万一丗丘一(bool 丐万丗丒下七丟丁三));
        Rilisoft.GameEventDropChanceData val_5 = 0;
        System.Collections.Generic.List<Rilisoft.GameEventData> val_4 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        val_13 = this.丝且与丝丒丟万丁专;
        val_14 = this.丝且与丝丒丟万丁专.丄丝不业丄三且丙不;
        goto label_8;
        label_6:
        val_15 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        goto label_11;
        label_7:
        val_13 = 48;
        val_14 = 0;
        label_8:
        val_12 = this.丝且与丝丒丟万丁专.丐丕世丄业丝丑丌一(丒丐七丞丝丏丕丑且:  val_14, 丑丞丘丛丂丗不万东: out  val_4, 丐丐万丕丛丑丗丏丁: out  val_5);
        mem[48] = 0;
        if(val_12 == false)
        {
            goto label_13;
        }
        
        if((System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventData>(source:  val_4)) == null)
        {
            goto label_14;
        }
        
        val_16 = null;
        val_16 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  Rilisoft.三一丈七且丄与丝东.丞东三丄专丏丌业丂.Keys, value:  val_7.EventId)) == false)
        {
            goto label_18;
        }
        
        label_14:
        val_17 = val_4;
        if(val_17 == 0)
        {
            goto label_19;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_20;
        }
        
        this.丝且与丝丒丟万丁专.不且一七丄丞丒丈一(丄丞丏东七丂世丛丈:  val_17);
        val_18 = val_4;
        goto label_21;
        label_18:
        object[] val_10 = new object[1];
        val_12 = val_7.EventId;
        val_10[0] = val_12;
        UnityEngine.Debug.LogErrorFormat(format:  "Apply game events impossible: Unknown event with id \'{0}\'", args:  val_10);
        label_13:
        val_19 = 1152921516635255488;
        val_20 = 0;
        goto label_29;
        label_20:
        0.不且一七丄丞丒丈一(丄丞丏东七丂世丛丈:  val_17);
        val_18 = val_4;
        label_21:
        this.丝且与丝丒丟万丁专.丄世七与业丆万丛不(丄丞丏东七丂世丛丈:  val_18);
        val_17 = val_4;
        label_19:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.东丐丛丟丆丂丅丆丙 = val_17;
            this.丝且与丝丒丟万丁专.丁丑三丁丒丞一丈丒(丙业与丙丗丝不丈东:  val_5);
            val_12 = this.丝且与丝丒丟万丁专.东丐丛丟丆丂丅丆丙;
        }
        else
        {
                mem[32] = val_17;
            0.丁丑三丁丒丞一丈丒(丙业与丙丗丝不丈东:  val_5);
            val_12 = mem[32];
        }
        
        this.丝且与丝丒丟万丁专.且七丙东东丘丛丄丆(丝七丐丁丌丄丂丂东:  val_12);
        val_19 = 1152921516635255488;
        val_20 = 1;
        label_29:
        val_3.Invoke(obj:  true);
        label_2:
        val_15 = 0;
        return (bool)val_15;
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
