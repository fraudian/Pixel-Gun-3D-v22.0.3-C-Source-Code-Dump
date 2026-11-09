using UnityEngine;
private sealed class SkinName.七业丘丞与三东丈万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SkinName 丝且与丝丒丟万丁专;
    private 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkinName.七业丘丞与三东丈万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_16;
        var val_17;
        UnityEngine.Object val_18;
        int val_19;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = null;
        val_15 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_8;
        }
        
        }
        
        val_16 = 丌丆丒七丑丞东三丛.丐下下丅与上东丙丑(丛丄业丕且丗下一万:  ((丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  this.丝且与丝丒丟万丁专.丁丅上丟丑三且且丆)) != true) ? "RoyaleHatsVisual/" : "Hats/"(((丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  this.丝且与丝丒丟万丁专.丁丅上丟丑三且且丆)) != true) ? "RoyaleHatsVisual/" : "Hats/") + this.丝且与丝丒丟万丁专.丁丅上丟丑三且且丆, 不丌丞专丈丙丛东丏:  false);
        val_17 = this;
        this.丅丒丑丄丞丑下丈丕 = val_16;
        if(val_16 != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_1:
        val_17 = this;
        val_16 = this.丅丒丑丄丞丑下丈丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_16 != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        if(val_16.下丑万三且丟丒丌丕() == false)
        {
            goto label_17;
        }
        
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_15 = this.丅丒丑丄丞丑下丈丕;
        UnityEngine.Object val_7 = val_15.丂丑且与丐七丟丝下();
        if(val_7 == null)
        {
            goto label_19;
        }
        
        val_15 = (null == null) ? (val_7) : 0;
        goto label_20;
        label_17:
        val_19 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_19;
        return (bool)val_19;
        label_19:
        val_18 = 0;
        label_20:
        val_16 = 1152921504848912384;
        if(val_18 != 0)
        {
                UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_18);
            val_16 = val_9.transform;
            val_16.parent = this.丝且与丝丒丟万丁专.hatsPoint.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_16.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
            val_16.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            val_16.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            this.丝且与丝丒丟万丁专.hatWear = val_9;
            this.丝且与丝丒丟万丁专.丒丒丂丂丛丌丐丈专 = 0;
        }
        
        this.丝且与丝丒丟万丁专.丙上丐丟丆丆丏万三();
        label_2:
        val_19 = 0;
        return (bool)val_19;
        label_8:
        this.丝且与丝丒丟万丁专.丒丒丂丂丛丌丐丈专 = 0;
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
