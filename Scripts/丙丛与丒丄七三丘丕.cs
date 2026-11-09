using UnityEngine;
private sealed class GiftScroll.丙丛与丒丄七三丘丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftScroll 丝且与丝丒丟万丁专;
    public float 业与三万七丝不万东;
    public UnityEngine.Vector3 丛上丙丄丄七丈且丅;
    public UnityEngine.GameObject 万且万且丑丗且丌丆;
    public UnityEngine.AudioClip 东世丑世丛丞不专丕;
    private float 丅丑东不丞丑丝丟丅;
    private UnityEngine.Vector3 且丁丛业丛一丘丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftScroll.丙丛与丒丄七三丘丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_8;
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
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.丗三丝万丂丂丞七丟();
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_9;
        }
        
        goto label_6;
        label_3:
        val_8 = 0.丗三丝万丂丂丞七丟();
        label_4:
        UnityEngine.Coroutine val_3 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_8);
        float val_8 = this.业与三万七丝不万东;
        val_8 = val_8 * 5f;
        this.丅丑东不丞丑丝丟丅 = 0f;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = this.丛上丙丄丄七丈且丅, y = V8.16B, z = V9.16B});
        this.且丁丛业丛一丘丕东 = val_4;
        mem[1152921537837642672] = val_4.y;
        mem[1152921537837642676] = val_4.z;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        if(this.丝且与丝丒丟万丁专.专七丘丞不专丗丕丒 == false)
        {
            goto label_10;
        }
        
        GiftSpringPanelForSound val_5 = GiftSpringPanelForSound.BeginWithSound(丝三丁东丈丒世丅业:  this.万且万且丑丗且丌丆, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = this.且丁丛业丛一丘丕东, y = val_4.y, z = val_4.z}, 丛上丟丌丄丗丁世与:  1f, 丏世一不与丗丏三不:  this.东世丑世丛丞不专丕);
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_10:
        float val_9 = this.丅丑东不丞丑丝丟丅;
        if(val_9 < 0)
        {
                val_9 = val_9 + 0.05f;
            this.丅丑东不丞丑丝丟丅 = val_9;
        }
        
        GiftSpringPanelForSound val_6 = GiftSpringPanelForSound.BeginWithSound(丝三丁东丈丒世丅业:  this.万且万且丑丗且丌丆, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = this.且丁丛业丛一丘丕东, y = val_4.y, z = val_4.z}, 丛上丟丌丄丗丁世与:  val_9, 丏世一不与丗丏三不:  this.东世丑世丛丞不专丕);
        val_9 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_9;
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
