using UnityEngine;
private sealed class Player_move_c.丟丞丙万丞一丕不业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    public 三丈丟与丏丘丈丐万 三七丐丟万上与丁丆;
    public UnityEngine.Animation 丐丞丑一丟丕世专丅;
    public int 与丏上丄丙丛丟不上;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丟丞丙万丞一丕不业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        UnityEngine.Animation val_12;
        int val_13;
        int val_14;
        val_11 = this.丗丏丅丕丆世丁专丟;
        if((val_11 - 1) < 2)
        {
            goto label_1;
        }
        
        if(val_11 == 3)
        {
            goto label_2;
        }
        
        if(val_11 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丐丞丑一丟丕世专丅 == 0)
        {
            goto label_13;
        }
        
        val_12 = this.丐丞丑一丟丕世专丅;
        if((val_12.IsPlaying(name:  "Shoot1")) == true)
        {
            goto label_11;
        }
        
        val_12 = this.丐丞丑一丟丕世专丅;
        if((val_12.IsPlaying(name:  "Shoot2")) == true)
        {
            goto label_11;
        }
        
        val_12 = this.丐丞丑一丟丕世专丅;
        if((val_12.IsPlaying(name:  "Shoot")) == false)
        {
            goto label_13;
        }
        
        label_11:
        val_13 = 2;
        this.丒上七丌业七丟与丐 = 0;
        goto label_14;
        label_13:
        val_12 = this.丐丞丑一丟丕世专丅;
        if(val_12 == 0)
        {
            goto label_17;
        }
        
        val_11 = this.丙不丅丌丗上丂丕一 + 1;
        this.丙不丅丌丗上丂丕一 = val_11;
        label_4:
        if(val_11 >= this.与丏上丄丙丛丟不上)
        {
            goto label_18;
        }
        
        val_12 = this.三七丐丟万上与丁丆;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_19;
        }
        
        if((this.丝且与丝丒丟万丁专.丗丘东专不下三丘业(三七丐丟万上与丁丆:  val_12)) == true)
        {
            goto label_20;
        }
        
        goto label_28;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_17:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_3:
        val_14 = 0;
        return (bool)val_14;
        label_18:
        WeaponSounds val_8 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_8.delayInBurstShooting);
        val_13 = 3;
        label_14:
        this.丗丏丅丕丆世丁专丟 = val_13;
        val_14 = 1;
        return (bool)val_14;
        label_19:
        val_12 = 0.丗丘东专不下三丘业(三七丐丟万上与丁丆:  val_12);
        if(val_12 == false)
        {
            goto label_28;
        }
        
        label_20:
        this.丝且与丝丒丟万丁专.丆丅一万丙丁丙丐丟();
        val_14 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_28:
        val_14 = 0;
        this.丝且与丝丒丟万丁专.万丈丌丌东东丄下上 = 0;
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
