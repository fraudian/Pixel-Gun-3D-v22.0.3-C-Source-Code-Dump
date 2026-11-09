using UnityEngine;
private sealed class MainMenuController.一且丒世丗丞丝丈下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.一且丒世丗丞丝丈下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ExperienceController val_2;
        var val_3;
        var val_4;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_3;
        label_1:
        int val_2 = this.丙不丅丌丗上丂丕一;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_2 = val_2 + 1;
        this.丙不丅丌丗上丂丕一 = val_2;
        if((val_2 & 2147483648) != 0)
        {
            goto label_4;
        }
        
        label_3:
        val_3 = null;
        val_3 = null;
        val_2 = ExperienceController.sharedController;
        if(val_2 == 0)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        val_2 = ExperienceController.sharedController;
        val_2.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        return false;
        label_4:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
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
