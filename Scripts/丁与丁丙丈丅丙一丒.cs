using UnityEngine;
private sealed class ClanRankPromoteWindow.丁与丁丙丈丅丙一丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丆丐七丅丆丗丛上与;
    public PGCompany.Banners.ClanRankPromoteWindow 丝且与丝丒丟万丁专;
    public UnityEngine.Transform 丞下万上三丘上与专;
    public bool 丌与丟丁万丝丞丄丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanRankPromoteWindow.丁与丁丙丈丅丙一丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_3;
        int val_4;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丆丐七丅丆丗丛上与);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = this.丌与丟丁万丝丞丄丏;
        this.丝且与丝丒丟万丁专.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  this.丞下万上三丘上与专, 丌与丟丁万丝丞丄丏:  (val_3 == true) ? 1 : 0);
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
