using UnityEngine;
public class FortEquipObject : PGBehaviour
{
    // Fields
    protected const float 东丒丈三万丅丗不丙 = 3;
    private bool 丘丄丆不丛丗上三上;
    internal 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅 上世丏丁世丟世丆业;
    internal int 丕丙万不丆丟三丆丝;
    public byte fortObjectID;
    protected string 丆与下丌丞丄丌丞三;
    internal string 一丏丌丐丌三专上上;
    public float health;
    protected float 丄丂三三丑丆丈东丆;
    public double respawnTimer;
    protected UnityEngine.Transform 丞下万上三丘上与专;
    internal PlayerDamageable 丘一丑丄丌丗丂与丙;
    private System.Collections.Generic.List<BotChangeDamageMaterial> _listBotChangerMaterials;
    internal BaseEquipmentController 丘丂不业一丆且上丂;
    internal bool 且丝业丙丁丂万丞与;
    private ObjectOnDamagePoisonParams 丐七不丗不丟丂丁丗;
    
    // Properties
    internal string 丞丝丝丄与丏业丂丝 { get; }
    internal ObjectOnDamagePoisonParams 七丁丑丘丂丆丌丁三 { get; }
    internal float 丞丈专下丈专业三丞 { get; }
    internal float 丂丛且丝丂专丘丘丛 { get; }
    internal float 丝丐上丘丟且丗一不 { get; }
    public bool 东丅丞丁丗万且丁丗 { get; set; }
    internal float 丈丆且丝丛丝丅一丛 { get; }
    
    // Methods
    internal string 七丕三一丁丒东丒丅()
    {
        return (string)this.丆与下丌丞丄丌丞三;
    }
    internal ObjectOnDamagePoisonParams 下丏万七东丐世业丆()
    {
        ObjectOnDamagePoisonParams val_4;
        if(this.丐七不丗不丟丂丁丗 == 0)
        {
                this.丐七不丗不丟丂丁丗 = this.gameObject.AddComponent<ObjectOnDamagePoisonParams>();
            return val_4;
        }
        
        val_4 = this.丐七不丗不丟丂丁丗;
        return val_4;
    }
    internal float 下与丗丒丐三丕丘丈()
    {
        if(this.上世丏丁世丟世丆业 == null)
        {
                return 10f;
        }
        
        bool val_1 = GameConnect.七丂万专且丏丘一丙();
        if(this.上世丏丁世丟世丆业.丁丙丅不丝丐丛丆丁() == null)
        {
                return 10f;
        }
        
        if(this.上世丏丁世丟世丆业.丁丙丅不丝丐丛丆丁().Count < 1)
        {
                return 10f;
        }
        
        bool val_5 = GameConnect.七丂万专且丏丘一丙();
        System.Collections.Generic.List<System.Single> val_6 = this.上世丏丁世丟世丆业.丁丙丅不丝丐丛丆丁();
        if(val_6 != null)
        {
                return val_6.Item[UnityEngine.Mathf.Min(a:  this.上世丏丁世丟世丆业.丁丙丅不丝丐丛丆丁().Count - 1, b:  this.丕丙万不丆丟三丆丝)];
        }
        
        return val_6.Item[UnityEngine.Mathf.Min(a:  this.上世丏丁世丟世丆业.丁丙丅不丝丐丛丆丁().Count - 1, b:  this.丕丙万不丆丟三丆丝)];
    }
    internal float 下丄丝七丑业一专一()
    {
        if(this.上世丏丁世丟世丆业 == null)
        {
                return 1f;
        }
        
        bool val_1 = GameConnect.七丂万专且丏丘一丙();
        if(this.上世丏丁世丟世丆业.丆丑丛东丄丕丑专丗() == null)
        {
                return 1f;
        }
        
        if(this.上世丏丁世丟世丆业.丆丑丛东丄丕丑专丗().Count < 1)
        {
                return 1f;
        }
        
        bool val_5 = GameConnect.七丂万专且丏丘一丙();
        System.Collections.Generic.List<System.Single> val_6 = this.上世丏丁世丟世丆业.丆丑丛东丄丕丑专丗();
        if(val_6 != null)
        {
                return val_6.Item[UnityEngine.Mathf.Min(a:  this.上世丏丁世丟世丆业.丆丑丛东丄丕丑专丗().Count - 1, b:  this.丕丙万不丆丟三丆丝)];
        }
        
        return val_6.Item[UnityEngine.Mathf.Min(a:  this.上世丏丁世丟世丆业.丆丑丛东丄丕丑专丗().Count - 1, b:  this.丕丙万不丆丟三丆丝)];
    }
    internal float 丌七丞七专丘丞世丒()
    {
        if(this.上世丏丁世丟世丆业 == null)
        {
                return 3.402823E+38f;
        }
        
        if(this.上世丏丁世丟世丆业.丙丈丗丌丘三丄业且() == 0f)
        {
                return 3.402823E+38f;
        }
        
        if(this.上世丏丁世丟世丆业 != null)
        {
                return this.上世丏丁世丟世丆业.丙丈丗丌丘三丄业且();
        }
        
        return this.上世丏丁世丟世丆业.丙丈丗丌丘三丄业且();
    }
    public bool get_isActive()
    {
        return (bool)this.丘丄丆不丛丗上三上;
    }
    public void set_isActive(bool 丙业与丙丗丝不丈东)
    {
        this.丘丄丆不丛丗上三上 = 丙业与丙丗丝不丈东;
    }
    internal virtual void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        var val_20;
        this.fortObjectID = 丞丅上丏丂且下丅与;
        this.丘丂不业一丆且上丂 = 丒专丈丛下丒一丒丛;
        val_20 = 0;
        mem[1152921537215909200] = ( != 0) ? 1 : 0;
        if((System.String.op_Equality(a:  this.丆与下丌丞丄丌丞三, b:  System.String.alignConst)) != false)
        {
                this.丆与下丌丞丄丌丞三 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅 val_7 = new 丄与东丕丑丗丌七上.丗一丂丈丅三丌东丅();
            this.上世丏丁世丟世丆业 = val_7;
            System.Collections.Generic.List<System.Single> val_8 = new System.Collections.Generic.List<System.Single>();
            val_8.Add(item:  BalanceController.丙丂丕丆丂丟不不专(丆万一不丌且东丐丐:  this.丆与下丌丞丄丌丞三));
            val_7.丏丑万丈一丈万丗万(丙业与丙丗丝不丈东:  val_8);
            System.Collections.Generic.List<System.Single> val_10 = new System.Collections.Generic.List<System.Single>();
            val_10.Add(item:  BalanceController.专丏与下专且万上丛(丆万一不丌且东丐丐:  this.丆与下丌丞丄丌丞三));
            this.上世丏丁世丟世丆业.三丒丌丅丑丝世丝丂(丙业与丙丗丝不丈东:  val_10);
            this.上世丏丁世丟世丆业.丒丈丗丕丁三丞丌业(丙业与丙丗丝不丈东:  BalanceController.不万丅不丆丞与丙七(丆万一不丌且东丐丐:  this.丆与下丌丞丄丌丞三));
            this.上世丏丁世丟世丆业.不一丒丁丄上下丟丛(丙业与丙丗丝不丈东:  BalanceController.丞丟三下丟下丞世丟(丆万一不丌且东丐丐:  this.丆与下丌丞丄丌丞三));
            this.上世丏丁世丟世丆业.三丒丆一七丌东丞丛(丙业与丙丗丝不丈东:  BalanceController.丒丂丂丁三下丘丛三(丆万一不丌且东丐丐:  this.丆与下丌丞丄丌丞三));
            this.上世丏丁世丟世丆业.丙丈世万万丂丙且丆(丙业与丙丗丝不丈东:  BalanceController.一丌丛丂丝丁不东三(丆万一不丌且东丐丐:  this.丆与下丌丞丄丌丞三));
            return;
        }
        
        this.上世丏丁世丟世丆业 = 丄与东丕丑丗丌七上.丑七不且上丗丁一世().丐下下丅与上东丙丑(丈丟且丐上不世专丁:  ((System.String.IsNullOrEmpty(value:  this.一丏丌丐丌三专上上)) != true) ? (this.丆与下丌丞丄丌丞三) : (this.一丏丌丐丌三专上上));
    }
    internal float 三丟丅不丅丅业丛丁()
    {
        int val_9;
        var val_10;
        int val_11;
        if(this.上世丏丁世丟世丆业 == null)
        {
                return 0f;
        }
        
        if(this.上世丏丁世丟世丆业.三丟丅不丅丅业丛丁().Count == 0)
        {
                return 0f;
        }
        
        if(this.上世丏丁世丟世丆业.三丟丅不丅丅业丛丁().Count > this.丕丙万不丆丟三丆丝)
        {
                val_9 = this.丕丙万不丆丟三丆丝;
            val_10 = 1152921526036592992;
            val_11 = val_9;
            return this.上世丏丁世丟世丆业.三丟丅不丅丅业丛丁().Item[val_11];
        }
        
        val_9 = this.上世丏丁世丟世丆业.三丟丅不丅丅业丛丁().Count;
        val_10 = 1152921526036592992;
        val_11 = val_9 - 1;
        return this.上世丏丁世丟世丆业.三丟丅不丅丅业丛丁().Item[val_11];
    }
    public void RemoveTargetRPC(int 世上丕丐丈世上不丏, byte 丏与丅下丞丗与七下)
    {
        UnityEngine.Transform val_5;
        UnityEngine.Transform val_1 = this.丗丕一丁下丅世一三(世上丕丐丈世上不丏:  世上丕丐丈世上不丏, 丏与丅下丞丗与七下:  丏与丅下丞丗与七下);
        val_5 = 1152921504848912384;
        if(val_1 == 0)
        {
                return;
        }
        
        val_5 = this.丞下万上三丘上与专;
        if(val_5 != val_1)
        {
                return;
        }
        
        this.丞下万上三丘上与专 = 0;
        this.丄丂三三丑丆丈东丆 = UnityEngine.Time.time;
    }
    public void SetTargetRPC(int 世上丕丐丈世上不丏, byte 丏与丅下丞丗与七下)
    {
        var val_4;
        this.丞下万上三丘上与专 = this.丗丕一丁下丅世一三(世上丕丐丈世上不丏:  世上丕丐丈世上不丏, 丏与丅下丞丗与七下:  丏与丅下丞丗与七下);
        val_4 = 0;
        this.丘一丑丄丌丗丂与丙 = this.丞下万上三丘上与专.GetComponent<PlayerDamageable>();
    }
    protected UnityEngine.Transform 丗丕一丁下丅世一三(int 世上丕丐丈世上不丏, byte 丏与丅下丞丗与七下)
    {
        PhotonView val_8 = PhotonView.Find(世上丕丐丈世上不丏:  世上丕丐丈世上不丏);
        if(val_8 == 0)
        {
                return 0;
        }
        
        if((丏与丅下丞丗与七下 & 255) == 200)
        {
                TankController val_4 = val_8.GetComponent<TankController>();
            val_8 = val_4.tankObject;
        }
        else
        {
                BaseEquipmentController val_5 = val_8.GetComponent<BaseEquipmentController>();
            if(val_5 != 0)
        {
                val_8 = val_5.GetEquipmentByID(丞丅上丏丂且下丅与:  丏与丅下丞丗与七下);
            if(val_8 != null)
        {
                return val_8.transform;
        }
        
            return val_8.transform;
        }
        
        }
        
        if(val_8 != null)
        {
                return val_8.transform;
        }
        
        return val_8.transform;
    }
    public virtual void AttackTargetRPC()
    {
    
    }
    public virtual void AttackTargetsRPC(int[] 丏丌丄丆丟丝下丟丝, byte[] 丘业丌下丁业下丐东)
    {
    
    }
    public virtual void AttackTargetsRPC(double 七不丅不丛不丁丁上)
    {
    
    }
    public virtual void ShotArtillery(UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕)
    {
    
    }
    public virtual void ShotArtillery(UnityEngine.Vector2[] 丌丐丏丐丆丙丛丁丕, float 丛上丟丌丄丗丁世与)
    {
    
    }
    internal virtual void 万不丄下丂三丕丒不(float 丞丈专下丈专业三丞, int 丞丗且下世丐业丌丙 = 0, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专 = 0)
    {
    
    }
    public virtual void SetDestinationRPC(UnityEngine.Vector3 丁丆丈丂上丙丈丙万, float 东丗上东丘丄东丘世)
    {
    
    }
    public virtual void SyncronizeRPC(float 丆不丝丕且东丅丄三, double 丝业万丑丛丁七丑三)
    {
        double val_4 = 丝业万丑丛丁七丑三;
        if(丆不丝丕且东丅丄三 > 0f)
        {
                val_4 = this.health;
            this.health = UnityEngine.Mathf.Min(a:  val_4, b:  丆不丝丕且东丅丄三);
            return;
        }
        
        if(val_4 <= 0f)
        {
                return;
        }
        
        if(this.丘丄丆不丛丗上三上 != false)
        {
            
        }
        
        this.respawnTimer = System.Math.Min(val1:  this.respawnTimer, val2:  val_4 = 丝业万丑丛丁七丑三);
    }
    internal void 业丂丛丟上且丂东丂(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙 = 0, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专 = 0)
    {
        this.丘丂不业一丆且上丂.SendDamageRPC(上世万世丐丄上丑丆:  this, 丞丈专下丈专业三丞:  (this.health > 丛业专丘丂丅丗丝丛) ? 丛业专丘丂丅丗丝丛 : 10000f, 丞丗且下世丐业丌丙:  丞丗且下世丐业丌丙, 丐丟丘世丁三丕专专:  丐丟丘世丁三丕专专);
    }
    public virtual void Deactivate()
    {
        if(this.丘丄丆不丛丗上三上 == false)
        {
                return;
        }
        
        this.丘丄丆不丛丗上三上 = false;
        this.health = 0f;
        double val_4 = (double)this.丌七丞七专丘丞世丒();
        val_4 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_4;
        this.respawnTimer = val_4;
        this.gameObject.SetActive(value:  false);
    }
    public virtual void Activate()
    {
        if(this.丘丄丆不丛丗上三上 != false)
        {
                return;
        }
        
        this.丘丄丆不丛丗上三上 = true;
        this.health = this.下丄丝七丑业一专一();
        this.respawnTimer = -1;
        this.gameObject.SetActive(value:  true);
        if(this._listBotChangerMaterials == null)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = this._listBotChangerMaterials.GetEnumerator();
        label_6:
        if(((-1748428792) & 1) == 0)
        {
            goto label_4;
        }
        
        0.丐丏七丌丕丗业且上().ResetMainMaterial();
        goto label_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal 不七世丁丟丏世业丑 丛丞丘一丘丈丐丂丙(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        var val_4;
        PhotonView val_1 = this.丕专与下丁不丆世业(丂丈丙且丈丗三丆丕:  丂丈丙且丈丗三丆丕);
        if(丂丈丙且丈丗三丆丕 != null)
        {
                val_4 = 0;
            var val_3 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (TankDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) != null) ? (W2) : 55;
        }
        
        return new 不七世丁丟丏世业丑();
    }
    internal PhotonView 丕专与下丁不丆世业(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        var val_15;
        TankEquipmentController val_16;
        var val_17;
        var val_20;
        val_16 = 丂丈丙且丈丗三丆丕;
        if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                if(this.且丝业丙丁丂万丞与 == false)
        {
            goto label_4;
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() != false)
        {
                label_4:
        }
        
        if((GameConnect.七丂万专且丏丘一丙() != false) && (this.且丝业丙丁丂万丞与 != false))
        {
                val_15 = 0;
            if( != 0)
        {
                if(((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 丂丈丙且丈丗三丆丕 : 0 + 24.一丝丌丏万丐丌丆东()) != false)
        {
                val_16 = mem[(丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 丂丈丙且丈丗三丆丕 : 0 + 24 + 1576];
            val_16 = (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 丂丈丙且丈丗三丆丕 : 0 + 24 + 1576;
            val_17 = mem[(丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 丂丈丙且丈丗三丆丕 : 0 + 24 + 1576 + 496];
            val_17 = (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 丂丈丙且丈丗三丆丕 : 0 + 24 + 1576 + 496;
            return (PhotonView)val_17;
        }
        
        }
        
        }
        
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_29;
        }
        
        if(val_16 == null)
        {
            goto label_52;
        }
        
        if(137129984 == this.丘丂不业一丆且上丂)
        {
            goto label_37;
        }
        
        val_20 = null;
        val_20 = null;
        var val_12 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + FortEquipObject.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_20) ? (val_16) : 0;
        return (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + FortEquipObject.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_20 ? 丂丈丙且丈丗三丆丕 : 0 + 152.GetPhotonView();
        label_29:
        if(val_16 == null)
        {
            goto label_52;
        }
        
        goto label_50;
        label_37:
        label_50:
        label_52:
        val_17 = 0;
        return (PhotonView)val_17;
    }
    internal bool 丗丝丒丈与三丁东丟(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        PhotonView val_1 = this.丕专与下丁不丆世业(丂丈丙且丈丗三丆丕:  丂丈丙且丈丗三丆丕);
        if(val_1 == 0)
        {
                return false;
        }
        
        if(val_1 != null)
        {
                return val_1.isMine;
        }
        
        return val_1.isMine;
    }
    protected void 丗丘七上丏丌丒七丂()
    {
        List.Enumerator<T> val_1 = this._listBotChangerMaterials.GetEnumerator();
        label_4:
        if(((-1747886584) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().ShowDamageEffect(万东丏丌不七东丘万:  false, 丗与丟上上丑专世丗:  0);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.上万万丐丏且与专不());
    }
    private System.Collections.IEnumerator 上万万丐丏且与专不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortEquipObject.丅丘丈丌一丏一东丒();
    }
    public FortEquipObject()
    {
        this.丆与下丌丞丄丌丞三 = System.String.alignConst;
        this.一丏丌丐丌三专上上 = System.String.alignConst;
    }

}
