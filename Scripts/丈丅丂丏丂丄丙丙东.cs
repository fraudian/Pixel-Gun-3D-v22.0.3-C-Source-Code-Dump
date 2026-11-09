using UnityEngine;
private sealed class TurretControllerScene_Artillery.丈丅丂丏丂丄丙丙东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretControllerScene_Artillery 丝且与丝丒丟万丁专;
    public UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕;
    public float 一丄且丒一丝丏丄与;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretControllerScene_Artillery.丈丅丂丏丂丄丙丙东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        int val_6;
        UnityEngine.Vector2 val_7;
        float val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_4 = this;
        this.丈丌丝且业丏丈丂丁 = 0;
        val_5 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        mem[1152921540619612280] = 0;
        goto label_3;
        label_1:
        val_4 = this.丈丌丝且业丏丈丂丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_12;
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_16:
        val_7 = this.丌丐丏丐丆丙丛丁丕[X21];
        UnityEngine.Vector2 val_3 = this.丌丐丏丐丆丙丛丁丕[X21];
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_8 = val_7;
            this.丝且与丝丒丟万丁专.丟丑丙七丁三丞丕丁(丂丆丞丞丐丗丈上丂:  val_8, 丄丛丐专一丙下且丒:  val_3, 一丄且丒一丝丏丄与:  this.一丄且丒一丝丏丄与);
            val_9 = mem[X21];
            val_9 = X21;
        }
        else
        {
                val_8 = val_7;
            0.丟丑丙七丁三丞丕丁(丂丆丞丞丐丗丈上丂:  val_8, 丄丛丐专一丙下且丒:  val_3, 一丄且丒一丝丏丄与:  this.一丄且丒一丝丏丄与);
            val_9 = mem[X21];
            val_9 = X21;
        }
        
        int val_4 = this.丝且与丝丒丟万丁专.shootSeriesCount;
        val_4 = val_4 - 1;
        if(val_9 < val_4)
        {
                val_4 = this.三丛与七下专丅丕东;
            if(val_4 == null)
        {
                val_7 = this.丝且与丝丒丟万丁专.shootSeriesDelay;
            UnityEngine.WaitForSeconds val_1 = null;
            val_4 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  val_7);
            this.三丛与七下专丅丕东 = val_4;
        }
        
            val_6 = 1;
            this.丒上七丌业七丟与丐 = val_4;
            this.丗丏丅丕丆世丁专丟 = val_6;
            return (bool)val_6;
        }
        
        label_12:
        val_5 = val_4 + 1;
        mem2[0] = val_5;
        label_3:
        if(val_5 < this.丌丐丏丐丆丙丛丁丕.Length)
        {
            goto label_16;
        }
        
        val_7 = UnityEngine.Time.time;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.且丌业丙丆丅七世丟 = val_7;
        }
        else
        {
                mem[556] = val_7;
        }
        
        val_6 = 0;
        this.丝且与丝丒丟万丁专.丟丞丟不丆一丞丙丄 = 0;
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
