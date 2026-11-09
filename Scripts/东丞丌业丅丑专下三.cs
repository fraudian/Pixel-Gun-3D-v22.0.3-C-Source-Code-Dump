using UnityEngine;
private sealed class ClanWarConnectScene.东丞丌业丅丑专下三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClanWarConnectScene 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 业丅万业东丗下专丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanWarConnectScene.东丞丌业丅丑专下三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_6;
        int val_7;
        var val_8;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.业丅万业东丗下专丙 = 0;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
        label_5:
        if(FriendsController.丝丗专上三不丄丑丑() >= 1)
        {
                if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0)
        {
            goto label_13;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._body, 丏业丟一东丂东丘丛:  false);
        val_6 = 0;
        val_7 = 1;
        goto label_17;
        label_3:
        val_8 = 0;
        return (bool)val_8;
        label_13:
        this.丝且与丝丒丟万丁专.丕丕业七丙七丅丈丄();
        val_6 = this.业丅万业东丗下专丙;
        if(val_6 == null)
        {
                UnityEngine.WaitForSeconds val_5 = null;
            val_6 = val_5;
            val_5 = new UnityEngine.WaitForSeconds(seconds:  5f);
            this.业丅万业东丗下专丙 = val_6;
        }
        
        val_7 = 2;
        label_17:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_8;
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
