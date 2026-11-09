using UnityEngine;
private sealed class MainMenuController.业丗丁丛丆丕丞七丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MainMenuController 丝且与丝丒丟万丁专;
    private System.Func<bool> 下丛丟三上丝万丄丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.业丗丁丛丆丕丞七丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        System.Func<System.Boolean> val_7;
        UnityEngine.GameObject val_8;
        int val_9;
        val_4 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = null;
        val_5 = null;
        val_7 = MainMenuController.<>c.<>9__227_0;
        if(val_7 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainMenuController.<>c::丆丏丄专下一丁东丘());
            MainMenuController.<>c.<>9__227_0 = val_7;
        }
        
        this.下丛丟三上丝万丄丘 = val_7;
        if(val_7 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_1:
        val_7 = this.下丛丟三上丝万丄丘;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_7 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        val_8 = val_7.Invoke();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_11;
        }
        
        if(val_8 == false)
        {
            goto label_12;
        }
        
        label_18:
        this.丝且与丝丒丟万丁专.丆七丌三丈丕丅丗专();
        val_4 = this.丝且与丝丒丟万丁专.lobbyPanel.clansButtonContainer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_11:
        if(val_8 == true)
        {
            goto label_18;
        }
        
        label_12:
        val_8 = this.丝且与丝丒丟万丁专.mainMenuPanel.tasksBtn.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.lobbyPanel.clansButtonContainer, 丏业丟一东丂东丘丛:  false);
        val_9 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_9;
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
