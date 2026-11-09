using UnityEngine;
private sealed class 丅业丅与丄与一丙一.业专丅丁丁东下丂丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 丅业丅与丄与一丙一 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丅业丅与丄与一丙一.业专丅丁丁东下丂丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专.不三丏不丒丅东丂与() != false)
        {
                val_2 = 1;
            this.丗丏丅丕丆世丁专丟 = val_2;
            this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丅下丈专丕丅丑业下;
            return (bool)val_2;
        }
        
        }
        
        val_2 = 0;
        return (bool)val_2;
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
