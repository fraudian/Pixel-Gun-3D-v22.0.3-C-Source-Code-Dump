using UnityEngine;
private sealed class LeaderboardEventController.丒丐不世丕专丕上丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LeaderboardEventController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaderboardEventController.丒丐不世丕专丕上丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LeaderboardEventController val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        val_3 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if((AuthSceneController.一不丆丏与丐丏丈丄() == false) || (下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false))
        {
            goto label_5;
        }
        
        if(val_3 == null)
        {
            goto label_6;
        }
        
        val_3.专丅丈丏丑专丗丂且();
        val_3.丏丑万丌丘万三丙与(丟丟丄专上丟丁丐丝:  0);
        goto label_7;
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_5:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_6:
        0.专丅丈丏丑专丗丂且();
        0.丏丑万丌丘万三丙与(丟丟丄专上丟丁丐丝:  0);
        label_7:
        val_4 = 0;
        this.丝且与丝丒丟万丁专.丅东三丒且丅丄丐丒 = 0;
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
