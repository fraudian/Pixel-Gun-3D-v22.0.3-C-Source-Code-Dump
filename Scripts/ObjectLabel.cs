using UnityEngine;
public class ObjectLabel : MonoBehaviour
{
    // Fields
    internal static UnityEngine.Camera 丐万与与丙丁丂丅专;
    public WeaponManager _weaponManager;
    public UnityEngine.Camera cam;
    public UnityEngine.Camera cameraToUse;
    private UnityEngine.Transform 丝丈不丁丝上业丅丄;
    public float clampBorderSize;
    public bool clampToScreen;
    public UnityEngine.GUIText clanName;
    public UnityEngine.GUITexture clanTexture;
    private ExperienceController 丁世万丙丞丅丆丌业;
    private bool 上丘丁丟丅三丞丁丁;
    public bool isMenu;
    private bool 下丘丛世丅不且丂七;
    public bool isShadow;
    public bool isShow;
    private float 专丙上且丐万东且丐;
    public UnityEngine.Vector3 offset;
    public UnityEngine.Vector3 posLabel;
    private int 专世专丟丝丌与丘上;
    public UnityEngine.Transform target;
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    public float timeShow;
    public bool useMainCamera;
    
    // Methods
    private void Start()
    {
        var val_20;
        var val_21;
        val_20 = null;
        val_20 = null;
        this._weaponManager = WeaponManager.丟丗丄业丘丗业丗七;
        this.丁世万丙丞丅丆丌业 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "ExperienceController").GetComponent<ExperienceController>();
        float val_3 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        this.万一丂丐丄丁上与丟 = this.transform;
        val_21 = null;
        val_21 = null;
        this.cam = ObjectLabel.丐万与与丙丁丂丅专;
        this.丝丈不丁丝上业丅丄 = ObjectLabel.丐万与与丙丁丂丅专.transform;
        float val_22 = this.专丙上且丐万东且丐;
        float val_21 = -75f;
        float val_20 = -3f;
        val_20 = val_22 * val_20;
        val_21 = val_22 * val_21;
        val_22 = val_22 * 30f;
        this.transform.GetComponent<UnityEngine.GUITexture>().pixelInset = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        float val_23 = this.专丙上且丐万东且丐;
        val_23 = val_23 * (-45f);
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_23, y:  0f);
        this.transform.GetComponent<UnityEngine.GUIText>().pixelOffset = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        float val_24 = 20f;
        val_24 = this.专丙上且丐万东且丐 * val_24;
        this.transform.GetComponent<UnityEngine.GUIText>().fontSize = UnityEngine.Mathf.RoundToInt(f:  val_24);
        float val_25 = this.专丙上且丐万东且丐;
        float val_15 = val_25 * (-18f);
        float val_16 = val_25 * (-64f);
        val_25 = val_25 * 15f;
        this.上丘丁丟丅三丞丁丁 = GameConnect.丅业东业丞七上丞丑();
        this.clanTexture.pixelInset = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        float val_26 = this.专丙上且丐万东且丐;
        UnityEngine.Vector2 val_18;
        val_26 = val_26 * (-41f);
        val_18 = new UnityEngine.Vector2(x:  val_26, y:  -4f);
        this.clanName.pixelOffset = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
        float val_27 = this.专丙上且丐万东且丐;
        val_27 = val_27 * 16f;
        this.clanName.fontSize = UnityEngine.Mathf.RoundToInt(f:  val_27);
    }
    public void ResetTimeShow()
    {
        this.timeShow = 1f;
    }
    private void Update()
    {
        UnityEngine.Transform val_70;
        float val_71;
        float val_73;
        var val_74;
        int val_75;
        var val_76;
        float val_77;
        float val_78;
        float val_82;
        float val_83;
        float val_84;
        float val_85;
        val_70 = this;
        val_71 = this.timeShow;
        if(val_71 > 0f)
        {
                val_73 = val_71 - UnityEngine.Time.deltaTime;
            this.timeShow = val_73;
        }
        
        val_74 = 1152921504848912384;
        if(this.target != 0)
        {
                if(this.cam != 0)
        {
            goto label_7;
        }
        
        }
        
        UnityEngine.Debug.Log(message:  "target == null || cam == null");
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        return;
        label_7:
        val_75 = 1152921505066536960;
        if((GameConnect.不专专丂万丝上东丐() == false) || (MiniGamesController.丑七不且上丗丁一世() == 0))
        {
            goto label_19;
        }
        
        MiniGamesController val_8 = MiniGamesController.丑七不且上丗丁一世();
        if(val_8.isGo == false)
        {
            goto label_23;
        }
        
        label_19:
        if(this._weaponManager.myPlayer != 0)
        {
            goto label_27;
        }
        
        label_23:
        this.timeShow = 1f;
        label_27:
        if(GameConnect.丑丌丛丈丅丅与不业() != 2)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 4)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
            goto label_53;
        }
        
        }
        
        }
        
        if(((this._weaponManager.myPlayer != 0) && (this._weaponManager.myPlayerMoveC != 0)) && ((this.target.GetComponent<Player_move_c>()) != 0))
        {
                val_75 = this.target.GetComponent<Player_move_c>();
            if(this._weaponManager.myPlayerMoveC.丘丑丅三丆丑丌且丝() == val_75.丘丑丅三丆丑丌且丝())
        {
                this.timeShow = 1f;
        }
        
        }
        
        label_53:
        val_76 = null;
        val_76 = null;
        this.cam = ObjectLabel.丐万与与丙丁丂丅专;
        this.丝丈不丁丝上业丅丄 = ObjectLabel.丐万与与丙丁丂丅专.transform;
        UnityEngine.GUITexture val_22 = this.transform.GetComponent<UnityEngine.GUITexture>();
        if(val_22 == 0)
        {
                UnityEngine.Debug.LogError(message:  "guiTexture == null");
            return;
        }
        
        if(this.isMenu == false)
        {
            goto label_64;
        }
        
        float val_72 = this.专丙上且丐万东且丐;
        float val_71 = -130f;
        float val_70 = -6f;
        val_70 = val_72 * val_70;
        val_71 = val_72 * val_71;
        val_72 = val_72 * 36f;
        val_22.pixelInset = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        float val_73 = this.专丙上且丐万东且丐;
        val_73 = val_73 * (-85f);
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_73, y:  0f);
        this.transform.GetComponent<UnityEngine.GUIText>().pixelOffset = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
        val_71 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        float val_74 = 20f;
        val_74 = val_71 * val_74;
        this.transform.GetComponent<UnityEngine.GUIText>().fontSize = UnityEngine.Mathf.RoundToInt(f:  val_74);
        this.offset = 0;
        mem[1152921538481262252] = 0;
        val_22.texture = this.丁世万丙丞丅丆丌业.marks[(long)ExperienceController.丞丞丘业东丙丏七丌()];
        float val_78 = this.专丙上且丐万东且丐;
        float val_77 = -110f;
        float val_76 = -18f;
        val_76 = val_78 * val_76;
        val_77 = val_78 * val_77;
        val_78 = val_78 * 15f;
        val_77 = 0f;
        this.clanTexture.pixelInset = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = val_77, m_Height = 0f};
        float val_79 = this.专丙上且丐万东且丐;
        val_79 = val_79 * (-85f);
        UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_79, y:  -2f);
        this.clanName.pixelOffset = new UnityEngine.Vector2() {x = val_32.x, y = val_32.y};
        val_78 = 16f;
        val_73 = this.专丙上且丐万东且丐 * val_78;
        val_75 = UnityEngine.Mathf.RoundToInt(f:  val_73);
        this.clanName.fontSize = val_75;
        if(this.clanTexture.texture != 0)
        {
            goto label_127;
        }
        
        if((((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌()) == 0))
        {
            goto label_96;
        }
        
        this.clanTexture.texture = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌();
        goto label_100;
        label_64:
        Player_move_c val_47 = this.target.GetComponent<Player_move_c>();
        if(this.下丘丛世丅不且丂七 != true)
        {
                if(val_47.丘丑丅三丆丑丌且丝() == 1)
        {
                UnityEngine.Color val_51 = UnityEngine.Color.blue;
            val_71 = val_51.r;
            val_82 = val_51.b;
            val_83 = val_51.a;
            val_73 = val_71;
            val_78 = val_51.g;
            val_77 = val_82;
            this.gameObject.GetComponent<UnityEngine.GUIText>().color = new UnityEngine.Color() {r = val_73, g = val_78, b = val_77, a = val_83};
            this.下丘丛世丅不且丂七 = true;
        }
        
            if(val_47.丘丑丅三丆丑丌且丝() == 2)
        {
                UnityEngine.Color val_55 = UnityEngine.Color.red;
            val_71 = val_55.r;
            val_82 = val_55.b;
            val_83 = val_55.a;
            val_73 = val_71;
            val_78 = val_55.g;
            val_77 = val_82;
            this.gameObject.GetComponent<UnityEngine.GUIText>().color = new UnityEngine.Color() {r = val_73, g = val_78, b = val_77, a = val_83};
            this.下丘丛世丅不且丂七 = true;
        }
        
        }
        
        val_74 = 1152921524444239504;
        NetworkStartTable val_56 = val_47.业丐上东丅丞丛万上.GetComponent<NetworkStartTable>();
        if(((val_56.下东且丐丆丅丁世丟 & 2147483648) != 0) || (val_56.下东且丐丆丅丁世丟 >= this.丁世万丙丞丅丆丌业.marks.Length))
        {
            goto label_117;
        }
        
        val_22.texture = this.丁世万丙丞丅丆丌业.marks[(long)val_56.下东且丐丆丅丁世丟];
        goto label_122;
        label_96:
        this.clanTexture.texture = 0;
        label_100:
        val_75 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丙上东业丆不丟丘();
        this.clanName.text = val_75;
        goto label_127;
        label_117:
        UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Rank is equal to {0}, but the range [0, {1}) expected.", arg0:  val_56.下东且丐丆丅丁世丟, arg1:  this.丁世万丙丞丅丆丌业.marks.Length));
        label_122:
        NetworkStartTable val_61 = val_47.业丐上东丅丞丛万上.GetComponent<NetworkStartTable>();
        this.clanTexture.texture = val_61.丏丅业丞丁丌丈与丆;
        NetworkStartTable val_62 = val_47.业丐上东丅丞丛万上.GetComponent<NetworkStartTable>();
        val_75 = val_62.丐丆丒丅且丏世一与;
        this.clanName.text = val_75;
        label_127:
        val_84 = this.timeShow;
        if(val_84 > 0f)
        {
                val_75 = this.target;
            UnityEngine.Vector3 val_63 = val_75.position;
            UnityEngine.Vector3 val_64 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = val_83, z = V12.16B});
            val_71 = val_64.x;
            val_82 = val_64.z;
            UnityEngine.Vector3 val_65 = this.cam.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_71, y = val_64.y, z = val_82});
            val_84 = this.timeShow;
            this.posLabel = val_65;
            mem[1152921538481262260] = val_65.y;
            mem[1152921538481262264] = val_65.z;
        }
        
        if(val_84 > 0f)
        {
                if(val_71 >= 0f)
        {
            goto label_144;
        }
        
        }
        
        val_85 = 0f;
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = 0f, y = val_85, z = 0f};
        goto label_146;
        label_144:
        val_85 = val_82;
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = this.posLabel, y = val_85, z = val_71};
        label_146:
        if(this.isMenu == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_69 = this.target.transform.parent.transform.position;
        if(val_69.y >= 0)
        {
                return;
        }
        
        val_70 = this.万一丂丐丄丁上与丟;
        val_70.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ObjectLabel()
    {
        this.clampBorderSize = 0.05f;
        float val_3 = 768f;
        val_3 = (float)UnityEngine.Screen.height / val_3;
        this.专丙上且丐万东且丐 = val_3;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        this.offset = val_2;
        mem[1152921538481853480] = val_2.y;
        mem[1152921538481853484] = val_2.z;
        this.专世专丟丝丌与丘上 = 1;
        this.useMainCamera = 1;
    }
    private static ObjectLabel()
    {
    
    }

}
