using UnityEngine;
internal sealed class FortSpawnMob : FortEquipObject, 丅丙上七上一丐不下
{
    // Fields
    internal System.Collections.Generic.List<string> _spawnBot;
    public int maxCountSpawnMob;
    public float timeForSpawnMob;
    private float _patrolRadius;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 世丞且丒丑丈丈与丞;
    private const string 不万丈丐丘上世丑丗 = "DungeonMobs/";
    public bool isEnemy;
    public UnityEngine.GameObject isEnemySprite;
    public UnityEngine.Transform healthBar;
    public UnityEngine.TextMesh nickLabel;
    private int 丞丏七丁不丂不丞与;
    private bool 丒丘且东与世万下丑;
    private UnityEngine.Coroutine 丘上下与丟一丘丙丁;
    private UnityEngine.Transform _pointSpawn;
    private string 丐丁世不丘业丙丅丛;
    private int <专业丞不丟专专丐与>k__BackingField;
    
    // Properties
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    private void Awake()
    {
        this.丐丌丗丐丐丟丈上一();
    }
    private void Start()
    {
        object val_5 = this;
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortSpawnMob::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
        HashSet.Enumerator<T> val_3 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞.GetEnumerator();
        label_6:
        if(((-16482408) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_4 = 0.丐丏七丌丕丗业且上();
        this.丗丛丄丏丅丆三上丑(丑丁一丛万丘万丗不:  public RilisoftBot.BaseBot HashSet.Enumerator<RilisoftBot.BaseBot>::get_Current());
        goto label_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortSpawnMob::丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
    }
    internal void 丐丌丗丐丐丟丈上一()
    {
        if(this.丘上下与丟一丘丙丁 != null)
        {
                return;
        }
        
        this.丘上下与丟一丘丙丁 = this.StartCoroutine(routine:  this.万丏上丘且一下丈下());
    }
    private System.Collections.IEnumerator 万丏上丘且一下丈下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortSpawnMob.丄丂下丑丑丘丛丐下();
    }
    private void Update()
    {
        this.世万业丐与丏丂丐丏();
        if((this.isActive != false) && (this.healthBar != 0))
        {
                if(S8 > 0f)
        {
                float val_3 = this.下丄丝七丑业一专一();
            val_3 = S8 / val_3;
        }
        
            this.healthBar.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        this.丁丅丐丈万丏三东丏();
        if(this.isEnemySprite == 0)
        {
                return;
        }
        
        var val_6 = (this.isEnemy == true) ? 1 : 0;
        val_6 = this.isEnemySprite.activeSelf ^ val_6;
        if(val_6 == false)
        {
                return;
        }
        
        this = this.isEnemySprite;
        this.SetActive(value:  (this.isEnemy == true) ? 1 : 0);
    }
    private void 丁丅丐丈万丏三东丏()
    {
        var val_4;
        var val_5;
        bool val_6;
        val_4 = null;
        val_4 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_10;
        }
        
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
                val_5 = 0;
        }
        
        if((this.IsEnemyTo(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
            goto label_10;
        }
        
        val_6 = 1;
        goto label_15;
        label_10:
        val_6 = false;
        label_15:
        this.isEnemy = val_6;
    }
    internal override void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        this.上丛丌丆丑上七世三(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
        this.丐丁世不丘业丙丅丛 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  丒专丈丛下丒一丒丛).SubategoryLocalizeName(丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  丒专丈丛下丒一丒丛).SubategoryLocalizeName) + " " + System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  136855705)(System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2497"), arg0:  136855705)) + " ";
    }
    private void 世万业丐与丏丂丐丏()
    {
        float val_7;
        float val_8;
        int val_9;
        var val_10;
        if(this.nickLabel == 0)
        {
                return;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_6;
        }
        
        label_19:
        if(this.丞丏七丁不丂不丞与 == 1)
        {
            goto label_20;
        }
        
        UnityEngine.Color val_3 = UnityEngine.Color.blue;
        val_7 = val_3.r;
        val_8 = val_3.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_7, g = val_3.g, b = val_8, a = val_3.a};
        val_9 = 1;
        goto label_9;
        label_6:
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_15;
        }
        
        val_10 = null;
        val_10 = null;
        if(SiegeController.三三万丆下一丗万丛.inAttackTeam == false)
        {
            goto label_19;
        }
        
        label_15:
        if(this.丞丏七丁不丂不丞与 == 2)
        {
            goto label_20;
        }
        
        UnityEngine.Color val_6 = UnityEngine.Color.red;
        val_7 = val_6.r;
        val_8 = val_6.b;
        this.nickLabel.color = new UnityEngine.Color() {r = val_7, g = val_6.g, b = val_8, a = val_6.a};
        val_9 = 2;
        label_9:
        this.丞丏七丁不丂不丞与 = val_9;
        label_20:
        this.nickLabel.text = this.丐丁世不丘业丙丅丛;
    }
    private void 上丌万丁丄丅一丐丙()
    {
        var val_3 = null;
        if((FortSpawnMob.<>c.<>9__24_0) == null)
        {
            goto label_3;
        }
        
        label_8:
        int val_1 = this.世丞且丒丑丈丈与丞.RemoveAll(match:  FortSpawnMob.<>c.<>9__24_0);
        return;
        label_3:
        FortSpawnMob.<>c.<>9__24_0 = new System.Predicate<RilisoftBot.BaseBot>(object:  FortSpawnMob.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortSpawnMob.<>c::丕一丂七东丝丝东丝(RilisoftBot.BaseBot 三丟东丕丄丄下下丑));
        if(this.世丞且丒丑丈丈与丞 != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private void 丟丕丏专专丙专丂丗(string 丗丙丒一且丝丂丒世)
    {
        string val_13 = 丗丙丒一且丝丂丒世;
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(2 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(2 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 2;
        val_1[1] = val_1.Length;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(this._pointSpawn != 0)
        {
            goto label_15;
        }
        
        if(this.transform != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        UnityEngine.Vector3 val_5 = 0.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.3f);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_13 = "DungeonMobs/"("DungeonMobs/") + val_13;
        UnityEngine.Quaternion val_11 = this.transform.rotation;
        UnityEngine.GameObject val_12 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  val_13, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_1);
        return;
        label_15:
        if(this._pointSpawn != null)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    private void 丗丛丄丏丅丆三上丑(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        UnityEngine.Object val_22;
        var val_23;
        val_22 = 1152921504848912384;
        if(丑丁一丛万丘万丗不 == 0)
        {
                return;
        }
        
        val_22 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_22 == 0)
        {
                return;
        }
        
        val_22 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        if(val_4.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        PhotonView val_5 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        val_22 = val_5.丞丁丝丕世丏丌丞丁;
        if(val_5.丞丁丝丕世丏丌丞丁.Length == 0)
        {
                return;
        }
        
        PhotonView val_6 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        val_22 = val_6.丞丁丝丕世丏丌丞丁;
        object val_22 = val_22[0];
        if(null != 2)
        {
                return;
        }
        
        PhotonView val_7 = 丑丁一丛万丘万丗不.丛丘丟业下丐专丕丑();
        object val_23 = val_7.丞丁丝丕世丏丌丞丁[1];
        if(null != val_7.丞丁丝丕世丏丌丞丁)
        {
                return;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_27;
        }
        
        this.东专丆业世丝丅丟丈(丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
        if(丑丁一丛万丘万丗不 != null)
        {
            goto label_33;
        }
        
        goto label_29;
        label_27:
        if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                this.丗丄且丄丅丗上世上(丑丁一丛万丘万丗不:  丑丁一丛万丘万丗不);
        }
        
        if(丑丁一丛万丘万丗不 != null)
        {
            goto label_33;
        }
        
        label_29:
        label_33:
        丑丁一丛万丘万丗不.七与世丄丞丒一七三().且丙丅丗丗丐且丟丛(且万丕丏且丛丂丛丐:  X22.丁丙丅不丝丐丛丆丁().Item[UnityEngine.Mathf.Min(a:  W23, b:  X24.丁丙丅不丝丐丛丆丁().Count - 1)]);
        丑丁一丛万丘万丗不.七与世丄丞丒一七三().丞与丗丐丈丄丌丅丁();
        if(丑丁一丛万丘万丗不 != null)
        {
                val_23 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
        }
        else
        {
                val_23 = 0.七与世丄丞丒一七三();
        }
        
        RilisoftBot.BaseBot val_20 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
        val_23.丂丆东丕丐丄丗丒业(丙业与丙丗丝不丈东:  val_20.health);
        this.世丞且丒丑丈丈与丞.Add(item:  丑丁一丛万丘万丗不.七与世丄丞丒一七三());
    }
    private void 东专丆业世丝丅丟丈(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        RilisoftBot.BotAiController val_40;
        float val_41;
        float val_42;
        var val_43;
        val_40 = 丑丁一丛万丘万丗不;
        PatrolModifierMoveInRadius val_2 = val_40.gameObject.AddComponent<PatrolModifierMoveInRadius>();
        val_41 = this._patrolRadius;
        if((public PatrolModifierMoveInRadius UnityEngine.GameObject::AddComponent<PatrolModifierMoveInRadius>()) != 0)
        {
                if(不七不丈丐万丂丌下() > 0f)
        {
                val_41 = X22.不七不丈丐万丂丌下();
        }
        
        }
        
        UnityEngine.Vector3 val_6 = this.transform.position;
        val_42 = val_6.y;
        val_2.丆业丙丘与丄专七不(且丛上丕业丂丒与一:  val_41, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_6.x, y = val_42, z = val_6.z});
        if(val_40 != null)
        {
                丑丁一丛万丘万丗不.丌万丁七丈业丈丗东 = val_2;
        }
        else
        {
                mem[96] = val_2;
        }
        
        MyMobsCurrentAiState val_8 = val_40.gameObject.AddComponent<MyMobsCurrentAiState>();
        val_8.丐丑七丈业丝丄东丝(丗不丛七丏丄业三丁:  val_40.七与世丄丞丒一七三(), 丑丁一丛万丘万丗不:  val_40);
        if(val_40 != null)
        {
                丑丁一丛万丘万丗不.丆丞业丅三丞专丝丒 = val_8;
        }
        else
        {
                mem[120] = val_8;
        }
        
        MyMobFortChooseNewTarget val_11 = val_40.gameObject.AddComponent<MyMobFortChooseNewTarget>();
        if(val_11 != null)
        {
                val_11.丐丑七丈业丝丄东丝(丗不丛七丏丄业三丁:  val_40.七与世丄丞丒一七三(), 丑丁一丛万丘万丗不:  val_40);
            val_11.丈专世丌三丝东万东 = val_8;
            val_11.专丒东丝丕丟一专专(丟丝上丄丂三丞且丄:  val_2);
            PhotonView val_13 = val_40.丛丘丟业下丐专丕丑();
            if(val_13.丞丁丝丕世丏丌丞丁.Length >= 2)
        {
                PhotonView val_14 = val_40.丛丘丟业下丐专丕丑();
            int val_15 = System.Convert.ToInt32(value:  val_14.丞丁丝丕世丏丌丞丁[1]);
            val_11.且三丕三丕丈下丕丝 = val_15;
            val_11.专丐丛丆与专世丆丂 = FortDefenceLinkController.丄丘七三上丕世丞业.丅七丂丆三业丘丌世(且三丕三丕丈下丕丝:  val_15);
        }
        
            if(val_40 != null)
        {
                丑丁一丛万丘万丗不.且丑不三上世丈丁丆 = val_11;
        }
        else
        {
                mem[136] = val_11;
        }
        
            RilisoftBot.BaseBot val_17 = val_40.七与世丄丞丒一七三();
            val_17.世丗万丞世丂丂丕丝 = false;
            MyMobIgnorIDamageable val_19 = val_40.gameObject.AddComponent<MyMobIgnorIDamageable>();
            if(val_40 != null)
        {
                丑丁一丛万丘万丗不.丝丘丗丘业丝丈下丞 = val_19;
        }
        else
        {
                mem[144] = val_19;
        }
        
            RilisoftBot.BaseBot val_20 = val_40.七与世丄丞丒一七三();
            val_43 = 1152921504848912384;
            if(val_20.丆丆丂丑丁世上丟上 == 0)
        {
                return;
        }
        
            UnityEngine.GameObject val_23 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NickNameLabel"));
            RilisoftBot.BaseBot val_25 = val_40.七与世丄丞丒一七三();
            val_23.transform.SetParent(p:  val_25.丆丆丂丑丁世上丟上.丙丄不上东丟丞七世().parent);
            RilisoftBot.BaseBot val_29 = val_40.七与世丄丞丒一七三();
            UnityEngine.Vector3 val_31 = val_29.丆丆丂丑丁世上丟上.丙丄不上东丟丞七世().position;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  0.3f);
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            val_23.transform.position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
            val_43 = val_23.transform;
            UnityEngine.Quaternion val_36 = UnityEngine.Quaternion.identity;
            val_43.localRotation = new UnityEngine.Quaternion() {x = val_36.x, y = val_36.y, z = val_36.z, w = val_36.w};
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.one;
            val_41 = val_38.x;
            val_42 = val_38.z;
            val_23.transform.localScale = new UnityEngine.Vector3() {x = val_41, y = val_38.y, z = val_42};
            RilisoftBot.BaseBot val_39 = val_40.七与世丄丞丒一七三();
            val_40 = val_39.丆丆丂丑丁世上丟上;
            val_39.丆丆丂丑丁世上丟上.三丕万丕丈丄丄丗万 = true;
            return;
        }
    
    }
    private void 丗丄且丄丅丗上世上(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        RilisoftBot.BotAiController val_40;
        float val_41;
        float val_42;
        var val_43;
        val_40 = 丑丁一丛万丘万丗不;
        PatrolModifierMoveInRadius val_2 = val_40.gameObject.AddComponent<PatrolModifierMoveInRadius>();
        val_41 = this._patrolRadius;
        if((public PatrolModifierMoveInRadius UnityEngine.GameObject::AddComponent<PatrolModifierMoveInRadius>()) != 0)
        {
                if(不七不丈丐万丂丌下() > 0f)
        {
                val_41 = X22.不七不丈丐万丂丌下();
        }
        
        }
        
        UnityEngine.Vector3 val_6 = this.transform.position;
        val_42 = val_6.y;
        val_2.丆业丙丘与丄专七不(且丛上丕业丂丒与一:  val_41, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_6.x, y = val_42, z = val_6.z});
        if(val_40 != null)
        {
                丑丁一丛万丘万丗不.丌万丁七丈业丈丗东 = val_2;
        }
        else
        {
                mem[96] = val_2;
        }
        
        MyMobsCurrentAiState val_8 = val_40.gameObject.AddComponent<MyMobsCurrentAiState>();
        val_8.丐丑七丈业丝丄东丝(丗不丛七丏丄业三丁:  val_40.七与世丄丞丒一七三(), 丑丁一丛万丘万丗不:  val_40);
        if(val_40 != null)
        {
                丑丁一丛万丘万丗不.丆丞业丅三丞专丝丒 = val_8;
        }
        else
        {
                mem[120] = val_8;
        }
        
        EnemyMobFortChooseNewTarget val_11 = val_40.gameObject.AddComponent<EnemyMobFortChooseNewTarget>();
        RilisoftBot.BaseBot val_12 = val_40.七与世丄丞丒一七三();
        if(val_11 != null)
        {
                val_11.丈专世丌三丝东万东 = val_8;
            val_11.专丒东丝丕丟一专专(丟丝上丄丂三丞且丄:  val_2);
            PhotonView val_13 = val_40.丛丘丟业下丐专丕丑();
            if(val_13.丞丁丝丕世丏丌丞丁.Length >= 2)
        {
                PhotonView val_14 = val_40.丛丘丟业下丐专丕丑();
            int val_15 = System.Convert.ToInt32(value:  val_14.丞丁丝丕世丏丌丞丁[1]);
            val_11.且三丕三丕丈下丕丝 = val_15;
            val_11.专丐丛丆与专世丆丂 = FortDefenceLinkController.丄丘七三上丕世丞业.丅七丂丆三业丘丌世(且三丕三丕丈下丕丝:  val_15);
        }
        
            if(val_40 != null)
        {
                丑丁一丛万丘万丗不.且丑不三上世丈丁丆 = val_11;
        }
        else
        {
                mem[136] = val_11;
        }
        
            RilisoftBot.BaseBot val_17 = val_40.七与世丄丞丒一七三();
            val_17.世丗万丞世丂丂丕丝 = false;
            MyMobIgnorIDamageable val_19 = val_40.gameObject.AddComponent<MyMobIgnorIDamageable>();
            if(val_40 != null)
        {
                丑丁一丛万丘万丗不.丝丘丗丘业丝丈下丞 = val_19;
        }
        else
        {
                mem[144] = val_19;
        }
        
            RilisoftBot.BaseBot val_20 = val_40.七与世丄丞丒一七三();
            val_43 = 1152921504848912384;
            if(val_20.丆丆丂丑丁世上丟上 == 0)
        {
                return;
        }
        
            UnityEngine.GameObject val_23 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "EnemyNickNameLabel"));
            RilisoftBot.BaseBot val_25 = val_40.七与世丄丞丒一七三();
            val_23.transform.SetParent(p:  val_25.丆丆丂丑丁世上丟上.丙丄不上东丟丞七世().parent);
            RilisoftBot.BaseBot val_29 = val_40.七与世丄丞丒一七三();
            UnityEngine.Vector3 val_31 = val_29.丆丆丂丑丁世上丟上.丙丄不上东丟丞七世().position;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  0.3f);
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            val_23.transform.position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
            val_43 = val_23.transform;
            UnityEngine.Quaternion val_36 = UnityEngine.Quaternion.identity;
            val_43.localRotation = new UnityEngine.Quaternion() {x = val_36.x, y = val_36.y, z = val_36.z, w = val_36.w};
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.one;
            val_41 = val_38.x;
            val_42 = val_38.z;
            val_23.transform.localScale = new UnityEngine.Vector3() {x = val_41, y = val_38.y, z = val_42};
            RilisoftBot.BaseBot val_39 = val_40.七与世丄丞丒一七三();
            val_40 = val_39.丆丆丂丑丁世上丟上;
            val_39.丆丆丂丑丁世上丟上.三丕万丕丈丄丄丗万 = true;
            return;
        }
    
    }
    internal override void 万不丄下丂三丕丒不(float 丛业专丘丂丅丗丝丛, int 丞丗且下世丐业丌丙 = 0, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三 = 0)
    {
        var val_9;
        var val_10;
        val_9 = this;
        val_10 = 0;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != 丞丗且下世丐业丌丙)
        {
                val_10 = 0;
            this.丗丘七上丏丌丒七丂();
        }
        
        丛业专丘丂丅丗丝丛 = 丛业专丘丂丅丗丝丛 - 丛业专丘丂丅丗丝丛;
        mem[1152921526068272128] = 丛业专丘丂丅丗丝丛;
        if(丛业专丘丂丅丗丝丛 >= 0)
        {
                return;
        }
        
        mem[1152921526068272128] = 0;
        val_9 = ???;
        goto typeof(FortSpawnMob).__il2cppRuntimeField_1F8;
    }
    internal bool 丑丝丈丟丌且且万世(string 丗丙丒一且丝丂丒世)
    {
        var val_5;
        List.Enumerator<T> val_1 = this._spawnBot.GetEnumerator();
        label_4:
        if(((-13286936) & 1) == 0)
        {
            goto label_2;
        }
        
        if((System.String.op_Equality(a:  0.丐丏七丌丕丗业且上().ToLower(), b:  丗丙丒一且丝丂丒世)) == false)
        {
            goto label_4;
        }
        
        val_5 = 1;
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
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
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.丗丘七上丏丌丒七丂();
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  丞丈专下丈专业三丞, 丞丗且下世丐业丌丙:  丒丈丐丐丗丐专丈丏, 丐丟丘世丁三丕专专:  0);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
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
        bool val_1 = this.isActive;
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public FortSpawnMob()
    {
        this._spawnBot = new System.Collections.Generic.List<System.String>();
        this.maxCountSpawnMob = 3;
        this.timeForSpawnMob = 10f;
        this._patrolRadius = 5f;
        this.世丞且丒丑丈丈与丞 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
    }

}
