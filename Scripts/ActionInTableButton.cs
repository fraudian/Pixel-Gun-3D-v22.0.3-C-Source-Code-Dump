using UnityEngine;
public sealed class ActionInTableButton : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject plusButton;
    private UIButton 三一东丈业丈世世丛;
    public LikeButtonHandler likeButton;
    public UILabel rankLabel;
    public UnityEngine.GameObject check;
    public UILabel namesPlayers;
    public UnityEngine.Vector3 defaultNameLabelPos;
    private int 不丄丛万丒丐丅上丙;
    public UILabel scorePlayers;
    public UILabel countKillsPlayers;
    public UILabel countDeathPlayers;
    public UILabel placeLabel;
    private UnityEngine.Vector3 东下丘丝丝业丕丞丙;
    private UnityEngine.Vector3 丕丙丘丝丅且七万丆;
    private UnityEngine.Vector3 万上丏丂丕丞不丂下;
    public UILabel distanceScore;
    public UILabel timeScore;
    public UITexture clanTexture;
    public string pixelbookID;
    public string nickPlayer;
    internal bool 一七不三丌专三丆一;
    internal NetworkStartTableNGUIController networkStartTableNGUIController;
    public bool isMine;
    public UnityEngine.GameObject isMineSprite;
    public UnityEngine.GameObject isTeammateSprite;
    public UnityEngine.GameObject playerDisconnected;
    public UnityEngine.GameObject oddPanel;
    public UnityEngine.GameObject subscriptionBackground;
    public UnityEngine.GameObject subscriptionLeftSide;
    public UnityEngine.GameObject subscriptionRightSide;
    public UnityEngine.MeshRenderer playerPreviewRenderer;
    public UITexture revengeCheckmark;
    public UnityEngine.Material playerPreviewMaterial;
    public bool initialized;
    private bool 七丙丘万专丟世与专;
    private bool 丕丝世丕丛一丏世丝;
    
    // Methods
    private void 上丛丌丆丑上七世三()
    {
        if(this.initialized == true)
        {
                return;
        }
        
        this.initialized = true;
        this.三一东丈业丈世世丛 = this.GetComponent<UIButton>();
        if(this.playerPreviewRenderer == 0)
        {
                return;
        }
        
        UnityEngine.Material val_4 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Unlit/Texture"));
        this.playerPreviewMaterial = val_4;
        this.playerPreviewRenderer.sharedMaterial = val_4;
    }
    private void Start()
    {
        bool val_60;
        var val_61;
        string val_62;
        if(this.check.activeSelf != false)
        {
                val_60 = PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.check, 丏业丟一东丂东丘丛:  val_60);
        }
        
        this.上丛丌丆丑上七世三();
        if(GameConnect.一与东丝万上三丆丏() == true)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 4)
        {
                UnityEngine.Vector3 val_7 = this.countKillsPlayers.transform.position;
            val_61 = val_7.x;
            UnityEngine.Vector3 val_10 = this.scorePlayers.transform.position;
            UnityEngine.Vector3 val_12 = this.countKillsPlayers.transform.position;
            UnityEngine.Vector3 val_14 = this.countKillsPlayers.transform.position;
            this.countKillsPlayers.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_17 = this.scorePlayers.transform.position;
            val_60 = this.scorePlayers.transform;
            UnityEngine.Vector3 val_19 = val_60.position;
            this.scorePlayers.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        if((GameConnect.丑丌丛丈丅丅与不业() != 1) && (GameConnect.丑丌丛丈丅丅与不业() != 14))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 21)
        {
                if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_40;
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_26 = this.countKillsPlayers.transform.position;
        val_61 = val_26.x;
        UnityEngine.Vector3 val_28 = this.scorePlayers.transform.position;
        val_60 = this.scorePlayers.transform;
        UnityEngine.Vector3 val_30 = val_60.position;
        this.scorePlayers.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.countKillsPlayers.gameObject.SetActive(value:  false);
        label_40:
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                this.countKillsPlayers.gameObject.SetActive(value:  false);
            this.scorePlayers.gameObject.SetActive(value:  false);
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                this.countKillsPlayers.gameObject.SetActive(value:  true);
            this.scorePlayers.gameObject.SetActive(value:  false);
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.三与万丝丒一丏丝七 != false)
        {
                if((System.String.IsNullOrEmpty(value:  this.pixelbookID)) == true)
        {
            goto label_69;
        }
        
        }
        
        if((this.pixelbookID.Equals(value:  "0")) != true)
        {
                if((this.pixelbookID.Equals(value:  "-1")) == false)
        {
            goto label_91;
        }
        
        }
        
        label_69:
        if((((((GameConnect.丑丌丛丈丅丅与不业() != 20) && ((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)) && (GameConnect.丑丌丛丈丅丅与不业() != 19)) && (GameConnect.东且三丆丑世世丘丟() != true)) && ((System.String.op_Inequality(a:  this.pixelbookID, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)) && (this.likeButton != 0))
        {
                val_60 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1224");
            if((this.nickPlayer.Contains(value:  val_60)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  this.pixelbookID)) == false)
        {
            goto label_92;
        }
        
        }
        
        }
        
        label_91:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  false);
        label_111:
        if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_100;
        }
        
        }
        
        this.scorePlayers.gameObject.SetActive(value:  false);
        this.countKillsPlayers.gameObject.SetActive(value:  false);
        this.distanceScore.gameObject.SetActive(value:  true);
        this.timeScore.gameObject.SetActive(value:  true);
        label_100:
        this.networkStartTableNGUIController = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
        return;
        label_92:
        if(this.一七不三丌专三丆一 != false)
        {
                val_62 = System.String.Format(format:  "bt_{0}", arg0:  UnityEngine.Random.Range(min:  9999, max:  0));
        }
        else
        {
                val_62 = this.pixelbookID;
        }
        
        this.丘丅与丙丕丄七下七(丄丒且丙三丆丟与丏:  val_62);
        goto label_111;
    }
    private void Update()
    {
        this.UpdateAddState();
    }
    public void UpdateAddState()
    {
        UnityEngine.GameObject val_46;
        string val_47;
        var val_48;
        var val_49;
        UnityEngine.GameObject val_50;
        string val_51;
        val_46 = this;
        val_47 = 1152921505066536960;
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if(this.playerPreviewRenderer != 0)
        {
                if(this.playerPreviewRenderer.enabled != true)
        {
                this.playerPreviewRenderer.enabled = true;
        }
        
        }
        
            if(this.三一东丈业丈世世丛 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.三一东丈业丈世世丛.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        if(((((((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.三与万丝丒一丏丝七 != false) && (GameConnect.丑丌丛丈丅丅与不业() != 20)) && ((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)) && (GameConnect.丑丌丛丈丅丅与不业() != 19)) && (GameConnect.东且三丆丑世世丘丟() != true)) && ((System.String.op_Inequality(a:  this.pixelbookID, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)) && (this.likeButton != 0))
        {
                val_47 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1224");
            if((this.nickPlayer.Contains(value:  val_47)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  this.pixelbookID)) == false)
        {
            goto label_38;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  false);
        label_111:
        if((System.String.IsNullOrEmpty(value:  this.pixelbookID)) == true)
        {
            goto label_48;
        }
        
        val_48 = null;
        val_48 = null;
        val_47 = this.pixelbookID;
        if(((FriendsController.丄丞丁丈与业上丞丟.IsShowAdd(业丗丑丝丙业丝丏上:  val_47)) == false) || (PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛() == false))
        {
            goto label_48;
        }
        
        if(this.三一东丈业丈世世丛.enabled == false)
        {
            goto label_50;
        }
        
        val_46 = this.check;
        goto label_96;
        label_48:
        if((((System.String.IsNullOrEmpty(value:  this.pixelbookID)) == true) || ((this.pixelbookID.Equals(value:  "0")) == true)) || ((this.pixelbookID.Equals(value:  "-1")) == true))
        {
            goto label_63;
        }
        
        val_47 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((((this.pixelbookID.Equals(value:  val_47)) == true) || (丐丞丞丏丞业丄一丈.七万专丕丝丅丟丐丗() == false)) || ((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true))
        {
            goto label_63;
        }
        
        val_47 = 1152921505641934848;
        if(PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛() == false)
        {
            goto label_63;
        }
        
        if(this.三一东丈业丈世世丛.enabled != false)
        {
                this.三一东丈业丈世世丛.enabled = false;
            this.三一东丈业丈世世丛.SetActive(value:  false);
        }
        
        if(this.check == 0)
        {
                return;
        }
        
        if(this.check.activeSelf == true)
        {
                return;
        }
        
        val_49 = null;
        val_50 = this.check;
        goto label_106;
        label_63:
        if(this.三一东丈业丈世世丛.enabled != false)
        {
                this.三一东丈业丈世世丛.enabled = false;
        }
        
        if(this.三一东丈业丈世世丛.activeSelf != false)
        {
                this.三一东丈业丈世世丛.SetActive(value:  false);
        }
        
        if(this.check == 0)
        {
                return;
        }
        
        if(this.check.activeSelf == false)
        {
                return;
        }
        
        val_46 = this.check;
        label_108:
        val_46.SetActive(value:  false);
        return;
        label_50:
        this.三一东丈业丈世世丛.enabled = true;
        this.三一东丈业丈世世丛.SetActive(value:  true);
        if(this.check != 0)
        {
                val_47 = PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛();
            null.SetActive(value:  val_47);
        }
        
        label_96:
        if(null == 0)
        {
                return;
        }
        
        if(null.activeSelf != false)
        {
                return;
        }
        
        val_49 = null;
        val_50 = null;
        label_106:
        bool val_43 = PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛();
        goto label_108;
        label_38:
        if(this.一七不三丌专三丆一 != false)
        {
                val_51 = System.String.Format(format:  "bt_{0}", arg0:  UnityEngine.Random.Range(min:  9999, max:  0));
        }
        else
        {
                val_51 = this.pixelbookID;
        }
        
        this.丘丅与丙丕丄七下七(丄丒且丙三丆丟与丏:  val_51);
        goto label_111;
    }
    private void 丘丅与丙丕丄七下七(string 丄丒且丙三丆丟与丏)
    {
        var val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛());
        if(this.likeButton.gameObject.activeSelf == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        this.likeButton.丈且东丑丂且万丒丅(丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏, 丞丞下东且丗丄丒丏:  this.nickPlayer, 丐丑丘与丘丈丟丒且:  PlayerLikeController.丄丘七三上丕世丞业.一且丈丅丏丏丟丌世(丞丅上丏丂且下丅与:  丄丒且丙三丆丟与丏), 一七不三丌专三丆一:  (this.一七不三丌专三丆一 == true) ? 1 : 0);
    }
    public void SetPlace(int 且丒丛与丞世丙丕丌)
    {
        this.placeLabel.text = 且丒丛与丞世丙丕丌.ToString();
        this.oddPanel.SetActive(value:  ((且丒丛与丞世丙丕丌 & 1) != 0) ? 1 : 0);
    }
    public void ShowPlaceAndPlus(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.placeLabel, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.plusButton, 丏业丟一东丂东丘丛:  val_1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.check, 丏业丟一东丂东丘丛:  val_1);
    }
    public void UpdateState(bool 东丅丞丁丗万且丁丗, bool 东三丄丒丌丏下下丗 = False, bool 丐丛丂丈七且世业业 = False, int 下丄丁丑三丏丗丛七 = 0, string 不丆业丏上丐与丌业 = "", string 万且丒下丕丝专丟上 = "", string 丂丌丙丝且东丗丙万 = "", string 丈一七上丛丗丄丘丞 = "", int 专世专丟丝丌与丘上 = 1, UnityEngine.Texture 丅丈丛丅丝东七丂且, string 丛丄世丐丐丗且丈与 = "", bool 丒东三丌专丗三丂丟 = False, UnityEngine.Texture 丒丁丑丂丄丛丌上专, bool 丏七丟丛与丞丐丄上 = False, bool 不丄丐上业丕且丝丝 = False, bool 丗丞丕不丌丑三三业 = False, 七丈丆丝三丌七专丙 丐丑丘与丘丈丟丒且 = 0, bool 专丛下不丄且丌丛丕 = False, bool 丏丝丁七丂且丕丑丕 = False)
    {
        string val_103;
        bool val_104;
        UnityEngine.Material val_105;
        bool val_106;
        UILabel val_107;
        var val_108;
        UnityEngine.Vector3 val_109;
        float val_110;
        float val_114;
        float val_115;
        float val_116;
        var val_120;
        float val_124;
        float val_125;
        float val_126;
        var val_127;
        UnityEngine.Vector3 val_128;
        var val_131;
        val_103 = 不丆业丏上丐与丌业;
        val_104 = 东三丄丒丌丏下下丗;
        val_105 = this;
        this.pixelbookID = 丛丄世丐丐丗且丈与;
        this.nickPlayer = val_103;
        this.isMine = val_104;
        this.一七不三丌专三丆一 = 丐丛丂丈七且世业业;
        val_106 = 1152921505246941184;
        七丈丆丝三丌七专丙 val_3 = PlayerLikeController.丄丘七三上丕世丞业.一且丈丅丏丏丟丌世(丞丅上丏丂且下丅与:  this.pixelbookID);
        val_107 = this.rankLabel;
        if(val_107 != 0)
        {
                val_107 = this.rankLabel.gameObject;
            if(GameController.onlineMode.丗三不丞丈业丑丘万 != false)
        {
                val_106 = 0;
        }
        else
        {
                val_106 = BalanceController.丄专丕世与世丙丏丛;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_107, 丏业丟一东丂东丘丛:  (val_106 == true) ? 1 : 0);
        }
        
        if(this.initialized == false)
        {
            goto label_17;
        }
        
        if(东丅丞丁丗万且丁丗 == false)
        {
            goto label_18;
        }
        
        label_38:
        UnityEngine.Color val_7 = UnityEngine.Color.white;
        if(this.isMine == false)
        {
            goto label_19;
        }
        
        if(this.isMineSprite != 0)
        {
                this.isMineSprite.SetActive(value:  true);
        }
        
        if(this.isTeammateSprite != 0)
        {
                this.isTeammateSprite.SetActive(value:  false);
        }
        
        if(this.三一东丈业丈世世丛.enabled == false)
        {
            goto label_29;
        }
        
        this.三一东丈业丈世世丛.enabled = false;
        this.三一东丈业丈世世丛.SetActive(value:  false);
        if(this.check == 0)
        {
            goto label_37;
        }
        
        this.check.SetActive(value:  false);
        goto label_37;
        label_17:
        this.上丛丌丆丑上七世三();
        if(东丅丞丁丗万且丁丗 == true)
        {
            goto label_38;
        }
        
        label_18:
        val_105 = this.gameObject;
        val_105.SetActive(value:  false);
        return;
        label_19:
        if(this.isMineSprite != 0)
        {
                this.isMineSprite.SetActive(value:  false);
        }
        
        if(this.isTeammateSprite == 0)
        {
            goto label_47;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_50;
        }
        
        val_108 = 1;
        if(this.isTeammateSprite != null)
        {
            goto label_147;
        }
        
        goto label_52;
        label_29:
        label_37:
        if(mem[this.check] != 0)
        {
                if(mem[this.check].activeSelf != false)
        {
                mem[this.check].SetActive(value:  false);
        }
        
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
            
        }
        else
        {
                bool val_20 = GameConnect.一业上七丟业且业丙();
        }
        
        val_20 = val_20 & 丒东三丌专丗三丂丟;
        if(val_20 == true)
        {
            goto label_69;
        }
        
        if(GameConnect.东丒七专丂世丝丏丗() != false)
        {
                if(丒东三丌专丗三丂丟 == true)
        {
            goto label_69;
        }
        
        }
        
        if((GameConnect.丙丌丒丈东七丒上丌() == false) || (专丛下不丄且丌丛丕 == false))
        {
            goto label_182;
        }
        
        label_69:
        label_181:
        label_182:
        label_180:
        label_168:
        if(this.playerDisconnected != 0)
        {
                this.playerDisconnected.SetActive(value:  丒东三丌专丗三丂丟);
        }
        
        this.gameObject.SetActive(value:  true);
        this.namesPlayers.text = val_103;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.zero;
        val_114 = this.defaultNameLabelPos;
        val_115 = V8.16B;
        val_116 = V9.16B;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_114, y = val_115, z = val_116}, rhs:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z})) != false)
        {
                UnityEngine.Vector3 val_29 = this.namesPlayers.transform.localPosition;
            this.defaultNameLabelPos = val_29;
            mem[1152921524285334700] = val_29.y;
            mem[1152921524285334704] = val_29.z;
        }
        
        if(this.不丄丛万丒丐丅上丙 == 0)
        {
                this.不丄丛万丒丐丅上丙 = this.namesPlayers.width;
        }
        
        if(((((((NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.三与万丝丒一丏丝七 != false) && (GameConnect.丑丌丛丈丅丅与不业() != 20)) && ((GameConnect.丒丂东丏丁万丄下专(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != true)) && (GameConnect.丑丌丛丈丅丅与不业() != 19)) && (GameConnect.东且三丆丑世世丘丟() != true)) && ((System.String.op_Inequality(a:  this.pixelbookID, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)) && (this.likeButton != 0))
        {
                if((this.nickPlayer.Contains(value:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1224"))) != true)
        {
                if((System.String.IsNullOrEmpty(value:  this.pixelbookID)) == false)
        {
            goto label_109;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  false);
        label_254:
        val_104 = 1152921505066536960;
        val_103 = 丅丈丛丅丝东七丂且;
        if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(this.clanTexture != 0)
        {
                bool val_44 = UnityEngine.Object.op_Equality(x:  val_103, y:  0);
        }
        
            val_109 = this.defaultNameLabelPos;
            val_114 = val_109;
            val_115 = V9.16B;
            val_116 = this.defaultNameLabelPos;
            this.namesPlayers.transform.localPosition = new UnityEngine.Vector3() {x = val_114, y = val_115, z = val_116};
        }
        
        if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_129;
        }
        
        var val_47 = (this.七丙丘万专丟世与专 == true) ? 1 : 0;
        val_47 = val_47 ^ 不丄丐上业丕且丝丝;
        if(val_47 == false)
        {
            goto label_129;
        }
        
        this.七丙丘万专丟世与专 = 不丄丐上业丕且丝丝;
        this.revengeCheckmark.gameObject.SetActive(value:  不丄丐上业丕且丝丝);
        if(下丄丁丑三丏丗丛七 == 2)
        {
            goto label_128;
        }
        
        if(下丄丁丑三丏丗丛七 != 1)
        {
            goto label_129;
        }
        
        UnityEngine.Vector3 val_51 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.丕丙丘丝丅且七万丆, y = val_109, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z})) != false)
        {
                UnityEngine.Vector3 val_54 = this.scorePlayers.transform.localPosition;
            this.丕丙丘丝丅且七万丆 = val_54;
            mem[1152921524285334760] = val_54.y;
            mem[1152921524285334764] = val_54.z;
        }
        
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.万上丏丂丕丞不丂下, y = val_109, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z})) != false)
        {
                UnityEngine.Vector3 val_58 = this.countKillsPlayers.transform.localPosition;
            this.万上丏丂丕丞不丂下 = val_58;
            mem[1152921524285334772] = val_58.y;
            mem[1152921524285334776] = val_58.z;
        }
        
        if(不丄丐上业丕且丝丝 == false)
        {
            goto label_141;
        }
        
        UnityEngine.Vector3 val_60 = UnityEngine.Vector3.zero;
        goto label_144;
        label_50:
        val_108 = GameConnect.丝丆世丕丂丄万东且();
        if(this.isTeammateSprite != null)
        {
            goto label_147;
        }
        
        label_52:
        label_147:
        this.isTeammateSprite.SetActive(value:  val_108 & 丗丞丕不丌丑三三业);
        label_47:
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_150;
        }
        
        if(下丄丁丑三丏丗丛七 == 1)
        {
            goto label_180;
        }
        
        if(下丄丁丑三丏丗丛七 != 0)
        {
            goto label_181;
        }
        
        goto label_180;
        label_150:
        if(丒东三丌专丗三丂丟 == false)
        {
            goto label_154;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_160;
        }
        
        }
        
        label_253:
        label_154:
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_120 = 1;
        }
        else
        {
                val_120 = GameConnect.丝丆世丕丂丄万东且();
        }
        
        val_120 = val_120 & 丗丞丕不丌丑三三业;
        if(val_120 == false)
        {
            goto label_168;
        }
        
        goto label_180;
        label_128:
        UnityEngine.Vector3 val_68 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.东下丘丝丝业丕丞丙, y = val_109, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z})) != false)
        {
                UnityEngine.Vector3 val_71 = this.rankLabel.transform.localPosition;
            this.东下丘丝丝业丕丞丙 = val_71;
            mem[1152921524285334748] = val_71.y;
            mem[1152921524285334752] = val_71.z;
        }
        
        if(不丄丐上业丕且丝丝 == false)
        {
            goto label_176;
        }
        
        UnityEngine.Vector3 val_73 = UnityEngine.Vector3.zero;
        goto label_179;
        label_141:
        UnityEngine.Vector3 val_74 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_75 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z}, d:  50f);
        label_144:
        UnityEngine.Vector3 val_76 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丕丙丘丝丅且七万丆, y = V9.16B, z = val_109}, b:  new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z});
        val_124 = val_76.x;
        val_125 = val_76.y;
        val_126 = val_76.z;
        this.scorePlayers.transform.localPosition = new UnityEngine.Vector3() {x = val_124, y = val_125, z = val_126};
        val_127 = null;
        val_128 = this.万上丏丂丕丞不丂下;
        val_131 = this.countKillsPlayers.transform;
        if(不丄丐上业丕且丝丝 == true)
        {
            goto label_189;
        }
        
        UnityEngine.Vector3 val_78 = UnityEngine.Vector3.right;
        goto label_192;
        label_176:
        UnityEngine.Vector3 val_79 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_80 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z}, d:  50f);
        label_179:
        UnityEngine.Vector3 val_81 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.东下丘丝丝业丕丞丙, y = V9.16B, z = val_109}, b:  new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z});
        val_124 = val_81.x;
        val_125 = val_81.y;
        val_126 = val_81.z;
        this.rankLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_124, y = val_125, z = val_126};
        val_127 = null;
        val_128 = this.defaultNameLabelPos;
        val_131 = this.namesPlayers.transform;
        if(不丄丐上业丕且丝丝 == false)
        {
            goto label_199;
        }
        
        label_189:
        UnityEngine.Vector3 val_83 = UnityEngine.Vector3.zero;
        goto label_202;
        label_199:
        UnityEngine.Vector3 val_84 = UnityEngine.Vector3.left;
        label_192:
        UnityEngine.Vector3 val_85 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_84.x, y = val_84.y, z = val_84.z}, d:  50f);
        label_202:
        UnityEngine.Vector3 val_86 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_128, y = val_81.y, z = val_81.x}, b:  new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z});
        val_110 = val_86.y;
        val_131.localPosition = new UnityEngine.Vector3() {x = val_86.x, y = val_110, z = val_86.z};
        label_129:
        if(this.revengeCheckmark != 0)
        {
                this.revengeCheckmark.enabled = 丏七丟丛与丞丐丄上;
        }
        
        this.namesPlayers.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        val_107 = 丏丝丁七丂且丕丑丕;
        if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_218;
        }
        
        }
        
        this.distanceScore.text = (GameConnect.且丘丄丛下丆丟万丕() != true) ? "" : 万且丒下丕丝专丟上;
        this.distanceScore.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        this.timeScore.text = 丂丌丙丝且东丗丙万;
        label_248:
        this.timeScore.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        label_246:
        this.丏且丟三下丒三下丂(丏丝丁七丂且丕丑丕:  val_107, 下丄丁丑三丏丗丛七:  下丄丁丑三丏丗丛七);
        int val_101 = 专世专丟丝丌与丘上;
        val_101 = val_101 >> 31;
        this.丕丝世丕丛一丏世丝 = val_101;
        this.rankLabel.text = 专世专丟丝丌与丘上.ToString();
        if(专世专丟丝丌与丘上 == 1)
        {
                this.rankLabel.gameObject.SetActive(value:  false);
        }
        
        val_106 = this.clanTexture;
        if(val_106 != 0)
        {
                val_106 = this.clanTexture;
        }
        
        if(丒丁丑丂丄丛丌上专 == 0)
        {
                return;
        }
        
        val_106 = this.playerPreviewRenderer;
        if(val_106 == 0)
        {
                return;
        }
        
        val_105 = this.playerPreviewMaterial;
        val_105.mainTexture = 丒丁丑丂丄丛丌上专;
        return;
        label_218:
        this.scorePlayers.text = 万且丒下丕丝专丟上;
        this.scorePlayers.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        this.countKillsPlayers.text = 丂丌丙丝且东丗丙万;
        this.countKillsPlayers.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        if(this.countDeathPlayers == 0)
        {
            goto label_246;
        }
        
        this.countDeathPlayers.text = 丈一七上丛丗丄丘丞;
        goto label_248;
        label_160:
        if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_253;
        }
        
        goto label_253;
        label_109:
        this.丘丅与丙丕丄七下七(丄丒且丙三丆丟与丏:  this.pixelbookID);
        goto label_254;
    }
    private void 丏且丟三下丒三下丂(bool 丏丝丁七丂且丕丑丕, int 下丄丁丑三丏丗丛七)
    {
        int val_10 = 下丄丁丑三丏丗丛七;
        if(this.subscriptionBackground == 0)
        {
                return;
        }
        
        if(this.subscriptionLeftSide == 0)
        {
                return;
        }
        
        if(this.subscriptionRightSide == 0)
        {
                return;
        }
        
        this.subscriptionBackground.SetActive(value:  丏丝丁七丂且丕丑丕);
        bool val_5 = GameConnect.丆丁上丟丛业丄丅丝();
        bool val_8 = val_5 ^ 1;
        val_10 = val_5 & ((val_10 > 1) ? 1 : 0);
        val_8 = ((val_10 < 2) ? 1 : 0) | val_8;
        this.subscriptionRightSide.SetActive(value:  val_10);
        this.subscriptionLeftSide.SetActive(value:  val_8);
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.likeButton, 丏业丟一东丂东丘丛:  false);
    }
    internal void OnClick()
    {
        var val_14;
        var val_15;
        if(PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛() == false)
        {
                return;
        }
        
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
        {
                return;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 == true)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(ExperienceController.sharedController.丁与丌东丄丙下下万 == true)
        {
                return;
        }
        
        if(this.isMine == true)
        {
                return;
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        if(this.丕丝世丕丛一丏世丝 == true)
        {
                return;
        }
        
        if(this.networkStartTableNGUIController == 0)
        {
                return;
        }
        
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.networkStartTableNGUIController.丆丗丌世且丛丐丒丗(丛丄世丐丐丗且丈与:  this.pixelbookID, 丆丆丂业丒丈丙丒丅:  this.nickPlayer, 下上丐东丛丗丐且丑:  (this.一七不三丌专三丆一 == true) ? 1 : 0);
    }
    public ActionInTableButton()
    {
        this.七丙丘万专丟世与专 = true;
    }

}
