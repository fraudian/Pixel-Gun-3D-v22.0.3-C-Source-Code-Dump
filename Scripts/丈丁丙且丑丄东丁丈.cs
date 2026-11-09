using UnityEngine;
private sealed class LobbyItemsController.丈丁丙且丑丄东丁丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LobbyItemsController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyItemsController.丈丁丙且丑丄东丁丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_0;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_1;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        this.丝且与丝丒丟万丁专.丌丛上丟专与世专一();
        goto label_3;
        label_0:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_2;
        return (bool)val_2;
        label_2:
        0.丌丛上丟专与世专一();
        label_3:
        val_2 = 0;
        this.丝且与丝丒丟万丁专.丅丏不下与下丄下丁 = 0;
        return (bool)val_2;
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
