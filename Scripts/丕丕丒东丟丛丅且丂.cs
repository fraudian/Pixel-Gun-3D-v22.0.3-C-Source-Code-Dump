using UnityEngine;
private sealed class ClanLobbyButton.丕丕丒东丟丛丅且丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClanLobbyButton 丝且与丝丒丟万丁专;
    private bool 下丞上丙且丗丙一丆;
    private UnityEngine.WaitForSeconds 业一下丝丗丌与丙丘;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanLobbyButton.丕丕丒东丟丛丅且丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_61;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_57 = 106037592 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_57 = val_57 + 106037592;
        }
        else
        {
                val_61 = 0;
            return (bool);
        }
    
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
