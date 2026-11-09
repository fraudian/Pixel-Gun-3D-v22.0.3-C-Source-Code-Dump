using UnityEngine;
internal class TankDamageable : MonoBehaviour, 丅丙上七上一丐不下, 且丏丕丝丄上业上丒
{
    // Fields
    private UnityEngine.Vector3 丑且丈一丐丂不丟丌;
    private int <丈下丑丆上万丆万专>k__BackingField;
    internal float 世丙丟上丘上七万万;
    internal bool 丐下丁与一丑丟丛世;
    private int <专业丞不丟专专丐与>k__BackingField;
    private DamageableObjectResist 万业七不丗丝世丕不;
    
    // Properties
    public bool 丈下三丟丑丒业东丕 { get; }
    public PlayerBot.丙丗世丅丟东上世下 且丛不丟丁丝东丑七 { get; }
    public UnityEngine.Transform 上丛东下专丅一丂一 { get; }
    public UnityEngine.Vector3 下丘丈丘一专下东丆 { get; }
    public UnityEngine.Vector3 下且丅丗专一东丄三 { get; }
    public float 下丑丐丂丞一万丂丞 { get; }
    public int 丆丐一七且丞专世丑 { get; set; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    
    // Methods
    public bool get_BotTargetIsDead()
    {
        if(this.丐下丁与一丑丟丛世 == true)
        {
                return true;
        }
        
        this = this.gameObject;
        if(this == 0)
        {
                return true;
        }
        
        if(TankController.丄丘七三上丕世丞业 != null)
        {
                return 0.不丝丁丞万丈丆丏万();
        }
        
        return 0.不丝丁丞万丈丆丏万();
    }
    public PlayerBot.丙丗世丅丟东上世下 get_BotTargetMeaning()
    {
        return 2;
    }
    public UnityEngine.Transform get_BotTargetTransform()
    {
        return this.transform;
    }
    public UnityEngine.Vector3 get_BotTargetAimCenter()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  2f);
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    public UnityEngine.Vector3 get_BotTargetVelocity()
    {
        return new UnityEngine.Vector3() {x = this.丑且丈一丐丂不丟丌};
    }
    public float get_BotTargetCurrentSpeed()
    {
        return 0f;
    }
    public int get_BotTargetPriority()
    {
        return (int)this.<丈下丑丆上万丆万专>k__BackingField;
    }
    public void set_BotTargetPriority(int 丙业与丙丗丝不丈东)
    {
        this.<丈下丑丆上万丆万专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void RegisterTargetForBot()
    {
        丘丛丞且一丅丁丏丐.一世丟丘丗丞丄丆下(上丌东丘丑丗不三且:  this);
    }
    public void UnregisterTargetForBot()
    {
        丘丛丞且一丅丁丏丐.且专丗丅上东三丂东(上丌东丘丑丗不三且:  this);
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public float get_maxHealth()
    {
        var val_4;
        if(PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆() == null)
        {
                return 10f;
        }
        
        if(TankEquipmentController.丄丘七三上丕世丞业 == null)
        {
                val_4 = 0;
        }
        
        if(val_2.HPClanTankBase != null)
        {
                return val_2.HPClanTankBase.Item[val_4.丞丆下丒丗丒丘七丐()];
        }
        
        return val_2.HPClanTankBase.Item[val_4.丞丆下丒丗丒丘七丐()];
    }
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    internal void 业丂丛丟上且丂东丂(float 丛业专丘丂丅丗丝丛)
    {
        var val_7;
        var val_8;
        val_7 = this;
        val_8 = 72745;
        if(TankController.丄丘七三上丕世丞业 == null)
        {
                val_8 = 0;
        }
        
        if(val_8.不丝丁丞万丈丆丏万() == true)
        {
                return;
        }
        
        float val_7 = this.世丙丟上丘上七万万;
        val_7 = val_7 - 丛业专丘丂丅丗丝丛;
        this.世丙丟上丘上七万万 = val_7;
        if(val_7 >= 0)
        {
                return;
        }
        
        this.世丙丟上丘上七万万 = 0f;
        val_7 = ???;
        goto typeof(TankDamageable).__il2cppRuntimeField_288;
    }
    internal void 丐丁与丌不世丅丆东(DamageableObjectResist 七丟不世东丛丈与东)
    {
        this.万业七不丗丝世丕不 = 七丟不世东丛丈与东;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        float val_3;
        float val_3 = 丞丈专下丈专业三丞;
        if(this.万业七不丗丝世丕不 == 0)
        {
            goto label_3;
        }
        
        if(丞丈专下丈专业三丞 >= 0)
        {
            goto label_6;
        }
        
        val_3 = 0f;
        goto label_6;
        label_3:
        val_3 = 1f;
        label_6:
        val_3 = val_3 * val_3;
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  val_3);
        TankController.丄丘七三上丕世丞业.三丘丛丐丆丏丒丅丝(且丑丐丂与丐丟丒下:  (this.丐下丁与一丑丟丛世 == true) ? 10000f : (val_3));
    }
    public bool IsDead()
    {
        return (bool)(this.世丙丟上丘上七万万 <= 0f) ? 1 : 0;
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        if(专丞上七七且丝七丗 != null)
        {
                return 专丞上七七且丝七丗.一丝丌丏万丐丌丆东();
        }
        
        return 专丞上七七且丝七丗.一丝丌丏万丐丌丆东();
    }
    private void Start()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        this.RegisterTargetForBot();
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        this.UnregisterTargetForBot();
    }
    private void Update()
    {
    
    }
    public void Reset()
    {
        this.世丙丟上丘上七万万 = this.maxHealth;
        this.丐下丁与一丑丟丛世 = false;
    }
    public virtual void StartDeactivate()
    {
        if(this.丐下丁与一丑丟丛世 != false)
        {
                return;
        }
        
        this.丐下丁与一丑丟丛世 = true;
        TankController.丄丘七三上丕世丞业.OnTankDestroyed();
    }
    public TankDamageable()
    {
        this.丑且丈一丐丂不丟丌 = 0;
        mem[1152921540475475152] = 0;
    }
    private UnityEngine.Transform IDamageable.get_transform()
    {
        return this.transform;
    }

}
