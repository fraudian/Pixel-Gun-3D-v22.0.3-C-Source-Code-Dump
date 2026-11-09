using UnityEngine;
internal class DamageableObjectWithoutDeath : MonoBehaviour, 丅丙上七上一丐不下, 东丁丆一业丈万丆丐
{
    // Fields
    private System.Action<float> 上专世丌丑与丕丛丕;
    private PhotonView _photonView;
    private BotChangeDamageMaterial _botChangerMaterial;
    private bool enemyForMyPlayerToo;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    
    // Methods
    internal void 下一丌丕业丒万七丐(System.Action<float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.上专世丌丑与丕丛丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上专世丌丑与丕丛丕 != 1152921540020221720);
    
    }
    internal void 丆下三上丒丝世丈丐(System.Action<float> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.上专世丌丑与丕丛丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.上专世丌丑与丕丛丕 != 1152921540020358296);
    
    }
    private void Start()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        if(this._botChangerMaterial != 0)
        {
                return;
        }
        
        this._botChangerMaterial = this.GetComponent<BotChangeDamageMaterial>();
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    public void GetDamageRPC(float 且丑丐丂与丐丟丒下)
    {
        if(this.上专世丌丑与丕丛丕 != null)
        {
                this.上专世丌丑与丕丛丕.Invoke(obj:  且丑丐丂与丐丟丒下);
        }
        
        if(this._botChangerMaterial != 0)
        {
                this._botChangerMaterial.ShowDamageEffect(万东丏丌不七东丘万:  false, 丗与丟上上丑专世丗:  0);
        }
        
        if(this.gameObject == 0)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.上万万丐丏且与专不());
    }
    private System.Collections.IEnumerator 上万万丐丏且与专不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DamageableObjectWithoutDeath.万丞丕丈下丝不丑一();
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    private void 业丂丛丟上且丂东丂(float 且丑丐丂与丐丟丒下)
    {
        if(this._photonView == 0)
        {
                this.GetDamageRPC(且丑丐丂与丐丟丒下:  且丑丐丂与丐丟丒下);
            return;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = 且丑丐丂与丐丟丒下;
        this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_2);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        if((丞世不丒下上上丝丑 & 255) == 24)
        {
                object val_2 = 专丒丌丆下丐丞丟丞[0];
            this.GetDamageRPC(且丑丐丂与丐丟丒下:  3.782474E-38f);
            val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
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
        return 0f;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.业丂丛丟上且丂东丂(且丑丐丂与丐丟丒下:  丞丈专下丈专业三丞);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        var val_1;
        if(this.enemyForMyPlayerToo != false)
        {
                return true;
        }
        
        val_1 = null;
        val_1 = null;
        return UnityEngine.Object.op_Inequality(x:  专丞上七七且丝七丗, y:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
    }
    public bool IsDead()
    {
        return false;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public DamageableObjectWithoutDeath()
    {
    
    }

}
