using UnityEngine;
private sealed class TurretControllerScene_PoisonPlant.专七万世不丞丄丟丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretControllerScene_PoisonPlant 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretControllerScene_PoisonPlant.专七万世不丞丄丟丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TurretControllerScene_PoisonPlant val_33;
        int val_34;
        var val_35;
        float val_36;
        var val_37;
        float val_39;
        val_33 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_34 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_34;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_35 = null;
        val_35 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_8;
        }
        
        if(val_33 != null)
        {
            goto label_9;
        }
        
        val_36 = 0.丐丕世丂上丐丑东丂() + 0.1f;
        mem[584] = val_36;
        mem[128] = 123372880;
        goto label_19;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_24;
        label_8:
        val_37 = null;
        val_37 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == typeof(Player_move_c).__il2cppRuntimeField_378)
        {
            goto label_19;
        }
        
        label_9:
        val_36 = val_33.丐丕世丂上丐丑东丂() + 0.1f;
        mem2[0] = val_36;
        label_19:
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                if((UnityEngine.TrackedReference.op_Inequality(x:  Item["turret_shoot"], y:  0)) != false)
        {
                UnityEngine.AnimationState val_8 = Item["turret_shoot"];
            float val_11 = val_33.丐丕世丂上丐丑东丂();
            val_11 = typeof(Player_move_c).__il2cppRuntimeField_378.Item["turret_shoot"].length / val_11;
            val_11 = val_11 + val_11;
            val_8.speed = val_11;
            bool val_12 = val_8.Play(animation:  "turret_shoot");
            val_39 = val_33.丐丕世丂上丐丑东丂();
            丕世专丒丁不丁丅丁 val_14 = null;
            float val_33 = 0.25f;
            val_33 = val_39 * val_33;
            val_33 = val_14;
            val_14 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  val_33);
            val_34 = 1;
            this.丒上七丌业七丟与丐 = val_33;
            this.丗丏丅丕丆世丁专丟 = val_34;
            return (bool)val_34;
        }
        
        }
        
        label_24:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_33;
        }
        
        if(this == 0)
        {
            goto label_39;
        }
        
        this.PlayOneShot(clip:  this.丝且与丝丒丟万丁专.shotClip);
        goto label_39;
        label_33:
        if(val_33 == null)
        {
            goto label_60;
        }
        
        label_39:
        label_60:
        UnityEngine.Vector3 val_17 = this.丝且与丝丒丟万丁专.shotPoint.right;
        UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.AngleAxis(angle:  this.丝且与丝丒丟万丁专.angle, axis:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector3 val_19 = this.丝且与丝丒丟万丁专.shotPoint.forward;
        UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w}, point:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Vector3 val_21 = this.丝且与丝丒丟万丁专.shotPoint.position;
        UnityEngine.Quaternion val_23 = val_33.transform.rotation;
        UnityEngine.GameObject val_24 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.chargePrefab, position:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, rotation:  new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w});
        TurretRocketControllerScene val_25 = val_24.GetComponent<TurretRocketControllerScene>();
        if(val_25 != null)
        {
                val_25.fortObjectName = null;
            val_25.且丝业丙丁丂万丞与 = 1152921526057697296;
        }
        else
        {
                mem[72] = ???;
            val_25.且丝业丙丁丂万丞与 = ;
        }
        
        val_25.丌不且专丘丆丞丂丟 = val_33;
        val_25.splashRadius = val_33.SplashRadius;
        val_25.SetTarget(丞下万上三丘上与专:  0);
        val_25.丝丏丗丘丞丄丘丅且(丟丞一专丕三东丗一:  this.丝且与丝丒丟万丁专.chargeSpeed);
        UnityEngine.Rigidbody val_28 = val_24.GetComponent<UnityEngine.Rigidbody>();
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丝且与丝丒丟万丁专.chargeSpeed, y = -1f, z = val_21.z}, d:  this.丝且与丝丒丟万丁专.chargeSpeed);
        val_39 = val_29.x;
        val_28.velocity = new UnityEngine.Vector3() {x = val_39, y = val_29.y, z = val_29.z};
        if((System.String.op_Equality(a:  val_28.丆丘丒东且丂与丂丑(), b:  "Poison")) != false)
        {
                val_25.typeDead = "Poison";
            val_25.三一丝且丝丛不丄丐 = 1;
            val_25.poisonHitsCount = "Poison";
            val_25.poisonHitsDelay = 1f;
            val_34 = 0;
            val_25.poisonDamageMultipier = val_33.三丟丅不丅丅业丛丁();
            return (bool)val_34;
        }
        
        val_34 = 0;
        return (bool)val_34;
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
