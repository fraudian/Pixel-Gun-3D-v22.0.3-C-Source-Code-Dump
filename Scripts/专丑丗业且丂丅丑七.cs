using UnityEngine;
private sealed class SkinName.专丑丗业且丂丅丑七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SkinName 丝且与丝丒丟万丁专;
    public bool 七丅丅世丆丆丗丟丐;
    private 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkinName.专丑丗业且丂丅丑七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_12;
        var val_13;
        int val_14;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = 1152921505171808256;
        val_13 = null;
        val_13 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        label_36:
        this.丝且与丝丒丟万丁专.丁丈丌丏万七七丟丁 = 0;
        goto label_7;
        label_1:
        val_12 = this.丅丒丑丄丞丑下丈丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_12 != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        if(val_12.下丑万三且丟丒丌丕() == false)
        {
            goto label_9;
        }
        
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_12 = val_12;
        UnityEngine.Object val_2 = val_12.丂丑且与丐七丟丝下();
        if(val_2 == null)
        {
            goto label_11;
        }
        
        val_12 = (null == null) ? (val_2) : 0;
        goto label_12;
        label_9:
        val_14 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_5:
        东丕与不丟丈与丄丟 val_4 = 丌丆丒七丑丞东三丛.丐下下丅与上东丙丑(丛丄业丕且丗下一万:  "Masks/"("Masks/") + this.丝且与丝丒丟万丁专.与丁丝七丕业业丄且, 不丌丞专丈丙丛东丏:  false);
        this.丅丒丑丄丞丑下丈丕 = val_4;
        if(val_4 != null)
        {
            goto label_17;
        }
        
        goto label_18;
        label_11:
        val_12 = 0;
        label_12:
        if(val_12 != 0)
        {
                val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_12);
            UnityEngine.Transform val_7 = val_12.transform;
            val_7.parent = this.丝且与丝丒丟万丁专.maskPoint.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_7.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            val_7.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            val_7.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            this.丝且与丝丒丟万丁专.maskWear = val_12;
            if(this.七丅丅世丆丆丗丟丐 != false)
        {
                Rilisoft.与丄丁丄丙丞下下丙.丏丏丄七且丛丟丁丗(丅万专世丈丕丑丗丘:  val_7, 丈七与世丏丕业世丙:  false);
        }
        
        }
        
        this.丅丒丑丄丞丑下丈丕 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_36;
        }
        
        label_6:
        mem[656] = 0;
        label_7:
        this.丝且与丝丒丟万丁专.丙上丐丟丆丆丏万三();
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
