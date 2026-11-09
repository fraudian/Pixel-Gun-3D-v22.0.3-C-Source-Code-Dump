using UnityEngine;
private sealed class Player_move_c.丛丏丝七丏七三丐与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丛丏丝七丏七三丐与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Vector3 val_1 = this.丝且与丝丒丟万丁专.myPlayerTransform.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  UnityEngine.Random.Range(min:  49f, max:  98f));
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.丝且与丝丒丟万丁专.myPlayerTransform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        label_3:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Random.Range(min:  21f, max:  39f));
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_2:
        val_8 = 0;
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
