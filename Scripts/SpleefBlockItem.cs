using UnityEngine;
internal class SpleefBlockItem : MonoBehaviour, 丅丙上七上一丐不下
{
    // Fields
    public float[] liveFromTiers;
    public float live;
    public short index;
    public UnityEngine.Material disolveMaterial;
    public bool isDamageble;
    public bool isKilled;
    private bool 丒丞一下丑丆丐丕丞;
    private UnityEngine.Material 丐丒丟下丛丛丒丒上;
    private UnityEngine.AudioSource 丅丄业与东丂丝丒丑;
    private UnityEngine.Renderer 丑与丗丛丝丈丙丆丌;
    private float 七丕七与丂专丘丟不;
    private int <专业丞不丟专专丐与>k__BackingField;
    private bool 不且万世专不丒丝专;
    private bool 丁丞丁丑且丝丛丆世;
    
    // Properties
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    private void Start()
    {
        var val_7 = null;
        int val_8 = RilisoftBot.BaseBot.且业七丒丞丈丟丛不;
        val_8 = this.liveFromTiers[0] * val_8;
        this.live = val_8;
        this.七丕七与丂专丘丟不 = val_8;
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        UnityEngine.Renderer val_2 = this.GetComponent<UnityEngine.Renderer>();
        float val_9 = this.live;
        val_9 = val_9 / this.七丕七与丂专丘丟不;
        this.丑与丗丛丝丈丙丆丌 = val_2;
        val_2.sharedMaterial = val_2.丁丒丅丏专万万三丂(丛东与丑丌丗东丕丗:  (val_9 >= 0) ? ((val_9 < 0) ? 1 : 0) : 2);
        UnityEngine.AudioSource val_6 = this.GetComponent<UnityEngine.AudioSource>();
        this.丅丄业与东丂丝丒丑 = val_6;
        val_6.enabled = false;
    }
    private UnityEngine.Material 丁丒丅丏专万万三丂(int 丛东与丑丌丗东丕丗)
    {
        UnityEngine.Material[] val_1 = SpleefBlockItemsController.丄丘七三上丕世丞业.stageMaterials + (((long)(int)(丛东与丑丌丗东丕丗)) << 3);
        return (UnityEngine.Material)mem[(SpleefBlockItemsController.丄丘七三上丕世丞业.stageMaterials + ((long)(int)(丛东与丑丌丗东丕丗)) << 3) + 32];
    }
    private int 上下与上丈丏丘丝丌()
    {
        float val_2 = this.live;
        val_2 = val_2 / this.七丕七与丂专丘丟不;
        if(val_2 < 0)
        {
                return 2;
        }
        
        return (int)(val_2 < 0) ? 1 : 0;
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    private void Update()
    {
    
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
        return 100f;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.GetDamage(丞丈专下丈专业三丞:  丞丈专下丈专业三丞);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return true;
    }
    public bool IsDead()
    {
        return (bool)this.isKilled;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public void GetDamage(float 丞丈专下丈专业三丞)
    {
        float val_2;
        var val_3;
        var val_4;
        val_2 = 丞丈专下丈专业三丞;
        float val_2 = this.live;
        if(val_2 <= 0f)
        {
                return;
        }
        
        if(this.isKilled != false)
        {
                return;
        }
        
        val_2 = val_2 - val_2;
        this.isDamageble = true;
        this.live = val_2;
        if(val_2 <= 0f)
        {
                val_3 = null;
            val_3 = null;
            val_2 = 1E+07f;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_4 = null;
            val_4 = null;
            万丑东上万丙业丁丑(丆丞丌东丐一丕一丄:  1);
        }
        
        }
        
        this.丏丝丄不丝丆三丏丟();
        SpleefBlockItemsController.丄丘七三上丕世丞业.GetDamage(丞世不丒下上上丝丑:  this.index, 丞丈专下丈专业三丞:  val_2);
    }
    public void GetDamageRPC(float 不丄一下下丈丈丛世)
    {
        this.isDamageble = true;
        if(this.isKilled != false)
        {
                return;
        }
        
        不丄一下下丈丈丛世 = this.live - 不丄一下下丈丈丛世;
        this.live = 不丄一下下丈丈丛世;
        this.丏丝丄不丝丆三丏丟();
    }
    public void KilledChest()
    {
        UnityEngine.Renderer val_10;
        UnityEngine.Material val_11;
        if(this.isKilled != false)
        {
                return;
        }
        
        this.isKilled = true;
        if(this.丑与丗丛丝丈丙丆丌 == 0)
        {
                val_10 = this.GetComponent<UnityEngine.Renderer>();
            this.丑与丗丛丝丈丙丆丌 = val_10;
        }
        else
        {
                val_10 = this.丑与丗丛丝丈丙丆丌;
        }
        
        if(val_10 != 0)
        {
                val_11 = this.disolveMaterial;
            this.丑与丗丛丝丈丙丆丌.material = val_11;
        }
        
        if((与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false) && (this.丅丄业与东丂丝丒丑 != 0))
        {
                val_11 = 1152921505323831296;
            if(SpleefBlockItemsController.丄丘七三上丕世丞业.deadSound != 0)
        {
                this.丅丄业与东丂丝丒丑.enabled = true;
            val_11 = mem[SpleefBlockItemsController.丄丘七三上丕世丞业 + 64];
            val_11 = SpleefBlockItemsController.丄丘七三上丕世丞业.deadSound;
            this.丅丄业与东丂丝丒丑.PlayOneShot(clip:  val_11);
        }
        
        }
        
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丝三不丑上七丅且丆());
        this.GetComponent<UnityEngine.BoxCollider>().enabled = false;
    }
    private System.Collections.IEnumerator 丝三不丑上七丅且丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SpleefBlockItem.丅丅丛丙丐丝上丒丂();
    }
    private void 丏丝丄不丝丆三丏丟()
    {
        if(this.live <= 0f)
        {
            goto label_0;
        }
        
        if(this.isKilled == false)
        {
            goto label_1;
        }
        
        return;
        label_0:
        this.KilledChest();
        return;
        label_1:
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丗下丝上七丈丂专丄());
    }
    private System.Collections.IEnumerator 丗下丝上七丈丂专丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SpleefBlockItem.三丈丛丄一七丌丌丕();
    }
    public SpleefBlockItem()
    {
        this.liveFromTiers = new float[6] {5.748827E-41f, 8.618686E-41f, 1.157192E-41f, 2.592122E-41f, 4.027052E-41f, 5.031502E-41f};
    }

}
