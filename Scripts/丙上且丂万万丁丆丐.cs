using UnityEngine;
private sealed class Player_move_c.丙上且丂万万丁丆丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    private WeaponSounds 丙丒丈丂丒与丗丕丑;
    private int 丈专业丗丆丆上万万;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丙上且丂万万丁丆丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        float val_6;
        int val_7;
        int val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丙丒丈丂丒与丗丕丑 = this.丝且与丝丒丟万丁专.丅且不三丅丂上丈丅();
        val_5 = 1f;
        if((val_1.isCharging != false) && (this.丙丒丈丂丒与丗丕丑.dotFlameTimeIsDependedOnChargeTime != false))
        {
                val_5 = this.丝且与丝丒丟万丁专.一丝丘三上丕丒万一;
        }
        
        float val_2 = this.丙丒丈丂丒与丗丕丑.丛丆丑丁下丆丘丏丝();
        val_6 = val_2;
        val_2 = val_6 / this.丙丒丈丂丒与丗丕丑.dotTimeFlamethrower;
        val_2 = val_5 * val_2;
        val_7 = 0;
        val_8 = 0;
        this.丈专业丗丆丆上万万 = UnityEngine.Mathf.RoundToInt(f:  val_2);
        this.丟丗丒丟丝丘丞丝丏 = 0;
        goto label_13;
        label_1:
        val_7 = this.丈专业丗丆丆上万万;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = this.丟丗丒丟丝丘丞丝丏 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_8;
        label_13:
        if(val_8 < val_7)
        {
                this.丝且与丝丒丟万丁专.丛丂丁丐丏三丘丐丐(丌丝下丄业一丄不三:  this.丙丒丈丂丒与丗丕丑);
            val_6 = this.丙丒丈丂丒与丗丕丑.dotTimeFlamethrower;
            val_9 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_6);
            this.丗丏丅丕丆世丁专丟 = val_9;
            return (bool)val_9;
        }
        
        this.丝且与丝丒丟万丁专.丏一丂下丙丞丒丅万();
        label_2:
        val_9 = 0;
        return (bool)val_9;
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
