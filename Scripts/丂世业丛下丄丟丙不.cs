using UnityEngine;
private sealed class 丛丏丒丈七丆丞与丌.丂世业丛下丄丟丙不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.丛丏丒丈七丆丞与丌 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丛丏丒丈七丆丞与丌.丂世业丛下丄丟丙不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        MainMenuController val_4;
        var val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = null;
        val_3 = null;
        val_4 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_4 == 0)
        {
            goto label_13;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
        val_4 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
        if((activeInHierarchy == false) || ((this.丝且与丝丒丟万丁专 & 1) == 0))
        {
            goto label_13;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
                return (bool)val_6;
        }
        
        this.丝且与丝丒丟万丁专.Invoke();
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_13:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
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
