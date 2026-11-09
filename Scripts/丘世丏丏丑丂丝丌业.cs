using UnityEngine;
private sealed class ScenarioController.丘世丏丏丑丂丝丌业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ScenarioController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ScenarioController.丘世丏丏丑丂丝丌业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ScenarioController val_5;
        int val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = 0;
        if(val_5 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_5 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(this.丝且与丝丒丟万丁专.丌丕丈与且业丘业且 == false)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.丌丕丈与且业丘业且 = false;
        val_5 = this.三丛与七下专丅丕东;
        if(val_5 == null)
        {
                UnityEngine.WaitForSeconds val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
            this.三丛与七下专丅丕东 = val_5;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = val_5;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_6:
        val_7 = null;
        val_7 = null;
        if(SpawnDungeonMobeSetting.丄丘七三上丕世丞业 != 0)
        {
                val_8 = null;
            val_8 = null;
            SpawnDungeonMobeSetting.丄丘七三上丕世丞业.丒且业丈丛丗丈东丂(丌丒丝东丌下丕丁丅:  且丅丐世专丒业丄一());
        }
        
        val_5.丝丕业丆丐丑世丄下();
        val_9 = null;
        val_9 = null;
        if(SpawnDungeonMobeSetting.丄丘七三上丕世丞业 != 0)
        {
                val_10 = null;
            val_10 = null;
            SpawnDungeonMobeSetting.丄丘七三上丕世丞业.丞万不丟丙下丕丕且();
        }
        
        val_6 = 0;
        this.丝且与丝丒丟万丁专.丌丕丈与且业丘业且 = true;
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
