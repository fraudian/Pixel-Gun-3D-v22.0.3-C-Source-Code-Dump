using UnityEngine;
private sealed class MapVoteController.丅世丒七丗丈丄丘丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MapVoteController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丗丕专丐丞丞下不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MapVoteController.丅世丒七丗丈丄丘丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_5;
        UnityEngine.WaitForSecondsRealtime val_6;
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
        this.丗丕专丐丞丞下不丒 = new UnityEngine.WaitForSecondsRealtime(time:  870f);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        label_6:
        val_5 = this.丝且与丝丒丟万丁专.丐丈丁丘东七世丄且();
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        label_4:
        val_5 = 0.丐丈丁丘东七世丄且();
        label_5:
        UnityEngine.Coroutine val_4 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_5);
        val_7 = 1;
        goto label_7;
        label_2:
        val_6 = this.丗丕专丐丞丞下不丒;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = 2;
        label_7:
        this.丒上七丌业七丟与丐 = val_6;
        val_8 = 1;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_8;
        label_3:
        val_8 = 0;
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
