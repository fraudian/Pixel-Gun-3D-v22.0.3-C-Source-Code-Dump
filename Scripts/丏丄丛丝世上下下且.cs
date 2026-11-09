using UnityEngine;
private sealed class ShopShootingController.丏丄丛丝世上下下且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public ShopShootingController 丝且与丝丒丟万丁专;
    public string 丁下不下业世下丛丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopShootingController.丏丄丛丝世上下下且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_14;
        float val_15;
        int val_16;
        UnityEngine.GameObject val_17;
        val_14 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        val_15 = this.丕丕世且下一与丝与;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_15 <= 0f)
        {
            goto label_4;
        }
        
        val_16 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_15);
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = this.丝且与丝丒丟万丁专.不丐丐东丅一丛丙丛;
        UnityEngine.Object.Destroy(obj:  val_14);
        label_3:
        val_16 = 0;
        return (bool)val_16;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "OnGroundWeaponEffects/"("OnGroundWeaponEffects/") + this.丁下不下业世下丛丐 + "_OnGroundEffect"));
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_12;
        }
        
        this.丝且与丝丒丟万丁专.不丐丐东丅一丛丙丛 = val_4;
        if(val_4 != null)
        {
            goto label_35;
        }
        
        label_36:
        label_35:
        RayAndExplosionsStackItem val_5 = val_4.GetComponent<RayAndExplosionsStackItem>();
        if(val_5 == 0)
        {
            goto label_14;
        }
        
        val_15 = val_5.timeDeactivate;
        UnityEngine.Object.Destroy(obj:  val_5);
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_18;
        }
        
        label_20:
        val_17 = mem[this.丝且与丝丒丟万丁专 + 184];
        val_17 = this.丝且与丝丒丟万丁专 + 184;
        goto label_19;
        label_14:
        val_15 = 1f;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_20;
        }
        
        label_18:
        val_17 = mem[this.丝且与丝丒丟万丁专 + 184];
        val_17 = this.丝且与丝丒丟万丁专 + 184;
        label_19:
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_17, 不东丛三丂丌丑专丆:  this.丝且与丝丒丟万丁专.丁上丏世丛丙丗世丑);
        UnityEngine.Vector3 val_8 = this.丝且与丝丒丟万丁专.onGroundEffectPoint.position;
        this.丝且与丝丒丟万丁专 + 184.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  90f, y:  0f, z:  0f);
        this.丝且与丝丒丟万丁专 + 184.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        UnityEngine.ParticleSystem val_11 = this.丝且与丝丒丟万丁专 + 184.GetComponent<UnityEngine.ParticleSystem>();
        if(val_11 != 0)
        {
                val_11.Play();
        }
        
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_15);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_16 = 1;
        return (bool)val_16;
        label_12:
        mem[184] = val_4;
        if(mem[184] != 0)
        {
            goto label_35;
        }
        
        goto label_36;
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
