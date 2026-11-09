using UnityEngine;
private sealed class RewardParticlesReceiver.丙丏丘三上丏与丁丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RewardParticlesReceiver 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RewardParticlesReceiver.丙丏丘三上丏与丁丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_2;
        int val_3;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.enableOnRecive, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.enableOnRecive, 丏业丟一东丂东丘丛:  true);
        if(this.丝且与丝丒丟万丁专.onReciveAnimation != null)
        {
                this.丝且与丝丒丟万丁专.onReciveAnimation.Play();
        }
        
        this.丝且与丝丒丟万丁专.丑且业丕下丁丙丁下 = this.丝且与丝丒丟万丁专.enableTime;
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_8:
        if(this.丝且与丝丒丟万丁专.丑且业丕下丁丙丁下 > 0f)
        {
            goto label_9;
        }
        
        val_2 = this.丝且与丝丒丟万丁专.enableOnRecive;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_9:
        val_3 = 1;
        this.丝且与丝丒丟万丁专.丑且业丕下丁丙丁下 = -UnityEngine.Time.deltaTime;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
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
