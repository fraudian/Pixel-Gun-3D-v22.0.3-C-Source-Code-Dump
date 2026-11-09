using UnityEngine;
private sealed class DirectionViewerTarget.世丑万七东丛三业不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.DirectionViewerTarget 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DirectionViewerTarget.世丑万七东丛三业不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 3)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专._rocketComponent != 0)
        {
            goto label_13;
        }
        
        this.丝且与丝丒丟万丁专._rocketComponent = this.丝且与丝丒丟万丁专.transform.root.GetComponentInParent<Rocket>();
        val_5 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_13:
        if(this.丝且与丝丒丟万丁专._rocketComponent.下丄丈丑丙丕世丆丂 == false)
        {
            goto label_15;
        }
        
        this.丝且与丝丒丟万丁专.丑丂上且丌专不一专();
        label_5:
        if(this.丝且与丝丒丟万丁专._rocketComponent.下丄丈丑丙丕世丆丂 == false)
        {
            goto label_17;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        val_6 = 3;
        goto label_18;
        label_17:
        this.丝且与丝丒丟万丁专.一丒丆丛丅丁丆丒万();
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_15:
        val_6 = 2;
        this.丒上七丌业七丟与丐 = 0;
        label_18:
        this.丗丏丅丕丆世丁专丟 = val_6;
        val_5 = 1;
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
