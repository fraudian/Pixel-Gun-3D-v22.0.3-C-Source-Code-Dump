using UnityEngine;
internal sealed class BonusPickup : PGBehaviour
{
    // Fields
    public float firstSpawnTime;
    public float respawnTime;
    private float 丕丗丑七丁万不世丘;
    public short myIndex;
    protected bool 丁丏且与丗丄上丆丘;
    protected PhotonView 丄丈丑丐丆丞丘与丗;
    public bool isRespawning;
    private UnityEngine.Collider collider;
    private UnityEngine.GameObject meshObject;
    public BonusPickup.业丈丞丏丆且丙丏丈 myType;
    private UnityEngine.AudioSource 不丁丙丑丂丘专丈丆;
    
    // Methods
    private void 东丒万丘丆丐世丕丗(bool 下下东且万业丞丅丒)
    {
        bool val_1 = 下下东且万业丞丅丒;
        this.meshObject.SetActive(value:  val_1);
        this.collider.enabled = val_1;
    }
    private void Awake()
    {
        this.不丁丙丑丂丘专丈丆 = this.GetComponent<UnityEngine.AudioSource>();
        this.丕丗丑七丁万不世丘 = this.firstSpawnTime;
        this.isRespawning = true;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  false);
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
                return;
        }
        
        if(this.myType != 2)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void Update()
    {
        float val_2;
        if(this.丕丗丑七丁万不世丘 <= 0f)
        {
                return;
        }
        
        val_2 = this.丕丗丑七丁万不世丘 - UnityEngine.Time.deltaTime;
        if(val_2 <= 0f)
        {
                this.isRespawning = false;
            this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  true);
            val_2 = 0f;
        }
        
        this.丕丗丑七丁万不世丘 = val_2;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_15;
        var val_16;
        var val_17;
        var val_18;
        val_15 = 丘丛丏丘丝七世七丅.gameObject.transform.root.GetComponentInChildren<Player_move_c>();
        if((UnityEngine.Object.op_Implicit(exists:  val_15)) == false)
        {
                return;
        }
        
        val_16 = 1152921505171275776;
        val_17 = null;
        val_17 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_18 = 丘丛丏丘丝七世七丅.gameObject.transform.root.GetComponentInChildren<Player_move_c>();
            if(val_18.丟丌下三七丁与丟丑() == false)
        {
                return;
        }
        
        }
        
        this.上丙丅丕丛业丛上世(专丞上七七且丝七丗:  丘丛丏丘丝七世七丅.gameObject.transform.root.GetComponentInChildren<Player_move_c>());
    }
    private void 七丅丘七丁七丌丗丅()
    {
        this.isRespawning = false;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  true);
        this.丕丗丑七丁万不世丘 = 0f;
    }
    public void PrepareObject(short 丞世不丒下上上丝丑)
    {
        this.myIndex = 丞世不丒下上上丝丑;
        this.transform.parent = 0;
    }
    private void 上丙丅丕丛业丛上世(Player_move_c 专丞上七七且丝七丗)
    {
        var val_47;
        var val_48;
        var val_49;
        bool val_50;
        bool val_51;
        var val_52;
        OnlineModeController val_53;
        var val_54;
        var val_79;
        val_47 = null;
        val_47 = null;
        val_48 = 1152921504848912384;
        if(GameController.onlineMode != 0)
        {
                val_49 = null;
            val_49 = null;
            val_50 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_50 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_50 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_4 = BattleRoyaleController.丑七不且上丗丁一世();
            val_51 = val_4.squadMode;
        }
        else
        {
                val_51 = 0;
        }
        
        val_52 = null;
        val_52 = null;
        val_53 = GameController.onlineMode;
        if(val_53 != 0)
        {
                val_54 = null;
            val_54 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        }
        
        label_142:
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                val_53 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
            if(val_53 != 0)
        {
                val_53 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
            if(val_53.且世专不丄丏七下万() == true)
        {
                return;
        }
        
        }
        
        }
        
        if(this.myType > 4)
        {
            goto label_156;
        }
        
        var val_49 = 106030704 + (this.myType) << 2;
        var val_10 = (val_51 | val_50) | 0;
        val_49 = val_49 + 106030704;
        goto (106030704 + (this.myType) << 2 + 106030704);
        label_27:
        bool val_42 = GameController.onlineMode.丄丗三丌世东业上丌();
        goto label_142;
        label_156:
        val_79 = null;
        val_79 = null;
        this.七丛丐与丑丈一万丁();
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        BonusPickupsController.丄丘七三上丕世丞业.SendPlayDestroyEffect(丞世不丒下上上丝丑:  this.myIndex);
    }
    private void 七丛丐与丑丈一万丁()
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.GetComponent<UnityEngine.AudioSource>().Play();
        }
        
        this.isRespawning = true;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  false);
        if(this.丕丗丑七丁万不世丘 != 0f)
        {
                return;
        }
        
        this.丕丗丑七丁万不世丘 = this.respawnTime;
    }
    public void ResetState()
    {
        this.isRespawning = true;
        this.丕丗丑七丁万不世丘 = this.firstSpawnTime;
        this.东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  false);
    }
    public void SetSyncTimeLeftToRespawn(byte 丁不丞丂丐丂丈丈丈)
    {
        float val_2 = 255f;
        val_2 = ((float)丁不丞丂丐丂丈丈丈 & 255) / val_2;
        val_2 = val_2 * this.respawnTime;
        this.丕丗丑七丁万不世丘 = val_2;
    }
    public byte GetSyncTimeLeftToRespawn()
    {
        float val_1 = this.respawnTime;
        val_1 = this.丕丗丑七丁万不世丘 / val_1;
        val_1 = val_1 * 255f;
        return (byte)(int)val_1;
    }
    internal void 业丐丞万与七万丗与()
    {
        this.七丛丐与丑丈一万丁();
    }
    private void 丗东业丒丂业上丂丏()
    {
        this.七丛丐与丑丈一万丁();
    }
    public BonusPickup()
    {
        this.firstSpawnTime = 8f;
        this.respawnTime = 15f;
        this.myIndex = 65535;
        this.isRespawning = true;
    }

}
