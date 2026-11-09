using UnityEngine;
private sealed class TeamDuelController.丈丞专东丈七丁丌丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TeamDuelController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TeamDuelController.丈丞专东丈七丁丌丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TeamDuelController val_6;
        int val_7;
        var val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        val_6 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_6.duelUI == 0)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        if(val_6 != null)
        {
                this.丝且与丝丒丟万丁专.myPlayerDead = false;
        }
        else
        {
                mem[172] = 0;
        }
        
        val_6.duelUI.丂万与丙上丐一且一();
        if(this.丝且与丝丒丟万丁专.playerStarted == false)
        {
            goto label_11;
        }
        
        label_1:
        val_7 = 0;
        return (bool)val_7;
        label_11:
        this.丝且与丝丒丟万丁专.playerStarted = true;
        val_8 = null;
        val_8 = null;
        GameController.onlineMode.丟丛专七不七丆三万();
        val_6.duelUI.丆东世丝万丆下丞一();
        this.丝且与丝丒丟万丁专.showGoInterface = true;
        val_9 = null;
        val_9 = null;
        this.丝且与丝丒丟万丁专.myTeamInDuel = 丘丑丅三丆丑丌且丝();
        return (bool)val_7;
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
