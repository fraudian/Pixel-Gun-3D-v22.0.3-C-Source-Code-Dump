using UnityEngine;
private sealed class Rocket.丌一丞万丒三丙丂丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.Collider 专不丑且不丏东丟丅;
    public Rocket 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.丌一丞万丒三丙丂丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.专不丑且不丏东丟丅 == 0)
        {
            goto label_13;
        }
        
        label_12:
        if(this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上 != 0)
        {
            goto label_9;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_9:
        if(this.丝且与丝丒丟万丁专.万丂一万丙丌不丘一 != true)
        {
                this.丝且与丝丒丟万丁专.万丂一万丙丌不丘一 = true;
            this.丝且与丝丒丟万丁专.一丑丝丛丘下上丈三(丁丙丈上一丘下丘丆:  true);
            UnityEngine.Transform val_3 = this.专不丑且不丏东丟丅.transform;
            this.丝且与丝丒丟万丁专.七丙丝丐东下丟丒业 = val_3;
            UnityEngine.Vector3 val_4 = val_3.position;
            this.丝且与丝丒丟万丁专.不丘一一丏丗下丕上 = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
            this.丝且与丝丒丟万丁专.七下丒万丐丅丝丕丅();
            this.丝且与丝丒丟万丁专.丈丝业业丐丟下七丈();
            bool val_5 = this.丝且与丝丒丟万丁专.一丏七丁且与丛丑丏(专不丑且不丏东丟丅:  this.专不丑且不丏东丟丅);
        }
        
        label_13:
        val_6 = 0;
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
