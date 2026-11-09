using UnityEngine;
private sealed class DelayAttackBotComponent.丑七丆且丞业丅下丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public DelayAttackBotComponent 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DelayAttackBotComponent.丑七丆且丞业丅下丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        UnityEngine.Animation val_7;
        int val_8;
        string val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        val_6 = this.丝且与丝丒丟万丁专;
        val_7 = this.丝且与丝丒丟万丁专.animations;
        goto label_5;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_4:
        val_6 = 88;
        val_7 = 0;
        label_5:
        丟丒下丙不丙上不丟 val_1 = this.丝且与丝丒丟万丁专.baseBot.万丙丞东丆上下丞丌();
        val_9 = val_1.专丅丟丏丂丅东丑万;
        if((val_7.IsPlaying(name:  val_9)) == true)
        {
            goto label_10;
        }
        
        丟丒下丙不丙上不丟 val_3 = this.丝且与丝丒丟万丁专.baseBot.万丙丞东丆上下丞丌();
        val_9 = val_3.丙丝丞一丏专丘丐丄;
        if((0.IsPlaying(name:  val_9)) == false)
        {
            goto label_14;
        }
        
        label_10:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_14:
        this.丝且与丝丒丟万丁专.<丘丒丛丁丄丗丞三上>k__BackingField = true;
        this.丝且与丝丒丟万丁专.<丆丑丞丕丑世丈丈丅>k__BackingField = true;
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
