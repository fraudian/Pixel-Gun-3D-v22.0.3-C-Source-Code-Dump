using UnityEngine;
private sealed class TournamentController.丈上丆三世三丅下丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TournamentController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TournamentController.丈上丆三世三丅下丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        label_16:
        if(PixelTime.丙丅丅业丟丁世丁丗() <= (TournamentController.丝丘丙丙世丁丈丟世() << ))
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.东丙丗万下丌不下丏();
        goto label_11;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.万与丛世丒丅下上丁() != 2)
        {
            goto label_11;
        }
        
        if(PixelTime.丙丅丅业丟丁世丁丗() <= (TournamentController.丝丘丙丙世丁丈丟世() << ))
        {
            goto label_16;
        }
        
        val_9 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  20f);
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_11:
        val_9 = 0;
        return (bool)val_9;
        label_6:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_9 = 1;
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
