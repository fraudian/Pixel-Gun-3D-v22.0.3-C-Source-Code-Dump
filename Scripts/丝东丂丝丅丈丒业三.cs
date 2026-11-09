using UnityEngine;
private sealed class RewardParticlesSource.丝东丂丝丅丈丒业三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RewardParticlesSource 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RewardParticlesSource.丝东丂丝丅丈丒业三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_5;
        var val_6;
        float val_7;
        int val_8;
        float val_9;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.countHolder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.countLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "+{0}", arg0:  this.丝且与丝丒丟万丁专.丕丟丈丙丟丅丟丑七.丂丁丏一丙丛业且丌()));
        this.丝且与丝丒丟万丁专.丘不不专下丒世丙不 = this.丝且与丝丒丟万丁专.showCountTime;
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        label_7:
        val_6 = this.丝且与丝丒丟万丁专;
        val_7 = this.丝且与丝丒丟万丁专.丘不不专下丒世丙不;
        if(val_7 > 0f)
        {
            goto label_9;
        }
        
        label_14:
        val_5 = this.丝且与丝丒丟万丁专.countHolder;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_9:
        val_9 = UnityEngine.Time.deltaTime;
        goto label_13;
        label_8:
        if(0f <= 0f)
        {
            goto label_14;
        }
        
        val_6 = 172;
        val_7 = 0f;
        float val_4 = UnityEngine.Time.deltaTime;
        val_9 = val_4;
        label_13:
        val_4 = val_7 - val_9;
        val_8 = 1;
        mem[172] = val_4;
        this.丒上七丌业七丟与丐 = 0;
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
