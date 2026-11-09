using UnityEngine;
internal class BonusController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static BonusController 丄丞丁丈与业上丞丟;
    public UnityEngine.GameObject bonusPrefab;
    public BonusItem[] bonusStack;
    internal System.Collections.Generic.List<SettingBonus> 丒丘东丌丞丛三下下;
    internal static System.Collections.Generic.List<BonusCreationZone> 上丒丒七丙专业丘丗;
    public UnityEngine.GameObject bonusWeaponPrefab;
    public System.Collections.Generic.List<WeaponBonusItem> bonusWeaponStack;
    private float 丞业且丂且丄东丆且;
    public float timerToAddBonus;
    private bool 丁丑丅丏丒不七上丁;
    private bool 丝丙七丒且丂丝与丏;
    private bool 专世丙世与丑不丄丄;
    public bool isBeginCreateBonuses;
    private WeaponManager 丐下丁三且丗上丈东;
    private ZombieCreator 专业丙上丕丌丙丕三;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    public int maxCountBonus;
    public int startCountBonus;
    private int 上一丆丐丙不丏丆七;
    private int 与与丁一丑丟丌丑丅;
    private System.Collections.Generic.Dictionary<int, int> 丗丐丐东丈丅丄丛丌;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, int>> 不丅丈丛丞东丌丝丆;
    private int 不丅业丈上一丝丟丟;
    private System.Collections.Generic.List<WeaponBonusPreview> 丟丟丘东上不丗世丄;
    private int 丛丆三丅丁上丐世丁;
    private int 七丝专丗丛与丗丐丅;
    
    // Methods
    private void 丈丘丕丞丛丈丟万丆()
    {
        BonusItem[] val_15;
        var val_16;
        BonusItem[] val_17;
        var val_18;
        val_15 = 1152921505066536960;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_6;
        }
        
        }
        
        val_16 = 30;
        goto label_7;
        label_6:
        val_16 = 6;
        label_7:
        int val_3 = val_16 + this.maxCountBonus;
        val_17 = new BonusItem[0];
        this.bonusStack = val_17;
        this.不丅业丈上一丝丟丟 = 0;
        val_18 = 0;
        goto label_8;
        label_25:
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  100f);
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bonusPrefab, position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        val_8.transform.parent = this.transform;
        val_15 = this.bonusStack;
        BonusItem val_11 = val_8.GetComponent<BonusItem>();
        if(val_15 == null)
        {
            goto label_18;
        }
        
        if(val_11 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_11 == null)
        {
            goto label_22;
        }
        
        label_19:
        label_22:
        val_15[0] = val_11;
        val_17 = this.bonusStack;
        val_18 = 1;
        label_8:
        if(val_18 < this.bonusStack.Length)
        {
            goto label_25;
        }
        
        var val_15 = 7;
        do
        {
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            bool val_14 = this.丟丞业且丝丞与东丑(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 丌下丏丐丕丏不丗一:  this.一丈与丗丗七与一丟(), 与与专丟丗东丌与丆:  0f);
            val_15 = val_15 - 1;
        }
        while(val_15 != 0);
    
    }
    private void Awake()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = null;
        val_13 = null;
        if(BonusController.丄丞丁丈与业上丞丟 == 0)
        {
                val_14 = null;
            val_14 = null;
            BonusController.丄丞丁丈与业上丞丟 = this;
        }
        else
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        val_15 = 1091567616;
        if((GameConnect.丌专丌万一下丕专上() != true) && (GameConnect.万七丄丛丈丟专一丑() != true))
        {
                if(GameConnect.业丛丛丂一丆丕丗丟() != false)
        {
                val_15 = 1091567616 + 6291456;
        }
        else
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_39;
        }
        
            val_15 = 1050214400;
            val_15 = 16025;
        }
        
        }
        
        this.丞业且丂且丄东丆且 = 0.3f;
        label_39:
        this.timerToAddBonus = 0.3f;
        val_16 = null;
        val_16 = null;
        this.丁丑丅丏丒不七上丁 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        this.丝丙七丒且丂丝与丏 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == true)
        {
                return;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == true)
        {
                return;
        }
        
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_37;
        }
        
        val_17 = 2;
        goto label_46;
        label_37:
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_45;
        }
        
        }
        
        val_17 = 3;
        goto label_46;
        label_45:
        val_17 = 5;
        label_46:
        this.maxCountBonus = 5;
    }
    private void Start()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        PhotonView val_1 = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
        this.丄丈丑丐丆丞丘与丗 = val_1;
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
        {
                PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        }
        
        val_5 = null;
        val_5 = null;
        if(this.maxCountBonus > BonusController.上丒丒七丙专业丘丗.Count)
        {
                val_6 = null;
            val_6 = null;
            this.maxCountBonus = BonusController.上丒丒七丙专业丘丗.Count;
        }
        
        val_7 = null;
        val_7 = null;
        this.专业丙上丕丌丙丕三 = ZombieCreator.丞丈丟丒丂丞丏不丑;
        val_8 = null;
        val_8 = null;
        this.丐下丁三且丗上丈东 = WeaponManager.丟丗丄业丘丗业丗七;
        this.上不丆丕丏丕三丙丁();
        this.丈丘丕丞丛丈丟万丆();
    }
    internal BonusController()
    {
        this.丒丘东丌丞丛三下下 = new System.Collections.Generic.List<SettingBonus>();
        this.bonusWeaponStack = new System.Collections.Generic.List<WeaponBonusItem>();
        this.丞业且丂且丄东丆且 = 6f;
        this.maxCountBonus = 5;
        this.丗丐丐东丈丅丄丛丌 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.不丅丈丛丞东丌丝丆 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>();
        this.丟丟丘东上不丗世丄 = new System.Collections.Generic.List<WeaponBonusPreview>();
        Rilisoft.且三与世丁丏丂丌下 val_6 = this.与丑丌丌丌丁丌不丕();
        val_6.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void BonusController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    private void 上不丆丕丏丕三丙丁()
    {
        var val_18;
        var val_25;
        var val_26;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_27;
        var val_28;
        var val_29;
        var val_30;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_31;
        var val_32;
        val_25 = this;
        this.丗丐丐东丈丅丄丛丌.Clear();
        this.不丅丈丛丞东丌丝丆.Clear();
        this.与与丁一丑丟丌丑丅 = 0;
        val_26 = null;
        val_26 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_5;
        }
        
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
            goto label_8;
        }
        
        val_27 = this.丗丐丐东丈丅丄丛丌;
        val_28 = 3;
        val_29 = 100;
        val_30 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Int32>::Add(System.Int32 key, System.Int32 value);
        goto label_34;
        label_5:
        val_31 = this.丗丐丐东丈丅丄丛丌;
        val_30 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Int32>::Add(System.Int32 key, System.Int32 value);
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_13;
        }
        
        val_31.Add(key:  0, value:  55);
        this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  14);
        val_27 = this.丗丐丐东丈丅丄丛丌;
        val_30 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Int32>::Add(System.Int32 key, System.Int32 value);
        val_28 = 2;
        val_29 = 12;
        goto label_34;
        label_8:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_19;
        }
        
        this.丗丐丐东丈丅丄丛丌.Add(key:  0, value:  50);
        this.丗丐丐东丈丅丄丛丌.Add(key:  16, value:  6);
        this.丗丐丐东丈丅丄丛丌.Add(key:  15, value:  9);
        this.丗丐丐东丈丅丄丛丌.Add(key:  14, value:  15);
        this.丗丐丐东丈丅丄丛丌.Add(key:  13, value:  4);
        this.丗丐丐东丈丅丄丛丌.Add(key:  12, value:  6);
        val_27 = this.丗丐丐东丈丅丄丛丌;
        val_30 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Int32>::Add(System.Int32 key, System.Int32 value);
        val_28 = 11;
        val_29 = 10;
        goto label_34;
        label_19:
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "knife2")) != true)
        {
                if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "knife3_christmas")) == false)
        {
            goto label_31;
        }
        
        }
        
        this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  75);
        val_27 = this.丗丐丐东丈丅丄丛丌;
        val_30 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Int32>::Add(System.Int32 key, System.Int32 value);
        label_89:
        val_28 = 2;
        val_29 = 25;
        goto label_34;
        label_31:
        if((GameConnect.东且三丆丑世世丘丟() == true) || ((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false))
        {
            goto label_39;
        }
        
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
            goto label_42;
        }
        
        this.丗丐丐东丈丅丄丛丌.Add(key:  0, value:  50);
        this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  15);
        if(this.丗丐丐东丈丅丄丛丌 != null)
        {
            goto label_34;
        }
        
        goto label_34;
        label_39:
        val_31 = this.丗丐丐东丈丅丄丛丌;
        val_30 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Int32>::Add(System.Int32 key, System.Int32 value);
        label_13:
        val_29 = 100;
        val_28 = 0;
        label_34:
        val_31.Add(key:  0, value:  100);
        val_32 = 1152921505066536960;
        if(GameConnect.万七丄丛丈丟专一丑() != false)
        {
                this.丗丐丐东丈丅丄丛丌.Clear();
            this.丗丐丐东丈丅丄丛丌.Add(key:  0, value:  55);
            this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  14);
        }
        
        if((PolygonController.一下一万丄丅丘且丑 != 0) && ((PolygonController.一下一万丄丅丘且丑 + 24) != 0))
        {
                this.丗丐丐东丈丅丄丛丌.Clear();
            this.丗丐丐东丈丅丄丛丌.Add(key:  0, value:  100);
        }
        
        if(GameConnect.东丒七专丂世丝丏丗() != false)
        {
                this.丗丐丐东丈丅丄丛丌.Clear();
            val_32 = 1152921524500189088;
            this.丗丐丐东丈丅丄丛丌.Add(key:  2, value:  70);
            this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  30);
        }
        
        Dictionary.Enumerator<TKey, TValue> val_16 = this.丗丐丐东丈丅丄丛丌.GetEnumerator();
        label_72:
        if(((-573229328) & 1) == 0)
        {
            goto label_68;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_20 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        null.Add(key:  "min", value:  this.与与丁一丑丟丌丑丅);
        int val_25 = this.与与丁一丑丟丌丑丅;
        val_25 = 1152921525508454120 + val_25;
        this.与与丁一丑丟丌丑丅 = val_25;
        null.Add(key:  "max", value:  val_25);
        this.不丅丈丛丞东丌丝丆.Add(key:  val_18.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂(), value:  null);
        goto label_72;
        label_68:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_42:
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_76;
        }
        
        this.丗丐丐东丈丅丄丛丌.Add(key:  0, value:  50);
        this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  20);
        if(this.丗丐丐东丈丅丄丛丌 != null)
        {
            goto label_34;
        }
        
        goto label_34;
        label_76:
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "WalkingFortress")) == false)
        {
            goto label_83;
        }
        
        this.丗丐丐东丈丅丄丛丌.Add(key:  0, value:  30);
        this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  10);
        if(this.丗丐丐东丈丅丄丛丌 != null)
        {
            goto label_34;
        }
        
        goto label_34;
        label_83:
        this.丗丐丐东丈丅丄丛丌.Add(key:  0, value:  60);
        this.丗丐丐东丈丅丄丛丌.Add(key:  1, value:  15);
        if(this.丗丐丐东丈丅丄丛丌 != null)
        {
            goto label_89;
        }
        
        goto label_89;
    }
    internal void 丂丏下丞下丅丐七世(WeaponBonusPreview 丑与丅东万丟世丄丌)
    {
        this.丟丟丘东上不丗世丄.Add(item:  丑与丅东万丟世丄丌);
    }
    internal void 丝丄专丌万万丆丘七(string 丆与丕丕丂下丟一丈, WeaponBonusPreview 丏丄丕丁丅丑丌万东)
    {
        this.丟丟丘东上不丗世丄.Add(item:  丏丄丕丁丅丑丌万东);
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(丆与丕丕丂下丟一丈 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(丆与丕丕丂下丟一丈 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = 丆与丕丕丂下丟一丈;
        UnityEngine.Vector3 val_3 = 丏丄丕丁丅丑丌万东.transform.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_1[1] = val_4;
        UnityEngine.Quaternion val_6 = 丏丄丕丁丅丑丌万东.transform.rotation;
        val_1[2] = val_6.y;
        val_1[3] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        val_1[4] = 丏丄丕丁丅丑丌万东.thisIndex;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  172, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_8;
        string val_9;
        int val_10;
        int val_11;
        object val_12;
        int val_15;
        var val_16;
        int val_17;
        var val_18;
        int val_19;
        val_8 = 丞世不丒下上上丝丑;
        val_9 = this;
        byte val_1 = val_8 & 255;
        if(val_1 > 36)
        {
            goto label_1;
        }
        
        if(val_1 > 7)
        {
            goto label_2;
        }
        
        byte val_2 = val_8 & 255;
        if(val_2 == 1)
        {
            goto label_3;
        }
        
        if(val_2 != 7)
        {
            goto label_30;
        }
        
        val_9 = 专丒丌丆下丐丞丟丞[0];
        专丒丌丆下丐丞丟丞[1].三丂且专业丞丄下丗(丆与丕丕丂下丟一丈:  val_9, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 3.782474E-38f});
        goto label_62;
        label_1:
        if(val_1 > 50)
        {
            goto label_10;
        }
        
        byte val_3 = val_8 & 255;
        if(val_3 == 49)
        {
            goto label_11;
        }
        
        if(val_3 != 50)
        {
            goto label_30;
        }
        
        val_10 = 专丒丌丆下丐丞丟丞.Length;
        if(val_10 == 0)
        {
                val_10 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_8 = 专丒丌丆下丐丞丟丞[0];
        object val_10 = 专丒丌丆下丐丞丟丞[1];
        if(val_8 != null)
        {
                val_8 = 0;
        }
        
        this.且丕丙上丗丝丘丝丝(不丟丗丏丛丕不丁丌:  val_8, 丞世不丒下上上丝丑:  21884928);
        goto label_62;
        label_2:
        byte val_6 = val_8 & 255;
        if(val_6 == 22)
        {
            goto label_20;
        }
        
        if(val_6 != 36)
        {
            goto label_30;
        }
        
        val_11 = 专丒丌丆下丐丞丟丞.Length;
        if(val_11 == 0)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_11 = 专丒丌丆下丐丞丟丞[0];
        if(val_11 <= 1)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_12 = 专丒丌丆下丐丞丟丞[1];
        if(val_11 <= 2)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_12 = 专丒丌丆下丐丞丟丞[2];
        if(val_11 <= 3)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_13 = 专丒丌丆下丐丞丟丞[3];
        object val_14 = 专丒丌丆下丐丞丟丞[4];
        this.丐丗丐丟业丒丛业丁(丞世不丒下上上丝丑:  21884928, 丁丅丈丌丟世丗丗丟:  21884928, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 专丌万丑三丙丕丙丝:  3.782474E-38f, 丁丅丆丟上丄丅丟与:  21884928);
        goto label_62;
        label_10:
        byte val_7 = val_8 & 255;
        if(val_7 == 170)
        {
            goto label_29;
        }
        
        if(val_7 != 172)
        {
            goto label_30;
        }
        
        val_15 = 专丒丌丆下丐丞丟丞.Length;
        val_8 = 专丒丌丆下丐丞丟丞[0];
        if(val_15 <= 1)
        {
                val_15 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_16 = 专丒丌丆下丐丞丟丞[1];
        if(val_15 <= 2)
        {
                val_15 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_17 = 专丒丌丆下丐丞丟丞[2];
        if(val_15 <= 3)
        {
                val_15 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_18 = 专丒丌丆下丐丞丟丞[3];
        object val_19 = 专丒丌丆下丐丞丟丞[4];
        val_12 = 1152921504622075904;
        this.丘丆丈丄丆丁丒且万(丆与丕丕丂下丟一丈:  val_8, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 丐丘丗上丂丒丐丟业:  3.782474E-38f, 世万丘丟丐上世不上:  21884928, 东七丛丝丑专世丏三:  21884928);
        goto label_62;
        label_30:
        val_16 = 0;
        return (bool)val_16;
        label_3:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_40;
        }
        
        val_12 = 专丒丌丆下丐丞丟丞;
        val_17 = 专丒丌丆下丐丞丟丞.Length;
        if(val_17 == 1)
        {
            goto label_41;
        }
        
        if(val_17 != 2)
        {
            goto label_42;
        }
        
        label_61:
        object val_20 = 专丒丌丆下丐丞丟丞[0];
        object val_21 = 专丒丌丆下丐丞丟丞[1];
        val_18 = 1152921504628731904;
        goto label_46;
        label_11:
        object val_22 = 专丒丌丆下丐丞丟丞[0];
        this.与不七丕丗且东丌丌(丞世不丒下上上丝丑:  21884928);
        goto label_62;
        label_20:
        object val_23 = 专丒丌丆下丐丞丟丞[0];
        this.丛下业丅下丘东与世(丞世不丒下上上丝丑:  21884928);
        goto label_62;
        label_29:
        val_19 = 专丒丌丆下丐丞丟丞.Length;
        if(val_19 == 0)
        {
                val_19 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_24 = 专丒丌丆下丐丞丟丞[0];
        if(val_19 <= 1)
        {
                val_19 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_25 = 专丒丌丆下丐丞丟丞[1];
        object val_26 = 专丒丌丆下丐丞丟丞[2];
        val_12 = 1152921504622075904;
        this.且七三丏丂专丁丆丘(七丄丞七丄丏七下上:  21884928, 三丁丐丂丂丘丈丆丕:  21884928, 丄丒且丙三丆丟与丏:  21884928);
        goto label_62;
        label_40:
        val_8 = 28563616;
        if(28563616 != 1)
        {
            goto label_58;
        }
        
        label_41:
        object val_27 = 专丒丌丆下丐丞丟丞[0];
        this.丏丂业下上东丐丂丈(丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 3.782474E-38f});
        goto label_62;
        label_58:
        val_12 = 24;
        val_17 = 28563616;
        if(val_8 == 2)
        {
            goto label_61;
        }
        
        label_42:
        if(val_17 != 3)
        {
            goto label_62;
        }
        
        object val_28 = 专丒丌丆下丐丞丟丞[0];
        object val_29 = 专丒丌丆下丐丞丟丞[1];
        object val_30 = 专丒丌丆下丐丞丟丞[2];
        val_18 = 1152921504628731904;
        label_46:
        this.丏丂业下上东丐丂丈(丌下丏丐丕丏不丗一:  21884928, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 与与专丟丗东丌与丆:  3.782474E-38f);
        label_62:
        val_16 = 1;
        return (bool)val_16;
    }
    private void 丘丆丈丄丆丁丒且万(string 丆与丕丕丂下丟一丈, UnityEngine.Vector3 丙丆丗业丌丏业丒丝, float 丐丘丗上丂丒丐丟业, int 世万丘丟丐上世不上, int 东七丛丝丑专世丏三)
    {
        float val_8;
        float val_9;
        System.Collections.Generic.List<WeaponBonusItem> val_10;
        object val_11;
        int val_12;
        int val_13;
        val_8 = 丐丘丗上丂丒丐丟业;
        val_9 = 丙丆丗业丌丏业丒丝.y;
        val_10 = this;
        BonusController.丂丄丕业东丆丄三三 val_1 = null;
        val_11 = val_1;
        val_1 = new BonusController.丂丄丕业东丆丄三三();
        if(val_11 != null)
        {
                val_12 = val_11;
            .世万丘丟丐上世不上 = 世万丘丟丐上世不上;
        }
        else
        {
                val_12 = 16;
            mem[16] = 世万丘丟丐上世不上;
        }
        
        .东七丛丝丑专世丏三 = 东七丛丝丑专世丏三;
        val_13 = 1152921504848912384;
        if((this.bonusWeaponStack.Find(match:  new System.Predicate<WeaponBonusItem>(object:  val_1, method:  System.Boolean BonusController.丂丄丕业东丆丄三三::七七丏专丌丄不丕万(WeaponBonusItem 丐丙丒丈丄不一丈与)))) != 0)
        {
                return;
        }
        
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_8 = val_5.x;
        val_9 = val_5.z;
        val_13 = (BonusController.丂丄丕业东丆丄三三)[1152921525509568944].东七丛丝丑专世丏三;
        val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bonusWeaponPrefab, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_8, y = val_5.y, z = val_9, w = val_5.w}).GetComponent<WeaponBonusItem>();
        val_11.InitBonus(丗万丛丙上丟上万三:  val_12, 东七丛丝丑专世丏三:  val_13, 丆与丕丕丂下丟一丈:  丆与丕丕丂下丟一丈);
        val_10 = this.bonusWeaponStack;
        val_10.Add(item:  val_11);
    }
    internal void 且与丟丞三不丙业不(int 东七丛丝丑专世丏三, WeaponBonusItem 业丟下丐不丆丆丄七)
    {
        .东七丛丝丑专世丏三 = 东七丛丝丑专世丏三;
        WeaponBonusPreview val_3 = this.丟丟丘东上不丗世丄.Find(match:  new System.Predicate<WeaponBonusPreview>(object:  new BonusController.下丏丌丑七丗丕丅世(), method:  System.Boolean BonusController.下丏丌丑七丗丕丅世::丑丏丄丈丐丌丈且丌(WeaponBonusPreview 七丏丄丅丌业与且丙)));
        if(val_3 == 0)
        {
                return;
        }
        
        if(业丟下丐不丆丆丄七 != 0)
        {
                if(业丟下丐不丆丆丄七 != null)
        {
                业丟下丐不丆丆丄七.ammoInClip = val_3.ammoInClip;
            业丟下丐不丆丆丄七.initialAmmoInBackUp = val_3.initialAmmoInBackUp;
        }
        else
        {
                mem[64] = val_3.ammoInClip;
            mem[68] = val_3.initialAmmoInBackUp;
        }
        
            业丟下丐不丆丆丄七.isMineBonus = true;
        }
        
        bool val_6 = this.丟丟丘东上不丗世丄.Remove(item:  val_3);
        UnityEngine.Object.Destroy(obj:  val_3.gameObject);
    }
    internal void 万丗丏丘丐丙丂专业(string 丆与丕丕丂下丟一丈, UnityEngine.Vector3 丙丆丗业丌丏业丒丝)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丆与丕丕丂下丟一丈 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丆与丕丕丂下丟一丈 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 丆与丕丕丂下丟一丈;
        val_1[1] = 丙丆丗业丌丏业丒丝;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  7, 丞下万上三丘上与专:  2, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 三丂且专业丞丄下丗(string 丆与丕丕丂下丟一丈, UnityEngine.Vector3 丙丆丗业丌丏业丒丝)
    {
        string val_8;
        float val_9;
        float val_10;
        val_8 = 丆与丕丕丂下丟一丈;
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                丙丆丗业丌丏业丒丝.y = 丙丆丗业丌丏业丒丝.y + (-0.5f);
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            val_9 = val_2.x;
            val_10 = val_2.z;
            丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "Weapon_Bonuses/Weapon_Bonus", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_9, y = val_2.y, z = val_10, w = val_2.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0).GetComponent<WeaponBonus>().SetWeaponName(丞丕丟丄且丂丅丏万:  val_8);
            return;
        }
        
        val_8 = "Weapon_Bonuses/"("Weapon_Bonuses/") + val_8 + "_Bonus";
        丙丆丗业丌丏业丒丝.y = 丙丆丗业丌丏业丒丝.y + (-0.5f);
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
        val_9 = val_6.x;
        val_10 = val_6.z;
        UnityEngine.GameObject val_7 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  val_8, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_9, y = val_6.y, z = val_10, w = val_6.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0);
    }
    internal void 丄世丑丌丐万上东专(UnityEngine.Vector3 丙丆丗业丌丏业丒丝)
    {
        PhotonView val_2;
        var val_3;
        val_2 = this;
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_2 = this.丄丈丑丐丆丞丘与丗;
        object[] val_1 = new object[1];
        val_1[0] = 丙丆丗业丌丏业丒丝;
        val_2.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  1, 丞下万上三丘上与专:  2, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丏下丈丈东丝丕丁专(int 丞丙且丘丂丝丝与业, UnityEngine.Vector3 丙丆丗业丌丏业丒丝, float 丘七丛丂专丅丛业丑)
    {
        PhotonView val_2;
        var val_3;
        val_2 = this;
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_2 = this.丄丈丑丐丆丞丘与丗;
        object[] val_1 = new object[3];
        val_1[0] = 丞丙且丘丂丝丝与业;
        val_1[1] = 丙丆丗业丌丏业丒丝;
        val_1[2] = 丘七丛丂专丅丛业丑;
        val_2.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  1, 丞下万上三丘上与专:  2, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 丏丂业下上东丐丂丈(UnityEngine.Vector3 丙丆丗业丌丏业丒丝)
    {
        Rilisoft.专与丏丞三与不不丆 val_1 = this.下丟世丅丙丐丟上七();
        if(val_1 == 18)
        {
                return;
        }
        
        this.丏丂业下上东丐丂丈(丌下丏丐丕丏不丗一:  val_1, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 丙丆丗业丌丏业丒丝.x, y = 丙丆丗业丌丏业丒丝.y, z = 丙丆丗业丌丏业丒丝.z}, 与与专丟丗东丌与丆:  0f);
    }
    private void 丏丂业下上东丐丂丈(int 丌下丏丐丕丏不丗一, UnityEngine.Vector3 丙丆丗业丌丏业丒丝, float 与与专丟丗东丌与丆 = 0)
    {
        var val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
            if(GameConnect.世丐丄三三上丅七三() == true)
        {
                return;
        }
        
        }
        
        if((this.丟丞业且丝丞与东丑(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 丙丆丗业丌丏业丒丝.x, y = 丙丆丗业丌丏业丒丝.y, z = 丙丆丗业丌丏业丒丝.z}, 丌下丏丐丕丏不丗一:  丌下丏丐丕丏不丗一, 与与专丟丗东丌与丆:  与与专丟丗东丌与丆)) == false)
        {
                return;
        }
        
        int val_4 = this.不丅业丈上一丝丟丟;
        val_4 = val_4 + 1;
        this.不丅业丈上一丝丟丟 = val_4;
    }
    private bool 丟丞业且丝丞与东丑(UnityEngine.Vector3 下业丕七东丌丝下且, int 丌下丏丐丕丏不丗一, float 与与专丟丗东丌与丆 = 0)
    {
        float val_69;
        int val_70;
        System.Int32[] val_71;
        object val_72;
        var val_73;
        var val_75;
        double val_76;
        double val_77;
        var val_78;
        var val_79;
        int val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        float val_85;
        float val_86;
        var val_87;
        var val_88;
        float val_89;
        string val_90;
        var val_95;
        float val_96;
        float val_97;
        UnityEngine.GameObject val_98;
        var val_99;
        float val_100;
        val_69 = 与与专丟丗东丌与丆;
        val_70 = 丌下丏丐丕丏不丗一;
        val_71 = this;
        val_72 = 1152921505066536960;
        val_73 = 0;
        if((val_70 - 4) < 5)
        {
                return (bool)val_73;
        }
        
        if(GameConnect.丟丆丏上丌一丝丟业() == true)
        {
                return (bool)val_73;
        }
        
        if(this.丁丑丅丏丒不七上丁 == false)
        {
            goto label_5;
        }
        
        label_110:
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_3 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_3 == null)
        {
            goto label_8;
        }
        
        FilterMaps val_4 = val_3.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom");
        if(val_4 == 100)
        {
            goto label_111;
        }
        
        label_8:
        if(val_70 != 9)
        {
            goto label_10;
        }
        
        if(val_4.世丟丒上业七丈七丟() == false)
        {
            goto label_111;
        }
        
        ExitGames.Client.Photon.Hashtable val_6 = new ExitGames.Client.Photon.Hashtable();
        val_75 = null;
        val_75 = null;
        val_76 = 480;
        val_77 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_76;
        val_72 = val_77;
        val_6.set_Item(key:  GameConnect.万丟丞七万业七与丞, value:  val_77);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_6, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        label_10:
        val_78 = 1152921504838316032;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        if(((-570605392) & 1) == 0)
        {
            goto label_20;
        }
        
        if((this.丒丘东丌丞丛三下下.Count + this.上一丆丐丙不丏丆七) >= this.maxCountBonus)
        {
            goto label_111;
        }
        
        val_79 = null;
        val_79 = null;
        val_80 = UnityEngine.Random.Range(min:  0, max:  BonusController.上丒丒七丙专业丘丗.Count);
        int val_14 = BonusController.上丒丒七丙专业丘丗.Count;
        bool[] val_15 = new bool[0];
        val_81 = 0;
        goto label_27;
        label_30:
        val_81 = 1;
        val_15[0] = false;
        label_27:
        if(val_81 < val_15.Length)
        {
            goto label_30;
        }
        
        val_82 = 0;
        goto label_31;
        label_46:
        BonusItem val_69 = this.bonusStack[0];
        if(this.bonusStack[0x0][0].isActive != false)
        {
                BonusItem val_70 = this.bonusStack[0];
            if(this.bonusStack[0x0][0].mySpawnNumber != 1)
        {
                BonusItem val_71 = this.bonusStack[0];
            val_15[this.bonusStack[0x0][0].mySpawnNumber] = true;
        }
        
        }
        
        val_82 = 1;
        label_31:
        if(val_82 < this.bonusStack.Length)
        {
            goto label_46;
        }
        
        val_83 = 0;
        goto label_47;
        label_56:
        SettingBonus val_16 = this.丒丘东丌丞丛三下下.Item[0];
        if(val_16.numberSpawnZone != 1)
        {
                SettingBonus val_17 = this.丒丘东丌丞丛三下下.Item[0];
            val_15[val_17.numberSpawnZone] = true;
        }
        
        val_83 = 1;
        label_47:
        if(val_83 < this.丒丘东丌丞丛三下下.Count)
        {
            goto label_56;
        }
        
        goto label_57;
        label_60:
        int val_20 = ((val_80 + 1) == val_15.Length) ? 0 : (val_80 + 1);
        label_57:
        if(val_15[(long)val_20] == true)
        {
            goto label_60;
        }
        
        val_84 = null;
        val_84 = null;
        val_78 = 1152921504838316032;
        BonusCreationZone val_21 = BonusController.上丒丒七丙专业丘丗.Item[val_20];
        UnityEngine.Vector3 val_22 = val_21.boxCollider.size;
        UnityEngine.Vector3 val_23 = val_21.万东万丆专丌丕丐丗.localScale;
        UnityEngine.Vector3 val_24 = val_21.boxCollider.size;
        UnityEngine.Vector3 val_25 = val_21.万东万丆专丌丕丐丗.localScale;
        UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_22.x * val_23.x, y:  val_24.z * val_25.z);
        UnityEngine.Vector3 val_29 = val_21.万东万丆专丌丕丐丗.position;
        val_72 = val_21.万东万丆专丌丕丐丗;
        UnityEngine.Vector3 val_30 = val_72.position;
        float val_73 = 0.5f;
        float val_31 = val_28.x * val_73;
        val_31 = val_29.x - val_31;
        val_73 = val_28.y * val_73;
        val_73 = val_30.z - val_73;
        float val_32 = 0.x;
        val_85 = UnityEngine.Random.Range(min:  0f, max:  val_32);
        UnityEngine.Vector3 val_34 = val_21.万东万丆专丌丕丐丗.position;
        val_86 = val_34.x;
        float val_37 = val_86 + (UnityEngine.Random.Range(min:  0f, max:  val_34.x));
        val_77 = val_32 + val_85;
        val_76 = val_34.y;
        goto label_72;
        label_5:
        if(GameConnect.上丏丈七丘丁与丅丏() != true)
        {
                if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_110;
        }
        
        }
        
        }
        
        int val_74 = 丟丌丁且且世丈丈丟.丆丂丆丂上丄下丒丒();
        val_74 = val_74 - this.专业丙上丕丌丙丕三.丌丟且丛丄丒万丈丑();
        if((val_74 <= 0) && (GameConnect.上丏丈七丘丁与丅丏() != false))
        {
                if(this.专业丙上丕丌丙丕三.bossShowm == false)
        {
            goto label_90;
        }
        
        }
        
        if((GameConnect.丌专丌万一下丕专上() == false) || (this.专业丙上丕丌丙丕三.stopGeneratingBonuses == false))
        {
            goto label_110;
        }
        
        label_90:
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_104;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_101;
        }
        
        val_87 = null;
        val_87 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == true)
        {
            goto label_104;
        }
        
        label_101:
        this.专世丙世与丑不丄丄 = true;
        label_104:
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_111;
        }
        
        val_88 = null;
        val_88 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == true)
        {
            goto label_110;
        }
        
        goto label_111;
        label_20:
        val_80 = 0;
        label_72:
        if(val_70 != 3)
        {
            goto label_112;
        }
        
        if((this.丁丑丅丏丒不七上丁 == false) || (this.丝丙七丒且丂丝与丏 == false))
        {
            goto label_114;
        }
        
        val_71 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_155;
        }
        
        val_85 = 下业丕七东丌丝下且.x;
        val_89 = 下业丕七东丌丝下且.y;
        val_69 = 下业丕七东丌丝下且.z;
        val_90 = "Bonuses/Bonus_"("Bonuses/Bonus_") + 3;
        UnityEngine.Quaternion val_52 = UnityEngine.Quaternion.identity;
        val_95 = null;
        val_96 = val_52.x;
        val_86 = val_52.y;
        val_97 = val_52.z;
        goto label_120;
        label_112:
        val_72 = 0;
        goto label_121;
        label_127:
        BonusItem val_75 = this.bonusStack[0];
        if(this.bonusStack[0x0][0].isActive == false)
        {
            goto label_125;
        }
        
        val_72 = 1;
        label_121:
        if(val_72 < this.bonusStack.Length)
        {
            goto label_127;
        }
        
        label_111:
        val_73 = 0;
        return (bool)val_73;
        label_114:
        UnityEngine.Object val_54 = UnityEngine.Resources.Load(path:  "Bonuses/Bonus_"("Bonuses/Bonus_") + 3);
        val_85 = 下业丕七东丌丝下且.x;
        val_69 = 下业丕七东丌丝下且.z;
        UnityEngine.Quaternion val_55 = UnityEngine.Quaternion.identity;
        val_86 = val_55.y;
        if(val_54 == null)
        {
            goto label_133;
        }
        
        var val_56 = (null == null) ? (val_54) : 0;
        goto label_134;
        label_125:
        if(val_70 == 10)
        {
            goto label_135;
        }
        
        if(val_70 == 1)
        {
                int val_57 = this.一丈与丗丗七与一丟();
            val_70 = val_57;
        }
        
        val_85 = 下业丕七东丌丝下且.y;
        if(val_80 == 1)
        {
            goto label_137;
        }
        
        goto label_138;
        label_133:
        val_98 = 0;
        label_134:
        val_70 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_98, position:  new UnityEngine.Vector3() {x = val_85, y = 下业丕七东丌丝下且.y, z = val_69}, rotation:  new UnityEngine.Quaternion() {x = val_55.x, y = val_86, z = val_55.z, w = val_55.w}).GetComponent<SettingBonus>();
        val_59.numberSpawnZone = val_80;
        goto label_155;
        label_135:
        val_99 = null;
        val_99 = null;
        int val_60 = UnityEngine.Random.Range(min:  0, max:  ChestController.weaponForHungerGames.Length);
        val_71 = ChestController.weaponForHungerGames;
        System.Int32[] val_61 = val_71 + (((long)(int)(val_60)) << 2);
        val_85 = 下业丕七东丌丝下且.x;
        val_89 = 下业丕七东丌丝下且.y;
        val_69 = 下业丕七东丌丝下且.z;
        val_90 = System.String.Format(format:  "Weapon_Bonuses/Weapon{0}_Bonus", arg0:  (ChestController.weaponForHungerGames + ((long)(int)(val_60)) << 2) + 32);
        UnityEngine.Quaternion val_63 = UnityEngine.Quaternion.identity;
        val_96 = val_63.x;
        val_86 = val_63.y;
        val_97 = val_63.z;
        val_95 = null;
        label_120:
        val_70 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  val_90, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_85, y = val_89, z = val_69}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_96, y = val_86, z = val_97, w = val_63.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0).GetComponent<SettingBonus>();
        val_70.SetNumberSpawnZone(三世不丒世丆七丞丒:  0);
        goto label_155;
        label_137:
        label_138:
        this.丐丗丐丟业丒丛业丁(丞世不丒下上上丝丑:  0, 丁丅丈丌丟世丗丗丟:  val_70, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = val_85, z = 下业丕七东丌丝下且.z}, 专丌万丑三丙丕丙丝:  (float)val_57.丏东丟丞世东七东丄(丂七上与上不丘丐丛:  val_69), 丁丅丆丟上丄丅丟与:  0);
        if((this.丁丑丅丏丒不七上丁 == false) || (this.丝丙七丒且丂丝与丏 == false))
        {
            goto label_155;
        }
        
        object[] val_67 = new object[5];
        val_67[0] = val_72;
        val_67[1] = val_70;
        val_67[2] = 下业丕七东丌丝下且;
        if(val_80 == 1)
        {
            goto label_166;
        }
        
        val_100 = -1f;
        goto label_167;
        label_155:
        val_73 = 1;
        return (bool)val_73;
        label_166:
        val_100 = (float)下业丕七东丌丝下且.丏东丟丞世东七东丄(丂七上与上不丘丐丛:  val_69);
        label_167:
        val_67[3] = val_100;
        val_67[4] = val_80;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  36, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_67);
        return (bool)val_73;
    }
    internal void 丘业世下丌丗丕三丕(UnityEngine.Vector3 下业丕七东丌丝下且, int 丌下丏丐丕丏不丗一)
    {
        int val_2;
        PhotonView val_3;
        val_2 = 丌下丏丐丕丏不丗一;
        val_3 = this;
        int val_2 = this.bonusStack.Length;
        do
        {
            val_2 = val_2 - 1;
            if((val_2 & 2147483648) != 0)
        {
                return;
        }
        
            BonusItem val_3 = this.bonusStack[(long)val_2];
        }
        while((this.bonusStack[(long)(int)((this.bonusStack.Length - 1))][0].isActive) == true);
        
        val_3 = this.丄丈丑丐丆丞丘与丗;
        object[] val_1 = new object[5];
        val_1[0] = val_2;
        val_1[1] = val_2;
        val_1[2] = 下业丕七东丌丝下且;
        val_1[3] = -1f;
        val_2 = 0;
        val_1[4] = val_2;
        val_3.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  36, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丁上丞丆丘一丌丐丑(UnityEngine.Vector3 下业丕七东丌丝下且, int 丌下丏丐丕丏不丗一, int 丑一丟丑三丐下万丆)
    {
        BonusItem val_3;
        int val_4;
        object val_5;
        val_4 = 丑一丟丑三丐下万丆;
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
                return;
        }
        
        val_5 = 0;
        goto label_4;
        label_10:
        val_3 = this.bonusStack[0];
        if(this.bonusStack[0x0][0].isActive == false)
        {
            goto label_8;
        }
        
        val_5 = 1;
        label_4:
        val_3 = this.bonusStack;
        if(val_5 < this.bonusStack.Length)
        {
            goto label_10;
        }
        
        return;
        label_8:
        this.丐丗丐丟业丒丛业丁(丞世不丒下上上丝丑:  0, 丁丅丈丌丟世丗丗丟:  丌下丏丐丕丏不丗一, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 专丌万丑三丙丕丙丝:  -1f, 丁丅丆丟上丄丅丟与:  val_4);
        if(this.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        object[] val_2 = new object[5];
        val_3 = val_2;
        val_5 = val_5;
        val_3[0] = val_5;
        val_3[1] = 丌下丏丐丕丏不丗一;
        val_3[2] = 下业丕七东丌丝下且;
        val_3[3] = -1f;
        val_4 = val_4;
        val_3[4] = val_4;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  36, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
    }
    internal void 丂下上不不上专东丞(int 丞世不丒下上上丝丑)
    {
        this.与不七丕丗且东丌丌(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
        if(this.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        this = this.丄丈丑丐丆丞丘与丗;
        object[] val_1 = new object[1];
        val_1[0] = 丞世不丒下上上丝丑;
        this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  49, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丅丁丂丐且东丕下丂(int 丞世不丒下上上丝丑)
    {
        System.Object[] val_5;
        int val_6 = 丞世不丒下上上丝丑;
        if(this.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(NetworkStartTable.与一专丒东丏丘专丕() == true)
        {
                return;
        }
        
        this.且丕丙上丗丝丘丝丝(不丟丗丏丛丕不丁丌:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上(), 丞世不丒下上上丝丑:  val_6 = 丞世不丒下上上丝丑);
        object[] val_3 = new object[2];
        val_5 = val_3;
        val_5[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_6 = val_6;
        val_5[1] = val_6;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  50, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_3);
    }
    internal void 东丞与且一丏丆丒丈()
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_7:
        BonusItem val_4 = this.bonusStack[0];
        if(this.bonusStack[0x0][0].isActive != false)
        {
                this.与不七丕丗且东丌丌(丞世不丒下上上丝丑:  0);
        }
        
        val_4 = 1;
        label_1:
        if(val_4 < this.bonusStack.Length)
        {
            goto label_7;
        }
        
        val_5 = 0;
        goto label_8;
        label_14:
        UnityEngine.Object.Destroy(obj:  this.bonusStack.Item[0].gameObject);
        val_5 = 1;
        label_8:
        if(val_5 < this.bonusWeaponStack.Count)
        {
            goto label_14;
        }
        
        this.bonusWeaponStack.Clear();
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_17;
        object val_18;
        object val_19;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_18 = 0;
        goto label_4;
        label_42:
        BonusItem val_17 = this.bonusStack[0];
        if(this.bonusStack[0x0][0].isActive == false)
        {
            goto label_8;
        }
        
        object[] val_2 = new object[5];
        if(val_2 == null)
        {
            goto label_9;
        }
        
        if(val_18 != 0)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_18 == 0)
        {
            goto label_13;
        }
        
        label_10:
        label_13:
        val_2[0] = val_18;
        BonusItem val_18 = this.bonusStack[0];
        val_2[1] = this.bonusStack[0x0][0].type;
        UnityEngine.Vector3 val_4 = this.bonusStack[0].transform.position;
        val_2[2] = val_4;
        BonusItem val_20 = this.bonusStack[0];
        val_2[3] = (float)this.bonusStack[0x0][0].expireTime;
        BonusItem val_21 = this.bonusStack[0];
        val_19 = this.bonusStack[0x0][0].mySpawnNumber;
        val_2[4] = val_19;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  36, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
        label_8:
        val_18 = 1;
        label_4:
        if(val_18 < this.bonusStack.Length)
        {
            goto label_42;
        }
        
        val_17 = 0;
        goto label_43;
        label_79:
        WeaponBonusItem val_5 = this.bonusWeaponStack.Item[0];
        if(val_5.isUsedBonus == true)
        {
            goto label_46;
        }
        
        object[] val_6 = new object[5];
        val_19 = val_6;
        WeaponBonusItem val_7 = this.bonusWeaponStack.Item[0];
        if(val_19 == null)
        {
            goto label_49;
        }
        
        if(val_7.weaponPrefabName != null)
        {
            goto label_50;
        }
        
        goto label_53;
        label_49:
        if(val_7.weaponPrefabName == null)
        {
            goto label_53;
        }
        
        label_50:
        label_53:
        val_19[0] = val_7.weaponPrefabName;
        UnityEngine.Vector3 val_10 = this.bonusWeaponStack.Item[0].transform.position;
        val_19[1] = val_10;
        UnityEngine.Quaternion val_13 = this.bonusWeaponStack.Item[0].transform.rotation;
        val_19[2] = val_13.y;
        WeaponBonusItem val_14 = this.bonusWeaponStack.Item[0];
        val_19[3] = val_14.ownerId;
        WeaponBonusItem val_15 = this.bonusWeaponStack.Item[0];
        val_19[4] = val_15.previewIndex;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  172, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_6);
        label_46:
        val_17 = 1;
        label_43:
        if(val_17 < this.bonusWeaponStack.Count)
        {
            goto label_79;
        }
    
    }
    private void 丐丗丐丟业丒丛业丁(int 丞世不丒下上上丝丑, int 丁丅丈丌丟世丗丗丟, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 专丌万丑三丙丕丙丝, int 丁丅丆丟上丄丅丟与)
    {
        BonusItem[] val_1;
        int val_2;
        val_1 = this.bonusStack;
        val_2 = 丁丅丆丟上丄丅丟与;
        if(this.bonusStack.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        val_1 = this.bonusStack[(long)丞世不丒下上上丝丑];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isActive == true)
        {
                return;
        }
        
        val_1 = this.bonusStack[(long)丞世不丒下上上丝丑];
        val_1.ActivateBonus(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 专丌万丑三丙丕丙丝:  (double)专丌万丑三丙丕丙丝, 丁丅丆丟上丄丅丟与:  val_2, 丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
        val_2 = this.bonusStack;
        BonusItem val_1 = val_2[(long)丞世不丒下上上丝丑];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isTimeBonus == true)
        {
                return;
        }
        
        int val_2 = this.上一丆丐丙不丏丆七;
        val_2 = val_2 + 1;
        this.上一丆丐丙不丏丆七 = val_2;
    }
    private void 丄丟丘丅东七丞世丒(int 丞世不丒下上上丝丑, 与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.bonusStack.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        BonusItem val_1 = this.bonusStack[(long)丞世不丒下上上丝丑];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isActive == false)
        {
                return;
        }
        
        BonusItem val_2 = this.bonusStack[(long)丞世不丒下上上丝丑];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isPickedUp != false)
        {
                return;
        }
        
        this.bonusStack[(long)丞世不丒下上上丝丑].PickupBonus(专丞上七七且丝七丗:  专丞上七七且丝七丗);
    }
    private void 与不七丕丗且东丌丌(int 丞世不丒下上上丝丑)
    {
        if(this.bonusStack.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        this.bonusStack = (long)丞世不丒下上上丝丑;
        BonusItem val_1 = this.bonusStack[this.bonusStack];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isActive == false)
        {
                return;
        }
        
        BonusItem val_2 = this.bonusStack[this.bonusStack];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isTimeBonus != true)
        {
                int val_3 = this.上一丆丐丙不丏丆七;
            val_3 = val_3 - 1;
            this.上一丆丐丙不丏丆七 = val_3;
        }
        
        this.bonusStack[this.bonusStack].DeactivateBonus();
    }
    private void 且丕丙上丗丝丘丝丝(与丅丕丈丘东丝世丟 不丟丗丏丛丕不丁丌, int 丞世不丒下上上丝丑)
    {
        if(this.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(NetworkStartTable.与一专丒东丏丘专丕() == true)
        {
                return;
        }
        
        if(this.bonusStack.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        BonusItem val_2 = this.bonusStack[(long)丞世不丒下上上丝丑];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isActive == false)
        {
                return;
        }
        
        this.丄丟丘丅东七丞世丒(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 专丞上七七且丝七丗:  不丟丗丏丛丕不丁丌);
    }
    private void 丛下业丅下丘东与世(int 丞世不丒下上上丝丑)
    {
        BonusItem[] val_4;
        与丅丕丈丘东丝世丟 val_5;
        var val_6;
        val_4 = this.bonusStack;
        if(this.bonusStack.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        val_4 = this.bonusStack[(long)丞世不丒下上上丝丑];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isActive == false)
        {
                return;
        }
        
        val_4 = this.bonusStack[(long)丞世不丒下上上丝丑];
        if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].isPickedUp == false)
        {
                return;
        }
        
        BonusItem val_4 = this.bonusStack[(long)丞世不丒下上上丝丑];
        val_5 = this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].playerPicked;
        if((val_5.Equals(丘丛丏丘丝七世七丅:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) != false)
        {
                val_5 = this.bonusStack[(long)丞世不丒下上上丝丑];
            if(this.bonusStack[(long)(int)(丞世不丒下上上丝丑)][0].type == 9)
        {
                val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_6 = null;
            val_6 = null;
            val_5.业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗世丈丂丒丞专上丟:  1, 世丁丙世丄一万丆三:  39, 丛丞万三下丘七丌丅:  true);
        }
        
        }
        
        this.与不七丕丗且东丌丌(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
    }
    internal void 丝三且丒丗丌且七丁(int 七丄丞七丄丏七下上, int 三丁丐丂丂丘丈丆丕, int 丄丒且丙三丆丟与丏)
    {
        object[] val_1 = new object[3];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(七丄丞七丄丏七下上 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(七丄丞七丄丏七下上 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 七丄丞七丄丏七下上;
        val_1[1] = 三丁丐丂丂丘丈丆丕;
        val_1[2] = 丄丒且丙三丆丟与丏;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  170, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 且七三丏丂专丁丆丘(int 七丄丞七丄丏七下上, int 三丁丐丂丂丘丈丆丕, int 丄丒且丙三丆丟与丏)
    {
        var val_9;
        BonusController.丛丄丁业且世丝丂丅 val_1 = new BonusController.丛丄丁业且世丝丂丅();
        if(val_1 != null)
        {
                .七丄丞七丄丏七下上 = 七丄丞七丄丏七下上;
        }
        else
        {
                mem[16] = 七丄丞七丄丏七下上;
        }
        
        .三丁丐丂丂丘丈丆丕 = 三丁丐丂丂丘丈丆丕;
        WeaponBonusItem val_3 = this.bonusWeaponStack.Find(match:  new System.Predicate<WeaponBonusItem>(object:  val_1, method:  System.Boolean BonusController.丛丄丁业且世丝丂丅::不丆丐丐丌丌丄丅丒(WeaponBonusItem 丐丙丒丈丄不一丈与)));
        if(val_3 != 0)
        {
                val_3.GetBonusRPC(业上上丏丄不上丅丈:  丄丒且丙三丆丟与丏);
            bool val_5 = this.bonusWeaponStack.Remove(item:  val_3);
            UnityEngine.Object.Destroy(obj:  val_3.gameObject);
            return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if( == null)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        bool val_8 = typeof(Player_move_c).__il2cppRuntimeField_538.Remove(item:  (BonusController.丛丄丁业且世丝丂丅)[1152921525516055280].三丁丐丂丂丘丈丆丕);
    }
    private double 丏东丟丞世东七东丄(float 丂七上与上不丘丐丛 = 0)
    {
        var val_5;
        if(丂七上与上不丘丐丛 == 0f)
        {
                val_5 = null;
            val_5 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return -1;
        }
        
            float val_3 = (GameConnect.万不丒丌丙万丗东不() != true) ? 60 : 15;
            val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + val_3;
            return -1;
        }
        
        double val_4 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_4 = val_4 + (double)丂七上与上不丘丐丛;
        return -1;
    }
    private bool 世丟丒上业七丈七丟()
    {
        object val_13;
        var val_14;
        var val_16;
        var val_17;
        var val_18;
        if(GameConnect.世丐丄三三上丅七三() != true)
        {
                val_13 = 1152921505171275776;
            val_14 = null;
            val_14 = null;
            if((((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)) && (NetworkStartTable.与一专丒东丏丘专丕() != true)) && (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null))
        {
                val_16 = null;
            val_13 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌();
            val_16 = null;
            if(val_13.Item[GameConnect.万丟丞七万业七与丞] != null)
        {
                val_17 = null;
            val_17 = null;
            val_13 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.万丟丞七万业七与丞];
            var val_12 = ((System.Convert.ToDouble(value:  val_13)) <= 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄()) ? 1 : 0;
            return (bool)val_18;
        }
        
        }
        
        }
        
        val_18 = 0;
        return (bool)val_18;
    }
    private int 一丈与丗丗七与一丟()
    {
        var val_8;
        if(GameConnect.东丒七专丂世丝丏丗() == true)
        {
            goto label_3;
        }
        
        int val_2 = UnityEngine.Random.Range(min:  0, max:  this.与与丁一丑丟丌丑丅);
        Dictionary.Enumerator<TKey, TValue> val_3 = this.不丅丈丛丞东丌丝丆.GetEnumerator();
        label_9:
        if(((-565244136) & 1) == 0)
        {
            goto label_5;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        if(val_2 < val_4._value._obj.Item["min"])
        {
            goto label_9;
        }
        
        if(val_2 >= val_4._value._obj.Item["max"])
        {
            goto label_9;
        }
        
        val_8 = val_4._value._obj.丙东专丂世丈丏丁丂();
        goto label_10;
        label_5:
        val_8 = 0;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_8;
        label_3:
        val_8 = 0;
        return (int)val_8;
    }
    private Rilisoft.专与丏丞三与不不丆 下丟世丅丙丐丟上七()
    {
        var val_14;
        System.Collections.Generic.List<Rilisoft.专与丏丞三与不不丆> val_15;
        var val_16;
        var val_17;
        if(this.世丟丒上业七丈七丟() != false)
        {
                if((UnityEngine.Random.Range(min:  0, max:  100)) < 5)
        {
            goto label_2;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = mem[GameController.mode + 280];
        val_15 = GameController.mode.killBonuses;
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "knife2")) != true)
        {
                if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "knife3_christmas")) == false)
        {
            goto label_9;
        }
        
        }
        
        System.Collections.Generic.List<Rilisoft.专与丏丞三与不不丆> val_7 = null;
        val_15 = val_7;
        val_7 = new System.Collections.Generic.List<Rilisoft.专与丏丞三与不不丆>();
        if(val_15 == null)
        {
            goto label_10;
        }
        
        val_7.Add(item:  1);
        goto label_11;
        label_2:
        val_16 = 9;
        return val_13;
        label_10:
        val_7.Add(item:  1);
        label_11:
        val_7.Add(item:  2);
        label_9:
        val_17 = 1152921525516557872;
        if(val_7.Count < 1)
        {
            goto label_14;
        }
        
        if(val_15 == null)
        {
            goto label_15;
        }
        
        val_17 = val_7.Count;
        goto label_16;
        label_14:
        val_16 = 18;
        return val_13;
        label_15:
        val_17 = val_7.Count;
        label_16:
        Rilisoft.专与丏丞三与不不丆 val_13 = val_7.Item[this.不丅业丈上一丝丟丟 - ((this.不丅业丈上一丝丟丟 / val_17) * val_17)];
        if(val_13 != 18)
        {
                return val_13;
        }
        
        int val_14 = this.不丅业丈上一丝丟丟;
        val_14 = val_14 + 1;
        this.不丅业丈上一丝丟丟 = val_14;
        return val_13;
    }
    private void Update()
    {
        BonusItem val_7;
        object val_8;
        float val_9;
        val_7 = 0;
        goto label_1;
        label_6:
        this.bonusStack[0].UpdateBonus();
        val_7 = 1;
        label_1:
        if(val_7 < this.bonusStack.Length)
        {
            goto label_6;
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if((this.丝丙七丒且丂丝与丏 == false) || (丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false))
        {
            goto label_30;
        }
        
        }
        
        val_8 = 0;
        goto label_12;
        label_29:
        val_7 = this.bonusStack[0];
        if(this.bonusStack[0x0][0].isActive == false)
        {
            goto label_20;
        }
        
        val_7 = this.bonusStack;
        BonusItem val_8 = val_7[0];
        if(this.bonusStack[0x0][0].isPickedUp == false)
        {
            goto label_20;
        }
        
        object[] val_2 = new object[1];
        val_7 = val_2;
        if(val_7 == null)
        {
            goto label_21;
        }
        
        if(val_8 != 0)
        {
            goto label_22;
        }
        
        goto label_25;
        label_21:
        if(val_8 == 0)
        {
            goto label_25;
        }
        
        label_22:
        label_25:
        val_7[0] = val_8;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  22, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_2);
        label_20:
        val_8 = 1;
        label_12:
        if(val_8 < this.bonusStack.Length)
        {
            goto label_29;
        }
        
        if(this.专世丙世与丑不丄丄 != true)
        {
                val_9 = this.timerToAddBonus;
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = val_9 - val_3;
            this.timerToAddBonus = val_3;
        }
        
        label_30:
        if(this.timerToAddBonus >= 0)
        {
                return;
        }
        
        this.timerToAddBonus = this.丞业且丂且丄东丆且;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_9 = val_4.x;
        bool val_6 = this.丟丞业且丝丞与东丑(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_9, y = val_4.y, z = val_4.z}, 丌下丏丐丕丏不丗一:  this.一丈与丗丗七与一丟(), 与与专丟丗东丌与丆:  0f);
    }
    private void OnDestroy()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丄丈丑丐丆丞丘与丗)) == false)
        {
                return;
        }
        
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    internal void 丙丗东丙业上丕上下()
    {
    
    }
    internal void 业丝丅下丆丁丙与丄()
    {
    
    }
    internal void 七不丏丝丐世东三东()
    {
    
    }
    internal void 丌丐丐丒丏且丏丁不(string 丆与丕丕丂下丟一丈, int 丟丒丙丁丑丐世三丈 = -1, int 上丂丝上丘专丟丁丈 = -1, float 丞丙丟丈丌七丐丝上 = -1000, ChestBatleRoyale.丞上七丈丗丝与丏丄 万丁丕七丞丞丂与丟 = 1)
    {
        System.Collections.Generic.List<东丙丏丐万与丐东七> val_1 = new System.Collections.Generic.List<东丙丏丐万与丐东七>();
        val_1.Add(item:  new 东丙丏丐万与丐东七() {世丟万一丘丐丙丝与 = 万丁丕七丞丞丂与丟, 丟丈一下东业一丝丆 = 丆与丕丕丂下丟一丈, 丅丕丟丙七下丘丏丁 = 丟丒丙丁丑丐世三丈, 万东不七丂丟丕专万 = 上丂丝上丘专丟丁丈});
        this.丙丕丅丝专万丐丞丕(丐丄专下丒且丕丐丝:  val_1, 世丅丆丅丒丏丝世丘:  丞丙丟丈丌七丐丝上);
    }
    internal void 丙丕丅丝专万丐丞丕(System.Collections.Generic.List<BonusController.东丙丏丐万与丐东七> 丐丄专下丒且丕丐丝, float 世丅丆丅丒丏丝世丘 = -1000)
    {
        string val_5;
        var val_8;
        int val_10;
        丞上七丈丗丝与丏丄 val_11;
        int val_31;
        float val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        string val_43;
        if(世丅丆丅丒丏丝世丘 <= (-500f))
        {
                if(丐丄专下丒且丕丐丝.Count == 1)
        {
                val_35 = -120f;
        }
        else
        {
                val_35 = 0f;
        }
        
        }
        
        val_36 = 1152921525517821136;
        float val_34 = (float)丐丄专下丒且丕丐丝.Count;
        val_34 = 360f / val_34;
        val_37 = 0;
        goto label_6;
        label_63:
        东丙丏丐万与丐东七 val_4 = 丐丄专下丒且丕丐丝.Item[0];
        val_38 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_5);
        东丙丏丐万与丐东七 val_7 = 丐丄专下丒且丕丐丝.Item[0];
        if(val_8 != 2)
        {
            goto label_11;
        }
        
        东丙丏丐万与丐东七 val_9 = 丐丄专下丒且丕丐丝.Item[0];
        if((val_10.Equals(obj:  0)) == true)
        {
            goto label_22;
        }
        
        label_11:
        if(val_38 != null)
        {
            goto label_14;
        }
        
        东丙丏丐万与丐东七 val_13 = 丐丄专下丒且丕丐丝.Item[0];
        if(val_11 != 2)
        {
            goto label_22;
        }
        
        label_14:
        val_39 = null;
        val_39 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_22;
        }
        
        val_40 = null;
        val_40 = null;
        float val_35 = 0f;
        val_35 = val_34 * val_35;
        float val_36 = UnityEngine.Random.Range(min:  val_35, max:  180f);
        val_36 = val_36 + val_35;
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 168.localRotation = new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w};
        UnityEngine.Vector3 val_16 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 160.position;
        UnityEngine.Vector3 val_17 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 160.forward;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  300f);
        UnityEngine.Quaternion val_20 = this.transform.rotation;
        val_41 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "Weapon_Bonuses/WeaponBonusPeview"), position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, rotation:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w});
        if(val_41 != null)
        {
                if(null == null)
        {
            goto label_48;
        }
        
        }
        
        val_41 = 0;
        val_42 = 1;
        goto label_49;
        label_48:
        val_42 = 0;
        label_49:
        东丙丏丐万与丐东七 val_24 = 丐丄专下丒且丕丐丝.Item[0];
        val_23.世丟万一丘丐丙丝与 = val_11;
        东丙丏丐万与丐东七 val_25 = 丐丄专下丒且丕丐丝.Item[0];
        if(val_8 == 1)
        {
            goto label_53;
        }
        
        if(val_8 != 2)
        {
            goto label_54;
        }
        
        东丙丏丐万与丐东七 val_26 = 丐丄专下丒且丕丐丝.Item[0];
        val_43 = val_5;
        goto label_56;
        label_53:
        val_43 = val_38.三与丛丑且丐丈业丌();
        label_56:
        val_41.GetComponent<WeaponBonusPreview>().SetModel(丝三丛且丘不丌丙下:  val_43);
        label_54:
        if(丐丄专下丒且丕丐丝 != null)
        {
                东丙丏丐万与丐东七 val_28 = 丐丄专下丒且丕丐丝.Item[0];
            val_23.ammoInClip = val_10;
        }
        else
        {
                东丙丏丐万与丐东七 val_29 = 0.Item[0];
            val_23.ammoInClip = val_10;
        }
        
        东丙丏丐万与丐东七 val_30 = 丐丄专下丒且丕丐丝.Item[0];
        val_23.initialAmmoInBackUp = val_31;
        val_36 = 1152921525517821136;
        val_38 = val_41.GetComponent<UnityEngine.Rigidbody>();
        val_38.AddForce(force:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        label_22:
        val_37 = 1;
        label_6:
        if(val_37 < 丐丄专下丒且丕丐丝.Count)
        {
            goto label_63;
        }
    
    }
    internal void 业丘下丄业三丞七一(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 丗与丘不且万丟丙丑, System.Collections.Generic.Dictionary<Rilisoft.专与丏丞三与不不丆, float> 丞且丁七丑丆丒丗丒, float 丘七丛丂专丅丛业丑)
    {
        float val_3;
        var val_4;
        float val_12;
        var val_13;
        float val_14;
        val_12 = 丗与丘不且万丟丙丑;
        val_13 = this;
        if(UnityEngine.Random.value > val_12)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = 丞且丁七丑丆丒丗丒.GetEnumerator();
        val_14 = 0f;
        goto label_3;
        label_4:
        string val_5 = val_4.丐丏七丌丕丗业且上();
        val_14 = val_14 + val_3;
        label_3:
        if(((-563409568) & 1) != 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        float val_10 = 0f;
        val_12 = UnityEngine.Random.Range(min:  0f, max:  val_14);
        Dictionary.Enumerator<TKey, TValue> val_7 = 丞且丁七丑丆丒丗丒.GetEnumerator();
        label_11:
        if(((-563409568) & 1) == 0)
        {
            goto label_10;
        }
        
        val_10 = val_10 + val_3;
        if(val_10 < val_12)
        {
            goto label_11;
        }
        
        this.丏下丈丈东丝丕丁专(丞丙且丘丂丝丝与业:  val_4.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂(), 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 丘七丛丂专丅丛业丑:  丘七丛丂专丅丛业丑);
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丗丐丝丝丒丕丑世丌(UnityEngine.Vector3 上业丆丝丌与丑且东)
    {
        this.丏下丈丈东丝丕丁专(丞丙且丘丂丝丝与业:  17, 丙丆丗业丌丏业丒丝:  new UnityEngine.Vector3() {x = 上业丆丝丌与丑且东.x, y = 上业丆丝丌与丑且东.y, z = 上业丆丝丌与丑且东.z}, 丘七丛丂专丅丛业丑:  100000f);
    }
    private static BonusController()
    {
        BonusController.上丒丒七丙专业丘丗 = new System.Collections.Generic.List<BonusCreationZone>();
    }

}
