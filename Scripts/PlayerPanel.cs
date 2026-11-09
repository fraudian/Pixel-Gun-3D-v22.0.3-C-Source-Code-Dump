using UnityEngine;
public sealed class PlayerPanel : MonoBehaviour
{
    // Fields
    internal static PlayerPanel 丄丘七三上丕世丞业;
    private UILabel raitingLabel;
    private string 丗东东丗丒丂丆丕丞;
    public UILabel experienceLabel;
    public UILabel likesLabel;
    public UISprite currentExp;
    public UISprite oldExp;
    public UILabel rankLabel;
    public UnityEngine.GameObject trophys;
    public UnityEngine.GameObject like;
    private int 丞丒丑丛专业丌七丐;
    private int 丒丆不丏丑丞丛东丐;
    private UILabel playerName;
    private UITexture clanIcon;
    private UILabel clanName;
    private UnityEngine.Vector3 丑丟丛七世专业一丛;
    private string 业丛丛丌万丂下丞丏;
    private int 不丗下丑丈丁丏丂丘;
    private UnityEngine.WaitForSeconds 且与丗丕丐丁丑专丟;
    
    // Properties
    public string 东万丄三一下丆丑丟 { get; set; }
    public float 丛丅七丂丕一丆丈万 { get; set; }
    public float 丝东丗专丈丟丒不专 { get; set; }
    public int 丁专七丛丈不万丏七 { get; set; }
    
    // Methods
    public string get_ExperienceLabel()
    {
        if(this.experienceLabel == 0)
        {
                return (string)System.String.alignConst;
        }
        
        if(this.experienceLabel != null)
        {
                return this.experienceLabel.text;
        }
        
        return this.experienceLabel.text;
    }
    public void set_ExperienceLabel(string 丙业与丙丗丝不丈东)
    {
        if(this.experienceLabel == 0)
        {
                return;
        }
        
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_4;
        }
        
        label_7:
        this.experienceLabel.text = 丙业与丙丗丝不丈东;
        return;
        label_4:
        if(this.experienceLabel != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    public float get_CurrentProgress()
    {
        if(this.currentExp == 0)
        {
                return (float)val_3.x;
        }
        
        this = this.currentExp.transform;
        UnityEngine.Vector3 val_3 = this.localScale;
        return (float)val_3.x;
    }
    public void set_CurrentProgress(float 丙业与丙丗丝不丈东)
    {
        if(this.currentExp == 0)
        {
                return;
        }
        
        this = this.currentExp.transform;
        float val_3 = UnityEngine.Mathf.Clamp(value:  丙业与丙丗丝不丈东, min:  0f, max:  1f);
        this.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public float get_OldProgress()
    {
        if(this.oldExp == 0)
        {
                return (float)val_3.x;
        }
        
        this = this.oldExp.transform;
        UnityEngine.Vector3 val_3 = this.localScale;
        return (float)val_3.x;
    }
    public void set_OldProgress(float 丙业与丙丗丝不丈东)
    {
        float val_8;
        var val_9;
        val_8 = 丙业与丙丗丝不丈东;
        val_9 = this;
        if(this.oldExp == 0)
        {
                return;
        }
        
        val_8 = UnityEngine.Mathf.Clamp(value:  val_8, min:  0f, max:  1f);
        UnityEngine.Vector3 val_5 = this.transform.localScale;
        val_9 = this.transform;
        UnityEngine.Vector3 val_7 = val_9.localScale;
        this.oldExp.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public int get_RankSprite()
    {
        return (int)this.丒丆不丏丑丞丛东丐;
    }
    public void set_RankSprite(int 丙业与丙丗丝不丈东)
    {
        if(this.rankLabel == 0)
        {
                return;
        }
        
        this.rankLabel.text = 丙业与丙丗丝不丈东.ToString();
        this.丒丆不丏丑丞丛东丐 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        var val_5;
        this.且与丗丕丐丁丑专丟 = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        val_5 = null;
        val_5 = null;
        PlayerPanel.丄丘七三上丕世丞业 = this;
        RatingSystem.丘世一丂丝世丏丆一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlayerPanel::世丕丆丒丕丝下业丘()));
        UnityEngine.Vector3 val_4 = this.playerName.transform.localPosition;
        this.丑丟丛七世专业一丛 = val_4;
        mem[1152921535930435108] = val_4.y;
        mem[1152921535930435112] = val_4.z;
    }
    private void OnEnable()
    {
        null = null;
        PlayerPanel.丄丘七三上丕世丞业 = this;
        this.丒丐丟不上业丏一一(丘上丅丝丄三一丕丁:  true);
        this.UpdateClanInfo();
        this.UpdateNickPlayer();
        this.UpdateRating();
        this.UpdateExp();
    }
    public void UpdateClanInfo()
    {
        var val_27;
        if(((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
        {
            goto label_5;
        }
        
        if((System.String.op_Inequality(a:  this.业丛丛丌万丂下丞丏, b:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丙上东业丆不丟丘())) == false)
        {
            goto label_8;
        }
        
        string val_11 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丙上东业丆不丟丘();
        this.业丛丛丌万丂下丞丏 = val_11;
        this.clanName.text = val_11;
        goto label_12;
        label_18:
        if(val_11 != null)
        {
                val_27 = val_11.Length;
        }
        else
        {
                val_27 = 0.Length;
        }
        
        this.clanName.text = val_11.Remove(startIndex:  val_27 + 0);
        this.clanName.ProcessText();
        label_12:
        if(this.clanName.width > 168)
        {
            goto label_18;
        }
        
        label_8:
        UnityEngine.Texture2D val_19 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌();
        this.playerName.transform.localPosition = new UnityEngine.Vector3() {x = this.丑丟丛七世专业一丛, y = V9.16B, z = V10.16B};
        if(this.clanName.enabled != true)
        {
                this.clanName.enabled = true;
        }
        
        if(this.clanIcon.enabled == false)
        {
            goto label_28;
        }
        
        return;
        label_5:
        this.clanName.enabled = false;
        this.clanIcon.enabled = false;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  -16f);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丑丟丛七世专业一丛, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        this.playerName.transform.localPosition = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        return;
        label_28:
        this.clanIcon.enabled = true;
    }
    public void UpdateRating()
    {
        string val_3 = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅().ToString();
        this.丗东东丗丒丂丆丕丞 = val_3;
        this.raitingLabel.text = val_3;
    }
    public void UpdateNickPlayer()
    {
        this.playerName.text = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  ProfileController.丆三丂丂丆上丆丕专());
    }
    public void UpdateExp()
    {
        int val_1 = ExperienceController.丞丞丘业东丙丏七丌();
        this.丞丒丑丛专业丌七丐 = ExperienceController.万丏丙丈东东万丝丞();
        System.Int32[] val_3 = ExperienceController.丐丏三三丅丏丅丑丛 + (((long)(int)(val_1)) << 2);
        this.RankSprite = val_1;
        if(val_1 == 65)
        {
                this.ExperienceLabel = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0928");
            this.CurrentProgress = 1f;
            return;
        }
        
        float val_8 = (float)this.丞丒丑丛专业丌七丐;
        val_8 = val_8 / ((float)(ExperienceController.丐丏三三丅丏丅丑丛 + ((long)(int)(val_1)) << 2) + 32);
        this.OldProgress = val_8;
        float val_9 = (float)this.丞丒丑丛专业丌七丐;
        val_9 = val_9 / ((float)(ExperienceController.丐丏三三丅丏丅丑丛 + ((long)(int)(val_1)) << 2) + 32);
        this.CurrentProgress = val_9;
        this.ExperienceLabel = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丞丒丑丛专业丌七丐)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丞丒丑丛专业丌七丐)) + "/"("/") + AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  (ExperienceController.丐丏三三丅丏丅丑丛 + ((long)(int)(val_1)) << 2) + 32)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  (ExperienceController.丐丏三三丅丏丅丑丛 + ((long)(int)(val_1)) << 2) + 32));
    }
    private void OnDisable()
    {
        this.oldExp.enabled = true;
        UnityEngine.Vector3 val_3 = this.currentExp.transform.localScale;
        this.oldExp.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.StopAllCoroutines();
    }
    private void Update()
    {
        if(this.丞丒丑丛专业丌七丐 == ExperienceController.万丏丙丈东东万丝丞())
        {
                if(this.丒丆不丏丑丞丛东丐 == ExperienceController.丞丞丘业东丙丏七丌())
        {
            goto label_6;
        }
        
        }
        
        this.丈丅丏业丒一丛不丁();
        label_6:
        this.UpdateClanInfo();
        this.丒丐丟不上业丏一一(丘上丅丝丄三一丕丁:  false);
        if(this.likesLabel.gameObject.activeSelf == false)
        {
                return;
        }
        
        int val_6 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丝丂丑丄丑丟丆专();
        if(val_6 == this.不丗下丑丈丁丏丂丘)
        {
                return;
        }
        
        this.不丗下丑丈丁丏丂丘 = val_6;
        this = val_6.ToString();
        this.likesLabel.text = this;
    }
    private void 丒丐丟不上业丏一一(bool 丘上丅丝丄三一丕丁 = False)
    {
        var val_10;
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_10 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂();
        }
        else
        {
                val_10 = 0;
        }
        
        bool val_4 = this.trophys.activeSelf;
        val_4 = val_10 ^ val_4;
        val_4 = val_4 ^ 1;
        val_4 = val_4 | 丘上丅丝丄三一丕丁;
        if(val_4 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.trophys, 丏业丟一东丂东丘丛:  (val_10 == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.raitingLabel.gameObject, 丏业丟一东丂东丘丛:  (val_10 == 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.likesLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.like, 丏业丟一东丂东丘丛:  false);
    }
    private void 丈丅丏业丒一丛不丁()
    {
        float val_18;
        int val_1 = ExperienceController.丞丞丘业东丙丏七丌();
        this.丞丒丑丛专业丌七丐 = ExperienceController.万丏丙丈东东万丝丞();
        System.Int32[] val_3 = ExperienceController.丐丏三三丅丏丅丑丛 + (((long)(int)(val_1)) << 2);
        this.RankSprite = val_1;
        if(val_1 == 65)
        {
                this.ExperienceLabel = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0928");
            this.CurrentProgress = 1f;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            this.oldExp.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            return;
        }
        
        float val_18 = (float)this.丞丒丑丛专业丌七丐;
        val_18 = val_18 / ((float)(ExperienceController.丐丏三三丅丏丅丑丛 + ((long)(int)(val_1)) << 2) + 32);
        this.CurrentProgress = val_18;
        this.ExperienceLabel = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丞丒丑丛专业丌七丐)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丞丒丑丛专业丌七丐)) + "/"("/") + AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  (ExperienceController.丐丏三三丅丏丅丑丛 + ((long)(int)(val_1)) << 2) + 32)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  (ExperienceController.丐丏三三丅丏丅丑丛 + ((long)(int)(val_1)) << 2) + 32));
        UnityEngine.Vector3 val_11 = this.oldExp.transform.localScale;
        val_18 = val_11.x;
        UnityEngine.Vector3 val_13 = this.currentExp.transform.localScale;
        if(val_18 > val_13.x)
        {
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            val_18 = val_15.x;
            this.oldExp.transform.localScale = new UnityEngine.Vector3() {x = val_18, y = val_15.y, z = val_15.z};
        }
        
        UnityEngine.Coroutine val_17 = this.StartCoroutine(routine:  this.且丆丑丟丄丐丈丐七());
    }
    private System.Collections.IEnumerator 且丆丑丟丄丐丈丐七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerPanel.专下上三丐丁丛业丟();
    }
    public void HandleOpenProfile()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_6 = null;
            val_6 = null;
            MainMenuController.丄丞丁丈与业上丞丟.万丅与丞东丅丆专丕();
        }
        
        if(ProfileController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ProfileController.丑七不且上丗丁一世().SetStaticticTab(丈丒丅上丗丅丙下丞:  2);
    }
    private void 世丕丆丒丕丝下业丘()
    {
        this.UpdateRating();
    }
    private void OnDestroy()
    {
        null = null;
        PlayerPanel.丄丘七三上丕世丞业 = 0;
        RatingSystem.不上丗东丞不丌丐世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlayerPanel::世丕丆丒丕丝下业丘()));
    }
    public PlayerPanel()
    {
        this.丒丆不丏丑丞丛东丐 = 1;
        this.不丗下丑丈丁丏丂丘 = 0;
        this.业丛丛丌万丂下丞丏 = "-:";
    }
    private static PlayerPanel()
    {
    
    }

}
