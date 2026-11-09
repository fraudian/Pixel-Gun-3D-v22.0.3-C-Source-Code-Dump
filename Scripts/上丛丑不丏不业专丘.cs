using UnityEngine;
private sealed class BaseDummy.上丛丑不丏不业专丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BaseDummy 丝且与丝丒丟万丁专;
    public bool 万东丏丌不七东丘万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseDummy.上丛丑不丏不业专丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Texture val_4;
        int val_6;
        val_4 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.万东丏丌不七东丘万 == false)
        {
            goto label_3;
        }
        
        UnityEngine.Texture2D val_1 = SkinsController.丈三且与上丄丗丙专();
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        val_4 = this.丝且与丝丒丟万丁专.丁东专丙丕丟丏业业;
        goto label_8;
        label_3:
        label_6:
        this.丝且与丝丒丟万丁专.SetTextureForBody(与万丆丛丒万丝丙丑:  SkinsController.丝丕且丐上丁丛三丝());
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.125f);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_7:
        val_4 = 123372880;
        label_8:
        this.丝且与丝丒丟万丁专.SetTextureForBody(与万丆丛丒万丝丙丑:  val_4);
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
