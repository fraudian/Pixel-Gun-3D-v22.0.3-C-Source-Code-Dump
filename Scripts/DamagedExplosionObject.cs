using UnityEngine;
internal sealed class DamagedExplosionObject : BaseExplosionObject, 丅丙上七上一丐不下
{
    // Fields
    internal const string 下丘丈世且丛与丗丘 = "DamagedExplosion";
    private float 与七丙且丅丁丒丝且;
    private int <专业丞不丟专专丐与>k__BackingField;
    private float 下万且与上丝且七世;
    private bool 丞丅丐丂丞丁丅丒丝;
    public UnityEngine.GameObject fireEffect;
    public float healthPoints;
    private 丅丙上七上一丐不下 不不业丑丞丑上丝丕;
    public float percentHealthForFireEffect;
    public float timeToDestroyByFire;
    
    // Properties
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Update()
    {
        if(this.丞丅丐丂丞丁丅丒丝 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.与七丙且丅丁丒丝且 - val_1;
        this.与七丙且丅丁丒丝且 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.丞丅丐丂丞丁丅丒丝 = false;
        this.丕丅丏与丟丘东丂上(丆丝专专丟丟丈丏丐:  this.不不业丑丞丑上丝丕);
    }
    internal void 业丂丛丟上且丂东丂(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒)
    {
        if(this.healthPoints <= 0f)
        {
                return;
        }
        
        float val_2 = this.下万且与上丝且七世;
        val_2 = this.healthPoints / val_2;
        this.不不业丑丞丑上丝丕 = 丛世一丟丞丁业丘丒;
        val_2 = val_2 * 100f;
        if(val_2 <= this.percentHealthForFireEffect)
        {
                if(this.fireEffect.activeSelf != true)
        {
                this.丅丞丌丐丙三丈丄与(下下东且万业丞丅丒:  true);
            this.丞丅丐丂丞丁丅丒丝 = true;
            this.与七丙且丅丁丒丝且 = this.timeToDestroyByFire;
        }
        
        }
        
        float val_3 = this.healthPoints;
        val_3 = val_3 - 丞丈专下丈专业三丞;
        this.healthPoints = val_3;
        if(val_3 > 0f)
        {
                return;
        }
        
        this.healthPoints = 0f;
        this.丕丅丏与丟丘东丂上(丆丝专专丟丟丈丏丐:  丛世一丟丞丁业丘丒);
    }
    protected override void 上不丒丘且丑专丞丕()
    {
        this.上不丒丘且丑专丞丕();
        this.下万且与上丝且七世 = this.healthPoints;
        this.丅丞丌丐丙三丈丄与(下下东且万业丞丅丒:  false);
    }
    private void 丅丞丌丐丙三丈丄与(bool 下下东且万业丞丅丒)
    {
        if(true != 0)
        {
                下下东且万业丞丅丒 = 下下东且万业丞丅丒;
            this.丘丈上丅与丏丑丈业(下下东且万业丞丅丒:  下下东且万业丞丅丒);
            object[] val_2 = new object[1];
            val_2[0] = 下下东且万业丞丅丒;
            下下东且万业丞丅丒.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  88, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
            return;
        }
        
        下下东且万业丞丅丒 = 下下东且万业丞丅丒;
        this.fireEffect.SetActive(value:  下下东且万业丞丅丒);
    }
    public UnityEngine.Transform get_transform()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.transform;
        }
        
        return val_1.transform;
    }
    public float get_maxHealth()
    {
        return (float)this.下万且与上丝且七世;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 丛世一丟丞丁业丘丒:  丛世一丟丞丁业丘丒);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return true;
    }
    public bool IsDead()
    {
        return (bool)(this.healthPoints <= 0f) ? 1 : 0;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public override bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 > 39)
        {
            goto label_1;
        }
        
        if(val_1 == 18)
        {
            goto label_2;
        }
        
        if(val_1 != 39)
        {
            goto label_6;
        }
        
        this.业丐丞万与七万丗与();
        goto label_9;
        label_1:
        if(val_1 == 88)
        {
            goto label_5;
        }
        
        if(val_1 != 101)
        {
            goto label_6;
        }
        
        this.丛丏且业丈业丑丗万();
        goto label_9;
        label_6:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        this.专丟丑丈丅丌丌丐下();
        goto label_9;
        label_5:
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        this.丘丈上丅与丏丑丈业(下下东且万业丞丅丒:  false);
        label_9:
        val_2 = 1;
        return (bool)val_2;
    }
    private void 丘丈上丅与丏丑丈业(bool 下下东且万业丞丅丒)
    {
        下下东且万业丞丅丒 = 下下东且万业丞丅丒;
        this.fireEffect.SetActive(value:  下下东且万业丞丅丒);
    }
    public DamagedExplosionObject()
    {
        this.healthPoints = 100f;
        this.percentHealthForFireEffect = 95f;
        this.timeToDestroyByFire = 5f;
    }

}
