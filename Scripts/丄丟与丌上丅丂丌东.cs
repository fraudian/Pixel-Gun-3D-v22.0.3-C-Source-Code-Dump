using UnityEngine;
private sealed class MiniMapController.丄丟与丌上丅丂丌东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MiniMapController 丝且与丝丒丟万丁专;
    public UnityEngine.Transform 不万且三丏丆丑丕且;
    public float 丞丏业丂丏七丛丝专;
    public float 丝业丏丄且丌业世丛;
    private float 丌丙三丂丒业一丂一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MiniMapController.丄丟与丌上丅丂丌东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        float val_4;
        float val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_3 = this;
        this.丌丙三丂丒业一丂一 = 1f;
        this.丗丏丅丕丆世丁专丟 = 0;
        0.丅七且东丟专世丁丐(丆丐三三丏丘丈专丆:  this.不万且三丏丆丑丕且, 丝丕丁丏丏上丅丏且:  1f);
        goto label_6;
        label_0:
        val_3 = this;
        val_4 = this.丌丙三丂丒业一丂一;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_1:
        val_3 = this.丌丙三丂丒业一丂一;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_6;
        label_10:
        float val_3 = this.丞丏业丂丏七丛丝专;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_3 * val_1;
        val_3 = S9 + val_1;
        this.丌丙三丂丒业一丂一 = val_3;
        0.丅七且东丟专世丁丐(丆丐三三丏丘丈专丆:  this.不万且三丏丆丑丕且, 丝丕丁丏丏上丅丏且:  val_3);
        val_5 = this.丝业丏丄且丌业世丛;
        if(this.丌丙三丂丒业一丂一 <= val_5)
        {
            goto label_8;
        }
        
        this.丌丙三丂丒业一丂一 = val_5;
        0.丅七且东丟专世丁丐(丆丐三三丏丘丈专丆:  this.不万且三丏丆丑丕且, 丝丕丁丏丏上丅丏且:  val_5);
        label_6:
        val_4 = this.丌丙三丂丒业一丂一;
        if(val_4 < 0)
        {
            goto label_10;
        }
        
        label_5:
        val_5 = 1f;
        if(val_4 <= val_5)
        {
            goto label_11;
        }
        
        label_15:
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丞丏业丂丏七丛丝专 * val_2;
        val_4 = val_4 - val_2;
        mem2[0] = val_4;
        0.丅七且东丟专世丁丐(丆丐三三丏丘丈专丆:  this.不万且三丏丆丑丕且, 丝丕丁丏丏上丅丏且:  val_4);
        if(val_3 >= 0)
        {
            goto label_13;
        }
        
        mem2[0] = 1065353216;
        0.丅七且东丟专世丁丐(丆丐三三丏丘丈专丆:  this.不万且三丏丆丑丕且, 丝丕丁丏丏上丅丏且:  val_5);
        if(val_3 > val_5)
        {
            goto label_15;
        }
        
        label_11:
        val_6 = 0;
        this.丝且与丝丒丟万丁专.世世丕与丁丌丆业七 = 0;
        return (bool)val_6;
        label_2:
        val_6 = 0;
        return (bool)val_6;
        label_13:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
        label_8:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
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
