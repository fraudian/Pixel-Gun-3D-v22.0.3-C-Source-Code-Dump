using UnityEngine;
private sealed class ClanLobbyStoreButton.丙七七丕东世丕业东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanLobbyStoreButton 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanLobbyStoreButton.丙七七丕东世丕业东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        int val_10;
        var val_11;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        PGCompany.ClanLootBoxController val_1 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        val_9 = val_1.丅丏丘丑丌七业丒不(丏专丒丅丙七三专丐:  250);
        goto label_4;
        label_1:
        val_10 = 0;
        return (bool)val_10;
        label_3:
        val_9 = 0;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._freeChestIndicator, 丏业丟一东丂东丘丛:  false);
        val_11 = null;
        val_11 = null;
        int val_8 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  206, 丞一丁业丄一一业且:  丌丅且丗七丘丅丛丑.丂丂一丑丑一世与三);
        val_8 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丅丏丘丑丌七业丒不(丏专丒丅丙七三专丐:  val_8);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.clanShopShine, 丏业丟一东丂东丘丛:  val_8);
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
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
