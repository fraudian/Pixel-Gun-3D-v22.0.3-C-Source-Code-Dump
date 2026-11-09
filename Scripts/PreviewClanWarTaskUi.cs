using UnityEngine;
internal sealed class PreviewClanWarTaskUi : PGBehaviour
{
    // Fields
    private UnityEngine.Transform mainWindow;
    private Rilisoft.ButtonHandler goToBattleButton;
    private UILabel taskIdLabel;
    private UILabel mapNameLabel;
    private UILabel mapModeLabel;
    private UILabel incomeLabel;
    private UILabel taskDescriptionLabel;
    private UILabel flagsCounterLabel;
    private UILabel silverCounterLabel;
    private UILabel contributionLabel;
    private UILabel progressLabel;
    private UIBasicSprite mapTexture;
    private bool showPlayerBar;
    private UIBasicSprite progressBar;
    private UIBasicSprite progressBarPlayer;
    private UnityEngine.Texture2D alphaTexture2D;
    private static string 丅丁丗七丁丗丌东七;
    private UnityEngine.Coroutine 丏丄丏且丞与世丘下;
    private PGCompany.世丐下丕专东丘丏且 东万与且丌丝丞专丏;
    private SceneInfo 丄不东丁丂丅万丒丟;
    private System.Action 丕不且丕东丅不丂丆;
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    private void OnEnable()
    {
        System.Action val_8;
        var val_9;
        var val_10;
        val_8 = 1152921505052479488;
        val_9 = static_value_081DACA8;
        val_9 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return;
        }
        
        val_10 = static_value_081DACA8;
        val_10 = static_value_081DACA8;
        System.Action val_3 = null;
        val_8 = val_3;
        val_3 = new System.Action(object:  static_value_081DACA8 + 184 + 16, method:  System.Void ConnectScene::丑丌丙丙丞丗丙七丂());
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_3, 与且专丈不万东一万:  System.String.Format(format:  "PreviewClanWarTask_{0}", arg0:  this.gameObject.name));
    }
    private void OnDisable()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    internal void 下丗丒丆丗丗丆东丈(System.Action 一丈下丕丗不丂丒世, PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘, System.Action<PGCompany.丁下丒丕丆下丂丆丌> 东丅丛丐丁与丑丟丘)
    {
        var val_14;
        var val_15;
        string val_16;
        var val_17;
        PreviewClanWarTaskUi.丛东丟丅丙丗世丗不 val_1 = new PreviewClanWarTaskUi.丛东丟丅丙丗世丗不();
        if(val_1 != null)
        {
                val_14 = val_1;
            .东丅丛丐丁与丑丟丘 = 东丅丛丐丁与丑丟丘;
        }
        else
        {
                val_14 = 16;
            mem[16] = 东丅丛丐丁与丑丟丘;
        }
        
        .丌丝万上丅丒一丈丘 = 丌丝万上丅丒一丈丘;
        this.goToBattleButton.ClearEvents();
        this.东万与且丌丝丞专丏 = 万不且且丛丆东丒业;
        this.丕不且丕东丅不丂丆 = 一丈下丕丗不丂丒世;
        if((this.goToBattleButton != 0) && (val_14 != 0))
        {
                this.goToBattleButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void PreviewClanWarTaskUi.丛东丟丅丙丗世丗不::丒丏丅一丆不上不世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        val_15 = null;
        val_15 = null;
        PGCompany.GameTaskActionSettings val_5 = this.东万与且丌丝丞专丏.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_16 = val_5.Map;
        SceneInfo val_6 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_16);
        this.丄不东丁丂丅万丒丟 = val_6;
        if(val_6 != 0)
        {
                if(this.mapTexture != 0)
        {
                val_17 = static_value_081DACA8;
            val_17 = static_value_081DACA8;
            UnityEngine.Texture val_10 = static_value_081DACA8 + 184 + 16.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  this.丄不东丁丂丅万丒丟.丙且上丒不下丑下丞());
            val_16 = this.alphaTexture2D;
        }
        
        }
        
        UnityEngine.Color val_11 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  1);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.progressBar, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
        UnityEngine.Color val_12 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  2);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.progressBarPlayer, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
        UnityEngine.Color val_13 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  2);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.contributionLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a});
        this.丝上丗不丒且世丌丑();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        this.丏丈丞丐业专不世丝();
    }
    private void 丏丈丞丐业专不世丝()
    {
        this.丏东丄丞丛七世业丟();
        this.丏丄丏且丞与世丘下 = CoroutineRunner.Instance.StartCoroutine(routine:  this.且一丏丏专不丙东丁());
    }
    private void 丏东丄丞丛七世业丟()
    {
        if(this.丏丄丏且丞与世丘下 == null)
        {
                return;
        }
        
        CoroutineRunner.Instance.StopCoroutine(routine:  this.丏丄丏且丞与世丘下);
    }
    private System.Collections.IEnumerator 且一丏丏专不丙东丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PreviewClanWarTaskUi.丒丟丌一东一丝下上();
    }
    internal void 丝上丗不丒且世丌丑()
    {
        UILabel val_43;
        var val_44;
        var val_46;
        string val_48;
        var val_49;
        string val_51;
        var val_53;
        val_43 = this;
        if(this.东万与且丌丝丞专丏 == null)
        {
                return;
        }
        
        val_44 = 0;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.mapNameLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丄不东丁丂丅万丒丟.七丛一丛专七丈丅专()));
        PGCompany.GameTaskActionSettings val_5 = this.东万与且丌丝丞专丏.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        var val_44 = 0;
        val_44 = val_44 + 1;
        val_44 = 0;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.mapModeLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[null]));
        PGCompany.丟丒丅丐万丈七且万 val_9 = this.东万与且丌丝丞专丏.世丈丁业丛上丘丗丐();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskIdLabel, 丕丗丘丑丛与丑业丒:  val_9.三丘丛三丂丙七东一);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskDescriptionLabel, 丕丗丘丑丛与丑业丒:  this.东万与且丌丝丞专丏);
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_11 = this.东万与且丌丝丞专丏.世丈丁业丛上丘丗丐().丁丘丞丛丂丑丕专不();
        val_46 = null;
        val_46 = null;
        if((PreviewClanWarTaskUi.<>c.<>9__28_0) == null)
        {
            goto label_25;
        }
        
        label_32:
        PGCompany.三东丏不丗世丅丌丄 val_13 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_11.FindAll(match:  PreviewClanWarTaskUi.<>c.<>9__28_0));
        if(val_13 == null)
        {
            goto label_27;
        }
        
        val_48 = val_13.丂丁丏一丙丛业且丌().ToString();
        goto label_28;
        label_25:
        PreviewClanWarTaskUi.<>c.<>9__28_0 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  PreviewClanWarTaskUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PreviewClanWarTaskUi.<>c::东丁丏丆丟丂专丗上(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
        if(val_11 != null)
        {
            goto label_32;
        }
        
        goto label_32;
        label_27:
        val_48 = 0;
        label_28:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.flagsCounterLabel, 丕丗丘丑丛与丑业丒:  val_48);
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_18 = this.东万与且丌丝丞专丏.世丈丁业丛上丘丗丐().丁丘丞丛丂丑丕专不();
        val_49 = null;
        val_49 = null;
        if((PreviewClanWarTaskUi.<>c.<>9__28_1) == null)
        {
            goto label_39;
        }
        
        label_46:
        PGCompany.三东丏不丗世丅丌丄 val_20 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_18.FindAll(match:  PreviewClanWarTaskUi.<>c.<>9__28_1));
        if(val_20 == null)
        {
            goto label_41;
        }
        
        val_51 = val_20.丂丁丏一丙丛业且丌().ToString();
        goto label_42;
        label_39:
        PreviewClanWarTaskUi.<>c.<>9__28_1 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  PreviewClanWarTaskUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PreviewClanWarTaskUi.<>c::丄丅东万丛丂丞一世(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
        if(val_18 != null)
        {
            goto label_46;
        }
        
        goto label_46;
        label_41:
        val_51 = 0;
        label_42:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.silverCounterLabel, 丕丗丘丑丛与丑业丒:  val_51);
        PGCompany.丁下丒丕丆下丂丆丌 val_25 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丈下丗丐丝丅丑丑(万不且且丛丆东丒业:  this.东万与且丌丝丞专丏);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.incomeLabel, 丕丗丘丑丛与丑业丒:  val_25.下丈丛与丄且丝万万.Item[1].Count.ToString());
        float val_45 = 100f;
        val_45 = val_25.下丕丘丟三丞丘上万() * val_45;
        val_53 = null;
        val_53 = null;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.contributionLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}%", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  PreviewClanWarTaskUi.丅丁丗七丁丗丌东七), arg1:  UnityEngine.Mathf.RoundToInt(f:  val_45)));
        float val_37 = (float)val_25.下三下东业丘且丟业().且丆丟业丞丕丑上且() / (float)val_25.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
        if(this.showPlayerBar != false)
        {
                float val_38 = val_25.下丕丘丟三丞丘上万();
            val_38 = val_37 - val_38;
            this.progressBar.fillAmount = val_38;
            if(this.progressBarPlayer != null)
        {
            goto label_64;
        }
        
        }
        else
        {
                this.progressBar.fillAmount = val_37;
        }
        
        label_64:
        this.progressBarPlayer.fillAmount = 0f;
        val_43 = this.progressLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_43, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_25.下三下东业丘且丟业().且丆丟业丞丕丑上且(), arg1:  val_25.下三下东业丘且丟业().丁丝丞与丟与丟丌三()));
    }
    internal void 丟三三业丆业丄丞且()
    {
        this.goToBattleButton.ClearEvents();
        this.丏东丄丞丛七世业丟();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    public void OnBackPressed()
    {
        if(this.丕不且丕东丅不丂丆 == null)
        {
                return;
        }
        
        this.丕不且丕东丅不丂丆.Invoke();
    }
    public PreviewClanWarTaskUi()
    {
    
    }
    private static PreviewClanWarTaskUi()
    {
        PreviewClanWarTaskUi.丅丁丗七丁丗丌东七 = "Key_8284";
    }

}
