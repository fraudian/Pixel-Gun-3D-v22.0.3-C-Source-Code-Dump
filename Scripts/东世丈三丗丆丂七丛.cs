using UnityEngine;
private sealed class InRoomTime.东世丈三丗丆丂七丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InRoomTime 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InRoomTime.东世丈三丗丆丂七丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ExitGames.Client.Photon.Hashtable val_7;
        var val_8;
        int val_9;
        val_7 = this;
        val_8 = 99544;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
                val_8 = 0;
        }
        
        if((val_8.IsRoomTimeSet == true) || (丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false))
        {
            goto label_7;
        }
        
        if(丅丒丗丑丒丙丛不丆.一丛丘专七丄丗丝丕() != 0)
        {
            goto label_10;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        val_9 = 1;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_10:
        ExitGames.Client.Photon.Hashtable val_4 = null;
        val_7 = val_4;
        val_4 = new ExitGames.Client.Photon.Hashtable();
        val_4.set_Item(key:  "#rt", value:  丅丒丗丑丒丙丛不丆.一丛丘专七丄丗丝丕());
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_4, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        label_7:
        val_9 = 0;
        return (bool)val_9;
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
