using UnityEngine;
private sealed class 业丂丏与世一丏业不.丝丞丐丛丛丏上专丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 业丂丏与世一丏业不 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 业丂丏与世一丏业不.丝丞丐丛丛丏上专丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(MainMenuController.丈一丏一丂丟三且丌() == true)
        {
            goto label_4;
        }
        
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_7;
        }
        
        this.丝且与丝丒丟万丁专.上世丆丂三丁丂丄丗(丕丞上丞业丅丛丒丆:  true);
        label_6:
        val_3 = 0;
        return (bool)val_3;
        label_7:
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_3;
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
