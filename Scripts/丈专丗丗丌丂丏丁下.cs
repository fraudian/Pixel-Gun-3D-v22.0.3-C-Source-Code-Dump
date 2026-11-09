using UnityEngine;
private sealed class MainMenuController.丈专丗丗丌丂丏丁下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MainMenuController 丝且与丝丒丟万丁专;
    private System.Func<bool> 丒不丆丈业丝专丄丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.丈专丗丗丌丂丏丁下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        System.Func<System.Boolean> val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = null;
        val_3 = null;
        val_5 = MainMenuController.<>c.<>9__228_0;
        if(val_5 == null)
        {
                System.Func<System.Boolean> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<System.Boolean>(object:  MainMenuController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MainMenuController.<>c::丐且下丆三丞丒一万());
            MainMenuController.<>c.<>9__228_0 = val_5;
        }
        
        this.丒不丆丈业丝专丄丗 = val_5;
        if(val_5 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_1:
        val_5 = this.丒不丆丈业丝专丄丗;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_5 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if(val_5.Invoke() == false)
        {
            goto label_13;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<Rilisoft.ButtonHandler>(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.lobbyPanel.openCraftBtns, 丏业丟一东丂东丘丛:  true);
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<Rilisoft.ButtonHandler>(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.lobbyPanel.openCraftBtns, 丏业丟一东丂东丘丛:  false);
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
