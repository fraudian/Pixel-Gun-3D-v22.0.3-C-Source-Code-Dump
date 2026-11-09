using UnityEngine;
internal sealed class ZombiManager : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private const double 丕丛丗丝丄丘丒丐丒 = 25;
    internal static ZombiManager 丟丗丄业丘丗业丗七;
    private System.Collections.Generic.List<string[]> 三东丙万丝丟丛丅丏;
    public int currentWeaponCategory;
    public bool isPizzaMap;
    public double maxTimeGame;
    public float nextAddZombi;
    public float nextTimeSynch;
    public PhotonView photonView;
    public bool startGame;
    public double timeGame;
    public double timeUpdateCategory;
    public System.Collections.Generic.List<string> zombiePrefabs;
    
    // Methods
    public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        int val_3;
        var val_4;
        val_2 = 丗与一丛丐丞丘丌丞;
        if((val_2 & 255) == 138)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
            if(val_3 == 0)
        {
                val_3 = 专丒丌丆下丐丞丟丞.Length;
        }
        
            object val_2 = 专丒丌丆下丐丞丟丞[0];
            object val_3 = 专丒丌丆下丐丞丟丞[1];
            val_4 = 1;
            this.currentWeaponCategory = null;
            this.timeUpdateCategory = null;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    private void Awake()
    {
        bool val_8;
        var val_9;
        string val_10;
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "Pizza")) == false)
        {
            goto label_2;
        }
        
        val_8 = 1;
        if(this != null)
        {
            goto label_6;
        }
        
        goto label_4;
        label_2:
        val_8 = Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "Paradise_Night");
        if(this != null)
        {
            goto label_6;
        }
        
        label_4:
        label_6:
        this.isPizzaMap = val_8;
        if(val_8 == false)
        {
            goto label_7;
        }
        
        val_9 = new string[11];
        val_9[0] = "86";
        val_9[1] = "90";
        val_9[2] = "88";
        val_9[3] = "91";
        val_9[4] = "84";
        val_9[5] = "87";
        val_9[6] = "82";
        val_9[7] = "81";
        val_9[8] = "92";
        val_9[9] = "80";
        val_10 = "83";
        if(val_5.Length > 10)
        {
            goto label_76;
        }
        
        goto label_76;
        label_7:
        val_9 = new string[11];
        val_9[0] = "1";
        val_9[1] = "79";
        val_9[2] = "2";
        val_9[3] = "3";
        val_9[4] = "57";
        val_9[5] = "16";
        val_9[6] = "56";
        val_9[7] = "27";
        val_9[8] = "73";
        val_9[9] = "9";
        val_10 = "39";
        label_76:
        val_9[10] = val_10;
        if(val_6.Length < 1)
        {
                return;
        }
        
        do
        {
            this.zombiePrefabs.Add(item:  "Enemies/Enemy"("Enemies/Enemy") + val_9[0] + "_go");
            val_10 = 0 + 1;
        }
        while(val_10 < val_6.Length);
    
    }
    private void Start()
    {
        ZombiManager val_8;
        var val_9;
        var val_10;
        System.Action<与丅丕丈丘东丝世丟> val_11;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(GameConnect.丙丘不世专且万丄丐() == true)
        {
            goto label_6;
        }
        
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        label_6:
        ZombiManager.丟丗丄业丘丗业丗七 = val_8;
        this.nextAddZombi = 5f;
        this.photonView = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void ZombiManager::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_11 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_11;
    }
    private void 丈且三丞且上丘丈丗(float 七三丗丙丏丘丘丅上)
    {
    
    }
    private void 丝丛万丆丑丆世丏七(int 专丄丌且一丕万与丛, double 丒下一丛丝丗七丐下)
    {
        this.currentWeaponCategory = 专丄丌且一丕万与丛;
        this.timeUpdateCategory = 丒下一丛丝丗七丐下;
    }
    private void 专丝一专丙下丘世东(int 专丄丌且一丕万与丛, double 丒下一丛丝丗七丐下)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(专丄丌且一丕万与丛 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(专丄丌且一丕万与丛 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 专丄丌且一丕万与丛;
        val_1[1] = 丒下一丛丝丗七丐下;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  138, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 东一丒丆丛丝世业丞()
    {
        do
        {
            int val_1 = UnityEngine.Random.Range(min:  0, max:  6);
        }
        while(val_1 == this.currentWeaponCategory);
        
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "New Category " + val_1);
        }
        
        this.专丝一专丙下丘世东(专丄丌且一丕万与丛:  val_1, 丒下一丛丝丗七丐下:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.currentWeaponCategory != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.currentWeaponCategory == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.currentWeaponCategory;
        val_1[1] = this.timeUpdateCategory;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  138, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public void EndMatch()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        this.startGame = false;
        this.timeGame = 0;
    }
    private void Update()
    {
        var val_23;
        var val_25;
        float val_26;
        object val_27;
        var val_28;
        bool val_29;
        var val_30;
        var val_31;
        val_23 = null;
        val_23 = null;
        if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null))
        {
            goto label_31;
        }
        
        val_25 = null;
        val_25 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.专丝下世丄业丕丑七] == null) || (GameConnect.丙丘不世专且万丄丐() == false))
        {
            goto label_31;
        }
        
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 <= 0f)
        {
            goto label_21;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_31;
        }
        
        if(this.timeUpdateCategory < 0)
        {
            goto label_25;
        }
        
        double val_7 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_26 = val_7;
        val_7 = val_26 - this.timeUpdateCategory;
        if(System.Math.Abs(val_7) <= 25)
        {
            goto label_31;
        }
        
        label_25:
        this.东一丒丆丛丝世业丞();
        goto label_31;
        label_21:
        this.timeUpdateCategory = -1;
        label_31:
        val_27 = 1152921505189965824;
        val_28 = null;
        val_28 = null;
        int val_8 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count;
        val_29 = this.startGame;
        var val_9 = (val_8 > 0) ? 1 : 0;
        val_9 = val_9 ^ ((val_29 == true) ? 1 : 0);
        if((val_9 & 1) != 0)
        {
                bool val_11 = (val_8 > 0) ? 1 : 0;
            this.timeGame = 0;
            this.startGame = val_11;
            this.nextAddZombi = 0f;
            this.nextTimeSynch = 0f;
        }
        
        if(val_11 == 0)
        {
                return;
        }
        
        val_26 = this.maxTimeGame;
        double val_24 = TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞;
        val_24 = val_26 - val_24;
        this.timeGame = val_24;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(this.timeGame <= (double)this.nextAddZombi)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        if(丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Count >= 15)
        {
                return;
        }
        
        double val_26 = this.maxTimeGame;
        double val_25 = 0.400000005960464;
        val_25 = val_26 * val_25;
        val_26 = val_26 * 0.800000011920929;
        float val_15 = (this.timeGame > val_26) ? 2f : ((this.timeGame > val_25) ? 3f : 4f);
        val_15 = this.nextAddZombi + val_15;
        this.nextAddZombi = val_15;
        val_31 = null;
        val_31 = null;
        int val_27 = UnityEngine.Mathf.Clamp(value:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count - (((System.String.op_Equality(a:  UnityEngine.Application.loadedLevelName, b:  "Arena")) != true) ? (1 + 1) : 1), min:  1, max:  15);
        val_27 = ">>> ZOMBIE COUNT "(">>> ZOMBIE COUNT ") + val_27;
        UnityEngine.Debug.LogWarning(message:  val_27);
        if(val_27 < 1)
        {
                return;
        }
        
        do
        {
            this.丟世一丒丗丝东业丄();
            val_27 = val_27 - 1;
        }
        while(val_27 != 0);
    
    }
    private void 丕下丄一丏丏丄丐丆(int 丌丒丝东丌下丕丁丅)
    {
        int val_1 = 丌丒丝东丌下丕丁丅;
        if(val_1 < 1)
        {
                return;
        }
        
        do
        {
            this.丟世一丒丗丝东业丄();
            val_1 = val_1 - 1;
        }
        while(val_1 != 0);
    
    }
    private void 丟世一丒丗丝东业丄()
    {
        var val_34;
        int val_35;
        var val_36;
        var val_37;
        val_34 = null;
        val_34 = null;
        EnemyCreationZone val_3 = 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Item[UnityEngine.Random.Range(min:  0, max:  丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Count)];
        UnityEngine.Vector3 val_4 = val_3.boxCollider.size;
        UnityEngine.Vector3 val_5 = val_3.万东万丆专丌丕丐丗.localScale;
        UnityEngine.Vector3 val_6 = val_3.boxCollider.size;
        UnityEngine.Vector3 val_7 = val_3.万东万丆专丌丕丐丗.localScale;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_4.x * val_5.x, y:  val_6.z * val_7.z);
        UnityEngine.Vector3 val_11 = val_3.万东万丆专丌丕丐丗.position;
        UnityEngine.Vector3 val_12 = val_3.万东万丆专丌丕丐丗.position;
        float val_34 = 0.5f;
        float val_13 = val_10.x * val_34;
        val_13 = val_11.x - val_13;
        val_34 = val_10.y * val_34;
        val_34 = val_12.z - val_34;
        float val_14 = 0.x;
        UnityEngine.Vector3 val_16 = val_3.万东万丆专丌丕丐丗.position;
        float val_18 = val_14 + (UnityEngine.Random.Range(min:  0f, max:  val_14));
        float val_19 = val_16.x + (UnityEngine.Random.Range(min:  0f, max:  val_16.x));
        double val_35 = this.timeGame;
        val_35 = val_35 / this.maxTimeGame;
        double val_20 = val_35 * 100;
        if(this.isPizzaMap == false)
        {
            goto label_13;
        }
        
        if(val_20 >= 0)
        {
            goto label_14;
        }
        
        val_35 = UnityEngine.Random.Range(min:  0, max:  4);
        goto label_15;
        label_13:
        if(val_20 >= 0)
        {
            goto label_16;
        }
        
        val_35 = UnityEngine.Random.Range(min:  0, max:  3);
        goto label_17;
        label_14:
        val_35 = 0;
        label_15:
        if((val_20 >= 15) && (val_20 < 0))
        {
                val_35 = UnityEngine.Random.Range(min:  0, max:  5);
        }
        
        if((val_20 >= 30) && (val_20 < 0))
        {
                val_35 = UnityEngine.Random.Range(min:  0, max:  6);
        }
        
        if((val_20 >= 45) && (val_20 < 0))
        {
                val_35 = UnityEngine.Random.Range(min:  1, max:  7);
        }
        
        if((val_20 < 60) || (val_20 >= 0))
        {
            goto label_34;
        }
        
        val_36 = 1;
        val_37 = 9;
        goto label_26;
        label_16:
        val_35 = 0;
        label_17:
        if((val_20 >= 15) && (val_20 < 0))
        {
                val_35 = UnityEngine.Random.Range(min:  0, max:  5);
        }
        
        if((val_20 >= 30) && (val_20 < 0))
        {
                val_35 = UnityEngine.Random.Range(min:  0, max:  6);
        }
        
        if((val_20 >= 45) && (val_20 < 0))
        {
                val_35 = UnityEngine.Random.Range(min:  1, max:  8);
        }
        
        if((val_20 < 60) || (val_20 >= 0))
        {
            goto label_34;
        }
        
        val_36 = 3;
        val_37 = 10;
        label_26:
        val_35 = UnityEngine.Random.Range(min:  3, max:  10);
        label_34:
        if(val_20 >= 75)
        {
                val_35 = UnityEngine.Random.Range(min:  3, max:  11);
        }
        
        UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_33 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  this.zombiePrefabs.Item[val_35], 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0);
    }
    private void OnDestroy()
    {
        var val_4;
        System.Action<与丅丕丈丘东丝世丟> val_5;
        ZombiManager.丟丗丄业丘丗业丗七 = 0;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void ZombiManager::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_5;
    }
    public ZombiManager()
    {
        this.三东丙万丝丟丛丅丏 = new System.Collections.Generic.List<System.String[]>();
        this.currentWeaponCategory = 0;
        this.maxTimeGame = 240;
        this.timeUpdateCategory = -1;
        this.zombiePrefabs = new System.Collections.Generic.List<System.String>();
    }

}
