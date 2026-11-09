using UnityEngine;
internal sealed class MenuBackgroundMusic : MonoBehaviour
{
    // Fields
    private UnityEngine.AudioSource 丑丑业丈丈丈丝且万;
    private static UnityEngine.AudioSource 丙丛丗七七万上东丐;
    internal static bool 下丁丛下业一丌丗三;
    internal static MenuBackgroundMusic 丌丂一丛下丒丞丛东;
    private static string[] 与丙丅丏三丞丑丗丛;
    
    // Properties
    internal bool 丄下丂丑万丟专丟且 { get; }
    internal static string 丈丌与世一丑业一丞 { get; }
    internal static string 丁下丘丈上丐丙丑丐 { get; set; }
    internal UnityEngine.AudioSource 丐丟业世丑专丄丞三 { get; }
    
    // Methods
    internal void 业丌丘世丞丙且下上(UnityEngine.AudioSource 丞下上且一上丙不丏)
    {
        var val_7;
        UnityEngine.AudioSource val_8;
        var val_9;
        if(丞下上且一上丙不丏 != 0)
        {
                val_7 = null;
            val_7 = null;
            if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 != false)
        {
                this.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  丞下上且一上丙不丏);
        }
        
        }
        
        val_8 = this.与丒丏丛业丒丟丛丘();
        val_9 = null;
        val_9 = null;
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.Linq.Enumerable.Contains<System.String>(source:  MenuBackgroundMusic.与丙丅丏三丞丑丗丛, value:  val_3.m_Handle.name)) != true)
        {
                UnityEngine.AudioSource val_6 = MenuBackgroundMusic.七一丐丈丅丆丙与丗();
            val_8 = val_6;
        }
        
        val_6.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  val_8);
    }
    internal static void 专下丆丞一丆丏丂东(float 与丁万东丌丑下丏丕)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(MenuBackgroundMusic.丙丛丗七七万上东丐 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        MenuBackgroundMusic.丙丛丗七七万上东丐.volume = UnityEngine.Mathf.Clamp01(value:  与丁万东丌丑下丏丕);
    }
    internal void 丐丞丛丗丈丐丆丂丛(UnityEngine.AudioSource 丞下上且一上丙不丏)
    {
        var val_6;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  丞下上且一上丙不丏, y:  0);
        if(val_1 != false)
        {
                val_1.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  丞下上且一上丙不丏);
        }
        
        val_6 = null;
        val_6 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  MenuBackgroundMusic.与丙丅丏三丞丑丗丛, value:  UnityEngine.Application.loadedLevelName)) != false)
        {
                UnityEngine.AudioSource val_4 = this.与丒丏丛业丒丟丛丘();
        }
        
        this.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  MenuBackgroundMusic.七一丐丈丅丆丙与丗());
    }
    private void Awake()
    {
        null = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MenuBackgroundMusic::丏上丛丐且丒世丆丕()));
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void MenuBackgroundMusic::上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void MenuBackgroundMusic::上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void 丏上丛丐且丒世丆丕()
    {
        if(this.与丒丏丛业丒丟丛丘().clip != 0)
        {
                bool val_6 = this.与丒丏丛业丒丟丛丘().clip.UnloadAudioData();
        }
        
        this.与丒丏丛业丒丟丛丘().clip = 0;
    }
    internal void Start()
    {
        var val_10 = null;
        与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 = 丛丌丙丂丑丞丂丏丟.丑上万丌丏上丌下三(丒丘丏上丙丟丑丕丈:  丛丌丙丂丑丞丂丏丟.丏丏丌下丑三丐与东(), 专不三上丏专丄且丞:  与丂丏丛丞丞丒丟丄.万七丐丈丗上丗丁业);
        与丂丏丛丞丞丒丟丄.丁万丂不一七丁丛与(丙业与丙丗丝不丈东:  丛丌丙丂丑丞丂丏丟.丑上万丌丏上丌下三(丒丘丏上丙丟丑丕丈:  丛丌丙丂丑丞丂丏丟.丏丏丌丆丞丂丆不丗(), 专不三上丏专丄且丞:  与丂丏丛丞丞丒丟丄.丂世三东丄丆七一不));
        this.与丒丏丛业丒丟丛丘().clip = MenuBackgroundMusic.且丕上丙东专万丝业(七不丐下丟专业万丅:  MenuBackgroundMusic.丄一丙三丄专丛一丆());
    }
    internal void 三且世三丂七丐一丟()
    {
        this.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  this.与丒丏丛业丒丟丛丘());
    }
    internal void 丌丄丏下七丁专丂世()
    {
        UnityEngine.AudioSource val_1 = this.与丒丏丛业丒丟丛丘();
        val_1.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  val_1);
    }
    internal bool 七丗东丑不一丌丞一()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((UnityEngine.Object.op_Implicit(exists:  MenuBackgroundMusic.丙丛丗七七万上东丐)) == false)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        if(MenuBackgroundMusic.丙丛丗七七万上东丐 != null)
        {
                return MenuBackgroundMusic.丙丛丗七七万上东丐.isPlaying;
        }
        
        return MenuBackgroundMusic.丙丛丗七七万上东丐.isPlaying;
    }
    private void 上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        var val_15;
        var val_16;
        var val_17;
        this.StopAllCoroutines();
        val_15 = null;
        val_15 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  MenuBackgroundMusic.与丙丅丏三丞丑丗丛, value:  UnityEngine.Application.loadedLevelName)) == true)
        {
            goto label_3;
        }
        
        val_16 = null;
        val_16 = null;
        if(MenuBackgroundMusic.下丁丛下业一丌丗三 == false)
        {
            goto label_6;
        }
        
        label_3:
        if(this.与丒丏丛业丒丟丛丘().isPlaying != true)
        {
                this.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  this.与丒丏丛业丒丟丛丘());
        }
        
        label_20:
        val_17 = null;
        val_17 = null;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = false;
        return;
        label_6:
        UnityEngine.AudioSource val_6 = this.与丒丏丛业丒丟丛丘();
        val_6.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  val_6);
        if((this.与丒丏丛业丒丟丛丘() == 0) || (this.与丒丏丛业丒丟丛丘().clip == 0))
        {
            goto label_20;
        }
        
        bool val_14 = this.与丒丏丛业丒丟丛丘().clip.UnloadAudioData();
        goto label_20;
    }
    internal void 丛丗丐丝丁丄丙丞丘(UnityEngine.AudioSource 丞下上且一上丙不丏)
    {
        UnityEngine.Object val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        UnityEngine.AudioClip val_41;
        var val_42;
        var val_44;
        if(丞下上且一上丙不丏 == 0)
        {
                return;
        }
        
        val_36 = null;
        val_36 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == false)
        {
                return;
        }
        
        val_37 = null;
        val_37 = null;
        if(Switcher.丐丟万丁丘丌业东丟 != 0)
        {
                val_38 = null;
            val_38 = null;
            if(丞下上且一上丙不丏 != (Switcher.丐丟万丁丘丌业东丟.GetComponent<UnityEngine.AudioSource>()))
        {
                val_39 = null;
            val_39 = null;
            UnityEngine.Object.Destroy(obj:  Switcher.丐丟万丁丘丌业东丟);
            Switcher.丐丟万丁丘丌业东丟 = 0;
        }
        
        }
        
        val_35 = this.与丒丏丛业丒丟丛丘();
        if(丞下上且一上丙不丏 != val_35)
        {
            goto label_24;
        }
        
        if(丞下上且一上丙不丏.clip != 0)
        {
            goto label_33;
        }
        
        val_40 = null;
        val_40 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_33;
        }
        
        val_41 = MenuBackgroundMusic.且丕上丙东专万丝业(七不丐下丟专业万丅:  MenuBackgroundMusic.丄一丙三丄专丛一丆());
        goto label_37;
        label_24:
        val_35 = this.与丒丏丛业丒丟丛丘().clip;
        if(val_35 != 0)
        {
                val_35 = this.与丒丏丛业丒丟丛丘().clip;
            bool val_17 = val_35.UnloadAudioData();
        }
        
        val_41 = 0;
        label_37:
        this.与丒丏丛业丒丟丛丘().clip = val_41;
        label_33:
        if(丞下上且一上丙不丏.clip == 0)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
            goto label_51;
        }
        
        label_71:
        float val_36 = System.Convert.ToSingle(value:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        float val_35 = 丞下上且一上丙不丏.clip.length;
        float val_29 = 丞下上且一上丙不丏.clip.length;
        val_29 = (System.Convert.ToSingle(value:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄())) / val_29;
        val_35 = val_35 * ((float)UnityEngine.Mathf.FloorToInt(f:  val_29));
        val_36 = val_36 - val_35;
        float val_33 = UnityEngine.Mathf.Clamp(value:  val_36, min:  0f, max:  丞下上且一上丙不丏.clip.length);
        if(丞下上且一上丙不丏 != null)
        {
            goto label_65;
        }
        
        goto label_65;
        label_51:
        val_42 = null;
        val_42 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_71;
        }
        
        }
        
        label_65:
        丞下上且一上丙不丏.time = 0f;
        val_44 = null;
        val_44 = null;
        MenuBackgroundMusic.丙丛丗七七万上东丐 = 丞下上且一上丙不丏;
        MenuBackgroundMusic.专下丆丞一丆丏丂东(与丁万东丌丑下丏丕:  与丂丏丛丞丞丒丟丄.业且丞丂一与不七丑());
        丞下上且一上丙不丏.Play();
    }
    internal void 丌丗世丐业丂丐丕且(UnityEngine.AudioSource 丞下上且一上丙不丏)
    {
        if(丞下上且一上丙不丏 == 0)
        {
                return;
        }
        
        丞下上且一上丙不丏.Stop();
    }
    private void OnApplicationPause(bool 丄七丙不丟丛与丏丐)
    {
        UnityEngine.AudioSource val_3;
        string val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_3 = this;
        if(PolygonController.一下一万丄丅丘且丑 != 0)
        {
                val_4 = PolygonController.一下一万丄丅丘且丑;
            if((PolygonController.一下一万丄丅丘且丑 + 24) != 0)
        {
                return;
        }
        
        }
        
        val_4 = 1152921505083416576;
        val_5 = null;
        if(丄七丙不丟丛与丏丐 != false)
        {
                val_6 = null;
            val_3 = MenuBackgroundMusic.丙丛丗七七万上东丐;
            if(val_3 == 0)
        {
                return;
        }
        
            val_7 = null;
            val_7 = null;
            MenuBackgroundMusic.丙丛丗七七万上东丐.Pause();
            return;
        }
        
        val_8 = null;
        this.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  MenuBackgroundMusic.丙丛丗七七万上东丐);
    }
    internal static void 丆不丅丐与业一东丙(string 七不丐下丟专业万丅, bool 七丆丟丗世丟且丒丆 = False, bool 丝下丘下丈一丞丄丄 = True, UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
    {
        UnityEngine.Object val_19;
        string val_20;
        var val_21;
        var val_22;
        var val_23;
        UnityEngine.Object val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_31;
        val_19 = 丆与丈丏丟七丁东丛;
        val_20 = 七不丐下丟专业万丅;
        val_21 = null;
        val_21 = null;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 == 0)
        {
                return;
        }
        
        bool val_7 = System.String.op_Equality(a:  MenuBackgroundMusic.丄一丙三丄专丛一丆().ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture), b:  val_20.ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture));
        if(val_7 != false)
        {
                if(七丆丟丗世丟且丒丆 == false)
        {
                return;
        }
        
        }
        
        if(丝下丘下丈一丞丄丄 != false)
        {
                MenuBackgroundMusic.七专丐丞丏丌丐丝一(丙业与丙丗丝不丈东:  val_20);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_19)) != true)
        {
                val_19 = MenuBackgroundMusic.且丕上丙东专万丝业(七不丐下丟专业万丅:  val_20);
        }
        
        if(val_19 == 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_20 = MenuBackgroundMusic.丙丛丗七七万上东丐;
        if(val_20 == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        val_20 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
        if(val_20 == 0)
        {
                return;
        }
        
        val_24 = MenuBackgroundMusic.七一丐丈丅丆丙与丗();
        val_25 = null;
        if(val_24 == 0)
        {
            goto label_39;
        }
        
        val_26 = null;
        MenuBackgroundMusic.丙丛丗七七万上东丐.Stop();
        val_24 = MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘();
        val_24.clip = val_19;
        val_27 = null;
        if(val_7 == false)
        {
            goto label_45;
        }
        
        val_28 = null;
        MenuBackgroundMusic.丙丛丗七七万上东丐.Play();
        return;
        label_39:
        val_29 = null;
        UnityEngine.AudioSource val_16 = MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘();
        val_16.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  val_16);
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘().clip = val_19;
        goto label_54;
        label_45:
        val_31 = null;
        label_54:
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘());
    }
    internal static System.Collections.IEnumerator 丆不一万丗下不丆万(string 七不丐下丟专业万丅, bool 七丆丟丗世丟且丒丆 = False, bool 丝下丘下丈一丞丄丄 = True)
    {
        MenuBackgroundMusic.三世丟丒上世东丁万 val_1 = new MenuBackgroundMusic.三世丟丒上世东丁万();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .七不丐下丟专业万丅 = 七不丐下丟专业万丅;
            .七丆丟丗世丟且丒丆 = 七丆丟丗世丟且丒丆;
        }
        else
        {
                mem[32] = 七不丐下丟专业万丅;
            mem[40] = 七丆丟丗世丟且丒丆;
        }
        
        .丝下丘下丈一丞丄丄 = 丝下丘下丈一丞丄丄;
        return (System.Collections.IEnumerator)val_1;
    }
    internal static string 丙丄丏下丕丄丘丏丄()
    {
        var val_8;
        MenuBackgroundMusic val_9;
        var val_10;
        int val_11;
        val_8 = null;
        val_8 = null;
        val_9 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
        if(val_9 != 0)
        {
                val_10 = null;
            val_10 = null;
            val_9 = MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘();
            if(val_9 != 0)
        {
                if(val_9.clip != 0)
        {
                val_9 = val_9.clip;
            if(val_9.name != null)
        {
                return (string)val_11;
        }
        
        }
        
        }
        
        }
        
        val_11 = System.String.alignConst;
        return (string)val_11;
    }
    internal static string 丄一丙三丄专丛一丆()
    {
        string val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  96);
        return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) != true) ? "menu_music_ambient" : (val_2);
    }
    internal static void 七专丐丞丏丌丐丝一(string 丙业与丙丗丝不丈东)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙业与丙丗丝不丈东)) != false)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  96, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal UnityEngine.AudioSource 与丒丏丛业丒丟丛丘()
    {
        UnityEngine.AudioSource val_3;
        if(this.丑丑业丈丈丈丝且万 == 0)
        {
                this.丑丑业丈丈丈丝且万 = this.GetComponent<UnityEngine.AudioSource>();
            return val_3;
        }
        
        val_3 = this.丑丑业丈丈丈丝且万;
        return val_3;
    }
    private static UnityEngine.AudioSource 七一丐丈丅丆丙与丗()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(BackgroundMusicController.丄丘七三上丕世丞业 == 0)
        {
                return 0;
        }
        
        val_3 = null;
        val_3 = null;
        if(BackgroundMusicController.丄丘七三上丕世丞业 != null)
        {
                return BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁();
        }
        
        return BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁();
    }
    private static UnityEngine.AudioClip 且丕上丙东专万丝业(string 七不丐下丟专业万丅)
    {
        return UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "MenuMusic/"("MenuMusic/") + 七不丐下丟专业万丅.ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture)(七不丐下丟专业万丅.ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture)));
    }
    public MenuBackgroundMusic()
    {
    
    }
    private static MenuBackgroundMusic()
    {
        MenuBackgroundMusic.丙丛丗七七万上东丐 = 0;
        MenuBackgroundMusic.下丁丛下业一丌丗三 = false;
        string[] val_1 = new string[8];
        string val_2 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        val_1[1] = "SettingScene";
        val_1[2] = "SkinEditor";
        val_1[3] = "ChooseLevel";
        val_1[4] = "CampaignChooseBox";
        val_1[5] = "ProfileShop";
        val_1[6] = "Friends";
        val_1[7] = "Clans";
        MenuBackgroundMusic.与丙丅丏三丞丑丗丛 = val_1;
    }

}
