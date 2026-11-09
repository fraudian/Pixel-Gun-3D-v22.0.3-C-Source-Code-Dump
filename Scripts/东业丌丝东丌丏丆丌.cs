using UnityEngine;
private sealed class TeamDuelInGameEmojiController.东业丌丝东丌丏丆丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TeamDuelInGameEmojiController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TeamDuelInGameEmojiController.东业丌丝东丌丏丆丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        var val_5;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = UnityEngine.Resources.Load(path:  "Emoji/ChatEmojiInGame");
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        if(val_3 == null)
        {
            goto label_5;
        }
        
        label_8:
        var val_2 = (null == null) ? (val_3) : 0;
        goto label_6;
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_4:
        if(val_3 != null)
        {
            goto label_8;
        }
        
        label_5:
        val_5 = 0;
        label_6:
        mem2[0] = val_5;
        val_4 = 0;
        EmojiController.丘丆专丕丏且不丏丑 = this.丝且与丝丒丟万丁专;
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
