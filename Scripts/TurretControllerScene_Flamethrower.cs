using UnityEngine;
internal sealed class TurretControllerScene_Flamethrower : TurretControllerScene_Tower
{
    // Fields
    public UnityEngine.ParticleSystem gunFlash;
    public UnityEngine.AudioClip shotClip;
    public UnityEngine.Transform shotPoint;
    public UnityEngine.Transform shotPoint2;
    public float damageAngle;
    private UnityEngine.Coroutine 丞丐不丏一丘丁丕丞;
    
    // Methods
    private System.Collections.IEnumerable 业且且丗丈东世丈不(float 丕丕世且下一与丝与)
    {
        TurretControllerScene_Flamethrower.世丆丏且丄丌丆且丌 val_1 = new TurretControllerScene_Flamethrower.世丆丏且丄丌丆且丌(丗丏丅丕丆世丁专丟:  -2);
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
        float val_38;
        float val_39;
        float val_42;
        var val_43;
        val_35 = this;
        if(this.shotPoint2 == 0)
        {
                return;
        }
        
        if(this.shotPoint == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.shotPoint != 0)
        {
                this.shotPoint.PlayOneShot(clip:  this.shotClip);
        }
        
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
        
        val_36 = 0.1f;
        System.Collections.IEnumerable val_6 = this.业且且丗丈东世丈不(丕丕世且下一与丝与:  0.1f);
        var val_38 = 0;
        val_38 = val_38 + 1;
        this.丞丐不丏一丘丁丕丞 = this.StartCoroutine(routine:  val_6.GetEnumerator());
        丅丙上七上一丐不下 val_10 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_6);
        bool val_11 = this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_10);
        if(val_11 != true)
        {
                if(val_11 != false)
        {
                float val_12 = val_11.丟一丞丗业三丁上东();
        }
        else
        {
                val_38 = 0.15f;
        }
        
            val_39 = val_38 + 0.1f;
            mem[1152921540623013960] = val_39;
            this.丐万丙专丟丒丙与丂(丘业丝下丑丈且东丒:  val_10);
        }
        
        UnityEngine.Vector3 val_13 = this.shotPoint2.position;
        UnityEngine.Vector3 val_14 = this.shotPoint.position;
        UnityEngine.Vector3 val_15 = this.shotPoint2.position;
        UnityEngine.Vector3 val_16 = this.shotPoint.position;
        UnityEngine.Vector3 val_17 = this.shotPoint2.position;
        UnityEngine.Vector3 val_18 = this.shotPoint.position;
        float val_19 = val_13.x - val_14.x;
        float val_20 = val_15.y - val_16.y;
        val_18.z = val_17.z - val_18.z;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_22 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  true, 丅七上一丈丕上丒丞:  this.shotClip).世且一丄且上丄不一();
        label_62:
        var val_39 = 0;
        val_39 = val_39 + 1;
        if(val_22.MoveNext() == false)
        {
            goto label_42;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        T val_26 = val_22.Current;
        UnityEngine.Vector3 val_27 = val_26.position;
        UnityEngine.Vector3 val_28 = this.shotPoint.position;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        float val_31 = this.丌丆万丛万丞丙下三();
        val_31 = this.丌丆万丛万丞丙下三() * val_31;
        if(val_29.x > val_31)
        {
            goto label_62;
        }
        
        val_42 = 0f;
        float val_34 = (UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished == 0) ? 0 : UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished.七与万且专丁丝丘丈();
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z})) >= 0)
        {
            goto label_62;
        }
        
        丅丙上七上一丐不下 val_35 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_26);
        if(val_35 == null)
        {
            goto label_62;
        }
        
        bool val_36 = this.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  val_35);
        goto label_62;
        label_42:
        val_43 = 0;
        val_35 = 0;
        if(val_22 == null)
        {
            
        }
        else
        {
                var val_41 = 0;
            val_41 = val_41 + 1;
            val_22.Dispose();
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
    public TurretControllerScene_Flamethrower()
    {
        this.damageAngle = 45f;
    }

}
