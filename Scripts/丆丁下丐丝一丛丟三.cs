using UnityEngine;
private sealed class CloudHashMigrationValidator.丆丁下丐丝一丛丟三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CloudHashMigrationValidator.丆丁下丐丝一丛丟三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_13;
        int val_14;
        var val_15;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, 丞丁丙与丝丁不三丏>, System.Boolean> val_17;
        val_13 = this;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime(time:  3f);
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_5;
        label_1:
        int val_13 = this.丙不丅丌丗上丂丕一;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_13 = val_13 + 1;
        this.丙不丅丌丗上丂丕一 = val_13;
        if(val_13 >= 3)
        {
            goto label_6;
        }
        
        label_5:
        if(Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丕且三万丑丙丟丑上() == null)
        {
            goto label_19;
        }
        
        val_15 = null;
        val_15 = null;
        val_17 = CloudHashMigrationValidator.<>c.<>9__18_0;
        if(val_17 == null)
        {
                val_17 = null;
            val_17 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丞丁丙与丝丁不三丏>, System.Boolean>(object:  CloudHashMigrationValidator.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CloudHashMigrationValidator.<>c::丐专丞丑与丝三丌世(System.Collections.Generic.KeyValuePair<string, Rilisoft.丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏> 七丏丄丅丌业与且丙));
            CloudHashMigrationValidator.<>c.<>9__18_0 = val_17;
        }
        
        if((System.Linq.Enumerable.All<System.Collections.Generic.KeyValuePair<System.String, 丞丁丙与丝丁不三丏>>(source:  Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丕且三万丑丙丟丑上(), predicate:  null)) == false)
        {
            goto label_19;
        }
        
        label_6:
        val_14 = 0;
        CloudHashMigrationValidator.<丒丒丑不丆丈丌丙丕>k__BackingField = true;
        return (bool)val_14;
        label_3:
        val_14 = 0;
        return (bool)val_14;
        label_19:
        val_17 = CoroutineRunner.Instance;
        this.丒上七丌业七丟与丐 = val_17.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.下丟不上丏丝丞丒丟(丕丝专丙丗丙丝丌丗:  new System.Threading.Tasks.TaskCompletionSource<System.Boolean>(), 丑丗业丝丙丁且下七:  false, 丙丈丄丟业丗上丒丛:  true));
        this.丗丏丅丕丆世丁专丟 = 2;
        val_14 = 1;
        return (bool)val_14;
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
