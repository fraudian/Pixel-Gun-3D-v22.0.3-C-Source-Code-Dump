using UnityEngine;
private sealed class SunWay.专且丐丅丑丘丝丛丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SunWay 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SunWay.专且丐丅丑丘丝丛丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SunWay val_17;
        int val_18;
        var val_19;
        var val_20;
        val_17 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_18 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_17 = this.丝且与丝丒丟万丁专;
        val_19 = null;
        val_19 = null;
        if((UnityEngine.Object.op_Implicit(exists:  丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专)) == false)
        {
            goto label_8;
        }
        
        val_20 = null;
        val_20 = null;
        UnityEngine.Vector3 val_4 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
        UnityEngine.Vector3 val_6 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4.x, y:  val_6.z);
        UnityEngine.Vector3 val_9 = val_17.transform.position;
        UnityEngine.Vector3 val_11 = val_17.transform.position;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_9.x, y:  val_11.z);
        float val_13 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        if(val_17 == null)
        {
            goto label_21;
        }
        
        this.丝且与丝丒丟万丁专.丙三世东东丙上丂世 = val_13;
        goto label_22;
        label_8:
        val_18 = 0;
        return (bool)val_18;
        label_21:
        mem[56] = val_13;
        label_22:
        UnityEngine.Vector3 val_16 = val_17.transform.GetChild(index:  0).localScale;
        val_18 = 0;
        this.丝且与丝丒丟万丁专.七下下丑丁丘万丟世 = val_16.y;
        return (bool)val_18;
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
