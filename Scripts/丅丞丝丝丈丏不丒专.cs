using UnityEngine;
private sealed class MainMenuController.丅丞丝丝丈丏不丒专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MainMenuController 丝且与丝丒丟万丁专;
    public bool 丄丁上丒丌丝一上丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.丅丞丝丝丈丏不丒专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        var val_5;
        var val_6;
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
            goto label_26;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = 1;
        this.丝且与丝丒丟万丁专.丌丈且丛丅丏丏丌丆(丏业丟一东丂东丘丛:  true);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_9;
        }
        
        if(this.丄丁上丒丌丝一上丕 == false)
        {
            goto label_10;
        }
        
        Rilisoft.ClansLobbyGui.东丗丁丂专七丑丞丈();
        goto label_26;
        label_2:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_4 = 1;
        return (bool)val_4;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.mainPanel, 丏业丟一东丂东丘丛:  true);
        val_5 = null;
        val_5 = null;
        if(ExperienceController.sharedController != 0)
        {
                val_6 = null;
            val_6 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        }
        
        this.丝且与丝丒丟万丁专.丌丈且丛丅丏丏丌丆(丏业丟一东丂东丘丛:  false);
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        goto label_26;
        label_10:
        Rilisoft.ClansLobbyGui.丘不丌丈下专丘东七();
        label_26:
        val_4 = 0;
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
