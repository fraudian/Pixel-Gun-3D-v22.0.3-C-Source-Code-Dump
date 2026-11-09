using UnityEngine;
private sealed class ModulesController.丘丆下丛丙丒丕东丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ModulesController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ModulesController.丘丆下丛丙丒丕东丅(int 丗丏丅丕丆世丁专丟)
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
        if((((AuthSceneController.一不丆丏与丐丏丈丄() == false) || (this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 == null)) || (this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏.Modules_v2 == null)) || (this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏.Modules_v2.Count == 0))
        {
            goto label_6;
        }
        
        PGCompany.丁丈且万丈丅丆丐丈.丈专万业业与丑且且();
        PGCompany.丁丈且万丈丅丆丐丈.丒七丛丕丛丅且丂丐();
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_6:
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
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
