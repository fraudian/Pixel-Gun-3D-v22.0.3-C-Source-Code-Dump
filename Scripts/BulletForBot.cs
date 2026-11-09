using UnityEngine;
internal sealed class BulletForBot : MonoBehaviour
{
    // Fields
    private float 丒万不且且万丒丙一;
    private UnityEngine.Vector3 丆丁世一三丆丆三专;
    private bool 一与专七丛与丏丟专;
    private bool 丗丟丕一丏丐丙丛丗;
    private float 上丏丗丛丛丞丏丂丁;
    private UnityEngine.Vector3 丗丌上丁一丛一万丄;
    private bool 丂丘且丝丙上业世丙;
    public float radius;
    public float forceImpulse;
    public float minForcePercent;
    public float maxForcePercent;
    public float lifeTime;
    private UnityEngine.Transform 专专丏下丐丂丂丅东;
    private bool <丟丕丁不丁七世下一>k__BackingField;
    private bool <丆丗下丙东七三下丄>k__BackingField;
    private BulletForBot.东世丌丗丂丛丂丑下 丂丆丂丕与且与万七;
    private UnityEngine.Rigidbody 万丒丅丞上丟丑丄万;
    private RilisoftBot.BaseBot 丟丙丈七丗且丞丏丞;
    
    // Properties
    public bool 丄丅丄世丛丟丞丗丂 { get; set; }
    public bool 业万七东丂丆丝丄下 { get; set; }
    private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    
    // Methods
    public bool get_needDestroyByStop()
    {
        return (bool)this.<丟丕丁不丁七世下一>k__BackingField;
    }
    public void set_needDestroyByStop(bool 丙业与丙丗丝不丈东)
    {
        this.<丟丕丁不丁七世下一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 丌七专东丂不丅专丑(bool 丙业与丙丗丝不丈东)
    {
        this.<丆丗下丙东七三下丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_IsUse()
    {
        return (bool)this.<丆丗下丙东七三下丄>k__BackingField;
    }
    public void add_OnBulletDamage(BulletForBot.东世丌丗丂丛丂丑下 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丂丆丂丕与且与万七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丂丆丂丕与且与万七 != 1152921536444922088);
    
    }
    public void remove_OnBulletDamage(BulletForBot.东世丌丗丂丛丂丑下 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丂丆丂丕与且与万七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丂丆丂丕与且与万七 != 1152921536445058664);
    
    }
    private void Start()
    {
        this.万丒丅丞上丟丑丄万 = this.GetComponent<UnityEngine.Rigidbody>();
    }
    public void StartBullet(UnityEngine.Vector3 七丝丑丐东丅丒丁丂, UnityEngine.Vector3 丂七丅一一丒且万丕, float 丘丛丝世丄丄丑三丁, bool 丅上丝丟且专世丏与, bool 丂丘且丝丙上业世丙)
    {
        this.丗丟丕一丏丐丙丛丗 = false;
        this.丗丌上丁一丛一万丄 = 七丝丑丐东丅丒丁丂;
        mem[1152921536445319476] = 七丝丑丐东丅丒丁丂.y;
        mem[1152921536445319480] = 七丝丑丐东丅丒丁丂.z;
        this.丒万不且且万丒丙一 = 丘丛丝世丄丄丑三丁;
        this.丆丁世一三丆丆三专 = 丂七丅一一丒且万丕;
        mem[1152921536445319456] = 丂七丅一一丒且万丕.y;
        mem[1152921536445319460] = 丂七丅一一丒且万丕.z;
        this.一与专七丛与丏丟专 = 丅上丝丟且专世丏与;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = this.丗丌上丁一丛一万丄, y = 丂七丅一一丒且万丕.z, z = 七丝丑丐东丅丒丁丂.z};
        this.<丆丗下丙东七三下丄>k__BackingField = true;
        this.丌丟丄业且三丛丕丄().gameObject.SetActive(value:  true);
        this.上丏丗丛丛丞丏丂丁 = UnityEngine.Time.realtimeSinceStartup;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丂七丅一一丒且万丕.x, y = 丂七丅一一丒且万丕.y, z = 丂七丅一一丒且万丕.z}, b:  new UnityEngine.Vector3() {x = 七丝丑丐东丅丒丁丂.x, y = 七丝丑丐东丅丒丁丂.y, z = 七丝丑丐东丅丒丁丂.z});
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        this.丂丘且丝丙上业世丙 = 丂丘且丝丙上业世丙;
    }
    internal void 丗丞丝不三且不丕丘(RilisoftBot.BaseBot 丗不丛七丏丄业三丁)
    {
        this.丟丙丈七丗且丞丏丞 = 丗不丛七丏丄业三丁;
    }
    private void 丛东丅丗上七丈且七()
    {
        float val_10;
        var val_11;
        val_10 = this.radius;
        if(val_10 > 0f)
        {
                val_10 = this.forceImpulse;
            if(val_10 > 0f)
        {
                val_11 = null;
            val_11 = null;
            UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
            val_10 = val_2.x;
            一丘丈丗三不东与七(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_10, y = val_2.y, z = val_2.z}, 丒专丁不三丛丕世丙:  this.radius, 与丁丐丈万丏丘丂下:  this.forceImpulse, 三丘丅上丘丝丆丈丒:  this.minForcePercent, 下丆专丙丁丅下丏丙:  this.maxForcePercent);
        }
        
        }
        
        if((this.<丟丕丁不丁七世下一>k__BackingField) != false)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        if(this.丗丟丕一丏丐丙丛丗 != false)
        {
                this.东与丏丒七丂万东万(丑丒业丘丑东丕世丅:  false);
        }
        else
        {
                this.丌丟丄业且三丛丕丄().gameObject.SetActive(value:  false);
        }
        
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
        this.<丆丗下丙东七三下丄>k__BackingField = false;
        if(this.丗丟丕一丏丐丙丛丗 == false)
        {
                return;
        }
        
        this.丛上业丐丈丂与丒丒(丑丒业丘丑东丕世丅:  false);
    }
    private void OnTriggerEnter(UnityEngine.Collider 丛丂丁丅丂东丒东丅)
    {
        this.三东三世丑业七丆丗(丛丂丁丅丂东丒东丅:  丛丂丁丅丂东丒东丅.gameObject);
    }
    private void OnCollisionEnter(UnityEngine.Collision 丛丂丁丅丂东丒东丅)
    {
        this.三东三世丑业七丆丗(丛丂丁丅丂东丒东丅:  丛丂丁丅丂东丒东丅.gameObject);
    }
    private void 三东三世丑业七丆丗(UnityEngine.GameObject 丛丂丁丅丂东丒东丅)
    {
        UnityEngine.Object val_34;
        if((this.<丆丗下丙东七三下丄>k__BackingField) == false)
        {
                return;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_4;
        }
        
        if(this.丌丟丄业且三丛丕丄().root == 丛丂丁丅丂东丒东丅.transform.root)
        {
                return;
        }
        
        丅丙上七上一丐不下 val_8 = 丛丂丁丅丂东丒东丅.transform.GetComponentInParent<丅丙上七上一丐不下>();
        if(val_8 == null)
        {
            goto label_13;
        }
        
        var val_34 = 0;
        val_34 = val_34 + 1;
        goto label_17;
        label_4:
        val_34 = 丛丂丁丅丂东丒东丅.transform.root;
        label_60:
        if(丛丂丁丅丂东丒东丅 != null)
        {
            goto label_27;
        }
        
        label_28:
        label_27:
        if(丛丂丁丅丂东丒东丅.layer == 1)
        {
                return;
        }
        
        if(val_34 != 0)
        {
                if((System.String.IsNullOrEmpty(value:  val_34.tag)) == false)
        {
            goto label_26;
        }
        
        }
        
        label_50:
        label_62:
        this.丆专丄丂业丅丝丈丂(丞下万上三丘上与专:  0);
        return;
        label_13:
        if(丛丂丁丅丂东丒东丅 != null)
        {
            goto label_27;
        }
        
        goto label_28;
        label_26:
        if(this.丌丟丄业且三丛丕丄().root == val_34.transform.root)
        {
                return;
        }
        
        if((val_34.CompareTag(tag:  "Area")) == true)
        {
                return;
        }
        
        if(this.一与专七丛与丏丟专 != true)
        {
                if((val_34.CompareTag(tag:  "Enemy")) == true)
        {
                return;
        }
        
        }
        
        if(((((val_34.CompareTag(tag:  "Player")) == true) || ((val_34.CompareTag(tag:  "Turret")) == true)) || ((val_34.CompareTag(tag:  "Pet")) == true)) || ((val_34.CompareTag(tag:  "DamageableObject")) == true))
        {
            goto label_51;
        }
        
        if((this.一与专七丛与丏丟专 == false) || ((val_34.CompareTag(tag:  "Enemy")) == false))
        {
            goto label_50;
        }
        
        goto label_51;
        label_17:
        val_34 = val_8.transform;
        if(((this.丟丙丈七丗且丞丏丞 == 0) || ((val_34.CompareTag(tag:  "Enemy")) == false)) || (((val_8 != 0) ? 1 : 0) == ((this.丟丙丈七丗且丞丏丞.世丗万丞世丂丂丕丝 == true) ? 1 : 0)))
        {
            goto label_60;
        }
        
        label_51:
        UnityEngine.GameObject val_33 = val_34.gameObject;
        goto label_62;
    }
    private void 丆专丄丂业丅丝丈丂(UnityEngine.GameObject 丞下万上三丘上与专)
    {
        if(this.丂丆丂丕与且与万七 == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        this.丂丆丂丕与且与万七.Invoke(丏三丐丈丆与上丙丏:  丞下万上三丘上与专, 世丘丂丁七丐丐一专:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂丘且丝丙上业世丙:  this.丂丘且丝丙上业世丙);
        this.丛东丅丗上七丈且七();
    }
    private void Update()
    {
        if((this.<丆丗下丙东七三下丄>k__BackingField) == false)
        {
                return;
        }
        
        if(this.丗丟丕一丏丐丙丛丗 != true)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丆丁世一三丆丆三专, y = V9.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.丗丌上丁一丛一万丄, y = V10.16B, z = V11.16B});
            UnityEngine.Transform val_2 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_3 = val_2.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.丒万不且且万丒丙一);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_2.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        
        float val_8 = UnityEngine.Time.realtimeSinceStartup;
        val_8 = val_8 - this.上丏丗丛丛丞丏丂丁;
        if(val_8 < this.lifeTime)
        {
                return;
        }
        
        this.丛东丅丗上七丈且七();
    }
    private void 丛上业丐丈丂与丒丒(bool 丑丒业丘丑东丕世丅)
    {
        UnityEngine.Rigidbody val_1 = this.GetComponent<UnityEngine.Rigidbody>();
        if(val_1 != null)
        {
                val_1.useGravity = 丑丒业丘丑东丕世丅;
        }
        else
        {
                val_1.useGravity = 丑丒业丘丑东丕世丅;
        }
        
        val_1.isKinematic = (~丑丒业丘丑东丕世丅) & 1;
    }
    public void ApplyForceFroBullet(UnityEngine.Vector3 七丝丑丐东丅丒丁丂, UnityEngine.Vector3 丂七丅一一丒且万丕, bool 丅上丝丟且专世丏与, float 丒东业丙一丙业丏丆, UnityEngine.Vector3 丅丕万丐不丄丗且七, bool 丂丘且丝丙上业世丙)
    {
        float val_1;
        this.丗丟丕一丏丐丙丛丗 = true;
        this.一与专七丛与丏丟专 = 丅上丝丟且专世丏与;
        this.上丏丗丛丛丞丏丂丁 = UnityEngine.Time.realtimeSinceStartup;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 七丝丑丐东丅丒丁丂.x, y = 七丝丑丐东丅丒丁丂.y, z = 七丝丑丐东丅丒丁丂.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丂七丅一一丒且万丕.x, y = 丂七丅一一丒且万丕.y, z = 丂七丅一一丒且万丕.z}, b:  new UnityEngine.Vector3() {x = 七丝丑丐东丅丒丁丂.x, y = 七丝丑丐东丅丒丁丂.y, z = 七丝丑丐东丅丒丁丂.z});
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        this.GetComponent<UnityEngine.Rigidbody>().constraints = 112;
        this.东与丏丒七丂万东万(丑丒业丘丑东丕世丅:  true);
        this.丛上业丐丈丂与丒丒(丑丒业丘丑东丕世丅:  true);
        this.<丆丗下丙东七三下丄>k__BackingField = true;
        this.丂丘且丝丙上业世丙 = 丂丘且丝丙上业世丙;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丅丕万丐不丄丗且七.x, y = val_1, z = 丅丕万丐不丄丗且七.y}, d:  丒东业丙一丙业丏丆);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.丙业与且万丛世丘万(七丆丟丗世丟且丒丆:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}));
    }
    private System.Collections.IEnumerator 丙业与且万丛世丘万(UnityEngine.Vector3 七丆丟丗世丟且丒丆)
    {
        BulletForBot.丞丄丅且专不丂且三 val_1 = new BulletForBot.丞丄丅且专不丂且三();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七丆丟丗世丟且丒丆 = 七丆丟丗世丟且丒丆;
        mem[1152921536446808508] = 七丆丟丗世丟且丒丆.y;
        mem[1152921536446808512] = 七丆丟丗世丟且丒丆.z;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 东与丏丒七丂万东万(bool 丑丒业丘丑东丕世丅)
    {
        var val_19;
        if(this.gameObject.activeSelf != true)
        {
                this.gameObject.SetActive(value:  true);
        }
        
        val_19 = 0;
        goto label_4;
        label_9:
        this.丌丟丄业且三丛丕丄().GetChild(index:  0).gameObject.SetActive(value:  丑丒业丘丑东丕世丅);
        val_19 = 1;
        label_4:
        if(val_19 < this.丌丟丄业且三丛丕丄().childCount)
        {
            goto label_9;
        }
        
        UnityEngine.Renderer val_10 = this.GetComponent<UnityEngine.Renderer>();
        if(val_10 != 0)
        {
                val_10.enabled = 丑丒业丘丑东丕世丅;
        }
        
        UnityEngine.ParticleSystem val_13 = this.GetComponent<UnityEngine.ParticleSystem>();
        if(val_13 != 0)
        {
                val_13.enableEmission = 丑丒业丘丑东丕世丅;
        }
        
        UnityEngine.Collider val_16 = this.GetComponent<UnityEngine.Collider>();
        if(val_16 == 0)
        {
                return;
        }
        
        val_16.enabled = 丑丒业丘丑东丕世丅;
    }
    private UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if(this.专专丏下丐丂丂丅东 == 0)
        {
                this.专专丏下丐丂丂丅东 = this.transform;
            return val_3;
        }
        
        val_3 = this.专专丏下丐丂丂丅东;
        return val_3;
    }
    public BulletForBot()
    {
        this.丂丘且丝丙上业世丙 = true;
    }

}
