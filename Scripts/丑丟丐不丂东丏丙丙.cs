using UnityEngine;
private sealed class SettingsController.丑丟丐不丂东丏丙丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SettingsController.丑丟丐不丂东丏丙丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = 0;
        if((CloudHashMigrationValidator.七一一丑七丒上丐丑(丛专下丞丒丛下下与:  false)) == false)
        {
            goto label_6;
        }
        
        if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
            goto label_5;
        }
        
        val_7 = 0;
        goto label_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        SettingsController.丄丕万丁丗丆丒丅不();
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_5:
        CloudHashMigrationValidator.丄万丁三业万丛东丑();
        val_7 = 1;
        label_6:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.世丐不丗不业七丘丐(与下丛丂丒丘丛三丆:  true, 丄丌丟丛丆丝东世一:  false, 丙丛丐东与丒且丂上:  true, 且丏下一下上丟与丐:  true));
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
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
