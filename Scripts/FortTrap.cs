using UnityEngine;
internal class FortTrap : FortEquipObject, 丅丙上七上一丐不下
{
    // Fields
    public float destroyTime;
    public UnityEngine.GameObject trapObject;
    protected int 丛世万一业丆下丞丝;
    protected bool 丐下丁与一丑丟丛世;
    public float _timeEffect;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public float 世丏丝丘七上丐丌七 { get; }
    public float 丒丈丅丁丟丕丁丞三 { get; }
    public float 丒丒一东丘东东丟丄 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    public float get_detectRadius()
    {
        if(this == null)
        {
                return 0f;
        }
        
        return this.不七不丈丐万丂丌下();
    }
    public float get_effectRadius()
    {
        if(this == null)
        {
                return 0f;
        }
        
        return this.七与万且专丁丝丘丈();
    }
    public float get_TimeEffect()
    {
        return (float)this._timeEffect;
    }
    private void Start()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    public void Update()
    {
        goto typeof(FortTrap).__il2cppRuntimeField_2A8;
    }
    public virtual void DetectTargets()
    {
        float val_15;
        float val_16;
        var val_17;
        var val_18;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W21, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        label_21:
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        UnityEngine.Vector3 val_7 = val_2.Current.position;
        UnityEngine.Vector3 val_9 = this.transform.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_15 = 0f;
        if(val_10.x == 0)
        {
            goto label_17;
        }
        
        val_16 = val_10.x.不七不丈丐万丂丌下();
        if(val_10.x == 0)
        {
            goto label_19;
        }
        
        val_15 = val_10.x.不七不丈丐万丂丌下();
        goto label_19;
        label_17:
        val_16 = 0f;
        label_19:
        float val_13 = val_16 * val_15;
        if(val_10.x >= 0)
        {
            goto label_21;
        }
        
        goto label_21;
        label_7:
        val_17 = 0;
        val_18 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
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
    public virtual void DetectedTarget()
    {
    
    }
    internal override void 万不丄下丂三丕丒不(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙 = 0, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三 = 0)
    {
        var val_3;
        var val_4;
        var val_5;
        丛业专丘丂丅丗丝丛 = 丛业专丘丂丅丗丝丛 - 丛业专丘丂丅丗丝丛;
        mem[1152921537220747136] = 丛业专丘丂丅丗丝丛;
        if(丛业专丘丂丅丗丝丛 >= 0)
        {
                return;
        }
        
        this.丛世万一业丆下丞丝 = 丞丗且下世丐业丌丙;
        mem[1152921537220747136] = 0;
        if(this.丐下丁与一丑丟丛世 == true)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_690.viewID != 丞丗且下世丐业丌丙)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        typeof(Player_move_c).__il2cppRuntimeField_388.一东三丗丛不与丈丂(丐丘丌三丏与丙且东:  106, 专上丝且丂世丛丝丒:  1f);
    }
    public override void Activate()
    {
        this.Activate();
        this.丐下丁与一丑丟丛世 = false;
        if(this.trapObject == 0)
        {
                return;
        }
        
        this.trapObject.SetActive(value:  true);
    }
    public virtual void StartDeactivate()
    {
        if(this.丐下丁与一丑丟丛世 != false)
        {
                return;
        }
        
        this.丐下丁与一丑丟丛世 = true;
        if(this.trapObject != 0)
        {
                this.trapObject.SetActive(value:  false);
        }
        
        this.Invoke(methodName:  "DeactivateDelayed", time:  this.destroyTime);
    }
    public void DeactivateDelayed()
    {
        if(this.丐下丁与一丑丟丛世 == false)
        {
                return;
        }
        
        this.Deactivate();
    }
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
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
        return this.下丄丝七丑业一专一();
    }
    public float GetGamePlayForBaseGamePlay(int 业丆丈丟世一业一丙, int 业万上丆丐丞且丒七)
    {
        return (float)(float)业丆丈丟世一业一丙;
    }
    public virtual void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.丗丘七上丏丌丒七丂();
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  丞丈专下丈专业三丞, 丞丗且下世丐业丌丙:  丒丈丐丐丗丐专丈丏, 丐丟丘世丁三丕专专:  0);
    }
    public virtual bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
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
    public bool IsDead()
    {
        var val_3;
        if(this.isActive != false)
        {
                var val_2 = (this.丐下丁与一丑丟丛世 == true) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public FortTrap()
    {
        this.destroyTime = 2f;
        this._timeEffect = 2f;
    }

}
