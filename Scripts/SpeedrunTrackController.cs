using UnityEngine;
public class SpeedrunTrackController : MonoBehaviour
{
    // Fields
    internal static SpeedrunTrackController 丄丘七三上丕世丞业;
    internal const int 丛专与丅下丌丆世丒 = 1;
    public int visiblePartsCount;
    public int visibleCenter;
    public int partsBeforeHard;
    public int partsBeforeFullHard;
    public int chanceToSpawnHard;
    public int safeZoneDistance;
    public float distanceToGetCoin;
    public SpeedrunTrackPart[] allParts;
    public SpeedrunTrackPart[] tutorialParts;
    public UnityEngine.Transform startTrackPoint;
    public UnityEngine.GameObject followPlayerGO;
    private System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>>[] 东丙丏丑丞丕上丏不;
    private System.Collections.Generic.List<SpeedrunTrackPart> 丛丒丌七丟丞丏丗且;
    private int 丙世三丞业下丑万丁;
    private int 丅三丌丏世丐丅万丕;
    private int 丑七丙丙东业丟丘一;
    private Rilisoft.丒且丐三丁丅丕一业 下丝丏三三丛丛丑业;
    private float 三丅一世丁丁丝且一;
    private float 丗丘丆丟七万与丐丆;
    public float startPlayerSpeed;
    public float distanceToAddSpeed;
    public float playerAddSpeed;
    public UnityEngine.AudioClip shieldBreakSound;
    public float currentPlayerSpeed;
    public bool runStarted;
    private bool 丅与丆世与丅丗不专;
    private bool 丟专且三下丙丁丕七;
    private bool 丟丂丆丙丞丕与丛且;
    public float goTimer;
    private float 丁业且丛丁丂且丈丄;
    private float 丙与上万七丙丈丒丒;
    public bool isShowGo;
    private bool 丁丟东七与丏丙丗丙;
    
    // Properties
    private float 丝上七万上丄专丟丘 { get; set; }
    public bool 丐丁丞丄丙丞丂业丕 { get; }
    public bool 且丈东丁丘且丟三下 { get; }
    public bool 丝丐丕丂业丆丒丅东 { get; }
    public bool 丁一不丞丛丕下丄丁 { get; }
    
    // Methods
    private float 业且丝丌丄丏丅丑丛()
    {
        if(this.下丝丏三三丛丛丑业 != null)
        {
                return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
        }
        
        return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
    }
    private void 丗丕与丁丟丟丗丏且(float 丙业与丙丗丝不丈东)
    {
        this.下丝丏三三丛丛丑业.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public bool get_canBuyShield()
    {
        var val_3;
        Pauser val_4;
        var val_5;
        if(this.丟专且三下丙丁丕七 == true)
        {
                return false;
        }
        
        if(this.runStarted != false)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        val_4 = Pauser.且三丝三七七丐丁丁;
        if(val_4 == 0)
        {
                return 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = Pauser.且三丝三七七丐丁丁;
        if(val_4.丟三东与三丒丛下东() == true)
        {
                return false;
        }
        
        return 下丟世丏三东万丘丏.下不丙丌丙丞丞万上();
    }
    public bool get_canUseJoystick()
    {
        if(this.runStarted == false)
        {
                return true;
        }
        
        return (bool)(this.丟丂丆丙丞丕与丛且 == false) ? 1 : 0;
    }
    public bool get_canRespawn()
    {
        return (bool)(this.业且丝丌丄丏丅丑丛() <= (float)this.safeZoneDistance) ? 1 : 0;
    }
    public bool get_showSafeZone()
    {
        var val_3;
        if(this.runStarted != false)
        {
                if(this.isShowGo == false)
        {
                return (bool)(this.业且丝丌丄丏丅丑丛() <= (float)this.safeZoneDistance) ? 1 : 0;
        }
        
        }
        
        val_3 = 0;
        return (bool)(this.业且丝丌丄丏丅丑丛() <= (float)this.safeZoneDistance) ? 1 : 0;
    }
    private void OnEnable()
    {
        this.丙与上万七丙丈丒丒 = 0f;
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void SpeedrunTrackController::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void OnDisable()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丗世丛丂丅丑丙世丕(丌七丒世丄上丞丞丁:  UnityEngine.Mathf.RoundToInt(f:  this.丙与上万七丙丈丒丒));
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void SpeedrunTrackController::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    public void InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        if(七丐丅专且专七三丆 != 30)
        {
                return;
        }
        
        if(null != 1)
        {
                return;
        }
        
        this.TryBuyShield();
    }
    private void Awake()
    {
        System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>>[] val_12;
        var val_13;
        var val_14;
        var val_15;
        SpeedrunTrackController.丛专与丅下丌丆世丒 = this;
        val_12 = new System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>>[4];
        this.东丙丏丑丞丕上丏不 = val_12;
        val_13 = 1152921540329972704;
        val_14 = 0;
        goto label_1;
        label_9:
        System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>> val_2 = new System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>>();
        if(this.东丙丏丑丞丕上丏不 == null)
        {
            goto label_2;
        }
        
        if(val_2 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_2 == null)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        this.东丙丏丑丞丕上丏不[0] = val_2;
        val_12 = this.东丙丏丑丞丕上丏不;
        val_14 = 1;
        label_1:
        if(val_14 < this.东丙丏丑丞丕上丏不.Length)
        {
            goto label_9;
        }
        
        val_15 = 0;
        goto label_10;
        label_35:
        SpeedrunTrackPart val_11 = this.allParts[0];
        System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>> val_12 = this.东丙丏丑丞丕上丏不[this.allParts[0x0][0].type];
        SpeedrunTrackPart val_13 = this.allParts[0];
        val_13 = (this.allParts[0x0][0].group + 1) - val_12.Count;
        if(val_13 >= 1)
        {
                do
        {
            val_12.Add(item:  new System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>());
            val_13 = val_13 - 1;
        }
        while(val_13 != 0);
        
        }
        
        SpeedrunTrackPart val_14 = this.allParts[0];
        System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>> val_6 = val_12.Item[this.allParts[0x0][0].group];
        val_6.Add(item:  new System.Collections.Generic.List<SpeedrunTrackPart>());
        SpeedrunTrackPart val_15 = this.allParts[0];
        this.allParts[0x0][0].poolIndex = val_6.Count - 1;
        this.丅丟东上且专东上丈(东丅丁丆七下专丕与:  this.allParts[0]);
        val_15 = 1;
        label_10:
        if(val_15 < this.allParts.Length)
        {
            goto label_35;
        }
        
        this.丛丒丌七丟丞丏丗且 = new System.Collections.Generic.List<SpeedrunTrackPart>(capacity:  this.visiblePartsCount);
    }
    private void 丒丗一丒且丘丘万丟(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.GameObject val_1 = Initializer.丕丛不丄丁丞丗且下(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 丆丙丅丝七丒丐丙万:  3);
        if(val_1 == 0)
        {
                return;
        }
        
        CoinBonus val_3 = val_1.GetComponent<CoinBonus>();
        if(val_3 == 0)
        {
                object[] val_5 = new object[1];
            val_5[0] = val_3.GetType();
            UnityEngine.Debug.LogErrorFormat(format:  "Cannot find component \'{0}\'", args:  val_5);
            return;
        }
        
        val_3.SetPlayer();
    }
    private void 东丑世万丁丂丅专业()
    {
        var val_1;
        this.isShowGo = true;
        this.runStarted = true;
        this.currentPlayerSpeed = this.startPlayerSpeed;
        val_1 = null;
        val_1 = null;
        mem2[0] = this.currentPlayerSpeed;
        mem2[0] = 1;
    }
    public void ResetRun()
    {
        var val_1;
        this.goTimer = 0f;
        this.丁业且丛丁丂且丈丄 = 1f;
        this.runStarted = false;
        this.丗丕与丁丟丟丗丏且(丙业与丙丗丝不丈东:  0f);
        val_1 = null;
        val_1 = null;
        mem2[0] = 0;
    }
    private void Update()
    {
        var val_76;
        InGameGUI val_77;
        float val_78;
        float val_79;
        float val_80;
        float val_81;
        int val_82;
        UnityEngine.Object val_83;
        UnityEngine.Object val_84;
        var val_85;
        float val_86;
        float val_87;
        float val_88;
        var val_89;
        float val_90;
        var val_91;
        var val_92;
        val_76 = null;
        val_76 = null;
        val_77 = 1152921504848912384;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        val_77 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_77 == 0)
        {
                return;
        }
        
        float val_5 = UnityEngine.Mathf.Max(a:  0f, b:  this.goTimer - UnityEngine.Time.deltaTime);
        this.goTimer = val_5;
        if(((UnityEngine.Mathf.FloorToInt(f:  val_5)) <= 0) && (this.runStarted != true))
        {
                this.东丑世万丁丂丅专业();
        }
        
        if(this.isShowGo == false)
        {
            goto label_17;
        }
        
        val_78 = this.丁业且丛丁丂且丈丄;
        if(val_78 < 0f)
        {
            goto label_15;
        }
        
        val_78 = val_78 - UnityEngine.Time.deltaTime;
        this.丁业且丛丁丂且丈丄 = val_78;
        if(this.isShowGo == false)
        {
            goto label_17;
        }
        
        label_15:
        if(val_78 < 0)
        {
                this.isShowGo = false;
        }
        
        label_17:
        UnityEngine.Vector3 val_10 = transform.position;
        val_79 = val_10.x;
        val_80 = val_10.y;
        val_81 = val_10.z;
        this.followPlayerGO.transform.position = new UnityEngine.Vector3() {x = val_79, y = val_80, z = val_81};
        if(this.丛丒丌七丟丞丏丗且.Count > this.visibleCenter)
        {
                SpeedrunTrackPart val_12 = this.丛丒丌七丟丞丏丗且.Item[this.visibleCenter];
            UnityEngine.Vector3 val_14 = val_12.endPoint.transform.position;
            UnityEngine.Vector3 val_16 = transform.position;
            if(val_14.z < 0)
        {
                this.丅丟东上且专东上丈(东丅丁丆七下专丕与:  this.丛丒丌七丟丞丏丗且.Item[0]);
            this.丛丒丌七丟丞丏丗且.RemoveAt(index:  0);
            int val_76 = this.丙世三丞业下丑万丁;
            val_76 = val_76 + 1;
            this.丙世三丞业下丑万丁 = val_76;
        }
        
        }
        
        int val_19 = this.visiblePartsCount - this.丛丒丌七丟丞丏丗且.Count;
        if(val_19 < 1)
        {
            goto label_34;
        }
        
        label_50:
        SpeedrunTrackPart val_20 = this.丞一丘专七专丝上与();
        if(this.丛丒丌七丟丞丏丗且.Count <= 0)
        {
            goto label_37;
        }
        
        if(this.丛丒丌七丟丞丏丗且 == null)
        {
            goto label_38;
        }
        
        val_82 = this.丛丒丌七丟丞丏丗且.Count;
        goto label_39;
        label_37:
        if(this.startTrackPoint != null)
        {
            goto label_43;
        }
        
        goto label_41;
        label_38:
        val_82 = 0.Count;
        label_39:
        SpeedrunTrackPart val_26 = this.丛丒丌七丟丞丏丗且.Item[val_82 - 1];
        if(val_26.endPoint != null)
        {
            goto label_43;
        }
        
        label_41:
        label_43:
        UnityEngine.Vector3 val_27 = 0.position;
        val_79 = val_27.x;
        val_80 = val_27.y;
        val_81 = val_27.z;
        val_20.transform.position = new UnityEngine.Vector3() {x = val_79, y = val_80, z = val_81};
        this.丛丒丌七丟丞丏丗且.Add(item:  val_20);
        if(val_20.type == 2)
        {
                UnityEngine.Transform val_28 = val_20.coinSpawnPoint.transform;
            UnityEngine.Vector3 val_29 = val_28.position;
            val_28.丒丗一丒且丘丘万丟(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        }
        
        val_19 = val_19 - 1;
        if(val_19 != 0)
        {
            goto label_50;
        }
        
        label_34:
        val_83 = 0;
        val_84 = 0;
        val_85 = 2;
        goto label_51;
        label_64:
        SpeedrunTrackPart val_30 = this.丛丒丌七丟丞丏丗且.Item[val_82];
        UnityEngine.Vector3 val_32 = val_30.endPoint.transform.position;
        UnityEngine.Vector3 val_34 = transform.position;
        if(val_32.z < 0)
        {
                val_83 = this.丛丒丌七丟丞丏丗且.Item[val_82];
            val_84 = val_83;
            if(val_85 < this.丛丒丌七丟丞丏丗且.Count)
        {
                val_84 = val_83;
            val_83 = this.丛丒丌七丟丞丏丗且.Item[2];
        }
        
        }
        
        val_85 = 3;
        label_51:
        if((val_85 - 2) < this.丛丒丌七丟丞丏丗且.Count)
        {
            goto label_64;
        }
        
        if(val_84 != 0)
        {
                UnityEngine.Vector3 val_42 = val_84.transform.position;
            UnityEngine.Vector3 val_44 = val_35.endPoint.transform.position;
            val_80 = val_44.y;
            val_86 = UnityEngine.Mathf.Min(a:  val_42.y, b:  val_80);
            val_85 = val_84.transform;
            UnityEngine.Vector3 val_47 = val_85.position;
            UnityEngine.Vector3 val_49 = val_35.endPoint.transform.position;
            val_79 = val_47.y;
            val_87 = UnityEngine.Mathf.Max(a:  val_79, b:  val_49.y);
        }
        else
        {
                UnityEngine.Vector3 val_52 = this.startTrackPoint.transform.position;
            val_86 = val_52.y;
            UnityEngine.Vector3 val_54 = this.startTrackPoint.transform.position;
            val_87 = val_54.y;
        }
        
        val_88 = -4f;
        val_86 = val_86 + val_88;
        UnityEngine.Transform val_55 = transform;
        UnityEngine.Vector3 val_56 = val_55.position;
        if((val_86 > val_56.y) && (this.丁丟东七与丏丙丗丙 != true))
        {
                if(this.丅与丆世与丅丗不专 != false)
        {
                this.丅与丆世与丅丗不专 = false;
            this.丁丟东七与丏丙丗丙 = true;
            if(val_83 == 0)
        {
                val_83 = this.startTrackPoint;
        }
        
            UnityEngine.Transform val_58 = val_83.transform;
            val_87 = val_87 + 10f;
            UnityEngine.Vector3 val_59 = 0.position;
            val_88 = val_59.y;
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_88, z = val_59.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_79 = val_87;
            val_81 = val_60.y;
            UnityEngine.Coroutine val_62 = this.StartCoroutine(routine:  this.与丏东三上丈万丂丒(丌丄七丒丁丆丘丝业:  val_79, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_60.x, y = val_81, z = val_60.z}));
        }
        else
        {
                val_55.丗万业业一东丛东不();
        }
        
        }
        
        val_89 = null;
        val_89 = null;
        UnityEngine.Vector3 val_65 = transform.position;
        UnityEngine.Vector3 val_67 = this.startTrackPoint.transform.position;
        val_88 = val_67.z;
        val_79 = this.业且丝丌丄丏丅丑丛();
        this.丗丕与丁丟丟丗丏且(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  val_79, b:  val_65.z - val_88));
        val_90 = this.业且丝丌丄丏丅丑丛() - this.丗丘丆丟七万与丐丆;
        if(val_90 >= this.distanceToAddSpeed)
        {
                this.丗丘丆丟七万与丐丆 = this.业且丝丌丄丏丅丑丛();
            val_90 = this.currentPlayerSpeed + this.playerAddSpeed;
            this.currentPlayerSpeed = val_90;
            val_91 = null;
            val_91 = null;
            mem2[0] = this.currentPlayerSpeed;
        }
        
        val_92 = null;
        val_92 = null;
        val_77 = UnityEngine.Mathf.RoundToInt(f:  this.业且丝丌丄丏丅丑丛());
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  val_77);
        if(this.业且丝丌丄丏丅丑丛() <= (float)this.safeZoneDistance)
        {
                return;
        }
        
        float val_75 = this.业且丝丌丄丏丅丑丛();
        val_75 = val_75 - (float)this.safeZoneDistance;
        this.丙与上万七丙丈丒丒 = val_75;
    }
    private void 丗万业业一东丛东不()
    {
        null = null;
        不上丒万丙且与丆丗();
    }
    public void ApplyDeathColliderShield()
    {
        var val_6;
        var val_7;
        var val_8;
        if(this.丟专且三下丙丁丕七 == false)
        {
                return;
        }
        
        this.丟专且三下丙丁丕七 = false;
        val_6 = null;
        val_6 = null;
        丛丙丒丘丘丒一丂丆().SetActive(value:  false);
        if(一世丏丐下世丅丛丆() != 0)
        {
                val_7 = null;
            val_7 = null;
            一世丏丐下世丅丛丆().SetActive(value:  true);
        }
        
        val_8 = null;
        val_8 = null;
        专丘七丅丄一七丕不(丂三丟丂丈丐丆丗丟:  1f);
        GetComponent<UnityEngine.AudioSource>().PlayOneShot(clip:  this.shieldBreakSound);
    }
    private System.Collections.IEnumerator 与丏东三上丈万丂丒(float 丌丄七丒丁丆丘丝业, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        SpeedrunTrackController.东丅丌丟东万丂万专 val_1 = new SpeedrunTrackController.东丅丌丟东万丂万专();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丌丄七丒丁丆丘丝业 = 丌丄七丒丁丆丘丝业;
        }
        else
        {
                mem[48] = this;
            mem[32] = 丌丄七丒丁丆丘丝业;
        }
        
        .丅专与丒丈丗丒丘丌 = 丅专与丒丈丗丒丘丌;
        mem[1152921540332103048] = 丅专与丒丈丗丒丘丌.y;
        mem[1152921540332103052] = 丅专与丒丈丗丒丘丌.z;
        return (System.Collections.IEnumerator)val_1;
    }
    private SpeedrunTrackPart 三丝一且丁丞丆不业()
    {
        七世一且丌丌不三丞 val_2;
        int val_3;
        this.丑七丙丙东业丟丘一 = this.丑七丙丙东业丟丘一 + 1;
        if(this.tutorialParts[this.丑七丙丙东业丟丘一] != null)
        {
                val_3 = this.tutorialParts[this.丑七丙丙东业丟丘一][0].group;
            val_2 = this.tutorialParts[this.丑七丙丙东业丟丘一][0].type;
            return this.丟丁下丝丌丙东丘与(丁丅丈丌丟世丗丗丟:  val_2 = 0, 不丝丄丒丌丐一一与:  135970152, 丈丗丁丗丗七一东一:  this.tutorialParts[this.丑七丙丙东业丟丘一][0].poolIndex);
        }
        
        val_3 = 135970152;
        return this.丟丁下丝丌丙东丘与(丁丅丈丌丟世丗丗丟:  val_2, 不丝丄丒丌丐一一与:  135970152, 丈丗丁丗丗七一东一:  this.tutorialParts[this.丑七丙丙东业丟丘一][0].poolIndex);
    }
    private SpeedrunTrackPart 丒专丐丑万七丒丒丙()
    {
        return this.丟丁下丝丌丙东丘与(丁丅丈丌丟世丗丗丟:  2, 不丝丄丒丌丐一一与:  0, 丈丗丁丗丗七一东一:  0);
    }
    private SpeedrunTrackPart 丞一丘专七专丝上与()
    {
        七世一且丌丌不三丞 val_14;
        七世一且丌丌不三丞 val_15;
        int val_16;
        int val_17;
        var val_18;
        if((this.tutorialParts != null) && (this.丑七丙丙东业丟丘一 < this.tutorialParts.Length))
        {
                return this.三丝一且丁丞丆不业();
        }
        
        float val_1 = this.业且丝丌丄丏丅丑丛();
        val_1 = val_1 - this.三丅一世丁丁丝且一;
        if(val_1 >= this.distanceToGetCoin)
        {
            goto label_3;
        }
        
        if(val_1 >= this.distanceToGetCoin)
        {
            goto label_4;
        }
        
        val_14 = 0;
        goto label_9;
        label_3:
        val_15 = 2;
        val_16 = 0;
        val_17 = 0;
        this.三丅一世丁丁丝且一 = this.业且丝丌丄丏丅丑丛();
        return this.丟丁下丝丌丙东丘与(丁丅丈丌丟世丗丗丟:  val_15 = val_14, 不丝丄丒丌丐一一与:  val_16 = val_10, 丈丗丁丗丗七一东一:  val_17 = UnityEngine.Random.Range(min:  0, max:  val_16.Item[val_10].Count));
        label_4:
        float val_14 = (float)this.丙世三丞业下丑万丁 - this.partsBeforeHard;
        val_14 = val_14 / (float)this.partsBeforeFullHard;
        val_14 = 0;
        float val_15 = (float)this.chanceToSpawnHard;
        val_15 = (UnityEngine.Mathf.Clamp01(value:  val_14)) * val_15;
        if(val_15 > ((float)UnityEngine.Random.Range(min:  0, max:  100)))
        {
                val_14 = 1;
        }
        
        label_9:
        System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<SpeedrunTrackPart>>> val_16 = this.东丙丏丑丞丕上丏不[val_14];
        if(val_16.Count == 0)
        {
            goto label_13;
        }
        
        label_23:
        val_18 = UnityEngine.Random.Range(min:  0, max:  val_16.Count);
        if((val_14 == 0) && (val_18 == this.丅三丌丏世丐丅万丕))
        {
                val_18 = val_18 + 1;
            int val_10 = (val_18 < val_16.Count) ? (val_18) : 0;
        }
        
        this.丅三丌丏世丐丅万丕 = val_10;
        return this.丟丁下丝丌丙东丘与(丁丅丈丌丟世丗丗丟:  val_15, 不丝丄丒丌丐一一与:  val_16, 丈丗丁丗丗七一东一:  val_17);
        label_13:
        if(this.东丙丏丑丞丕上丏不[0] != null)
        {
            goto label_23;
        }
        
        goto label_23;
    }
    private SpeedrunTrackPart 丟丁下丝丌丙东丘与(SpeedrunTrackPart.七世一且丌丌不三丞 丁丅丈丌丟世丗丗丟, int 不丝丄丒丌丐一一与, int 丈丗丁丗丗七一东一)
    {
        var val_12;
        var val_13;
        var val_14;
        val_12 = this.东丙丏丑丞丕上丏不[(long)丁丅丈丌丟世丗丗丟].Item[不丝丄丒丌丐一一与].Item[丈丗丁丗丗七一东一];
        if(val_12 == null)
        {
            goto label_5;
        }
        
        val_13 = public SpeedrunTrackPart System.Collections.Generic.List<SpeedrunTrackPart>::get_Item(int index);
        if(val_12.Count < 2)
        {
            goto label_6;
        }
        
        val_14 = val_12.Item[1];
        goto label_7;
        label_5:
        val_13 = public SpeedrunTrackPart System.Collections.Generic.List<SpeedrunTrackPart>::get_Item(int index);
        if(0.Count >= 2)
        {
            goto label_8;
        }
        
        label_6:
        val_14 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_12.Item[0].gameObject).GetComponent<SpeedrunTrackPart>();
        if(val_14 != null)
        {
            goto label_15;
        }
        
        goto label_14;
        label_8:
        val_14 = 0.Item[1];
        val_12 = 0;
        label_7:
        val_12.RemoveAt(index:  1);
        if(val_14 != null)
        {
            goto label_15;
        }
        
        label_14:
        label_15:
        val_14.gameObject.SetActive(value:  true);
        return (SpeedrunTrackPart)val_14;
    }
    private void 丅丟东上且专东上丈(SpeedrunTrackPart 东丅丁丆七下专丕与)
    {
        东丅丁丆七下专丕与.gameObject.SetActive(value:  false);
        this.东丙丏丑丞丕上丏不[东丅丁丆七下专丕与.type].Item[东丅丁丆七下专丕与.group].Item[东丅丁丆七下专丕与.poolIndex].Add(item:  东丅丁丆七下专丕与);
    }
    private void 丝业七东上丐丈下一()
    {
        var val_2;
        this.丟专且三下丙丁丕七 = true;
        val_2 = null;
        val_2 = null;
        丛丙丒丘丘丒一丂丆().SetActive(value:  true);
    }
    public void TryBuyShield()
    {
        丈丞丕丘丕丗与上一 val_13;
        var val_14;
        UnityEngine.GameObject val_15;
        var val_16;
        if(this.丟专且三下丙丁丕七 == true)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        丈丞丕丘丕丗与上一 val_1 = null;
        val_13 = val_1;
        val_1 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  1, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() == false)
        {
            goto label_5;
        }
        
        val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if((val_15.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_1.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_8;
        }
        
        label_5:
        val_15 = InGameGUI.丙丞专丌丁丞与不丐.gameObject;
        val_16 = null;
        val_16 = null;
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_15, 丒世丘丘上丆丝东丞:  val_1, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void SpeedrunTrackController::丐不专世丗七丌丛丌()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  JoystickController.丗三丄与丂丟丌专东, method:  public System.Void UIJoystick::Reset()), 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  100);
        return;
        label_8:
        UnityEngine.Debug.LogError(message:  "Mini game (not enough currency) -> GoToMainStore");
        val_13 = val_1.东与三丌丅三丒丏业();
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_13, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    public void ChangeControlScheme(bool 丘丄丒丗丞丈丁丄丗)
    {
        this.丟丂丆丙丞丕与丛且 = 丘丄丒丗丞丈丁丄丗;
    }
    public SpeedrunTrackController()
    {
        this.chanceToSpawnHard = 70;
        this.safeZoneDistance = 200;
        this.distanceToGetCoin = 2000f;
        this.visiblePartsCount = ;
        this.visibleCenter = ;
        this.partsBeforeHard = 128849018910;
        this.partsBeforeFullHard = 30;
        this.下丝丏三三丛丛丑业 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.startPlayerSpeed = 18f;
        this.distanceToAddSpeed = 100f;
        this.playerAddSpeed = 1f;
        this.丟丂丆丙丞丕与丛且 = true;
        this.goTimer = 0f;
        this.丁业且丛丁丂且丈丄 = 1f;
    }
    private void 丐不专世丗七丌丛丌()
    {
        Rilisoft.一丟专且三万丞丁丂.丌万专丘丄丌丏丑丅(丞一丁业丄一一业且:  "shield_speedrun", 丟不丏丕上丝世丌丛:  true);
        Rilisoft.一丟专且三万丞丁丂.业丝东丄丁丝丐丞丘(丝丞丟丂丏丟丑一丗:  "shield_speedrun");
        this.丝业七东上丐丈下一();
    }

}
