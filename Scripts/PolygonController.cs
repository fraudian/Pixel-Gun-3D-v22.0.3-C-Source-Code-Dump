using UnityEngine;
internal class PolygonController : MonoBehaviour
{
    // Fields
    internal static PolygonController 丄丘七三上丕世丞业;
    public bool inPolygon;
    private UnityEngine.GameObject _container;
    private System.Collections.Generic.List<UnityEngine.Transform> _listPointSpawnPlayer;
    private InstantiatePlayer _instantiatePlayer;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 且东丕三丝东丒世下;
    private System.Collections.Generic.List<UnityEngine.Transform> _listPosition;
    private System.Collections.Generic.List<string> _mobList;
    private int _maxCountBot;
    private const string 一下一万丄丅丘且丑 = "Enemies";
    private static System.Action<bool> 万丘下丐丆专三丟丈;
    private string 丂下丟丟丏丐业丙万;
    private UnityEngine.MeshRenderer _mesh;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private UnityEngine.GameObject _pointForSkyBox;
    private bool 丏丐丘七丄世丑世丝;
    internal bool 丐且丘不下丏丟丕丝;
    private System.Collections.Generic.List<PolygonController.HealthModify> _healthMultipler;
    private bool 丙丂丅专与丕与丌丝;
    private PGCompany.丝丆业不一丌东万世 丕丈下丂万丂七东三;
    private PGCompany.丝丆业不一丌东万世 丏专东三与丛一三上;
    private UnityEngine.Coroutine 专世与丗专上下七不;
    private System.Collections.Generic.List<三丈丟与丏丘丈丐万> 丝丒专丄丒丝丛东丒;
    private int 丏与丄三丞丁丁丅丈;
    
    // Properties
    internal PGCompany.丝丆业不一丌东万世 业丌三丁丅丝世不丝 { get; }
    
    // Methods
    public static void add_ActivatePolygon(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PolygonController.万丘下丐丆专三丟丈, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PolygonController.万丘下丐丆专三丟丈 != 1152921505247424520);
    
    }
    public static void remove_ActivatePolygon(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PolygonController.万丘下丐丆专三丟丈, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PolygonController.万丘下丐丆专三丟丈 != 1152921505247424520);
    
    }
    private void Awake()
    {
        PolygonController.一下一万丄丅丘且丑 = this;
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 == false)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丐丞专专且丒七与();
    }
    private void OnDestroy()
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丐丞专专且丒七与();
    }
    internal float 丄七丐业丕丏丅丘丞()
    {
        System.Collections.Generic.List<HealthModify> val_10;
        int val_11;
        float val_12;
        var val_13;
        val_10 = this;
        val_11 = 0;
        val_12 = 1f;
        label_12:
        if(val_11 >= this._healthMultipler.Count)
        {
                return (float)val_12;
        }
        
        val_11 = val_11 + 1;
        HealthModify val_3 = this._healthMultipler.Item[0];
        if(val_11 >= this._healthMultipler.Count)
        {
            goto label_5;
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() < val_3.minLevel)
        {
            goto label_12;
        }
        
        HealthModify val_5 = this._healthMultipler.Item[val_11];
        if(ExperienceController.丞丞丘业东丙丏七丌() >= val_5.minLevel)
        {
            goto label_12;
        }
        
        val_10 = this._healthMultipler;
        HealthModify val_7 = val_10.Item[0];
        val_13 = val_7.minLevel >> 32;
        goto label_14;
        label_5:
        val_13 = val_3.minLevel >> 32;
        label_14:
        val_12 = val_13;
        return (float)val_12;
    }
    internal void 丟丒上丘上丄一下万()
    {
        this.下一万万业东丕七东(丌丝下丄业一丄不三:  0, 丅丕丑丗丄万丑丞丝:  false, 丘丂丒丟丝丆丕丛丝:  true);
    }
    internal PGCompany.丝丆业不一丌东万世 业上丌丗丒丞上丙丞()
    {
        if(this.丏专东三与丛一三上 != null)
        {
                return val_4;
        }
        
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        PGCompany.丝丆业不一丌东万世 val_4 = new PGCompany.丝丆业不一丌东万世().丞丒且东三丁七丆丂(丙业与丙丗丝不丈东:  false).丕一一丄丐丞丗业丅(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
        this.丏专东三与丛一三上 = val_4;
        return val_4;
    }
    internal void 下一万万业东丕七东(PGCompany.丟丝东丈丐丙三下丛 丌丝下丄业一丄不三, bool 丅丕丑丗丄万丑丞丝 = True, bool 丘丂丒丟丝丆丕丛丝 = False)
    {
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_33;
        var val_34;
        bool val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        val_34 = null;
        val_34 = null;
        GameConnect.丁丝丐七七万丞丞丒 = 0;
        GravitySetter.SetNormalGravity();
        if(丅丕丑丗丄万丑丞丝 != false)
        {
                val_35 = 1;
            AlmanachMainUI.东与七丄丕世丑丟丕(丝三丄专丗丞丄丄丌:  true);
        }
        else
        {
                val_35 = false;
        }
        
        this.丏丐丘七丄世丑世丝 = val_35;
        this.丕丈下丂万丂七东三 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
        PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  this.业上丌丗丒丞上丙丞());
        GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  0);
        val_36 = null;
        val_36 = null;
        this.丙丂丅专与丕与丌丝 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = false;
        this.inPolygon = true;
        this.丗三东丂丝且不丆丂();
        this._container.SetActive(value:  true);
        val_37 = null;
        val_37 = null;
        MainMenuController.丄丞丁丈与业上丞丟.gameObject.SetActive(value:  false);
        val_38 = null;
        val_38 = null;
        this.丏与丄三丞丁丁丅丈 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        this.丝丒专丄丒丝丛东丒 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        if(丌丝下丄业一丄不三 != null)
        {
                val_39 = null;
            val_39 = null;
            System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_6 = null;
            val_33 = val_6;
            val_6 = new System.Collections.Generic.List<三丈丟与丏丘丈丐万>();
            三丈丟与丏丘丈丐万 val_7 = new 三丈丟与丏丘丈丐万();
            .三丐三丞丘丕不丒专 = 丌丝下丄业一丄不三.丐上下三丑丈丑丄丟();
            val_7.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  丌丝下丄业一丄不三.丐上下三丑丈丑丄丟().下世下丂丂丌丑丝世());
            val_7.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  丌丝下丄业一丄不三.丐上下三丑丈丑丄丟().世与不万丆丒丂丁丒());
            val_6.Add(item:  val_7);
            WeaponManager.丟丗丄业丘丗业丗七.丁丆七丆丝丌世丂丗(丙业与丙丗丝不丈东:  val_6);
        }
        
        val_40 = null;
        val_40 = null;
        WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  0);
        GameConnect.丏丑丘丐丁世丝丕丌(丙业与丙丗丝不丈东:  0);
        val_41 = null;
        val_41 = null;
        bool val_13 = 丘丂丒丟丝丆丕丛丝;
        mem[277] = val_13;
        this.丐且丘不下丏丟丕丝 = val_13;
        val_42 = null;
        val_42 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 != false)
        {
                val_43 = null;
            val_43 = null;
            if(BackgroundMusicController.丄丘七三上丕世丞业 != 0)
        {
                val_44 = null;
            val_44 = null;
            BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁().Play();
        }
        
        }
        
        val_45 = null;
        val_45 = null;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
        {
                val_46 = null;
            val_46 = null;
            MenuBackgroundMusic.丌丂一丛下丒丞丛东.丌丄丏下七丁专丂世();
        }
        
        val_47 = null;
        val_47 = null;
        UnityEngine.Vector3 val_19 = this.下专丟世丏丏世世专().position;
        WeaponManager.丟丗丄业丘丗业丗七.transform.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        this.专世与丗专上下七不 = this.StartCoroutine(routine:  this.丟丕丏专专丙专丂丗());
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PolygonController::ExitFromPolygon()), 与且专丈不万东一万:  "Polygon");
        if(PolygonController.万丘下丐丆专三丟丈 != null)
        {
                PolygonController.万丘下丐丆专三丟丈.Invoke(obj:  true);
        }
        
        if((Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丂丌与丅丗丞丈与不().ContainsKey(key:  12)) != false)
        {
                Rilisoft.上丆丕业丘业丈丄丆 val_28 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丂丌与丅丗丞丈与不().Item[12];
            if(val_28 != null)
        {
                val_28.GetComponent<Rilisoft.LobbyItemSkyboxComponent>().不丕丕业世丛丁丟丄(与且丏丂丝丗丙丒与:  true);
        }
        
        }
        
        val_48 = null;
        val_48 = null;
        if(LobbySeasonController.instance != 0)
        {
                val_49 = null;
            val_49 = null;
            LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  false);
        }
        
        PGCompany.GamepadCoreController.Instance.丄丑七丘丁且丞丙专(丏业丟一东丂东丘丛:  0);
    }
    public void ExitFromPolygon()
    {
        var val_5;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        bool val_38;
        var val_39;
        var val_40;
        this.inPolygon = false;
        this._container.SetActive(value:  false);
        val_26 = null;
        val_26 = null;
        MainMenuController.丄丞丁丈与业上丞丟.gameObject.SetActive(value:  true);
        val_27 = null;
        val_27 = null;
        if(GameController.mode != null)
        {
                val_28 = null;
            val_28 = null;
            var val_2 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + (PolygonModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_28) ? GameController.mode : 0;
        }
        
        0.丛丕丆下丕三业丟三();
        if(this.专世与丗专上下七不 != null)
        {
                this.StopCoroutine(routine:  this.专世与丗专上下七不);
            this.专世与丗专上下七不 = 0;
        }
        
        List.Enumerator<T> val_3 = this.且东丕三丝东丒世下.GetEnumerator();
        label_20:
        if(((-250966368) & 1) == 0)
        {
            goto label_15;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        System.Action<RilisoftBot.BaseBot> val_7 = new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void PolygonController::世丗三东东三东七上(RilisoftBot.BaseBot 业丘东且七丕丞东不));
        val_6.万丗七丕专且丆丏丅(丙业与丙丗丝不丈东:  null);
        UnityEngine.Object.Destroy(obj:  val_6.gameObject);
        goto label_20;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_29 = null;
        val_29 = null;
        if(BackgroundMusicController.丄丘七三上丕世丞业 != 0)
        {
                val_30 = null;
            val_30 = null;
            BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁().Stop();
        }
        
        val_31 = 1152921505171275776;
        val_32 = null;
        val_32 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 != false)
        {
                val_33 = null;
            val_33 = null;
            if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
        {
                val_34 = null;
            val_34 = null;
            MenuBackgroundMusic.丌丂一丛下丒丞丛东.三且世三丂七丐一丟();
        }
        
        }
        
        this.且东丕三丝东丒世下.Clear();
        val_35 = null;
        val_35 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = UnityEngine.Camera.main;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().下丐丞专专且丒七与();
        val_36 = null;
        val_36 = null;
        丛与上丆丅丑业且与().丑丗丟上三丈丞丐业(丁丌且丏丟且七丈丅:  true);
        WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  this.丏与丄三丞丁丁丅丈);
        WeaponManager.丟丗丄业丘丗业丗七.丁丆七丆丝丌世丂丗(丙业与丙丗丝不丈东:  this.丝丒专丄丒丝丛东丒);
        this.东三世丙丁丒丝世丕();
        if(PolygonController.万丘下丐丆专三丟丈 != null)
        {
                PolygonController.万丘下丐丆专三丟丈.Invoke(obj:  false);
        }
        
        val_37 = null;
        val_37 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = this.丙丂丅专与丕与丌丝;
        if(this.丏丐丘七丄世丑世丝 != false)
        {
                AlmanachMainUI.东与七丄丕世丑丟丕(丝三丄专丗丞丄丄丌:  false);
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
        if((Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丂丌与丅丗丞丈与不().ContainsKey(key:  12)) != false)
        {
                Rilisoft.上丆丕业丘业丈丄丆 val_18 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丂丌与丅丗丞丈与不().Item[12];
            if(val_18 != null)
        {
                val_18.GetComponent<Rilisoft.LobbyItemSkyboxComponent>().不丕丕业世丛丁丟丄(与且丏丂丝丗丙丒与:  false);
        }
        
        }
        
        val_38 = 1152921505080168448;
        val_39 = null;
        val_39 = null;
        if(LobbySeasonController.instance != 0)
        {
                val_31 = 1152921524490355520;
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) != 0)
        {
                val_40 = null;
            val_40 = null;
            val_38 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业();
            LobbySeasonController.instance.丄丟丑丒与丂丝七东(丂丒丞七下与丛且专:  val_38);
        }
        
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  this.丕丈下丂万丂七东三);
    }
    internal UnityEngine.Transform 下专丟世丏丏世世专()
    {
        if(this._listPointSpawnPlayer != null)
        {
                return this._listPointSpawnPlayer.Item[UnityEngine.Random.Range(min:  0, max:  this._listPointSpawnPlayer.Count)];
        }
        
        return this._listPointSpawnPlayer.Item[UnityEngine.Random.Range(min:  0, max:  this._listPointSpawnPlayer.Count)];
    }
    private System.Collections.IEnumerator 丟丕丏专专丙专丂丗()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PolygonController.专世丁与丆丑丏丒丈();
    }
    private RilisoftBot.BaseBot 丛丌丂丕丁丄上专丘()
    {
        return UnityEngine.Object.Instantiate<RilisoftBot.BaseBot>(original:  UnityEngine.Resources.Load<RilisoftBot.BaseBot>(path:  "Enemies/"("Enemies/") + this._mobList.Item[UnityEngine.Random.Range(min:  0, max:  this._mobList.Count)](this._mobList.Item[UnityEngine.Random.Range(min:  0, max:  this._mobList.Count)])));
    }
    private void 世丗三东东三东七上(RilisoftBot.BaseBot 业丘东且七丕丞东不)
    {
        业丘东且七丕丞东不.万丗七丕专且丆丏丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void PolygonController::世丗三东东三东七上(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
        bool val_2 = this.且东丕三丝东丒世下.Remove(item:  业丘东且七丕丞东不);
    }
    private void 丗三东丂丝且不丆丂()
    {
        string val_18;
        if(this._mesh == 0)
        {
                return;
        }
        
        Rilisoft.丏丘七丞丄丙丌丞丁 val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丅丟丝丗丌丂且丗一(与丄不丌一世东丁丙:  4);
        if(val_3 == null)
        {
                return;
        }
        
        val_18 = 万丑丙丛不丑且且丄.一三专丞丒丅上业上();
        if((val_18.ContainsKey(key:  val_3.业上丙丞丐丄丆丅七())) == false)
        {
                return;
        }
        
        val_18 = 万丑丙丛不丑且且丄.一三专丞丒丅上业上().Item[val_3.业上丙丞丐丄丆丅七()].丁丌丘丟丘丌下世丁();
        if(val_10.Length < 16)
        {
                return;
        }
        
        val_18 = 万丑丙丛不丑且且丄.一三专丞丒丅上业上();
        string val_18 = val_18.Item[val_3.业上丙丞丐丄丆丅七()].丁丌丘丟丘丌下世丁()[15];
        if((System.String.IsNullOrEmpty(value:  val_18)) == true)
        {
                return;
        }
        
        val_18 = this.丂下丟丟丏丐业丙万;
        if((val_18.Equals(value:  val_18)) != false)
        {
                return;
        }
        
        this.丂下丟丟丏丐业丙万 = val_18;
        this._mesh.sharedMaterial = UnityEngine.Resources.Load<UnityEngine.Material>(path:  val_18);
    }
    private void 东三世丙丁丒丝世丕()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    public PolygonController()
    {
        this._listPointSpawnPlayer = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.且东丕三丝东丒世下 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
        this._listPosition = new System.Collections.Generic.List<UnityEngine.Transform>();
        this._mobList = new System.Collections.Generic.List<System.String>();
        this._maxCountBot = 5;
        this.丂下丟丟丏丐业丙万 = "";
        this._healthMultipler = new System.Collections.Generic.List<HealthModify>();
    }

}
