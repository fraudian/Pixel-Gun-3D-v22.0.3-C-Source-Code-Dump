using UnityEngine;
private sealed class GameEventSetsViewChestContentTap.丛丁丝丄丕专与丘专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventSetsViewChestContentTap 丝且与丝丒丟万丁专;
    public Rilisoft.GameEventSetItemView 丁世丛业丟下丕三丟;
    public System.Action 丟丘丙丄丅万丏与丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventSetsViewChestContentTap.丛丁丝丄丕专与丘专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        int val_5;
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
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._touchBlocker, 丏业丟一东丂东丘丛:  true);
        val_4 = 0;
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = 0;
        this.丝且与丝丒丟万丁专.丅丂丑丂不丛专世东 = 0;
        return (bool)val_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._touchBlocker, 丏业丟一东丂东丘丛:  false);
        if(this.丟丘丙丄丅万丏与丗 != null)
        {
                this.丟丘丙丄丅万丏与丗.Invoke();
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_5 = 1;
        return (bool)val_5;
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_9:
        if( != 0)
        {
                SetFrontActive(丏业丟一东丂东丘丛:  true, 丛丆与丆丞丏丅万丅:  false);
        }
        
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
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
