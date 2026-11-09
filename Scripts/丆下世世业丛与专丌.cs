using UnityEngine;
private sealed class DevDummyController.丆下世世业丛与专丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public DevDummyController 丝且与丝丒丟万丁专;
    public bool 丌丒丕丄丑丌世不丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DevDummyController.丆下世世业丛与专丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Texture val_4;
        UnityEngine.Texture val_5;
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
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_5 = mem[this.丌丒丕丄丑丌世不丐 == true ? this.丝且与丝丒丟万丁专.poisonHitTexture : this.丝且与丝丒丟万丁专.hitTexture];
        val_5 = (this.丌丒丕丄丑丌世不丐 == true) ? this.丝且与丝丒丟万丁专.poisonHitTexture : this.丝且与丝丒丟万丁专.hitTexture;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        val_4 = this.丝且与丝丒丟万丁专.三丌专世丑丒丙丁世;
        goto label_6;
        label_3:
        val_5 = mem[this.丌丒丕丄丑丌世不丐 == true ? this.丝且与丝丒丟万丁专.poisonHitTexture : this.丝且与丝丒丟万丁专.hitTexture];
        val_5 = (this.丌丒丕丄丑丌世不丐 == true) ? this.丝且与丝丒丟万丁专.poisonHitTexture : this.丝且与丝丒丟万丁专.hitTexture;
        label_4:
        this.丝且与丝丒丟万丁专.SetTexture(一丛丈业丏业丁下丛:  val_5);
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.125f);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_5:
        val_4 = 0;
        label_6:
        this.丝且与丝丒丟万丁专.SetTexture(一丛丈业丏业丁下丛:  val_4);
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
