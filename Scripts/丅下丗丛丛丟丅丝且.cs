using UnityEngine;
private sealed class MainMenuController.丅下丗丛丛丟丅丝且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Threading.CancellationToken 业丘丝业丛丆丄一上;
    public MainMenuController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.丅下丗丛丛丟丅丝且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        MainMenuController val_6;
        var val_7;
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = 1152921505080860672;
        val_7 = null;
        val_7 = null;
        if((MainMenuController.业万且与丘与与三丕 == true) || (MainMenuController.下且丄丝丘丝丈上丒 == true))
        {
            goto label_16;
        }
        
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
        {
                if(ConnectScene.丈丘丂丙不丛业丟三() == false)
        {
            goto label_15;
        }
        
        }
        
        label_33:
        if((this.业丘丝业丛丆丄一上 & 1) != 0)
        {
            goto label_16;
        }
        
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_15:
        val_10 = null;
        val_10 = null;
        val_6 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_6 == 0)
        {
            goto label_28;
        }
        
        val_11 = null;
        val_11 = null;
        val_6 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
        val_6 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
        if(val_6 == 0)
        {
            goto label_28;
        }
        
        val_12 = null;
        val_12 = null;
        val_6 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
        val_6 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
        if(activeInHierarchy == false)
        {
            goto label_33;
        }
        
        label_28:
        this.丝且与丝丒丟万丁专.一丛丟丞与丘丄丌三();
        label_16:
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
