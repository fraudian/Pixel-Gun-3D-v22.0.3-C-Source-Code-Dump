using UnityEngine;
public sealed class LoadingNGUIController : MonoBehaviour
{
    // Fields
    private static bool 东丆专丞专不丞万丗;
    private static readonly string 丆丑丄丗丆不丘丈丗;
    private string 丞丗专丝丙专丂上丗;
    public UITexture loadingNGUITexture;
    public UITexture quitNGUITexture;
    public UILabel[] levelNameLabels;
    public UILabel[] levelSettingLabels;
    public UILabel recommendedForThisMap;
    public UnityEngine.Transform gunsPoint;
    public UnityEngine.Transform UIRoot;
    private static bool 丄丗专东不不万专不;
    internal static bool 丙丅东上世万丐丏丞;
    
    // Properties
    internal static bool 丒东丐丑丗与一丅丕 { get; set; }
    public string 丅且下世丐丌不丏丈 { set; }
    internal static bool 丄上专万丒丁丝丂丞 { get; set; }
    public bool 丙丏丈东下丝不丞且 { get; set; }
    public float 不丗丐丈丗七三丅丑 { get; set; }
    
    // Methods
    internal static bool 世丈丙丞丞下世丑丐()
    {
        null = null;
        if(LoadingNGUIController.东丆专丞专不丞万丗 == false)
        {
                return PGCompany.丁东丌世与丕东丆上.丆业业丙丅丂丂丗东();
        }
        
        return true;
    }
    internal static void 丘不丘不业不丟世业(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        LoadingNGUIController.东丆专丞专不丞万丗 = 丙业与丙丗丝不丈东;
    }
    public void set_SceneToLoad(string 丙业与丙丗丝不丈东)
    {
        this.丞丗专丝丙专丂上丗 = 丙业与丙丗丝不丈东;
    }
    internal static bool 丈丗丑丛下东丂丝丟()
    {
        null = null;
        return (bool)LoadingNGUIController.丄丗专东不不万专不;
    }
    internal static void 与丙丏丐丘丁专东丒(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        LoadingNGUIController.丄丗专东不不万专不 = 丙业与丙丗丝不丈东;
    }
    public bool get_IsShowingTip()
    {
        if((Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance) == 0)
        {
                return false;
        }
        
        Rilisoft.LoadingTipsController val_3 = Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance;
        if(val_3 != null)
        {
                return val_3.IsShowing;
        }
        
        return val_3.IsShowing;
    }
    public void set_IsShowingTip(bool 丙业与丙丗丝不丈东)
    {
        if((Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance) == 0)
        {
                return;
        }
        
        Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance.IsShowing = 丙业与丙丗丝不丈东;
    }
    public float get_ShowingTime()
    {
        UnityEngine.Object val_4 = Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance;
        if(val_4 == 0)
        {
                return (float)val_3.ShowingTime;
        }
        
        val_4 = Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance;
        return (float)val_3.ShowingTime;
    }
    public void set_ShowingTime(float 丙业与丙丗丝不丈东)
    {
        UnityEngine.Object val_4 = Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance;
        if(val_4 == 0)
        {
                return;
        }
        
        val_4 = Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance;
        val_3.ShowingTime = 丙业与丙丗丝不丈东;
    }
    internal void 丘上丐世丆丑且丞丒(bool 丝丌丄丙专三丑丒丝 = False, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        string val_84;
        var val_85;
        string val_86;
        UILabel[] val_87;
        var val_88;
        var val_89;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_90;
        var val_91;
        var val_92;
        var val_93;
        丄丕丏东丆丌七与且.丟丙世丙不丛丈下丑 val_94;
        var val_96;
        var val_97;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_98;
        var val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_103;
        var val_104;
        var val_105;
        var val_106;
        var val_107;
        var val_108;
        var val_109;
        val_84 = this;
        LoadingNGUIController.与丙丏丐丘丁专东丒(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.recommendedForThisMap.gameObject, 丏业丟一东丂东丘丛:  false);
        val_85 = null;
        val_85 = null;
        val_86 = this.丞丗专丝丙专丂上丗;
        SceneInfo val_2 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_86);
        val_87 = this.levelNameLabels;
        val_88 = 1152921504848912384;
        val_89 = 0;
        goto label_9;
        label_25:
        val_86 = val_87[0];
        if(val_2 != 0)
        {
                if((System.String.IsNullOrEmpty(value:  this.丞丗专丝丙专丂上丗)) == false)
        {
            goto label_14;
        }
        
        }
        
        val_86 = val_86.gameObject;
        val_86.SetActive(value:  false);
        goto label_17;
        label_14:
        val_86.gameObject.SetActive(value:  true);
        val_86.text = val_2.七丛一丛专七丈丅专().Replace(oldValue:  "\n", newValue:  " ").Replace(oldValue:  "\r", newValue:  " ");
        label_17:
        val_89 = 1;
        label_9:
        if(val_89 < this.levelNameLabels.Length)
        {
            goto label_25;
        }
        
        val_90 = 丐且丘丑与万丞丑丅;
        if(丐且丘丑与万丞丑丅 != 0)
        {
            goto label_26;
        }
        
        val_91 = null;
        val_91 = null;
        val_90 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_90 == null)
        {
            goto label_31;
        }
        
        label_26:
        System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_10 = val_90.丌不丅不丞东万专专();
        val_86 = val_10.HasValue.丙东专丂世丈丏丁丂();
        if((val_86 != 3) || ((447376936 & 1) == 0))
        {
            goto label_31;
        }
        
        val_87 = 1152921505072021504;
        val_92 = 0;
        goto label_32;
        label_40:
        val_86 = this.levelSettingLabels[0];
        val_86.gameObject.SetActive(value:  true);
        val_86.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_90.丝丕世与与丝专万上());
        val_92 = 1;
        label_32:
        if(val_92 < this.levelSettingLabels.Length)
        {
            goto label_40;
        }
        
        label_31:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丞丗专丝丙专丂上丗)) == true)
        {
            goto label_43;
        }
        
        val_86 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if((System.String.op_Equality(a:  this.丞丗专丝丙专丂上丗, b:  val_86.丈一丝万丈世丛万一())) == false)
        {
            goto label_48;
        }
        
        label_43:
        val_93 = null;
        val_93 = null;
        if(与丂丏丛丞丞丒丟丄.丒丙下下丂七丌丈丄 != false)
        {
                LoadingTipsView val_20 = UnityEngine.Object.Instantiate<LoadingTipsView>(original:  UnityEngine.Resources.Load<LoadingTipsView>(path:  "LoadingTips"), parent:  this.UIRoot, worldPositionStays:  false);
            val_94 = val_20.gameObject;
            val_94.layer = this.gameObject.layer;
            val_84 = Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance;
            val_84.ShowTip(丞万一业万丕丏且丄:  val_20, 七丆丒与丗丌丄且丂:  268435456, 丛业丑丝丘丟七与丑:  false);
            return;
        }
        
        label_48:
        val_94 = Rilisoft.LoadingTipsController.七与丙一丞下丏丕业(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        if(val_94 == 0)
        {
                return;
        }
        
        if(LoadingNGUIController.世丈丙丞丞下世丑丐() == true)
        {
                return;
        }
        
        val_86 = this.丞丗专丝丙专丂上丗;
        if((val_86.Equals(value:  "CampaignChooseBox")) == true)
        {
                return;
        }
        
        val_86 = this.丞丗专丝丙专丂上丗;
        if((val_86.Equals(value:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        val_86 = this.丞丗专丝丙专丂上丗;
        if((val_86.Equals(value:  "ChooseLevel")) == true)
        {
                return;
        }
        
        val_86 = Initializer.丑七不且上丗丁一世();
        if(val_86 != 0)
        {
                if(丝丌丄丙专三丑丒丝 == false)
        {
                return;
        }
        
        }
        
        LoadingTipsView val_35 = UnityEngine.Object.Instantiate<LoadingTipsView>(original:  UnityEngine.Resources.Load<LoadingTipsView>(path:  "LoadingTips"), parent:  this.UIRoot, worldPositionStays:  false);
        val_35.gameObject.layer = this.gameObject.layer;
        UnityEngine.SceneManagement.Scene val_39 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_40 = val_39.m_Handle.name;
        val_96 = null;
        val_96 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_118;
        }
        
        if(丐且丘丑与万丞丑丅 != 0)
        {
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_41 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
            val_87 = 1152921525549507984;
            if(val_41.HasValue.丙东专丂世丈丏丁丂() == 4)
        {
                if((447376936 & 1) != 0)
        {
            goto label_96;
        }
        
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_43 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
            if(val_43.HasValue.丙东专丂世丈丏丁丂() == 3)
        {
                if((447376936 & 1) != 0)
        {
            goto label_96;
        }
        
        }
        
            if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 36)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 37)
        {
            goto label_203;
        }
        
        }
        
        }
        
        }
        
        label_96:
        val_97 = null;
        val_97 = null;
        val_98 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_98 != null)
        {
                val_98 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_98 == null)
        {
                val_98 = 0;
        }
        
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_48 = val_98.丌不丅不丞东万专专();
            val_87 = 1152921525549507984;
            if(val_48.HasValue.丙东专丂世丈丏丁丂() == 4)
        {
                if((447376936 & 1) != 0)
        {
            goto label_118;
        }
        
        }
        
            val_99 = null;
            val_99 = null;
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_50 = GameConnect.丈丝丂丐丟万丙丑丕.丌不丅不丞东万专专();
            if(val_50.HasValue.丙东专丂世丈丏丁丂() == 3)
        {
                if((447376936 & 1) != 0)
        {
            goto label_118;
        }
        
        }
        
            if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 36)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 37)
        {
            goto label_121;
        }
        
        }
        
        }
        
        }
        
        label_118:
        if((val_40.Equals(value:  this.丞丗专丝丙专丂上丗)) != false)
        {
                val_88 = 1;
        }
        else
        {
                val_100 = null;
            val_100 = null;
            if((val_40.Equals(value:  与丂丏丛丞丞丒丟丄.丁与丌丁丂七万丑丟)) != false)
        {
                val_101 = null;
            val_101 = null;
            bool val_83 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
            val_83 = val_83 ^ 1;
            val_88 = val_83 & 255;
        }
        else
        {
                val_88 = 0;
        }
        
        }
        
        System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_58 = PGCompany.BattlePass.BattlePassConnectScene.与业下丏丂上三丗丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 不丌丒丆丞下丙专万:  false);
        System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_60 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.丙七丕东丅与丈三不(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  this.丞丗专丝丙专丂上丗);
        val_102 = null;
        val_102 = null;
        val_103 = null;
        if((val_88 & (丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  LoadingNGUIController.丆丑丄丗丆不丘丈丗))) == false)
        {
            goto label_138;
        }
        
        val_104 = null;
        val_86 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  LoadingNGUIController.丆丑丄丗丆不丘丈丗, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        if(val_58 != null)
        {
            goto label_188;
        }
        
        label_189:
        label_188:
        if((((val_86 == 2) && (val_58.Count >= 1)) && (GameConnect.丑丌丛丈丅丅与不业() != 22)) && (GameConnect.丑丌丛丈丅丅与不业() != 33))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 36)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 37)
        {
            goto label_157;
        }
        
        }
        
        }
        
        if(((val_60 != null) && ((val_86 == 3) && (val_60.Count >= 1))) && (GameConnect.丑丌丛丈丅丅与不业() != 22))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 37)
        {
            goto label_169;
        }
        
        }
        
        }
        
        Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance.ShowTip(丞万一业万丕丏且丄:  val_35, 七丆丒与丗丌丄且丂:  val_94, 丛业丑丝丘丟七与丑:  (val_88 != 0) ? 1 : 0);
        val_105 = null;
        val_105 = null;
        val_84 = LoadingNGUIController.丆丑丄丗丆不丘丈丗;
        label_202:
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  val_84, 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        return;
        label_138:
        val_106 = null;
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  LoadingNGUIController.丆丑丄丗丆不丘丈丗, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 3)
        {
            goto label_185;
        }
        
        var val_84 = 106041320 + (val_75) << 2;
        val_84 = val_84 + 106041320;
        goto (106041320 + (val_75) << 2 + 106041320);
        label_185:
        if(val_58 != null)
        {
            goto label_188;
        }
        
        goto label_189;
        label_169:
        Rilisoft.Singleton<PGCompany.PixelPass.PixelPassLoadingTipsController>.Instance.丂且专三丅丌东万专(丞万一业万丕丏且丄:  val_35, 丞丗上不丂一丘且丙:  val_60, 丛业丑丝丘丟七与丑:  (val_88 != 0) ? 1 : 0);
        val_107 = null;
        val_107 = null;
        goto label_202;
        label_157:
        Rilisoft.Singleton<Rilisoft.LoadingBPTipsController>.Instance.下丟丞不丁业丌丛下(丞万一业万丕丏且丄:  val_35, 丑下三万万丝七丕丂:  val_58, 丛业丑丝丘丟七与丑:  (val_88 != 0) ? 1 : 0);
        Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance.七丅丏丄丏世丙万万(丆万一不丌且东丐丐:  val_94);
        val_108 = null;
        val_108 = null;
        goto label_202;
        label_121:
        if(丐且丘丑与万丞丑丅 == 0)
        {
                val_109 = null;
            val_109 = null;
        }
        
        label_203:
        val_35.东丆丛丁丞丞且丂丌(丐且丘丑与万丞丑丅:  GameConnect.丈丝丂丐丟万丙丑丕);
    }
    public void SetLoadingTexture(UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        this.loadingNGUITexture.gameObject.SetActive(value:  true);
        this.quitNGUITexture.gameObject.SetActive(value:  false);
    }
    public void SetQuitTexture(UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        this.loadingNGUITexture.gameObject.SetActive(value:  false);
        this.quitNGUITexture.gameObject.SetActive(value:  true);
        if(this.quitNGUITexture == null)
        {
            
        }
    
    }
    public void SetEnabledMapName(bool 丝三丄专丗丞丄丄丌)
    {
        goto label_0;
        label_6:
        this.levelNameLabels[0].gameObject.SetActive(value:  丝三丄专丗丞丄丄丌);
        0 = 1;
        label_0:
        if(0 < this.levelNameLabels.Length)
        {
            goto label_6;
        }
    
    }
    public void SetEnabledGunsScroll(bool 丝三丄专丗丞丄丄丌)
    {
        if(this.recommendedForThisMap != 0)
        {
                this.recommendedForThisMap.gameObject.SetActive(value:  丝三丄专丗丞丄丄丌);
        }
        
        if(this.gunsPoint == 0)
        {
                return;
        }
        
        this.gunsPoint.gameObject.SetActive(value:  丝三丄专丗丞丄丄丌);
    }
    private void OnEnable()
    {
        LoadingNGUIController.与丙丏丐丘丁专东丒(丙业与丙丗丝不丈东:  true);
    }
    private void OnDisable()
    {
        LoadingNGUIController.与丙丏丐丘丁专东丒(丙业与丙丗丝不丈东:  false);
    }
    private void OnDestroy()
    {
        LoadingNGUIController.与丙丏丐丘丁专东丒(丙业与丙丗丝不丈东:  false);
        this.loadingNGUITexture = 0;
        this.quitNGUITexture = 0;
    }
    public LoadingNGUIController()
    {
        this.丞丗专丝丙专丂上丗 = "";
    }
    private static LoadingNGUIController()
    {
        LoadingNGUIController.东丆专丞专不丞万丗 = false;
        LoadingNGUIController.丆丑丄丗丆不丘丈丗 = "LoadingNG_UIController_LASTSHOWTIPTYPEKEY";
        LoadingNGUIController.丙丅东上世万丐丏丞 = false;
    }

}
