using UnityEngine;
private sealed class SettingsTabAccount.丁丂丟丅丗丞丛世丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SettingsTabAccount.丁丂丟丅丗丞丛世丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        var val_8;
        int val_9;
        val_7 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = 0;
        if((CloudHashMigrationValidator.七一一丑七丒上丐丑(丛专下丞丒丛下下与:  false)) == false)
        {
            goto label_6;
        }
        
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
            goto label_5;
        }
        
        val_8 = 0;
        goto label_6;
        label_1:
        val_9 = 0;
        goto label_7;
        label_5:
        CloudHashMigrationValidator.丄万丁三业万丛东丑();
        val_8 = 1;
        label_6:
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.世丐不丗不业七丘丐(与下丛丂丒丘丛三丆:  true, 丄丌丟丛丆丝东世一:  false, 丙丛丐东与丒且丂上:  true, 且丏下一下上丟与丐:  true));
        val_9 = 1;
        val_7 = 1;
        label_7:
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_7;
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
