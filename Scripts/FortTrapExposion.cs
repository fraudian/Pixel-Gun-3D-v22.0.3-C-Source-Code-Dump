using UnityEngine;
internal class FortTrapExposion : FortTrap
{
    // Fields
    private bool _slowTarget;
    public UnityEngine.GameObject objectAfterDestroy;
    public float objectAfterDestroyLifetime;
    private WeaponSounds.丏专丐且丘丌丛不丁 _typeDead;
    private float _poisonDamageMultipier;
    private float _poisonHitsDelay;
    private string _nameExplosion;
    private System.Collections.Generic.List<UnityEngine.Transform> 丏丞专业丑丆丒丙丄;
    
    // Methods
    public override void DetectedTarget()
    {
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  1000f, 丞丗且下世丐业丌丙:  0, 丐丟丘世丁三丕专专:  0);
    }
    private void 丁丛丏上一业七上丁()
    {
        float val_26;
        float val_27;
        float val_28;
        float val_30;
        float val_31;
        var val_32;
        var val_33;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W21, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        label_37:
        var val_25 = 0;
        val_25 = val_25 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        T val_6 = val_2.Current;
        UnityEngine.Vector3 val_7 = val_6.position;
        UnityEngine.Vector3 val_9 = this.transform.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_26 = 0f;
        if(val_10.x == 0)
        {
            goto label_17;
        }
        
        val_27 = val_10.x.不七不丈丐万丂丌下();
        if(val_10.x == 0)
        {
            goto label_19;
        }
        
        val_26 = val_10.x.不七不丈丐万丂丌下();
        goto label_19;
        label_17:
        val_27 = 0f;
        label_19:
        val_28 = val_27 * val_26;
        if(val_10.x < 0)
        {
                丅丙上七上一丐不下 val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_6);
            if(val_13 != null)
        {
                UnityEngine.Vector3 val_16 = this.transform.position;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_28 = this.下与丗丒丐三丕丘丈();
            val_13.ApplyDamage(丞丈专下丈专业三丞:  val_28, 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), 丒丈丐丐丗丐专丈丏:  0);
        }
        
        }
        
        val_30 = 0f;
        if(val_10.x == 0)
        {
            goto label_31;
        }
        
        val_31 = val_10.x.七与万且专丁丝丘丈();
        if(val_10.x == 0)
        {
            goto label_33;
        }
        
        val_30 = val_10.x.七与万且专丁丝丘丈();
        goto label_33;
        label_31:
        val_31 = 0f;
        label_33:
        float val_22 = val_31 * val_30;
        if(val_28 >= 0)
        {
            goto label_37;
        }
        
        this.丟丌丞丗丛丘丑不丅(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_6));
        goto label_37;
        label_7:
        val_32 = 0;
        val_33 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    private void 丟丌丞丗丛丘丑不丅(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        var val_9;
        object val_10;
        var val_12;
        var val_15;
        var val_16;
        WeaponManager val_17;
        val_10 = this;
        if(this._slowTarget == false)
        {
                return;
        }
        
        val_9 = 1152921505066536960;
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_4;
        }
        
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        val_9 = 1152921505352957952;
        float val_2 = this.三丟丅不丅丅业丛丁();
        val_2 = 1f - val_2;
        val_12 = null;
        val_10 = val_2;
        val_12 = null;
        goto label_11;
        label_4:
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        if(丂丈丙且丈丗三丆丕 == null)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(丂丈丙且丈丗三丆丕 != typeof(Player_move_c).__il2cppRuntimeField_600)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_27;
        }
        
        val_17 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_17 == null)
        {
            goto label_28;
        }
        
        label_27:
        与东丁业丁与且丌丕(丞下万上三丘上与专:  typeof(Player_move_c).__il2cppRuntimeField_628.gameObject, 七丏上不丒万丐东丄:  V8.16B, 三上丅丈丄不丌万丙:  1f - this.三丟丅不丅丅业丛丁());
        return;
        label_11:
        ApplyDebuffByMode(丁丅丈丌丟世丗丗丟:  0, 丘七丛丂专丅丛业丑:  V8.16B, 业与丑丑丁丝丏丗世:  val_2);
        return;
        label_28:
    }
    public override void StartDeactivate()
    {
        if(true != 0)
        {
                return;
        }
        
        mem[1152921537224687444] = 1;
        if(137105408 != 0)
        {
                SetActive(value:  false);
        }
        
        this.Invoke(methodName:  "DeactivateDelayed", time:  null);
        this.丁丛丏上一业七上丁();
        UnityEngine.GameObject val_3 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  this._nameExplosion));
        UnityEngine.Vector3 val_5 = this.transform.position;
        this.丞丌丏丂丟东丕丞不(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_9 = this.transform.position;
        val_3.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
    }
    private void 丞丌丏丂丟东丕丞不(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_13;
        float val_14;
        UnityEngine.GameObject val_15;
        float val_16;
        var val_18;
        val_13 = 业丒丝丗与丐丛丟丏.z;
        val_14 = 业丒丝丗与丐丛丟丏.x;
        val_15 = this.objectAfterDestroy;
        if(val_15 == 0)
        {
                return;
        }
        
        val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.objectAfterDestroy);
        val_15.transform.position = new UnityEngine.Vector3() {x = val_14, y = 业丒丝丗与丐丛丟丏.y, z = val_13};
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        val_13 = val_5.x;
        val_14 = val_5.z;
        val_16 = val_13;
        val_15.transform.rotation = new UnityEngine.Quaternion() {x = val_16, y = val_5.y, z = val_14, w = val_5.w};
        DamageInRadiusEffect val_6 = val_15.GetComponent<DamageInRadiusEffect>();
        if(val_6 == 0)
        {
            goto label_13;
        }
        
        val_18 = this;
        if(this == null)
        {
            goto label_14;
        }
        
        val_13 = this.七与万且专丁丝丘丈();
        goto label_15;
        label_13:
        val_18 = 1152921537224852576;
        goto label_16;
        label_14:
        val_13 = 0f;
        label_15:
        val_14 = this._poisonHitsDelay;
        val_16 = this.下与丗丒丐三丕丘丈() * this._poisonDamageMultipier;
        val_6.丆丌且丙丝不万丂丆(丒下世丝丂万丑丏下:  val_16, 万丗丛丐丅丄七不丅:  val_13, 丂三丟丂丈丐丆丗丟:  val_14, 丝三丛且丘不丌丙下:  X22, 东丏业丞丞业下丄世:  this._typeDead, 丅业下不东丗丄与三:  20);
        val_6.下丞与与三上丟丙与(专丒丗与东丗与丙业:  true, 世一丅丌专丕东丑丗:  (this != 0) ? 1 : 0);
        label_16:
        if(this.丕丗业丝万上丂且丝() <= 0f)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  val_15, t:  this.丕丗业丝万上丂且丝());
    }
    internal override void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        this.上丛丌丆丑上七世三(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
        if(this == null)
        {
                return;
        }
        
        this._slowTarget = false;
        string val_1 = this.丆丘丒东且丂与丂丑();
        if((System.String.op_Equality(a:  val_1, b:  "SlowDown")) != true)
        {
                if((System.String.op_Equality(a:  val_1, b:  "SlowDown Area")) == false)
        {
                return;
        }
        
        }
        
        this._slowTarget = true;
    }
    public FortTrapExposion()
    {
        this.objectAfterDestroyLifetime = -1f;
        this._nameExplosion = "Explosion47";
        this.丏丞专业丑丆丒丙丄 = new System.Collections.Generic.List<UnityEngine.Transform>();
        mem[1152921537225126016] = 1073741824;
        mem[1152921537225126040] = 1073741824;
        this = new FortEquipObject();
    }

}
