using UnityEngine;
private sealed class ShopShootingController.丆东丘一丂丑丂一丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ShopShootingController 丝且与丝丒丟万丁专;
    public int 丂下丁上丌丕丒丙丄;
    public float 丕丕世且下一与丝与;
    public float 丝丗业丘丏与上东丆;
    public float 业丒三且三万丐丟上;
    public int 丈丗一世丈丁专与丟;
    public float 一丐丞丝下丙三丟丄;
    private UnityEngine.WaitForSeconds 丑丑丂丈丗丞丑丘世;
    private UnityEngine.WaitForSeconds 丐丁丄上丛专丙丞下;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopShootingController.丆东丘一丂丑丂一丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        FlashFire val_13;
        float val_14;
        UnityEngine.WaitForSeconds val_15;
        int val_16;
        UnityEngine.WaitForSeconds val_17;
        val_9 = this.丗丏丅丕丆世丁专丟;
        if(val_9 == 2)
        {
            goto label_1;
        }
        
        if(val_9 == 1)
        {
            goto label_2;
        }
        
        if(val_9 != 0)
        {
            goto label_3;
        }
        
        this.丟丗丒丟丝丘丞丝丏 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        mem[1152921539172921696] = 0;
        mem[1152921539172921704] = 0;
        goto label_4;
        label_1:
        val_10 = this;
        val_11 = this.丟丗丒丟丝丘丞丝丏;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_27;
        label_2:
        val_12 = this.丂下丁上丌丕丒丙丄;
        val_10 = this.丟丗丒丟丝丘丞丝丏;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_16;
        label_30:
        val_12 = this;
        val_13 = this.丝且与丝丒丟万丁专.下丛丗丑不不与丒与[this.丂下丁上丌丕丒丙丄];
        if(val_13 != 0)
        {
                val_13 = this.丝且与丝丒丟万丁专.下丛丗丑不不与丒与[this.丂下丁上丌丕丒丙丄];
            val_13.StartGunFlash();
        }
        
        val_14 = this.丕丕世且下一与丝与;
        if(val_14 > 0f)
        {
                val_15 = this.丑丑丂丈丗丞丑丘世;
            if(val_15 == null)
        {
                UnityEngine.WaitForSeconds val_2 = null;
            val_15 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  val_14);
            this.丑丑丂丈丗丞丑丘世 = val_15;
        }
        
            val_16 = 1;
            this.丒上七丌业七丟与丐 = val_15;
            this.丗丏丅丕丆世丁专丟 = val_16;
            return (bool)val_16;
        }
        
        label_16:
        val_14 = this.丝丗业丘丏与上东丆;
        float val_8 = (float)val_10;
        val_8 = this.业丒三且三万丐丟上 * val_8;
        System.Collections.IEnumerator val_4 = this.丝且与丝丒丟万丁专.七下世丗且丗三业且(丂下丁上丌丕丒丙丄:  this.丂下丁上丌丕丒丙丄, 丝丗业丘丏与上东丆:  val_14, 业丒三且三万丐丟上:  val_8 - this.业丒三且三万丐丟上);
        if(this.丝且与丝丒丟万丁专 != null)
        {
                UnityEngine.Coroutine val_5 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_4);
        }
        else
        {
                UnityEngine.Coroutine val_6 = 0.StartCoroutine(routine:  val_4);
        }
        
        val_13 = this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七;
        if(this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.isDoubleShot != true)
        {
                val_13 = val_12 + 1;
            mem2[0] = val_13;
            if(val_13 >= this.丝且与丝丒丟万丁专.下丛丗丑不不与丒与.Length)
        {
                mem2[0] = 0;
        }
        
        }
        
        int val_9 = this.丈丗一世丈丁专与丟;
        val_11 = mem[this.丟丗丒丟丝丘丞丝丏];
        val_11 = val_10;
        val_9 = val_9 - 1;
        if(val_11 < val_9)
        {
                val_14 = this.一丐丞丝下丙三丟丄;
            if(val_14 > 0f)
        {
                val_17 = this.丐丁丄上丛专丙丞下;
            if(val_17 == null)
        {
                UnityEngine.WaitForSeconds val_7 = null;
            val_17 = val_7;
            val_7 = new UnityEngine.WaitForSeconds(seconds:  val_14);
            this.丐丁丄上丛专丙丞下 = val_17;
        }
        
            this.丒上七丌业七丟与丐 = val_17;
            this.丗丏丅丕丆世丁专丟 = 2;
            val_16 = 1;
            return (bool)val_16;
        }
        
        }
        
        label_27:
        val_9 = val_11 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_9;
        label_4:
        if(val_9 < this.丈丗一世丈丁专与丟)
        {
            goto label_30;
        }
        
        label_3:
        val_16 = 0;
        return (bool)val_16;
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
