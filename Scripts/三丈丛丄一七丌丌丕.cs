using UnityEngine;
private sealed class SpleefBlockItem.三丈丛丄一七丌丌丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SpleefBlockItem 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpleefBlockItem.三丈丛丄一七丌丌丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioSource val_11;
        UnityEngine.AudioClip val_12;
        UnityEngine.Material val_13;
        int val_14;
        val_11 = this;
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
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = 1152921504848912384;
        if(this.丝且与丝丒丟万丁专.丐丒丟下丛丛丒丒上 == 0)
        {
                val_13 = 0;
            if(this.丝且与丝丒丟万丁专.丑与丗丛丝丈丙丆丌 != 0)
        {
                val_13 = this.丝且与丝丒丟万丁专.丑与丗丛丝丈丙丆丌.material;
        }
        
            this.丝且与丝丒丟万丁专.丐丒丟下丛丛丒丒上 = val_13;
            val_13.SetColor(name:  "_ColorRili", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        }
        
        if(this.丝且与丝丒丟万丁专.不且万世专不丒丝专 == false)
        {
            goto label_13;
        }
        
        val_14 = 0;
        this.丝且与丝丒丟万丁专.丁丞丁丑且丝丛丆世 = true;
        return (bool)val_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_40;
        }
        
        goto label_40;
        label_13:
        this.丝且与丝丒丟万丁专.不且万世专不丒丝专 = true;
        label_33:
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (this.丝且与丝丒丟万丁专.丅丄业与东丂丝丒丑 != 0))
        {
                val_12 = 1152921505323831296;
            if(SpleefBlockItemsController.丄丘七三上丕世丞业.hitSound != 0)
        {
                this.丝且与丝丒丟万丁专.丅丄业与东丂丝丒丑.enabled = true;
            val_12 = mem[SpleefBlockItemsController.丄丘七三上丕世丞业 + 56];
            val_12 = SpleefBlockItemsController.丄丘七三上丕世丞业.hitSound;
            this.丝且与丝丒丟万丁专.丅丄业与东丂丝丒丑.PlayOneShot(clip:  val_12);
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丁丞丁丑且丝丛丆世 = false;
        if(this.丝且与丝丒丟万丁专.isKilled == false)
        {
            goto label_32;
        }
        
        label_40:
        if(this.丝且与丝丒丟万丁专.丁丞丁丑且丝丛丆世 == true)
        {
            goto label_33;
        }
        
        this.丝且与丝丒丟万丁专.不且万世专不丒丝专 = false;
        label_16:
        if(this.丝且与丝丒丟万丁专.丅丄业与东丂丝丒丑.isPlaying != false)
        {
                this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_14 = 1;
            return (bool)val_14;
        }
        
        val_11 = this.丝且与丝丒丟万丁专.丅丄业与东丂丝丒丑;
        val_11.enabled = false;
        label_3:
        val_14 = 0;
        return (bool)val_14;
        label_32:
        float val_11 = this.丝且与丝丒丟万丁专.live;
        val_11 = val_11 / this.丝且与丝丒丟万丁专.七丕七与丂专丘丟不;
        val_12 = this.丝且与丝丒丟万丁专.丅丄业与东丂丝丒丑.丁丒丅丏专万万三丂(丛东与丑丌丗东丕丗:  (val_11 >= 0) ? ((val_11 < 0) ? 1 : 0) : 2);
        this.丝且与丝丒丟万丁专.丑与丗丛丝丈丙丆丌.sharedMaterial = val_12;
        if(this.丝且与丝丒丟万丁专.丁丞丁丑且丝丛丆世 == false)
        {
            goto label_40;
        }
        
        val_14 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_14;
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
