using UnityEngine;
private sealed class FiringShotBot.丈七丁且丟丘丏丂丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.FiringShotBot 丝且与丝丒丟万丁专;
    public UnityEngine.ParticleSystem 丏不丂丆且三丞丆丏;
    public UnityEngine.Transform 丂丁丟世丗东丙丐丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FiringShotBot.丈七丁且丟丘丏丂丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丛业丗丏下丌丏丗丗 == false)
        {
            goto label_4;
        }
        
        label_2:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丏不丂丆且三丞丆丏.Stop();
        val_5 = 0;
        this.丝且与丝丒丟万丁专.丛业丗丏下丌丏丗丗 = false;
        return (bool)val_5;
        label_4:
        this.丝且与丝丒丟万丁专.丛业丗丏下丌丏丗丗 = true;
        UnityEngine.Transform val_1 = this.丏不丂丆且三丞丆丏.transform;
        UnityEngine.Vector3 val_2 = this.丂丁丟世丗东丙丐丐.position;
        val_1.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Quaternion val_3 = this.丂丁丟世丗东丙丐丐.rotation;
        val_1.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
        this.丏不丂丆且三丞丆丏.Play();
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.timeShowFireEffect);
        this.丗丏丅丕丆世丁专丟 = val_5;
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
