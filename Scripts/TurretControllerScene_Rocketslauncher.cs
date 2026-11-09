using UnityEngine;
internal sealed class TurretControllerScene_Rocketslauncher : TurretControllerScene_Tower
{
    // Fields
    private UnityEngine.AudioClip shotClip;
    private UnityEngine.Transform[] shotPoints;
    private UnityEngine.GameObject rocketPrefab;
    private float rocketSpeed;
    private bool _simultaneousShooting;
    private UnityEngine.ParticleSystem[] gunFlashes;
    private int 丑上丒丏丐且上丄丘;
    private UnityEngine.BoxCollider 丕丈丝丐一丒三丕与;
    
    // Properties
    private float 丟上丝丞丄丞东丅与 { get; }
    
    // Methods
    private float 丕专丁世丝丁丛与三()
    {
        return 0f;
    }
    protected override void 丅丙业不丏丟丄丕丝()
    {
        if(this.shotPoints == null)
        {
                return;
        }
        
        if(this.shotPoints.Length == 0)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(137129984 != 0)
        {
                PlayOneShot(clip:  this.shotClip);
        }
        
        }
        
        if(this._simultaneousShooting != false)
        {
                this.丅丘丝丟丅丙上万丈();
            return;
        }
        
        this.丑业丕丐且丁七丒专();
    }
    private void 丅丘丝丟丅丙上万丈()
    {
        goto label_0;
        label_2:
        this.丄与丙丒专与丌东丑(丞世不丒下上上丝丑:  0);
        0 = 1;
        label_0:
        if(0 < this.shotPoints.Length)
        {
            goto label_2;
        }
    
    }
    private void 丑业丕丐且丁七丒专()
    {
        this.丄与丙丒专与丌东丑(丞世不丒下上上丝丑:  this.丑上丒丏丐且上丄丘);
        int val_1 = this.丑上丒丏丐且上丄丘 + 1;
        this.丑上丒丏丐且上丄丘 = val_1;
        int val_2 = this.shotPoints.Length;
        val_2 = val_2 - 1;
        if(val_1 <= val_2)
        {
                return;
        }
        
        this.丑上丒丏丐且上丄丘 = 0;
    }
    private void 丄与丙丒专与丌东丑(int 丞世不丒下上上丝丑)
    {
        var val_42;
        var val_43;
        Rilisoft.丏丏专丙世丝万丅且 val_44;
        float val_46;
        val_42 = this;
        if((this.gunFlashes != null) && (this.gunFlashes.Length != 0))
        {
                if(this.gunFlashes[(long)丞世不丒下上上丝丑] != 0)
        {
                this.gunFlashes[(long)丞世不丒下上上丝丑].enableEmission = true;
            this.gunFlashes[(long)丞世不丒下上上丝丑].gameObject.SetActive(value:  true);
            UnityEngine.ParticleSystem val_45 = this.gunFlashes[(long)丞世不丒下上上丝丑];
            val_45.Play();
        }
        
        }
        
        if((this.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_45))) != true)
        {
                float val_5 = this.丐丕世丂上丐丑东丂();
            val_5 = val_5 + 0.1f;
            mem[1152921540629515176] = val_5;
        }
        
        val_43 = 0;
        if(this.丕丈丝丐一丒三丕与 == 0)
        {
                this.丕丈丝丐一丒三丕与 = this.gameObject.GetComponent<UnityEngine.BoxCollider>();
        }
        
        if(this.shotPoints.Length <= 丞世不丒下上上丝丑)
        {
                val_43 = 0;
        }
        
        UnityEngine.Vector3 val_9 = this.shotPoints[(long)丞世不丒下上上丝丑].position;
        if(this.shotPoints.Length <= 丞世不丒下上上丝丑)
        {
                val_43 = 0;
        }
        
        UnityEngine.Quaternion val_10 = this.shotPoints[(long)丞世不丒下上上丝丑].rotation;
        UnityEngine.GameObject val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.rocketPrefab, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
        BaseMovementTurretRocket val_12 = val_11.GetComponent<BaseMovementTurretRocket>();
        BaseAttackTurretRocket val_13 = val_11.GetComponent<BaseAttackTurretRocket>();
        var val_14 = (W26 != 0) ? 1 : 0;
        var val_15 = (W23 != 0) ? 1 : 0;
        if(this.SplashRadius >= 0f)
        {
                float val_17 = this.SplashRadius;
        }
        
        val_44 = 0;
        if(this.丕丈丝丐一丒三丕与 != 0)
        {
                UnityEngine.BoxCollider val_19 = val_11.GetComponent<UnityEngine.BoxCollider>();
            val_44 = 0;
            if(val_19 != 0)
        {
                val_44 = 1;
            UnityEngine.Physics.IgnoreCollision(collider1:  this.丕丈丝丐一丒三丕与, collider2:  val_19, ignore:  true);
        }
        
        }
        
        if(this.shotPoints.Length <= 丞世不丒下上上丝丑)
        {
                val_44 = 0;
        }
        
        UnityEngine.Transform val_48 = this.shotPoints[(long)丞世不丒下上上丝丑];
        UnityEngine.Vector3 val_22 = val_48.forward;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  this.rocketSpeed);
        val_11.GetComponent<UnityEngine.Rigidbody>().velocity = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        if((System.String.IsNullOrEmpty(value:  val_48.丆丘丒东且丂与丂丑())) == true)
        {
            goto label_59;
        }
        
        string val_26 = val_48.丆丘丒东且丂与丂丑();
        val_44 = 0;
        if((val_26.Equals(value:  "Nuclear Area")) == true)
        {
            goto label_59;
        }
        
        string val_28 = val_26.丆丘丒东且丂与丂丑();
        val_44 = 0;
        if((val_28.Contains(value:  "Area")) == false)
        {
            goto label_59;
        }
        
        string val_30 = val_28.丆丘丒东且丂与丂丑();
        if((System.String.op_Equality(a:  val_30, b:  "Poison Area")) != true)
        {
                if((System.String.op_Equality(a:  val_30, b:  "Fire Area")) == false)
        {
            goto label_62;
        }
        
        }
        
        val_44 = 0;
        val_13.丕不丙丈与丅上丂业(三一丝且丝丛不丄丐:  val_30, 丒丂且不丅丞三丒世:  this.三丟丅不丅丅业丛丁());
        goto label_73;
        label_59:
        if((System.String.IsNullOrEmpty(value:  val_48.丆丘丒东且丂与丂丑())) != true)
        {
                float val_36 = this.三丟丅不丅丅业丛丁();
            mem[1152921540629514784] = val_36;
        }
        
        label_73:
        val_13.丞专业丗丟东丗三丏(东丏业丞丞业下丄世:  0, 三一丝且丝丛不丄丐:  val_44, 专丞丅丗丌丈且东丁:  0, 丗丝丂丕丑不丆丗丂:  val_36, 丒丙丘丕且一丞丕丑:  val_23.y);
        if(val_48.丕丗业丝万上丂且丝() > 0f)
        {
                float val_38 = this.丕丗业丝万上丂且丝();
        }
        else
        {
                val_46 = val_13.objectAfterDestroyLifetime;
        }
        
        val_13.objectAfterDestroyLifetime = val_46;
        return;
        label_62:
        if((System.String.op_Equality(a:  val_30, b:  "SlowDown Area")) == false)
        {
            goto label_70;
        }
        
        val_13.下专与三丗丂丒不丑(丂业丑丅与且三丐与:  this.三丟丅不丅丅业丛丁());
        goto label_73;
        label_70:
        if(val_30 == null)
        {
            goto label_73;
        }
        
        int val_41 = val_30.Length;
        goto label_73;
    }
    public TurretControllerScene_Rocketslauncher()
    {
        this.rocketSpeed = 30f;
        mem[1152921540629987592] = ;
        mem[1152921540629987608] = ;
        mem[1152921540629987628] = 1110704128;
        val_1 = new TurretControllerScene();
    }

}
