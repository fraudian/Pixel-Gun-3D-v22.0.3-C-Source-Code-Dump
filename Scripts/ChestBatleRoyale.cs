using UnityEngine;
internal class ChestBatleRoyale : MonoBehaviour, 丅丙上七上一丐不下, 世丂丈世且万世丞上
{
    // Fields
    public ChestBatleRoyale.专丈东下专与丒上业 typeChest;
    public float sqrDistanceMin;
    public short index;
    public UnityEngine.AudioClip brokenAudio;
    public UnityEngine.Transform chest;
    private UnityEngine.Vector3 丁丕丏不下丁上丙丘;
    public UnityEngine.GameObject chestSmoke;
    public ChestBatleRoyale.丈丛万专丁专丐业一 state;
    private bool 丁丞丛丑丂世一丙丆;
    public bool isBonusUsed;
    public string weaponBonusName;
    private System.Collections.Generic.List<ChestBatleRoyale.AdditionalItem> _additionalItems;
    private ChestBatleRoyale.丞上七丈丗丝与丏丄 万丁丕七丞丞丂与丟;
    private UnityEngine.Coroutine 业丅世丁丐丑与不丂;
    private UnityEngine.Coroutine 东丂万专一与丂世丘;
    private UnityEngine.Transform <丗专丟丑万丙与专丌>k__BackingField;
    private UnityEngine.GameObject 丈丞丒丗丈上丟丄一;
    private UnityEngine.Animation 丄丑专丑丝世丏丘丟;
    private bool 丒丒丝丕丛丆丘三与;
    private 业丗丕丟三丝丘三丗 一与丄丂上丂丈三东;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    private UnityEngine.SkinnedMeshRenderer 下丆丙丅丅与丏丗下;
    private UnityEngine.GameObject royaleChest;
    private UnityEngine.GameObject royaleChestLow;
    private WeaponSounds 丆业七丌丁丕一丐七;
    private bool isAddedToPopUpWindow;
    private UnityEngine.GameObject 丅丅丌丕世丙不丑丄;
    private float 丘丁丘世丄丒且一丘;
    public float progressLockMineBonus;
    private float 与丘上丑不丐上丙丐;
    private float 丙七丝东世丒丝与一;
    private float 丙丆丄东丈丙不丝一;
    private bool 丏丏七丛丂丄且世丙;
    private float 专丄丂丒与丄丝丗上;
    private bool 专一丕丛丛且丈三丛;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public bool 七丈丙丐丕丘丁七丟 { get; set; }
    internal ChestBatleRoyale.丞上七丈丗丝与丏丄 世丟万一丘丐丙丝与 { get; set; }
    internal UnityEngine.Transform 万一丂丐丄丁上与丟 { get; set; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    public bool get_IsActiveChest()
    {
        if(this.丁丞丛丑丂世一丙丆 == false)
        {
                return false;
        }
        
        return (bool)(this.state == 1) ? 1 : 0;
    }
    public void set_IsActiveChest(bool 丙业与丙丗丝不丈东)
    {
        this.丁丞丛丑丂世一丙丆 = 丙业与丙丗丝不丈东;
    }
    internal ChestBatleRoyale.丞上七丈丗丝与丏丄 丙与世丏丂丞丂丑丛()
    {
        return (丞上七丈丗丝与丏丄)this.万丁丕七丞丞丂与丟;
    }
    internal void 丑与且且且丁丐丆丐(ChestBatleRoyale.丞上七丈丗丝与丏丄 丙业与丙丗丝不丈东)
    {
        this.万丁丕七丞丞丂与丟 = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Transform 丗且丙丄七东丟丝下()
    {
        return (UnityEngine.Transform)this.<丗专丟丑万丙与专丌>k__BackingField;
    }
    private void 丄世丐与丒丆丒下专(UnityEngine.Transform 丙业与丙丗丝不丈东)
    {
        this.<丗专丟丑万丙与专丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        UnityEngine.AudioSource val_1 = this.GetComponent<UnityEngine.AudioSource>();
        this.丞下上且一上丙不丏 = val_1;
        val_1.enabled = false;
        this.丄丑专丑丝世丏丘丟 = this.GetComponent<UnityEngine.Animation>();
        UnityEngine.Transform val_3 = this.transform;
        this.<丗专丟丑万丙与专丌>k__BackingField = val_3;
        UnityEngine.Vector3 val_4 = val_3.position;
        this.丁丕丏不下丁上丙丘 = val_4;
        mem[1152921525670574588] = val_4.y;
        mem[1152921525670574592] = val_4.z;
        this.丄丑专丑丝世丏丘丟.Stop();
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        this.丁丞丛丑丂世一丙丆 = (this.typeChest != 3) ? 1 : 0;
        UnityEngine.SkinnedMeshRenderer val_7 = this.GetComponentInChildren<UnityEngine.SkinnedMeshRenderer>();
        this.下丆丙丅丅与丏丗下 = val_7;
        this.丏丏七丛丂丄且世丙 = val_7.enabled;
        if(this.royaleChest != 0)
        {
                this.royaleChest.SetActive(value:  false);
        }
        
        if(this.royaleChestLow == 0)
        {
                return;
        }
        
        this.royaleChestLow.SetActive(value:  true);
    }
    private void OnDestroy()
    {
        var val_4;
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  false);
    }
    public void SetBonusState()
    {
        if(this.state != 1)
        {
                return;
        }
        
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        if(this.chestSmoke != 0)
        {
                this.chestSmoke.SetActive(value:  false);
        }
        
        this.state = 2;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.丞下上且一上丙不丏.enabled = true;
            this.丞下上且一上丙不丏.PlayOneShot(clip:  this.brokenAudio);
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丕丈丂丞下丛一丆丝());
        }
        
        this.丄丑专丑丝世丏丘丟.Stop();
        if(this.royaleChest != 0)
        {
                this.royaleChest.SetActive(value:  true);
        }
        
        if(this.royaleChestLow != 0)
        {
                this.royaleChestLow.SetActive(value:  false);
        }
        
        bool val_10 = this.丄丑专丑丝世丏丘丟.Play(animation:  "Broken");
        this.东丂万专一与丂世丘 = this.StartCoroutine(routine:  this.万三丗下丆丁万业丁());
        this.GetComponent<UnityEngine.BoxCollider>().enabled = false;
        this.业丅世丁丐丑与不丂 = this.StartCoroutine(routine:  this.丂丒丆丏丁业丁丁丂());
    }
    internal void 且不七丄且专丅东丌()
    {
        var val_3;
        var val_20;
        var val_21;
        var val_22;
        val_20 = this;
        if(this._additionalItems == null)
        {
                return;
        }
        
        if(this._additionalItems.Count < 1)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this._additionalItems.GetEnumerator();
        label_34:
        if(((-410512704) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_3.GetAwaiter();
        if(val_5._value._obj == 1)
        {
            goto label_5;
        }
        
        if(val_5._value._obj != 2)
        {
            goto label_34;
        }
        
        丕丈丏丝丗下丟丅丂 val_7 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_5._value._token];
        val_21 = null;
        val_21 = null;
        object[] val_8 = new object[3];
        val_8[0] = val_5._value._token;
        UnityEngine.Vector3 val_10 = this.transform.position;
        val_3 = 0;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = UnityEngine.Random.Range(min:  -1f, max:  1f), y = 0.5f, z = UnityEngine.Random.Range(min:  -1f, max:  1f)});
        val_8[1] = val_13;
        val_8[2] = val_7.丄丑丏与丌丌丕丄丛;
        PickUpObjectSystem.PickUpObjectController.丄丘七三上丕世丞业.AddPickUpObject(丂一丘丞丗下丝丁丞:  2, 专丒丌丆下丐丞丟丞:  val_8);
        goto label_34;
        label_5:
        val_22 = null;
        val_22 = null;
        UnityEngine.Vector3 val_15 = this.transform.position;
        float val_16 = UnityEngine.Random.Range(min:  -1f, max:  1f);
        float val_17 = UnityEngine.Random.Range(min:  -1f, max:  1f);
        val_3 = 0;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        BonusController.丄丞丁丈与业上丞丟.万丗丏丘丐丙丂专业(丆与丕丕丂下丟一丈:  this.weaponBonusName, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        goto label_34;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private System.Collections.IEnumerator 丕丈丂丞下丛一丆丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ChestBatleRoyale.东一丟丏业丛丕丕丂();
    }
    private System.Collections.IEnumerator 万三丗下丆丁万业丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ChestBatleRoyale.丈丘丞丗三且丑一丙();
    }
    private System.Collections.IEnumerator 丂丒丆丏丁业丁丁丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ChestBatleRoyale.丕七东丑丐丗丑丛丑();
    }
    public void AddListAdditionalBonus(System.Collections.Generic.List<ChestBatleRoyale.AdditionalItem> 七丘专世丙丟世世丕)
    {
        this._additionalItems.AddRange(collection:  七丘专世丙丟世世丕);
    }
    private void 上丂业丟七丕丂丒东(UnityEngine.ResourceRequest 与上丏下万丛世丑且)
    {
        UnityEngine.GameObject val_20;
        var val_21;
        int val_22;
        UnityEngine.Object val_23;
        WeaponSounds val_24;
        .丝且与丝丒丟万丁专 = this;
        val_20 = 与上丏下万丛世丑且.asset;
        if(val_20 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_20 = 0;
        label_4:
        WeaponSounds val_3 = val_20.GetComponent<WeaponSounds>();
        .丛丟三丘丛且业丈丏 = val_3;
        this.丆业七丌丁丕一丐七 = val_3;
        val_21 = null;
        val_21 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != true)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            string val_6 = System.String.Format(format:  "LoadGameObjectFX/Bonus_Guns_Rays/Guns_Ray_{0}", arg0:  (ChestBatleRoyale.丝业丞丕丟万万丝丙)[1152921525671942144].丛丟三丘丛且业丈丏.丌上丗丕不七世丅丁().ToString());
            val_22 = val_6;
            UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  val_6);
            if(val_7 != null)
        {
                var val_8 = (null == null) ? (val_7) : 0;
        }
        else
        {
                val_23 = 0;
        }
        
            if(val_23 != 0)
        {
                UnityEngine.Vector3 val_10 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_23, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w});
            this.丅丅丌丕世丙不丑丄 = val_12;
            val_22 = this.gameObject.layer;
            val_12.layer = val_22;
            ZombieCreator.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丅丅丌丕世丙不丑丄, 丁东丑丞与下丛丐东:  this.gameObject.layer);
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "Not found ray:"("Not found ray:") + val_22);
        }
        
        }
        
        val_24 = (ChestBatleRoyale.丝业丞丕丟万万丝丙)[1152921525671942144].丛丟三丘丛且业丈丏;
        if((ChestBatleRoyale.丝业丞丕丟万万丝丙)[1152921525671942144].丛丟三丘丛且业丈丏 == null)
        {
                val_24 = (ChestBatleRoyale.丝业丞丕丟万万丝丙)[1152921525671942144].丛丟三丘丛且业丈丏;
        }
        
        丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_20, 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  new ChestBatleRoyale.丝业丞丕丟万万丝丙(), 丛丌丙世专世东丕下:  System.Void ChestBatleRoyale.丝业丞丕丟万万丝丙::丕业一丆万丝世丑丒(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)), 七丆丒与丗丌丄且丂:  (ChestBatleRoyale.丝业丞丕丟万万丝丙)[1152921525671942144].丛丟三丘丛且业丈丏.categoryNabor - 1, 丐丑七万丌丂专与丌:  val_24);
    }
    private void 三丗丏业丞丛丑下与(UnityEngine.ResourceRequest 与上丏下万丛世丑且)
    {
        UnityEngine.GameObject val_27;
        var val_28;
        UnityEngine.Object val_29;
        UnityEngine.Object val_1 = 与上丏下万丛世丑且.asset;
        if(val_1 != null)
        {
                val_1 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_27 = 0;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_27);
        val_28 = null;
        val_28 = null;
        if((东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true) || ((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  this.weaponBonusName)) == false))
        {
            goto label_17;
        }
        
        丕丈丏丝丗下丟丅丂 val_6 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[this.weaponBonusName];
        if(val_6 == null)
        {
            goto label_17;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_9 = System.String.Format(format:  "LoadGameObjectFX/Bonus_Guns_Rays/Guns_Ray_{0}", arg0:  val_6.七东与丄丕丁丛世三().ToString());
        UnityEngine.Object val_10 = UnityEngine.Resources.Load(path:  val_9);
        if(val_10 != null)
        {
                var val_11 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_29 = 0;
        }
        
        if(val_29 == 0)
        {
            goto label_24;
        }
        
        UnityEngine.Vector3 val_13 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_29, position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, rotation:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w});
        this.丅丅丌丕世丙不丑丄 = val_15;
        val_15.layer = this.gameObject.layer;
        ZombieCreator.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丅丅丌丕世丙不丑丄, 丁东丑丞与下丛丐东:  this.gameObject.layer);
        label_17:
        if(val_2 != null)
        {
            goto label_51;
        }
        
        label_52:
        label_51:
        val_2.transform.SetParent(p:  this.<丗专丟丑万丙与专丌>k__BackingField);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  0);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_25.z, w = val_25.w};
        this.丈丞丒丗丈上丟丄一 = val_2;
        return;
        label_24:
        UnityEngine.Debug.LogError(message:  "Not found ray:"("Not found ray:") + val_9);
        if(val_2 != null)
        {
            goto label_51;
        }
        
        goto label_52;
    }
    public void DelBonus()
    {
        this.state = 3;
        if(this.isAddedToPopUpWindow != false)
        {
                if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                this.一不丈丌丌与丂丟丒();
        }
        
        }
        
        if(this.业丅世丁丐丑与不丂 != null)
        {
                this.StopCoroutine(routine:  this.业丅世丁丐丑与不丂);
            this.业丅世丁丐丑与不丂 = 0;
        }
        
        if(this.东丂万专一与丂世丘 != null)
        {
                this.StopCoroutine(routine:  this.东丂万专一与丂世丘);
            this.丄丑专丑丝世丏丘丟.Stop();
            UnityEngine.Vector3 val_2 = this.chest.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  10000f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.chest.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.东丂万专一与丂世丘 = 0;
        }
        
        if(this.丅丅丌丕世丙不丑丄 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丅丅丌丕世丙不丑丄);
        }
        
        if(this.丈丞丒丗丈上丟丄一 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.丈丞丒丗丈上丟丄一);
    }
    private void 一不丈丌丌与丂丟丒()
    {
        this.isAddedToPopUpWindow = false;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丘丏丛丂丅丂世上丒 == 0)
        {
                return;
        }
        
        InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  false);
    }
    public void UpdateChest(bool 世丑丙下丝丌万丄丟, bool 七一下一丐丈丄七下)
    {
        ScopeViewGameEventsController val_21;
        float val_22;
        var val_23;
        float val_24;
        float val_25;
        float val_26;
        bool val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_21 = 世丑丙下丝丌万丄丟;
        val_22 = this.专丄丂丒与丄丝丗上;
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        if(val_22 >= 0)
        {
            goto label_25;
        }
        
        if(七一下一丐丈丄七下 == false)
        {
            goto label_2;
        }
        
        val_23 = null;
        val_23 = null;
        label_41:
        label_40:
        UnityEngine.Vector3 val_2 = 0.position;
        val_22 = val_2.x;
        UnityEngine.Vector3 val_3 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
        val_24 = val_3.x;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_22, y = val_2.y, z = val_2.z});
        val_25 = 22500f;
        val_26 = 40000f;
        this.丙丆丄东丈丙不丝一 = val_4.x;
        this.专一丕丛丛且丈三丛 = (val_4.x < 0) ? 1 : 0;
        if(val_4.x > val_26)
        {
            goto label_12;
        }
        
        val_26 = 250f;
        if(val_4.x < 0)
        {
            goto label_12;
        }
        
        if(val_4.x < 0)
        {
            goto label_13;
        }
        
        val_22 = UnityEngine.Time.realtimeSinceStartup;
        val_25 = 1f;
        val_24 = val_22 + (UnityEngine.Random.Range(min:  0.5f, max:  val_25));
        goto label_14;
        label_2:
        val_28 = null;
        val_28 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
            goto label_19;
        }
        
        val_29 = null;
        val_29 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform != null)
        {
            goto label_40;
        }
        
        goto label_41;
        label_12:
        val_22 = UnityEngine.Time.realtimeSinceStartup;
        val_25 = val_22 + 3f;
        val_24 = val_25 + (UnityEngine.Random.Range(min:  0f, max:  1f));
        label_14:
        val_27 = this.专一丕丛丛且丈三丛;
        this.专丄丂丒与丄丝丗上 = val_24;
        label_13:
        if(((this.丏丏七丛丂丄且世丙 == true) ? 1 : 0) != ((val_27 == true) ? 1 : 0))
        {
                this.下丆丙丅丅与丏丗下.enabled = (val_27 == true) ? 1 : 0;
            this.丏丏七丛丂丄且世丙 = this.专一丕丛丛且丈三丛;
        }
        
        label_25:
        if(val_21 == false)
        {
            goto label_27;
        }
        
        if((this.丁丞丛丑丂世一丙丆 == false) || (this.state != 1))
        {
            goto label_29;
        }
        
        if(this.丒丒丝丕丛丆丘三与 == true)
        {
            goto label_47;
        }
        
        if((this.typeChest - 1) >= 3)
        {
            goto label_31;
        }
        
        val_30 = mem[106019712 + ((this.typeChest - 1)) << 2];
        val_30 = 106019712 + ((this.typeChest - 1)) << 2;
        goto label_32;
        label_27:
        if(this.丒丒丝丕丛丆丘三与 == true)
        {
            goto label_33;
        }
        
        goto label_47;
        label_29:
        if(this.丒丒丝丕丛丆丘三与 == false)
        {
            goto label_47;
        }
        
        val_31 = null;
        val_31 = null;
        val_21 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
        val_21.DisableEvent(丅东专与不三丂丁丝:  this.一与丄丂上丂丈三东);
        label_33:
        this.一与丄丂上丂丈三东 = 0;
        this.丒丒丝丕丛丆丘三与 = false;
        label_47:
        if(this.state != 2)
        {
                return;
        }
        
        this.丟一且上丘专丗丅丛(七一下一丐丈丄七下:  七一下一丐丈丄七下);
        return;
        label_19:
        if((this.<丗专丟丑万丙与专丌>k__BackingField) != null)
        {
            goto label_40;
        }
        
        goto label_41;
        label_31:
        label_32:
        val_32 = null;
        val_32 = null;
        UnityEngine.Color val_19 = 丞东丑专丛丆丄丝世.且丁丒丙丞丙丒丈上(一丞万丈丌上丌丛七:  (this.typeChest == 4) ? -10418433 : (!0));
        this.一与丄丂上丂丈三东 = ScopeViewGameEventsController.丄丘七三上丕世丞业.AddEvent(且下丕七丙丗丄不七:  0, 业不不丞专丗丟世丈:  this.transform, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a}, 丑丘丛丆丝上丂丙丗:  -1f, 丐丟丕丌与丞丅下万:  1f);
        this.丒丒丝丕丛丆丘三与 = true;
        goto label_47;
    }
    private void 七丐丂万丁一与丕不(bool 七一下一丐丈丄七下)
    {
        UnityEngine.Object val_45;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_63;
        var val_64;
        var val_65;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        if(this.state != 2)
        {
            goto label_1;
        }
        
        if(七一下一丐丈丄七下 == false)
        {
            goto label_2;
        }
        
        float val_45 = 120f;
        val_45 = UnityEngine.Time.deltaTime * val_45;
        this.<丗专丟丑万丙与专丌>k__BackingField.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_47 = 1152921505286238208;
        val_48 = null;
        val_48 = null;
        val_49 = null;
        val_49 = null;
        val_50 = null;
        val_50 = null;
        if(InGameGUI.丙丞专丌丁丞与不丐.isTurretInterfaceActive != true)
        {
                val_51 = null;
            val_51 = null;
            UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            UnityEngine.Vector3 val_3 = this.<丗专丟丑万丙与专丌>k__BackingField.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) < 0)
        {
                val_52 = null;
            val_52 = null;
        }
        
        }
        
        val_53 = this;
        val_54 = 1152921525672878272;
        this.丘丁丘世丄丒且一丘 = 0f;
        mem[1152921525672990568] = 0;
        var val_46 = 0;
        label_50:
        val_55 = null;
        val_55 = null;
        if(val_46 >= typeof(Player_move_c).__il2cppRuntimeField_540.Count)
        {
            goto label_184;
        }
        
        val_56 = null;
        val_56 = null;
        val_45 = typeof(Player_move_c).__il2cppRuntimeField_540.Item[0];
        val_46 = val_46 + 1;
        if(val_45 != this)
        {
            goto label_50;
        }
        
        val_57 = null;
        val_57 = null;
        bool val_9 = typeof(Player_move_c).__il2cppRuntimeField_540.Remove(item:  this);
        goto label_184;
        label_1:
        if(七一下一丐丈丄七下 == false)
        {
                return;
        }
        
        val_47 = 1152921525672877248;
        val_54 = 1152921504848912384;
        var val_47 = 0;
        do
        {
            val_58 = null;
            val_58 = null;
            if(val_47 >= typeof(Player_move_c).__il2cppRuntimeField_540.Count)
        {
                return;
        }
        
            val_59 = null;
            val_59 = null;
            val_47 = val_47 + 1;
        }
        while(typeof(Player_move_c).__il2cppRuntimeField_540.Item[0] != this);
        
        val_60 = null;
        val_60 = null;
        bool val_13 = typeof(Player_move_c).__il2cppRuntimeField_540.Remove(item:  this);
        return;
        label_2:
        val_53 = this;
        this.丘丁丘世丄丒且一丘 = 0f;
        mem[1152921525672990568] = 0;
        label_184:
        val_61 = null;
        val_61 = null;
        this.progressLockMineBonus = UnityEngine.Mathf.Clamp01(value:  this.丘丁丘世丄丒且一丘 / WeaponBonusItem.丞丄丗丅丙七业东丈);
        return;
        label_103:
        val_65 = null;
        val_65 = null;
        if((System.String.op_Equality(a:  WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0].丈专世七丗三丙丝下(), b:  this.weaponBonusName)) == true)
        {
            goto label_122;
        }
        
        val_63 = null;
        val_64 = 1;
        val_63 = null;
        if(val_64 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_103;
        }
        
        val_68 = null;
        val_68 = null;
        if(this.丘丁丘世丄丒且一丘 >= WeaponBonusItem.丞丄丗丅丙七业东丈)
        {
            goto label_122;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_137;
        }
        
        val_69 = null;
        val_69 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丐丁丂丛万丂丒下不()) == true)
        {
            goto label_132;
        }
        
        val_70 = null;
        val_70 = null;
        if(丗丞业丐丛三上丄丕() == false)
        {
            goto label_137;
        }
        
        label_132:
        this.丘丁丘世丄丒且一丘 = 0f;
        var val_48 = 0;
        label_151:
        val_71 = null;
        val_71 = null;
        if(val_48 >= typeof(Player_move_c).__il2cppRuntimeField_540.Count)
        {
            goto label_143;
        }
        
        val_72 = null;
        val_72 = null;
        val_48 = val_48 + 1;
        if(typeof(Player_move_c).__il2cppRuntimeField_540.Item[0] != this)
        {
            goto label_151;
        }
        
        val_73 = null;
        val_73 = null;
        bool val_39 = typeof(Player_move_c).__il2cppRuntimeField_540.Remove(item:  this);
        label_143:
        this.与丘上丑不丐上丙丐 = this.丙七丝东世丒丝与一;
        goto label_184;
        label_122:
        this.DelBonus();
        val_74 = null;
        val_74 = null;
        ChestsBattleRoyaleController.丄丘七三上丕世丞业.GetBonus(丞世不丒下上上丝丑:  this.index);
        goto label_184;
        label_137:
        if(this.与丘上丑不丐上丙丐 <= 0f)
        {
            goto label_162;
        }
        
        float val_40 = UnityEngine.Time.deltaTime;
        val_40 = this.与丘上丑不丐上丙丐 - val_40;
        this.与丘上丑不丐上丙丐 = val_40;
        goto label_184;
        label_162:
        float val_41 = UnityEngine.Time.deltaTime;
        val_41 = this.丘丁丘世丄丒且一丘 + val_41;
        this.丘丁丘世丄丒且一丘 = val_41;
        var val_49 = 0;
        label_177:
        val_75 = null;
        val_75 = null;
        val_76 = null;
        if(val_49 >= typeof(Player_move_c).__il2cppRuntimeField_540.Count)
        {
            goto label_169;
        }
        
        val_77 = null;
        val_49 = val_49 + 1;
        if(typeof(Player_move_c).__il2cppRuntimeField_540.Item[0] != this)
        {
            goto label_177;
        }
        
        goto label_184;
        label_169:
        val_78 = null;
        typeof(Player_move_c).__il2cppRuntimeField_540.Add(item:  this);
        goto label_184;
    }
    private void 丟一且上丘专丗丅丛(bool 七一下一丐丈丄七下)
    {
        Player_move_c val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != true)
        {
                this.isAddedToPopUpWindow = false;
        }
        
        if(七一下一丐丈丄七下 == false)
        {
                return;
        }
        
        float val_9 = 120f;
        val_9 = UnityEngine.Time.deltaTime * val_9;
        this.<丗专丟丑万丙与专丌>k__BackingField.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        int val_3 = UnityEngine.Time.frameCount;
        if(0 != 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_11 = null;
        val_11 = null;
        val_9 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
        val_9 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
        val_12 = null;
        val_12 = null;
        val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_13 = null;
        val_13 = null;
        val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_9 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐.isTurretInterfaceActive != true)
        {
                val_14 = null;
            val_14 = null;
        }
        
        do
        {
            if(this.isAddedToPopUpWindow == false)
        {
                return;
        }
        
            this.一不丈丌丌与丂丟丒();
            return;
        }
        while( > 36f);
    
    }
    private string 丘不丗丁丛丘东丛一()
    {
        string val_1;
        string val_2;
        if(this.万丁丕七丞丞丂与丟 != 2)
        {
                if(this.万丁丕七丞丞丂与丟 != 1)
        {
                return "";
        }
        
            val_1 = this.weaponBonusName;
            val_2 = "Weapons/";
            return val_2 + val_1;
        }
        
        val_1 = this.weaponBonusName;
        val_2 = "GadgetBRPrefab/";
        return val_2 + val_1;
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
        return 1f;
    }
    public float GetGamePlayForBaseGamePlay(int 业丆丈丟世一业一丙, int 业万上丆丐丞且丒七)
    {
        return (float)(float)业丆丈丟世一业一丙;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        var val_3;
        if(this.丁丞丛丑丂世一丙丆 == false)
        {
                return;
        }
        
        if(this.state != 1)
        {
                return;
        }
        
        Rilisoft.丞丛七上丕专丏丌丈.丘丛一丛丈丅丄丑丝(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  UnityEngine.Application.loadedLevelName);
        val_3 = null;
        val_3 = null;
        ChestsBattleRoyaleController.丄丘七三上丕世丞业.KillChest(丞世不丒下上上丝丑:  this.index);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return true;
    }
    public bool IsDead()
    {
        return (bool)(this.state > 1) ? 1 : 0;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public bool AlreadyHaveThisWeapon()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_7 = 0;
        label_11:
        val_7 = null;
        val_7 = null;
        val_8 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        if(val_7 >= val_8.Count)
        {
            goto label_5;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        val_7 = val_7 + 1;
        if((System.String.op_Equality(a:  val_8.丈专世七丗三丙丝下(), b:  this.weaponBonusName)) == false)
        {
            goto label_11;
        }
        
        val_10 = 1;
        return (bool)val_10;
        label_5:
        val_10 = 0;
        return (bool)val_10;
    }
    public void AddWeaponToPlayer()
    {
        var val_1;
        InGameGUIPart_BattleRoyale.__il2cppRuntimeField_generic_class.丂丟丗丗三不丁丏上(丆丗上丗丆丑丘一丞:  this, 丁丈丝上丐且丘且专:  true);
        val_1 = null;
        val_1 = null;
        ChestsBattleRoyaleController.丄丘七三上丕世丞业.GetBonus(丞世不丒下上上丝丑:  this.index);
        this.DelBonus();
    }
    public string GetWeaponName()
    {
        return (string)this.weaponBonusName;
    }
    public int GetCurrentAmmoInClip()
    {
        var val_5;
        int val_6;
        val_5 = this;
        if(this.typeChest == 4)
        {
                val_5 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[this.weaponBonusName];
            val_6 = val_2.丄丑丏与丌丌丕丄丛;
            return (int)val_6;
        }
        
        if(this.丆业七丌丁丕一丐七 == 0)
        {
                val_6 = 0;
            return (int)val_6;
        }
        
        三丅丁丗丗丝丂万且 val_4 = this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁();
        if(val_4 != null)
        {
                return val_4.下世下丂丂丌丑丝世();
        }
        
        return val_4.下世下丂丂丌丑丝世();
    }
    public int GetCurrentAmmoInBackpack()
    {
        if(this.丆业七丌丁丕一丐七 == 0)
        {
                return 0;
        }
        
        三丅丁丗丗丝丂万且 val_2 = this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁();
        if(val_2 != null)
        {
                return val_2.丆丁丄丐丕下丘业丟();
        }
        
        return val_2.丆丁丄丐丕下丘业丟();
    }
    public ItemRarity GetRarity()
    {
        if(this.丆业七丌丁丕一丐七 != 0)
        {
            goto label_3;
        }
        
        if(this.typeChest != 4)
        {
            goto label_4;
        }
        
        丕丈丏丝丗下丟丅丂 val_3 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[this.weaponBonusName];
        if(val_3 != null)
        {
                return val_3.七东与丄丕丁丛世三();
        }
        
        return val_3.七东与丄丕丁丛世三();
        label_3:
        三丅丁丗丗丝丂万且 val_4 = this.丆业七丌丁丕一丐七.丌上丗丕不七世丅丁();
        if(val_4 != null)
        {
                return val_4.丆丙专丆丅丟丙与丈();
        }
        
        return val_4.丆丙专丆丅丟丙与丈();
        label_4:
        if((丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  this.weaponBonusName)) == null)
        {
            
        }
    
    }
    public bool IsGadget()
    {
        return (bool)(this.typeChest == 4) ? 1 : 0;
    }
    public ChestBatleRoyale()
    {
        this.sqrDistanceMin = 4f;
        this.state = 1;
        this.weaponBonusName = System.String.alignConst;
        this._additionalItems = new System.Collections.Generic.List<AdditionalItem>();
        this.丙七丝东世丒丝与一 = 0.25f;
        this.专一丕丛丛且丈三丛 = 1;
    }

}
