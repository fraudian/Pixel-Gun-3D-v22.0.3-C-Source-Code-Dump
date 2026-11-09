using UnityEngine;
private sealed class TurretControllerScene_BoomerangRocketLauncher.丆万丁丗上丟丘东万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretControllerScene_BoomerangRocketLauncher 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretControllerScene_BoomerangRocketLauncher.丆万丁丗上丟丘东万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        this.丝且与丝丒丟万丁专.丕丝丕丛丗专丄丅丏 = true;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丞专一丙丁丒万三丏();
        goto label_6;
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_3:
        mem[704] = 1;
        label_4:
        UnityEngine.WaitForSeconds val_2 = null;
        float val_3 = 0.8f;
        val_3 = this.丝且与丝丒丟万丁专.丟一丞丗业三丁上东() * val_3;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  val_3);
        val_3 = 1;
        this.丒上七丌业七丟与丐 = val_2;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_5:
        0.丞专一丙丁丒万三丏();
        label_6:
        val_3 = 0;
        this.丝且与丝丒丟万丁专.丕丝丕丛丗专丄丅丏 = false;
        return (bool)val_3;
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
