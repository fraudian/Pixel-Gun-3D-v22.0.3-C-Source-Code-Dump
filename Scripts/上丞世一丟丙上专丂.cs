using UnityEngine;
private sealed class NetworkStartTableNGUIController.上丞世一丟丙上专丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    public 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三;
    public float 丕丕世且下一与丝与;
    private bool 丛且不丐丏丒一上丂;
    private 丏与丌丐东七丈丑丕 与世丁丑丙丆丑丘万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.上丞世一丟丙上专丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Func<System.Boolean> val_83;
        int val_84;
        int val_85;
        if(this.丗丏丅丕丆世丁专丟 > 3)
        {
            goto label_5;
        }
        
        var val_83 = 106029496 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_83 = val_83 + 106029496;
        goto (106029496 + (this.丗丏丅丕丆世丁专丟) << 2 + 106029496);
        label_5:
        val_84 = 0;
        return (bool)val_84;
        label_92:
        val_83 = this.与世丁丑丙丆丑丘万.丒丒丆丙与且丅不丌().丌东业与丞丐丂丝专();
        if(val_83 == this.丗七丟丈三不丕一三.丌东业与丞丐丂丝专())
        {
            goto label_90;
        }
        
        val_83 = this.与世丁丑丙丆丑丘万;
        if(val_83.MoveNext() == true)
        {
            goto label_92;
        }
        
        val_84 = 0;
        mem[1152921531042705213] = 0;
        return (bool)val_84;
        label_90:
        mem[1152921531042705212] = 0;
        val_85 = 2;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_85;
        val_84 = 1;
        return (bool)val_84;
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
