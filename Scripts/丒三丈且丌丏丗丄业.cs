using UnityEngine;
private sealed class TournamentEventRespriteUi.丒三丈且丌丏丗丄业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TournamentEventRespriteUi 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TournamentEventRespriteUi.丒三丈且丌丏丗丄业(int 丗丏丅丕丆世丁专丟)
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
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丐且丘丑与万丞丑丅 != null)
        {
                bool val_2 = PGCompany.GameModeEvents.丅丑丘七且丄丂丘下.上万世丒丁万下丌丛(丏丒丒丌一丌东丘丝:  this.丝且与丝丒丟万丁专.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七(), 万且丕业与丗丗丝七:  true);
        }
        
        this.丝且与丝丒丟万丁专.丝上丗不丒且世丌丑();
        label_3:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  60f);
        this.丗丏丅丕丆世丁专丟 = val_4;
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
