using UnityEngine;
private sealed class MainMenuController.东丕万专一丕下丝东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.东丕万专一丕下丝东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(七专万下丄世丞丂且.丑七不且上丗丁一世().丙不丝丛七丟丄丂丑() != true)
        {
                if(丅丛丟上丁丆上丛专.且一东三万丄且业丘() == true)
        {
            goto label_6;
        }
        
        }
        
        七专万下丄世丞丂且.丑七不且上丗丁一世().丙丞丒丗与且丌丆一();
        label_6:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  5f);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        val_6 = 0;
        return (bool)val_6;
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
