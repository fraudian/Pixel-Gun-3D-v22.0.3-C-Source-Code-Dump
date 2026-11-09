using UnityEngine;
private sealed class ShopShootingController.丘丁丟丆丏丈丐丙下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ShopShootingController 丝且与丝丒丟万丁专;
    public int 丂下丁上丌丕丒丙丄;
    public float 业丒三且三万丐丟上;
    public float 丝丗业丘丏与上东丆;
    private UnityEngine.GameObject 丛万丗丏丞上丟下与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopShootingController.丘丁丟丆丏丈丐丙下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_32;
        int val_33;
        int val_34;
        UnityEngine.Object val_35;
        float val_37;
        WeaponSounds val_38;
        val_32 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_33 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_33;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.isDoubleShoot2Rockets == false) || (this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.bazookaRandomRockets == null))
        {
            goto label_7;
        }
        
        goto label_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_32 = this.丛万丗丏丞上丟下与;
        UnityEngine.Object.Destroy(obj:  val_32);
        goto label_14;
        label_7:
        val_34 = this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.rocketNum;
        label_11:
        if(this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.isDoubleShoot2Rockets == false)
        {
            goto label_17;
        }
        
        label_69:
        val_35 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Rockets/Rocket_"("Rockets/Rocket_") + val_34.ToString());
        if(val_35 != 0)
        {
            goto label_20;
        }
        
        label_14:
        val_33 = 0;
        return (bool)val_33;
        label_20:
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_35);
        this.丛万丗丏丞上丟下与 = val_5;
        val_35 = this.丛万丗丏丞上丟下与.AddComponent<UnityEngine.Rigidbody>();
        UnityEngine.Vector3 val_9 = this.丝且与丝丒丟万丁专.东丂七丆且丞丟丕东(丘丌丆上丞万丒与与:  this.丂下丁上丌丕丒丙丄);
        this.丛万丗丏丞上丟下与.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_13 = this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.gameObject.transform.rotation;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(x:  0f, y:  this.业丒三且三万丐丟上, z:  0f);
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w}, rhs:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w});
        val_37 = val_15.z;
        this.丛万丗丏丞上丟下与.transform.rotation = new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_37, w = val_15.w};
        UnityEngine.TrailRenderer val_16 = this.丛万丗丏丞上丟下与.GetComponentInChildren<UnityEngine.TrailRenderer>();
        if(val_16 != 0)
        {
                val_16.Clear();
        }
        
        this.丛万丗丏丞上丟下与.SetActive(value:  true);
        if(val_6.typeFly != 27)
        {
                if(val_6.typeFly != 13)
        {
            goto label_41;
        }
        
        }
        
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  UnityEngine.Mathf.Lerp(a:  val_6.chargeScaleMin, b:  val_6.chargeScaleMax, t:  this.丝丗业丘丏与上东丆));
        val_37 = val_21.z;
        this.丛万丗丏丞上丟下与.transform.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_37};
        label_41:
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丛万丗丏丞上丟下与, 不东丛三丂丌丑专丆:  this.丝且与丝丒丟万丁专.丁上丏世丛丙丗世丑);
        val_35.mass = 0.15f;
        UnityEngine.Vector3 val_25 = this.丛万丗丏丞上丟下与.transform.forward;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  ((this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.三专丏丘丟丞与与下() != true) ? 50f : 1f) * (val_5.GetComponent<RocketSettings>().与丕丒丂丗一且不丁()));
        val_35.AddForce(force:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, mode:  0);
        val_35.useGravity = (this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.grenadeLauncher == true) ? 1 : 0;
        val_33 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.rocketLifeTime);
        this.丗丏丅丕丆世丁专丟 = val_33;
        return (bool)val_33;
        label_17:
        if((this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.bazookaRandomRockets == null) || (this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.bazookaRandomRockets.Length == 0))
        {
            goto label_69;
        }
        
        val_38 = this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七;
        if(this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七 != null)
        {
            goto label_64;
        }
        
        val_38 = this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七;
        if(val_38 == null)
        {
            goto label_65;
        }
        
        label_64:
        int val_32 = this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.bazookaRandomRockets[(long)UnityEngine.Random.Range(min:  0, max:  this.丝且与丝丒丟万丁专.丆业七丌丁丕一丐七.bazookaRandomRockets.Length)];
        goto label_69;
        label_65:
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
