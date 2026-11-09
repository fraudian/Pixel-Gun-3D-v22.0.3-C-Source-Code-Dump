using UnityEngine;
private sealed class ShopShootingController.万丁丗与丄世丕丝丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ShopShootingController 丝且与丝丒丟万丁专;
    public int 丂下丁上丌丕丒丙丄;
    public int 丈丗一世丈丁专与丟;
    public float 一丐丞丝下丙三丟丄;
    private UnityEngine.WaitForSeconds 丞三丑丏丕三业丘万;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopShootingController.万丁丗与丄世丕丝丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        int val_3;
        UnityEngine.WaitForSeconds val_4;
        int val_5;
        val_2 = this.丗丏丅丕丆世丁专丟;
        if(val_2 == 1)
        {
            goto label_1;
        }
        
        if(val_2 != 0)
        {
            goto label_2;
        }
        
        this.丈丌丝且业丏丈丂丁 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        mem[1152921539173828184] = 0;
        goto label_3;
        label_1:
        val_3 = this.丈丌丝且业丏丈丂丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_9;
        label_12:
        this.丝且与丝丒丟万丁专.下丛丗丑不不与丒与[this.丂下丁上丌丕丒丙丄].StartGunFlash();
        int val_3 = this.丈丗一世丈丁专与丟;
        val_3 = this.丈丌丝且业丏丈丂丁;
        val_3 = val_3 - 1;
        if(val_3 < val_3)
        {
                val_4 = this.丞三丑丏丕三业丘万;
            if(val_4 == null)
        {
                UnityEngine.WaitForSeconds val_1 = null;
            val_4 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  this.一丐丞丝下丙三丟丄);
            this.丞三丑丏丕三业丘万 = val_4;
        }
        
            val_5 = 1;
            this.丒上七丌业七丟与丐 = val_4;
            this.丗丏丅丕丆世丁专丟 = val_5;
            return (bool)val_5;
        }
        
        label_9:
        val_2 = val_3 + 1;
        this.丈丌丝且业丏丈丂丁 = val_2;
        label_3:
        if(val_2 < this.丈丗一世丈丁专与丟)
        {
            goto label_12;
        }
        
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
