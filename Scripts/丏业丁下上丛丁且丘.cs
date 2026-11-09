using UnityEngine;
private sealed class GeneratorControllerScene_DamageBuff.丏业丁下上丛丁且丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GeneratorControllerScene_DamageBuff 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GeneratorControllerScene_DamageBuff.丏业丁下上丛丁且丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        WeaponManager val_11;
        var val_12;
        var val_13;
        float val_14;
        var val_15;
        var val_16;
        if(this.丗丏丅丕丆世丁专丟 > 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = null;
        val_10 = null;
        val_11 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_11 == 0)
        {
            goto label_12;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_11 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_11 == 0)
        {
            goto label_12;
        }
        
        val_13 = null;
        val_13 = null;
        UnityEngine.Vector3 val_4 = transform.position;
        val_11 = this.丝且与丝丒丟万丁专.丅专与丒丈丗丒丘丌;
        UnityEngine.Vector3 val_5 = val_11.position;
        val_14 = val_4.x;
        if(0 == 0)
        {
            goto label_22;
        }
        
        float val_7 = 0.不七不丈丐万丂丌下();
        goto label_23;
        label_1:
        val_15 = 0;
        return (bool)val_15;
        label_22:
        val_14 = 0f;
        label_23:
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_14, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) <= val_14)
        {
            goto label_25;
        }
        
        label_12:
        label_30:
        val_15 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_15;
        label_25:
        val_16 = null;
        val_16 = null;
        丞业丁丐丒丒丈一丅(世丁万下丗专世万丅:  true, 丌东世丞世丆丄丑三:  this.丝且与丝丒丟万丁专.下与丗丒丐三丕丘丈(), 下且一丒东丞下七丐:  this.丝且与丝丒丟万丁专.丑丗丘与丈不七东丛);
        float val_10 = -0.1f;
        val_10 = this.丝且与丝丒丟万丁专.丑丗丘与丈不七东丛 + val_10;
        null = new UnityEngine.WaitForSeconds(seconds:  val_10);
        goto label_30;
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
