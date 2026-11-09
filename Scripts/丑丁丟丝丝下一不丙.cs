using UnityEngine;
private sealed class MarathonButtonController.丑丁丟丝丝下一不丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MarathonButtonController 丝且与丝丒丟万丁专;
    private bool 丏丌业上上丆与丘业;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MarathonButtonController.丑丁丟丝丝下一不丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丏丌业上上丆与丘业 = false;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        bool val_1 = PixelTime.丝业丁丌丘东丏世与();
        var val_2 = (this.丏丌业上上丆与丘业 == true) ? 1 : 0;
        val_2 = val_1 ^ val_2;
        if(val_2 != false)
        {
                this.丏丌业上上丆与丘业 = val_1;
            this.丝且与丝丒丟万丁专.丝一丅丆三东丂丞七();
        }
        
        val_4 = 1;
        this.丗丏丅丕丆世丁专丟 = val_4;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.一丌丁丄丝丞七丗不;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
