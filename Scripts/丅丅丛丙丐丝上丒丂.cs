using UnityEngine;
private sealed class SpleefBlockItem.丅丅丛丙丐丝上丒丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SpleefBlockItem 丝且与丝丒丟万丁专;
    private float 七丁丒丞丐丒丞七丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpleefBlockItem.丅丅丛丙丐丝上丒丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_5;
        float val_6;
        int val_7;
        val_4 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_5 = val_4;
        this.七丁丒丞丐丒丞七丅 = 1.5f;
        val_6 = 1.5f;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_4;
        label_1:
        val_5 = val_4;
        val_6 = this.七丁丒丞丐丒丞七丅;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_6 > 0f)
        {
            goto label_4;
        }
        
        val_4 = this.丝且与丝丒丟万丁专.gameObject;
        val_4.SetActive(value:  false);
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_4:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_6 - val_2;
        this.七丁丒丞丐丒丞七丅 = val_2;
        this.丝且与丝丒丟万丁专.丑与丗丛丝丈丙丆丌.material.SetFloat(name:  "_Burn", value:  this.七丁丒丞丐丒丞七丅);
        val_7 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
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
