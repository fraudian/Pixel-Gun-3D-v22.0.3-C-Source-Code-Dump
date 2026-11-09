using UnityEngine;
internal class DamageableObject : MonoBehaviour, 丅丙上七上一丐不下, 东丁丆一业丈万丆丐
{
    // Fields
    private System.Action<DamageableObject> 丅七丑专丆三上七丅;
    private System.Action<DamageableObject> 丐且丘与专丁丆丗丙;
    private System.Action 上专世丌丑与丕丛丕;
    private System.Action 丕丕丞不丆业东下丒;
    private System.Action 丏丘三丆丄上一丆不;
    private DamageableObjectResist _resist;
    public bool isEnemyToMe;
    private float _health;
    public bool isImmortal;
    private float 下万且与上丝且七世;
    private bool 万丁丙东东丟丅丝三;
    private PhotonView _photonView;
    private BotChangeDamageMaterial _botChangerMaterial;
    private System.Collections.Generic.List<BotChangeDamageMaterial> _listBotChangerMaterials;
    private bool _useMultipler;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    internal float 三丄丗世丌丂丗丞东 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    internal void 丆下且丘七丂不丂专(System.Action<DamageableObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅七丑专丆三上七丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅七丑专丆三上七丅 != 1152921538520071192);
    
    }
    internal void 上丄丟一丂丟与丛丗(System.Action<DamageableObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅七丑专丆三上七丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅七丑专丆三上七丅 != 1152921538520207768);
    
    }
    internal void 丗丕世丞专丄丙三丛(System.Action<DamageableObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丐且丘与专丁丆丗丙, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐且丘与专丁丆丗丙 != 1152921538520344352);
    
    }
    internal void 丗丁世丈东丗丐丘世(System.Action<DamageableObject> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丐且丘与专丁丆丗丙, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐且丘与专丁丆丗丙 != 1152921538520480928);
    
    }
    internal void 下一丌丕业丒万七丐(System.Action 丙业与丙丗丝不丈东)
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
        while(this.上专世丌丑与丕丛丕 != 1152921538520617512);
    
    }
    internal void 丆下三上丒丝世丈丐(System.Action 丙业与丙丗丝不丈东)
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
        while(this.上专世丌丑与丕丛丕 != 1152921538520754088);
    
    }
    internal void 丅专丈丑丟东丏万丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丕丕丞不丆业东下丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丕丞不丆业东下丒 != 1152921538520890672);
    
    }
    internal void 不业丆不上丑丞三与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丕丕丞不丆业东下丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丕丕丞不丆业东下丒 != 1152921538521027248);
    
    }
    internal void 专丗丙专且下万丝丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏丘三丆丄上一丆不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏丘三丆丄上一丆不 != 1152921538521163832);
    
    }
    internal void 万业东丛万一东丙丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏丘三丆丄上一丆不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏丘三丆丄上一丆不 != 1152921538521300408);
    
    }
    internal float 三丏丟不丆丅丞不丛()
    {
        return (float)this._health;
    }
    private void Awake()
    {
        this.三丁丆上上丒丐丏丗(世丙丟上丘上七万万:  this._health);
    }
    internal void 三丁丆上上丒丐丏丗(float 世丙丟上丘上七万万)
    {
        var val_1;
        int val_2;
        if(this._useMultipler != false)
        {
                val_1 = null;
            val_1 = null;
            val_2 = RilisoftBot.BaseBot.且业七丒丞丈丟丛不;
        }
        else
        {
                val_2 = 1f;
        }
        
        val_2 = val_2 * 世丙丟上丘上七万万;
        this._health = val_2;
        this.下万且与上丝且七世 = val_2;
    }
    private void Start()
    {
        var val_7;
        System.Action<与丅丕丈丘东丝世丟> val_8;
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        if(this._botChangerMaterial == 0)
        {
                this._botChangerMaterial = this.GetComponent<BotChangeDamageMaterial>();
        }
        
        val_7 = null;
        val_7 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void DamageableObject::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_8 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_8;
    }
    private void OnDestroy()
    {
        var val_5;
        System.Action<与丅丕丈丘东丝世丟> val_6;
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        val_5 = null;
        val_5 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void DamageableObject::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_6 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_6;
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this._photonView.isMine == false)
        {
                return;
        }
        
        object[] val_2 = new object[1];
        val_2[0] = this._health;
        this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  61, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 七丛丐与丑丈一万丁(bool 丌丝丌丁下丐丞丆一)
    {
        this._health = 0f;
        this.万丁丙东东丟丅丝三 = true;
        if(this.丕丕丞不丆业东下丒 != null)
        {
                this.丕丕丞不丆业东下丒.Invoke();
        }
        
        if(this.丐且丘与专丁丆丗丙 == null)
        {
                return;
        }
        
        this.丐且丘与专丁丆丗丙.Invoke(obj:  this);
    }
    private void 丒丒丛丝丝丘丟丂不()
    {
        if(this.万丁丙东东丟丅丝三 != false)
        {
                return;
        }
        
        if(this._photonView != 0)
        {
                this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  34, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
        this.七丛丐与丑丈一万丁(丌丝丌丁下丐丞丆一:  false);
    }
    public void GetDamageRPC(float 且丑丐丂与丐丟丒下, int 丆丝专专丟丟丈丏丐)
    {
        var val_6;
        System.Collections.Generic.List<BotChangeDamageMaterial> val_14;
        var val_15;
        var val_16;
        if(this.万丁丙东东丟丅丝三 == true)
        {
                return;
        }
        
        float val_13 = this._health;
        val_13 = val_13 - 且丑丐丂与丐丟丒下;
        this._health = val_13;
        if(this.上专世丌丑与丕丛丕 != null)
        {
                this.上专世丌丑与丕丛丕.Invoke();
        }
        
        if(this.丅七丑专丆三上七丅 != null)
        {
                this.丅七丑专丆三上七丅.Invoke(obj:  this);
        }
        
        val_14 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        if(val_14.业丐丐三丕一丗丛丁() == 丆丝专专丟丟丈丏丐)
        {
            goto label_19;
        }
        
        if(this._botChangerMaterial != 0)
        {
                this._botChangerMaterial.ShowDamageEffect(万东丏丌不七东丘万:  false, 丗与丟上上丑专世丗:  0);
        }
        
        val_14 = this._listBotChangerMaterials;
        List.Enumerator<T> val_4 = val_14.GetEnumerator();
        label_15:
        if(((-444019760) & 1) == 0)
        {
            goto label_13;
        }
        
        val_6.丐丏七丌丕丗业且上().ShowDamageEffect(万东丏丌不七东丘万:  false, 丗与丟上上丑专世丗:  0);
        goto label_15;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_19:
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.上万万丐丏且与专不());
        if(this._health > 0f)
        {
                return;
        }
        
        if(this.万丁丙东东丟丅丝三 != true)
        {
                val_14 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
            if(val_14.业丐丐三丕一丗丛丁() == 丆丝专专丟丟丈丏丐)
        {
                val_14 = 1152921505058603008;
            val_15 = null;
            val_15 = null;
            if(DungeonsController.丄丘七三上丕世丞业 != 0)
        {
                val_16 = null;
            val_16 = null;
            DungeonsController.丄丘七三上丕世丞业.丌丁丏丅且丗下丕丐(丌丗万且世丞丏与下:  122);
        }
        
        }
        
        }
        
        this.丒丒丛丝丝丘丟丂不();
    }
    private System.Collections.IEnumerator 上万万丐丏且与专不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DamageableObject.上丏丘丟三上丌丙七();
    }
    private void 业丂丛丟上且丂东丂(float 且丑丐丂与丐丟丒下)
    {
        float val_4;
        PhotonView val_13;
        object val_14;
        val_13 = this;
        if(this.isImmortal == true)
        {
                return;
        }
        
        bool val_12 = this.万丁丙东东丟丅丝三;
        val_12 = val_12 + 3;
        var val_13 = ~val_12;
        val_13 = val_13 & 3;
        if(val_13 != 0)
        {
                return;
        }
        
        val_14 = 1152921504848912384;
        if(this._botChangerMaterial != 0)
        {
                this._botChangerMaterial.ShowDamageEffect(万东丏丌不七东丘万:  false, 丗与丟上上丑专世丗:  0);
        }
        
        List.Enumerator<T> val_2 = this._listBotChangerMaterials.GetEnumerator();
        label_10:
        if(((-443701520) & 1) == 0)
        {
            goto label_8;
        }
        
        val_4.丐丏七丌丕丗业且上().ShowDamageEffect(万东丏丌不七东丘万:  false, 丗与丟上上丑专世丗:  0);
        goto label_10;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this._photonView == 0)
        {
                this.GetDamageRPC(且丑丐丂与丐丟丒下:  且丑丐丂与丐丟丒下, 丆丝专专丟丟丈丏丐:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁());
            return;
        }
        
        val_13 = this._photonView;
        object[] val_9 = new object[2];
        val_4 = 且丑丐丂与丐丟丒下;
        val_9[0] = val_4;
        val_14 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        val_9[1] = val_14;
        val_13.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_9);
    }
    internal void 七丅丘七丁七丌丗丅()
    {
        if(this.丏丘三丆丄上一丆不 == null)
        {
                return;
        }
        
        this.丏丘三丆丄上一丆不.Invoke();
    }
    internal void 万丅万丙丌丕上丘丌(float 世丙丟上丘上七万万)
    {
        if(this.万丁丙东东丟丅丝三 == true)
        {
                return;
        }
        
        this._health = 世丙丟上丘上七万万;
        if(世丙丟上丘上七万万 > 0f)
        {
                return;
        }
        
        this.七丛丐与丑丈一万丁(丌丝丌丁下丐丞丆一:  false);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_2;
        var val_3;
        int val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_2 = 丞世不丒下上上丝丑;
        byte val_1 = val_2 & 255;
        if(val_1 == 61)
        {
            goto label_1;
        }
        
        if(val_1 == 34)
        {
            goto label_2;
        }
        
        if(val_1 != 24)
        {
            goto label_3;
        }
        
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_4;
        }
        
        val_3 = 专丒丌丆下丐丞丟丞;
        val_4 = 专丒丌丆下丐丞丟丞.Length;
        if(val_4 >= 2)
        {
            goto label_5;
        }
        
        label_16:
        if(val_4 == 0)
        {
            goto label_14;
        }
        
        if(专丒丌丆下丐丞丟丞 == null)
        {
                val_5 = mem[专丒丌丆下丐丞丟丞 + 24];
            val_5 = 专丒丌丆下丐丞丟丞 + 24;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        val_6 = 0;
        goto label_9;
        label_1:
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        if(this.万丁丙东东丟丅丝三 == true)
        {
            goto label_14;
        }
        
        this._health = null;
        if(null > 0f)
        {
            goto label_14;
        }
        
        label_2:
        this.七丛丐与丑丈一万丁(丌丝丌丁下丐丞丆一:  false);
        goto label_14;
        label_3:
        val_7 = 0;
        return (bool)val_7;
        label_4:
        val_3 = 24;
        val_8 = 28563616;
        if(28563616 < 2)
        {
            goto label_16;
        }
        
        label_5:
        val_2 = 专丒丌丆下丐丞丟丞[0];
        object val_4 = 专丒丌丆下丐丞丟丞[1];
        label_9:
        this.GetDamageRPC(且丑丐丂与丐丟丒下:  3.782474E-38f, 丆丝专专丟丟丈丏丐:  21884928);
        label_14:
        val_7 = 1;
        return (bool)val_7;
    }
    internal void 丟丏且丌丅丝丞丛丅(PhotonView 丄丈丑丐丆丞丘与丗)
    {
        this._photonView = 丄丈丑丐丆丞丘与丗;
    }
    internal void 一东丆专不丙丄业丞(BotChangeDamageMaterial 丅丁七丑丅丙且与丏, System.Collections.Generic.List<BotChangeDamageMaterial> 丗丟丗丞世丞下丑且)
    {
        this._botChangerMaterial = 丅丁七丑丅丙且与丏;
        this._listBotChangerMaterials = 丗丟丗丞世丞下丑且;
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
        return (float)this.下万且与上丝且七世;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        if(this._resist != 0)
        {
                if(this._resist != null)
        {
            goto label_5;
        }
        
        }
        else
        {
                float val_2 = 1f;
        }
        
        label_5:
        val_2 = val_2 * 丞丈专下丈专业三丞;
        this.业丂丛丟上且丂东丂(且丑丐丂与丐丟丒下:  val_2);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return (bool)this.isEnemyToMe;
    }
    public bool IsDead()
    {
        return (bool)this.万丁丙东东丟丅丝三;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public DamageableObject()
    {
        this.isEnemyToMe = true;
        this._health = 100f;
        this.下万且与上丝且七世 = 100f;
        this._useMultipler = true;
    }

}
