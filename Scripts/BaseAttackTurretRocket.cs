using UnityEngine;
internal class BaseAttackTurretRocket : PGBehaviour
{
    // Fields
    protected bool hasLifeTime;
    private float lifetime;
    public float splashRadius;
    internal bool 且丝业丙丁丂万丞与;
    internal bool 丅七上一丈丕上丒丞;
    internal FortEquipObject 丌不且专丘丆丞丂丟;
    public bool usePointDamage;
    public bool useExplosionEffect;
    protected string explosionName;
    public string fortObjectName;
    public UnityEngine.GameObject objectAfterDestroy;
    public float objectAfterDestroyLifetime;
    public WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    internal Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐;
    public float poisonDamageMultipier;
    public int poisonHitsCount;
    public float poisonHitsDelay;
    internal Rilisoft.丏丏专丙世丝万丅且 丈丒丌丄丗不东万丛;
    public float poisonAreaDamageMultipier;
    public float poisonAreaHitsDelay;
    protected float 一与东丑丄丁丏七丘;
    
    // Properties
    protected float 七丄且丞三丂上东上 { get; }
    
    // Methods
    protected float 丈丆丝丑丙丈丒丑丏()
    {
        if(this.丌不且专丘丆丞丂丟 == 0)
        {
                return 1f;
        }
        
        if(this.丌不且专丘丆丞丂丟 != null)
        {
                return this.丌不且专丘丆丞丂丟.下与丗丒丐三丕丘丈();
        }
        
        return this.丌不且专丘丆丞丂丟.下与丗丒丐三丕丘丈();
    }
    private void Update()
    {
        this.丂与丗丌与七丆与丝();
    }
    private void 丂与丗丌与七丆与丝()
    {
        if(this.hasLifeTime == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.lifetime - val_1;
        this.lifetime = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void OnCollisionEnter(UnityEngine.Collision 三丑丈且丏业丐丝丗)
    {
        goto typeof(BaseAttackTurretRocket).__il2cppRuntimeField_178;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        goto typeof(BaseAttackTurretRocket).__il2cppRuntimeField_188;
    }
    internal virtual bool 丕丛丆丞下丅且丆丂(Player_move_c 专丞上七七且丝七丗)
    {
        var val_5;
        var val_6;
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_3;
        }
        
        label_12:
        val_5 = 0;
        return (bool)val_5;
        label_3:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_7;
        }
        
        val_6 = null;
        val_6 = null;
        if(SiegeController.三三万丆下一丗万丛.attackTeam != 专丞上七七且丝七丗.丘丑丅三丆丑丌且丝())
        {
            goto label_12;
        }
        
        label_7:
        val_5 = 1;
        return (bool)val_5;
    }
    protected virtual void 丁万不且与丞丐丏丈(UnityEngine.Collision 三丑丈且丏业丐丝丗)
    {
    
    }
    protected virtual void 业万丗专丈下且丑万(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
    
    }
    internal void 丞专业丗丟东丗三丏(WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐, int 专丞丅丗丌丈且东丁, float 丗丝丂丕丑不丆丗丂, float 丒丙丘丕且一丞丕丑)
    {
        this.typeDead = 东丏业丞丞业下丄世;
        this.三一丝且丝丛不丄丐 = 三一丝且丝丛不丄丐;
        this.poisonHitsCount = 专丞丅丗丌丈且东丁;
        this.poisonHitsDelay = 丗丝丂丕丑不丆丗丂;
        this.poisonDamageMultipier = 丒丙丘丕且一丞丕丑;
    }
    internal virtual void 世业丄丐三丂丛丈世(FortEquipObject 丗与丝丌东上与丒丅, bool 丗丂且丘不专丌一丂, bool 且丝业丙丁丂万丞与, bool 丅七上一丈丕上丒丞)
    {
        this.丌不且专丘丆丞丂丟 = 丗与丝丌东上与丒丅;
        this.fortObjectName = 丗与丝丌东上与丒丅.七丕三一丁丒东丒丅();
        this.hasLifeTime = 丗丂且丘不专丌一丂;
        this.且丝业丙丁丂万丞与 = 且丝业丙丁丂万丞与;
        this.丅七上一丈丕上丒丞 = 丅七上一丈丕上丒丞;
    }
    protected virtual void 丞丌丏丂丟东丕丞不(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
    
    }
    internal virtual void 丆丞丐一一丒业丏与(float 丟上丝丞丄丞东丅与)
    {
        this.splashRadius = 丟上丝丞丄丞东丅与;
    }
    internal void 丕不丙丈与丅上丂业(Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐, float 丒丂且不丅丞三丒世)
    {
        this.丈丒丌丄丗不东万丛 = 三一丝且丝丛不丄丐;
        this.poisonAreaDamageMultipier = 丒丂且不丅丞三丒世;
    }
    internal void 下专与三丗丂丒不丑(float 丂业丑丅与且三丐与)
    {
        this.一与东丑丄丁丏七丘 = 丂业丑丅与且三丐与;
    }
    public BaseAttackTurretRocket()
    {
        this.hasLifeTime = true;
        this.lifetime = 7f;
        this.splashRadius = 6f;
        this.useExplosionEffect = true;
        this.objectAfterDestroyLifetime = -1f;
        this.poisonAreaHitsDelay = -1f;
        this.fortObjectName = "";
    }

}
