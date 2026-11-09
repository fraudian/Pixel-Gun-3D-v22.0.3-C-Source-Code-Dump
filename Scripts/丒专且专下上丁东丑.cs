using UnityEngine;
private sealed class Player_move_c.丒专且专下上丁东丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    private float 丞东东专七丕丏一丙;
    private float 丐东专丆丌七下丕丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丒专且专下上丁东丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_12;
        int val_13;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_12 = this.丐东专丆丌七下丕丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丞东东专七丕丏一丙 = 0.5f;
        this.丐东专丆丌七下丕丞 = 0f;
        goto label_4;
        label_1:
        val_12 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丐东专丆丌七下丕丞 < 0)
        {
            goto label_4;
        }
        
        label_2:
        val_13 = 0;
        return (bool)val_13;
        label_4:
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专.东三上专丅东业丛丐().transform.position;
        UnityEngine.Vector3 val_5 = this.丝且与丝丒丟万丁专.myTransform.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  7.5f);
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = val_12 + val_8;
        mem2[0] = val_8;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  UnityEngine.Time.deltaTime);
        UnityEngine.CollisionFlags val_11 = this.丝且与丝丒丟万丁专.mySkinName.character.Move(motion:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_13 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
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
