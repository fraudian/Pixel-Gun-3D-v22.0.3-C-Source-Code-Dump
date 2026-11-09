using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.下世丗丂丒丐丒不丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丐丌丝七下丈丒丅丗 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.下世丗丂丒丐丒不丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_23;
        var val_24;
        if((this.丗丏丅丕丆世丁专丟 == 2) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_4;
        }
        
        val_23 = null;
        if(Rilisoft.丐丌丝七下丈丒丅丗.丏与上不丛且业与丘() == false)
        {
            goto label_11;
        }
        
        label_4:
        if(UnityEngine.Application.isEditor != true)
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 19)
        {
            goto label_11;
        }
        
        }
        
        float val_23 = -300f;
        val_23 = UnityEngine.Time.realtimeSinceStartup + val_23;
        if(val_23 < 0)
        {
            goto label_11;
        }
        
        System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>> val_7 = Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().专业丛丂丅与世上丙(与且专丏丅世丐丐丑:  true, 丙丈丄丟业丗上丒丛:  false);
        if((Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0) || (Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == false))
        {
            goto label_19;
        }
        
        label_11:
        val_24 = 0;
        return (bool)val_24;
        label_2:
        val_24 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_24;
        label_19:
        if((CloudHashMigrationValidator.七一一丑七丒上丐丑(丛专下丞丒丛下下与:  true)) != false)
        {
                if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
            goto label_23;
        }
        
        }
        
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丂丗丞丞且万丛万不(丟东丈丗丏丛世万一:  ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "TableViewKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0, 且丏下一下上丟与丐:  false));
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_24;
        label_23:
        CloudHashMigrationValidator.丄万丁三业万丛东丑();
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.丈世丏丟不丗丏丛三());
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_24;
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
