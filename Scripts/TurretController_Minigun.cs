using UnityEngine;
internal sealed class TurretController_Minigun : TurretController_Tower
{
    // Fields
    public UnityEngine.ParticleSystem gunFlash;
    public ZeichenKraftwerk.Rotator rotator;
    public UnityEngine.AudioClip shotClip;
    public UnityEngine.Transform shotPoint;
    public UnityEngine.Transform shotPoint2;
    private float 东世万丒丝上一丈三;
    private float 丄丈丁丐丙业丛上下;
    private float 丕业丆丟丅丝专丕丌;
    private UnityEngine.Coroutine 丞丐不丏一丘丁丕丞;
    
    // Methods
    protected override void 下专专专丄世丗且丐()
    {
        this.下专专专丄世丗且丐();
        if(this.rotator == 0)
        {
                return;
        }
        
        if(S0 >= 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丄丈丁丐丙业丛上下 * val_2;
        float val_3 = S8 + val_2;
        this.rotator.eulersPerSecond = 0;
        mem2[0] = 0;
        mem2[0] = 0;
    }
    private System.Collections.IEnumerable 业且且丗丈东世丈不(float 丕丕世且下一与丝与)
    {
        TurretController_Minigun.丁丟上丈丏东丑万东 val_1 = new TurretController_Minigun.丁丟上丈丏东丑万东();
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
        var val_35;
        var val_36;
        var val_37;
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
                float val_34 = 0f;
            this.rotator.eulersPerSecond = 0;
            mem2[0] = 0;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.shotClip);
        }
        
        if(this.gunFlash != 0)
        {
                this.gunFlash.enableEmission = true;
            this.gunFlash.Play();
        }
        
        if(this.丞丐不丏一丘丁丕丞 != null)
        {
                this.StopCoroutine(routine:  this.丞丐不丏一丘丁丕丞);
            this.丞丐不丏一丘丁丕丞 = 0;
        }
        
        val_34 = val_34 * 1.1f;
        var val_35 = 0;
        val_35 = val_35 + 1;
        this.丞丐不丏一丘丁丕丞 = this.StartCoroutine(routine:  this.业且且丗丈东世丈不(丕丕世且下一与丝与:  val_34).GetEnumerator());
        val_35 = null;
        val_35 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_11 = this.shotPoint2.position;
        UnityEngine.Vector3 val_12 = this.shotPoint.position;
        UnityEngine.Vector3 val_14 = this.shotPoint2.position;
        UnityEngine.Vector3 val_15 = this.shotPoint.position;
        UnityEngine.Vector3 val_17 = this.shotPoint2.position;
        UnityEngine.Vector3 val_18 = this.shotPoint.position;
        float val_23 = (val_11.x - val_12.x) + (UnityEngine.Random.Range(min:  -this.丕业丆丟丅丝专丕丌, max:  this.丕业丆丟丅丝专丕丌));
        float val_24 = (val_14.y - val_15.y) + (UnityEngine.Random.Range(min:  -this.丕业丆丟丅丝专丕丌, max:  this.丕业丆丟丅丝专丕丌));
        float val_25 = (val_17.z - val_18.z) + (UnityEngine.Random.Range(min:  -this.丕业丆丟丅丝专丕丌, max:  this.丕业丆丟丅丝专丕丌));
        UnityEngine.Vector3 val_26 = this.shotPoint.position;
        UnityEngine.Vector3 val_27 = this.shotPoint.position;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  100f);
        UnityEngine.Color val_29 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, dir:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, color:  new UnityEngine.Color() {r = val_29.r, g = val_29.b, b = 1f}, duration:  null);
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  100f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丒丑丗一东丈万丅下())) == false)
        {
                return;
        }
        
        val_36 = null;
        val_36 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_37 = null;
            val_37 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        }
        
        丅丙上七上一丐不下 val_33 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(val_33 == null)
        {
                return;
        }
        
        this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  val_33);
    }
    public TurretController_Minigun()
    {
        this.东世万丒丝上一丈三 = -1000f;
        this.丄丈丁丐丙业丛上下 = 500f;
        this.丕业丆丟丅丝专丕丌 = 0.015f;
        mem[1152921540601440220] = ;
        mem[1152921540601440236] = 1130102784;
        val_1 = new TurretController();
    }

}
