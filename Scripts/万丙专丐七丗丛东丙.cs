using UnityEngine;
private sealed class 丐丌丝七下丈丒丅丗.万丙专丐七丗丛东丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 且丏下一下上丟与丐;
    public Rilisoft.丐丌丝七下丈丒丅丗 丝且与丝丒丟万丁专;
    public bool 丟东丈丗丏丛世万一;
    private int 丛丕业丏上上丟丝丞;
    private System.Func<bool> 丐丁丝丞丙三丆一与;
    private bool 丙三丈三丒丅丗丐且;
    private System.Collections.Generic.List<Rilisoft.丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏> 专丆三业丗丅丆业丗;
    private int 不上一丝丗丘丄下丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.万丙专丐七丗丛东丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 6)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 113;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_69;
        int val_84;
        System.Collections.IEnumerator val_101;
        int val_104;
        var val_105;
        if(this.丗丏丅丕丆世丁专丟 > 3)
        {
            goto label_259;
        }
        
        var val_64 = 106029312 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_64 = val_64 + 106029312;
        goto (106029312 + (this.丗丏丅丕丆世丁专丟) << 2 + 106029312);
        label_234:
        if( >= Count)
        {
            goto label_202;
        }
        
        丞丁丙与丝丁不三丏 val_46 = Item[0];
        if(((val_46.<七东丅丗丙下丐丘丈>k__BackingField) & 1) == 0)
        {
            goto label_206;
        }
        
        丞丁丙与丝丁不三丏 val_48 = Item[0];
        val_84 = this.且丏下一下上丟与丐;
        var val_49 = (val_84 == true) ? 1 : 0;
        var val_50 = (this.丟东丈丗丏丛世万一 == true) ? 1 : 0;
        val_101 = val_48.<丝专丞丑丞丏业丆丈>k__BackingField;
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  val_101);
        val_104 = 1;
        this.丗丏丅丕丆世丁专丟 = val_104;
        return (bool)val_104;
        label_202:
        mem2[0] = UnityEngine.Time.realtimeSinceStartup;
        if(this.且丏下一下上丟与丐 != false)
        {
                val_105 = null;
            val_105 = null;
            if(Rilisoft.丐丌丝七下丈丒丅丗.业七丈万丏丑丅丟且 == null)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
            goto label_222;
        }
        
        }
        
            this.一世丕丕业且且丅丌();
        }
        else
        {
                this.丐丁丝丞丙三丆一与 = 0;
            this.专丆三业丗丅丆业丗 = 0;
            this.一世丕丕业且且丅丌();
        }
        
        label_259:
        val_104 = 0;
        return (bool)val_104;
        label_206:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                object[] val_56 = new object[1];
            val_56[0] = Item[0];
            UnityEngine.Debug.LogWarningFormat(format:  "CloudSyncController: Trying to merge and push synchronizer that never pulled: {0}", args:  val_56);
        }
        
        this.不上一丝丗丘丄下丁 = this.不上一丝丗丘丄下丁 + 1;
        goto label_234;
        label_222:
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.丝万丗丐世万上丛丆(上丟专下不一丗丙丆:  this.丛丕业丏上上丟丝丞, 七万东下丛万丁且丘:  this.丐丁丝丞丙三丆一与.Invoke(), 丝丌丆一上丙丏丁业:  (this.丙三丈三丒丅丗丐且 == true) ? 1 : 0));
        val_69 = 3;
        this.丗丏丅丕丆世丁专丟 = val_69;
        return (bool)val_104;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        Rilisoft.丐丌丝七下丈丒丅丗.一上丂丑一丘丟上丁(丙业与丙丗丝不丈东:  false);
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
