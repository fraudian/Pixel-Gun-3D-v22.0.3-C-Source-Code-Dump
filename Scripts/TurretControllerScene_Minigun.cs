using UnityEngine;
internal sealed class TurretControllerScene_Minigun : TurretControllerScene_Tower
{
    // Fields
    public UnityEngine.ParticleSystem gunFlash;
    public ZeichenKraftwerk.Rotator rotator;
    public UnityEngine.AudioClip shotClip;
    public UnityEngine.Transform shotPoint;
    public UnityEngine.Transform shotPoint2;
    public UnityEngine.Vector3 maxSpeedRotator;
    public UnityEngine.Vector3 downSpeedRotator;
    public float dissipation;
    private UnityEngine.Coroutine 丞丐不丏一丘丁丕丞;
    
    // Methods
    protected override void 下专专专丄世丗且丐()
    {
        ZeichenKraftwerk.Rotator val_7;
        var val_8;
        float val_9;
        val_7 = this;
        this.下专专专丄世丗且丐();
        if((this.isActive != false) && (true != 0))
        {
                if(this.rotator == 0)
        {
                return;
        }
        
            if(S0 >= 0)
        {
                return;
        }
        
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.downSpeedRotator, y = V9.16B, z = V10.16B}, d:  UnityEngine.Time.deltaTime);
            val_8 = val_4.x;
            val_9 = val_4.z;
            this.rotator.eulersPerSecond = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_9;
            return;
        }
        
        if(this.rotator == 0)
        {
                return;
        }
        
        val_7 = this.rotator;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_8 = val_6.x;
        val_9 = val_6.z;
        this.rotator.eulersPerSecond = val_6;
        mem2[0] = val_6.y;
        mem2[0] = val_9;
    }
    public override void Deactivate()
    {
        this.Deactivate();
        this.rotator.enabled = false;
    }
    private System.Collections.IEnumerable 业且且丗丈东世丈不(float 丕丕世且下一与丝与)
    {
        TurretControllerScene_Minigun.丝丕丄上丛丕与下万 val_1 = new TurretControllerScene_Minigun.丝丕丄上丛丕与下万();
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[48] = this;
        }
        
        .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerable)val_1;
    }
    protected override void 丅丙业不丏丟丄丕丝()
    {
        float val_44;
        var val_46;
        var val_48;
        if(this.shotPoint2 == 0)
        {
                return;
        }
        
        if(this.shotPoint == 0)
        {
                return;
        }
        
        if(this.rotator != 0)
        {
                this.rotator.eulersPerSecond = this.maxSpeedRotator;
            mem2[0] = ???;
            mem2[0] = ???;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.rotator != 0)
        {
                this.rotator.PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        if(this.gunFlash != 0)
        {
                this.gunFlash.enableEmission = true;
            this.gunFlash.Play();
            this.gunFlash.gameObject.SetActive(value:  true);
        }
        
        if(this.丞丐不丏一丘丁丕丞 != null)
        {
                this.StopCoroutine(routine:  this.丞丐不丏一丘丁丕丞);
            this.丞丐不丏一丘丁丕丞 = 0;
        }
        
        val_44 = 0.1f;
        System.Collections.IEnumerable val_8 = this.业且且丗丈东世丈不(丕丕世且下一与丝与:  0.1f);
        var val_44 = 0;
        val_44 = val_44 + 1;
        this.丞丐不丏一丘丁丕丞 = this.StartCoroutine(routine:  val_8.GetEnumerator());
        if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_8))) != true)
        {
                val_44 = this.丐丕世丂上丐丑东丂() + 0.1f;
            mem[1152921540625580824] = val_44;
        }
        
        UnityEngine.Vector3 val_15 = this.shotPoint2.position;
        UnityEngine.Vector3 val_16 = this.shotPoint.position;
        UnityEngine.Vector3 val_18 = this.shotPoint2.position;
        UnityEngine.Vector3 val_19 = this.shotPoint.position;
        UnityEngine.Vector3 val_21 = this.shotPoint2.position;
        UnityEngine.Vector3 val_22 = this.shotPoint.position;
        float val_27 = (val_15.x - val_16.x) + (UnityEngine.Random.Range(min:  -this.dissipation, max:  this.dissipation));
        float val_28 = (val_18.y - val_19.y) + (UnityEngine.Random.Range(min:  -this.dissipation, max:  this.dissipation));
        float val_29 = (val_21.z - val_22.z) + (UnityEngine.Random.Range(min:  -this.dissipation, max:  this.dissipation));
        UnityEngine.Vector3 val_30 = this.shotPoint.position;
        UnityEngine.Vector3 val_31 = this.shotPoint.position;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  100f);
        UnityEngine.Color val_33 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, dir:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, color:  new UnityEngine.Color() {r = val_33.r, g = val_33.b, b = 1f}, duration:  0f);
        System.Collections.Generic.List<TSource> val_36 = System.Linq.Enumerable.ToList<UnityEngine.RaycastHit>(source:  UnityEngine.Physics.RaycastAll(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, maxDistance:  100f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.世丝上丁丐丘丗丈丏()));
        val_46 = null;
        val_46 = null;
        if((TurretControllerScene_Minigun.<>c.<>9__12_0) == null)
        {
            goto label_48;
        }
        
        label_60:
        val_36.Sort(comparison:  TurretControllerScene_Minigun.<>c.<>9__12_0);
        val_48 = 0;
        goto label_50;
        label_55:
        UnityEngine.RaycastHit val_37 = val_36.Item[0];
        丅丙上七上一丐不下 val_39 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(val_39 != null)
        {
                if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_39)) == true)
        {
            goto label_53;
        }
        
        }
        
        val_48 = 1;
        label_50:
        if(val_48 < val_36.Count)
        {
            goto label_55;
        }
        
        return;
        label_48:
        System.Comparison<UnityEngine.RaycastHit> val_42 = 1152921536275327056;
        val_42 = new System.Comparison<UnityEngine.RaycastHit>(object:  TurretControllerScene_Minigun.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TurretControllerScene_Minigun.<>c::业专不不丒丕丙与丄(UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂, UnityEngine.RaycastHit 丙专一丌丌丁不丈专));
        TurretControllerScene_Minigun.<>c.<>9__12_0 = val_42;
        if(val_36 != null)
        {
            goto label_60;
        }
        
        goto label_60;
        label_53:
        bool val_43 = this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  val_39);
    }
    public TurretControllerScene_Minigun()
    {
        this.dissipation = 0.015f;
        mem[1152921540625836168] = ;
        mem[1152921540625836184] = ;
        mem[1152921540625836204] = 1110704128;
        val_1 = new TurretControllerScene();
    }

}
