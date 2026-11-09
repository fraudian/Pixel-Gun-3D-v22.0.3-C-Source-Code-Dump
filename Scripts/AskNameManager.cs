using UnityEngine;
internal sealed class AskNameManager : MonoBehaviour
{
    // Fields
    internal const string 丁丐与丁上不丞丅丞 = "keyNameAlreadySet";
    internal static AskNameManager 丄丘七三上丕世丞业;
    internal static bool 东丏丂丙丑丁丞丞万;
    private static bool 丆丄丗七丂丐世丂七;
    private static UnityEngine.Coroutine 且一丗丟丙丟丙专世;
    private System.IDisposable 丞东丝专丌丅丂世一;
    public UIButton btnSetName;
    private string 世上丏丑丅丌丈丒丝;
    public UIInput inputPlayerName;
    private bool 丐万丈丄丈丂丆丏三;
    public UILabel lbPlayerName;
    public UnityEngine.GameObject objPanelEnterName;
    public UnityEngine.GameObject objPanelSetName;
    public UnityEngine.GameObject objWindow;
    public UnityEngine.GameObject characterError;
    public UnityEngine.GameObject tapToEditNickLabel;
    public UnityEngine.GameObject newPlayerNameGUI;
    private static System.Action 丟丘丙丄丅万丏与丗;
    
    // Properties
    internal static bool 业丌丈丝且万丄丕丌 { get; }
    internal static bool 一丟丕丛一三与丝下 { get; set; }
    private bool 丂丑丄丘丅丐丟丕丂 { get; }
    
    // Methods
    internal static bool 丟世丂且丝丞丄丗丂()
    {
        var val_2;
        var val_4;
        val_2 = null;
        val_2 = null;
        if(AskNameManager.丆丄丗七丂丐世丂七 == false)
        {
                return (bool)(AskNameManager.且一丗丟丙丟丙专世 != 0) ? 1 : 0;
        }
        
        val_4 = 1;
        return (bool)(AskNameManager.且一丗丟丙丟丙专世 != 0) ? 1 : 0;
    }
    internal static bool 下丅丏七丒且不丕且()
    {
        Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        if(val_1 != null)
        {
                return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  28);
        }
        
        return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  28);
    }
    internal static void 一丈三丐丌丌丝万丝(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  28);
            return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄上丅丝不丆世万三(业丄七丙丛上专专丕:  28);
    }
    private bool 丁丘丙世七一上丏不()
    {
        bool val_2 = System.String.IsNullOrEmpty(value:  this.世上丏丑丅丌丈丒丝.Trim());
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    internal static void 丁七丙丈丑万丕丆与(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  AskNameManager.丟丘丙丄丅万丏与丗, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AskNameManager.丟丘丙丄丅万丏与丗 != 1152921505229053976);
    
    }
    internal static void 丐上丑丌七下丏丘丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  AskNameManager.丟丘丙丄丅万丏与丗, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(AskNameManager.丟丘丙丄丅万丏与丗 != 1152921505229053976);
    
    }
    private void Awake()
    {
        null = null;
        AskNameManager.丄丘七三上丕世丞业 = this;
        AskNameManager.东丏丂丙丑丁丞丞万 = false;
        AskNameManager.丆丄丗七丂丐世丂七 = false;
        AskNameManager.且一丗丟丙丟丙专世 = 0;
        this.objWindow.SetActive(value:  false);
        this.objPanelSetName.SetActive(value:  false);
        this.objPanelEnterName.SetActive(value:  false);
        bool val_1 = AskNameManager.丙丗业三丅丟三丙业();
    }
    private void OnEnable()
    {
        下丟且丅丒万丆丅丙.丙专专丈且专丟丑下(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AskNameManager::世丗丙丒丆丑专丒丒(bool 丐万丗丒下七丟丁三)));
    }
    private void 世丗丙丒丆丑专丒丒(bool 丐万丗丒下七丟丁三)
    {
        if(丐万丗丒下七丟丁三 == false)
        {
                return;
        }
        
        if(this.丐万丈丄丈丂丆丏三 == false)
        {
                return;
        }
        
        this.丂丒丅丛丂丙丁丕丄();
    }
    private void OnDisable()
    {
        var val_2;
        下丟且丅丒万丆丅丙.世不丂且丑丐丆世丙(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void AskNameManager::世丗丙丒丆丑专丒丒(bool 丐万丗丒下七丟丁三)));
        val_2 = null;
        val_2 = null;
        AskNameManager.且一丗丟丙丟丙专世 = 0;
    }
    private void OnDestroy()
    {
        null = null;
        AskNameManager.丄丘七三上丕世丞业 = 0;
        AskNameManager.且一丗丟丙丟丙专世 = 0;
    }
    internal static bool 丙丗业三丅丟三丙业()
    {
        PlayerPanel val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_3 = 1152921505229049856;
        val_4 = null;
        if(AskNameManager.下丅丏七丒且不丕且() != false)
        {
                val_5 = null;
            val_5 = null;
            AskNameManager.东丏丂丙丑丁丞丞万 = true;
            val_6 = null;
            val_6 = null;
            val_3 = PlayerPanel.丄丘七三上丕世丞业;
            if(val_3 != 0)
        {
                val_7 = null;
            val_7 = null;
            val_3 = PlayerPanel.丄丘七三上丕世丞业;
            val_3.UpdateNickPlayer();
        }
        
            val_8 = 1;
            return (bool)val_8;
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    internal void 丂丒丅丛丂丙丁丕丄()
    {
        var val_11;
        var val_13;
        var val_15;
        val_11 = null;
        UnityEngine.Debug.Log(message:  "[CharacterCreationWindow] OnShowWindowSetName.    NameAlreadySet = "("[CharacterCreationWindow] OnShowWindowSetName.    NameAlreadySet = ") + AskNameManager.下丅丏七丒且不丕且().ToString());
        if(this.丞东丝专丌丅丂世一 != null)
        {
                var val_11 = 0;
            val_11 = val_11 + 1;
            this.丞东丝专丌丅丂世一.Dispose();
        }
        
        Rilisoft.BackSystem val_6 = Rilisoft.BackSystem.丑七不且上丗丁一世();
        val_13 = null;
        val_13 = null;
        if((AskNameManager.<>c.<>9__33_0) == null)
        {
            goto label_14;
        }
        
        label_33:
        this.丞东丝专丌丅丂世一 = val_6.Register(业丏丈世世世丞丒世:  AskNameManager.<>c.<>9__33_0, 与且专丈不万东一万:  0);
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                UnityEngine.Debug.Log(message:  "+ OnShowWindowSetName");
        }
        
        val_15 = null;
        val_15 = null;
        AskNameManager.丆丄丗七丂丐世丂七 = true;
        string val_9 = 专七丑丑丁丞丂丞丕();
        this.世上丏丑丅丌丈丒丝 = val_9;
        this.lbPlayerName.text = val_9;
        this.inputPlayerName.value = this.世上丏丑丅丌丈丒丝;
        this.丑丐丗丁丏丒三丛世();
        this.objPanelSetName.SetActive(value:  true);
        this.objWindow.SetActive(value:  true);
        this.丐万丈丄丈丂丆丏三 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newPlayerNameGUI, 丏业丟一东丂东丘丛:  true);
        return;
        label_14:
        AskNameManager.<>c.<>9__33_0 = new System.Action(object:  AskNameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AskNameManager.<>c::丘丌丁丟丄丑丅丑下());
        if(val_6 != null)
        {
            goto label_33;
        }
        
        goto label_33;
    }
    public void OnShowWindowEnterName()
    {
        this.objPanelEnterName.SetActive(value:  true);
        this.objPanelSetName.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToEditNickLabel, 丏业丟一东丂东丘丛:  true);
        this.OnStartEnterName();
    }
    private string 专七丑丑丁丞丂丞丕()
    {
        return ProfileController.丆三丂丂丆上丆丕专();
    }
    private void 丑丐丗丁丏丒三丛世()
    {
        UIButton val_3;
        UnityEngine.BoxCollider val_1 = this.btnSetName.GetComponent<UnityEngine.BoxCollider>();
        bool val_2 = this.丁丘丙世七一上丏不();
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(val_2 == false)
        {
            goto label_3;
        }
        
        label_6:
        val_1.enabled = true;
        val_3 = this.btnSetName;
        if(val_3 != null)
        {
            goto typeof(UIButton).__il2cppRuntimeField_1F8;
        }
        
        goto typeof(UIButton).__il2cppRuntimeField_1F8;
        label_2:
        if(val_2 == true)
        {
            goto label_6;
        }
        
        label_3:
        val_1.enabled = false;
        val_3 = this.btnSetName;
        goto typeof(UIButton).__il2cppRuntimeField_1F8;
    }
    public void OnStartEnterName()
    {
        if(this.丐万丈丄丈丂丆丏三 == false)
        {
                return;
        }
        
        this.inputPlayerName.isSelected = true;
        this.世上丏丑丅丌丈丒丝 = "";
        this.inputPlayerName.value = "";
        this.丑丐丗丁丏丒三丛世();
        this.丐万丈丄丈丂丆丏三 = false;
    }
    public void OnChangeName()
    {
        this.世上丏丑丅丌丈丒丝 = this.inputPlayerName.value;
        this.丑丐丗丁丏丒三丛世();
    }
    public void SaveChooseNameOutside(string 丒丘丏上丙丟丑丕丈)
    {
        this.inputPlayerName.value = 丒丘丏上丙丟丑丕丈;
        this.OnChangeName();
        this.SaveChooseName();
    }
    public void SaveChooseName()
    {
        string val_13;
        var val_14;
        var val_15;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToEditNickLabel, 丏业丟一东丂东丘丛:  false);
        if((this.inputPlayerName.value.Length < 3) || ((NickNameValidator.instance.ValidateNickName(丕丗丘丑丛与丑业丒:  this.inputPlayerName.value)) == false))
        {
            goto label_8;
        }
        
        string val_5 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  this.世上丏丑丅丌丈丒丝);
        val_13 = val_5;
        if((System.String.IsNullOrEmpty(value:  val_5)) != true)
        {
                if((System.String.op_Equality(a:  val_13.Trim(), b:  System.String.alignConst)) == false)
        {
            goto label_13;
        }
        
        }
        
        val_13 = ProfileController.丐与丄东丆上丟丑与();
        label_13:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东丐万丑丏上专世专(丑与丕丐七丆三丟一:  val_13);
        val_14 = null;
        val_14 = null;
        if(PlayerPanel.丄丘七三上丕世丞业 != 0)
        {
                val_15 = null;
            val_15 = null;
            PlayerPanel.丄丘七三上丕世丞业.UpdateNickPlayer();
        }
        
        AskNameManager.一丈三丐丌丌丝万丝(丙业与丙丗丝不丈东:  true);
        this.专丁七丈丁不丒七丕();
        return;
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  true);
        this.inputPlayerName.value = ProfileController.专不业业下东丆不世();
        this.OnChangeName();
    }
    private void 专丁七丈丁不丒七丕()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.newPlayerNameGUI, 丏业丟一东丂东丘丛:  false);
        if(this.丞东丝专丌丅丂世一 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            this.丞东丝专丌丅丂世一.Dispose();
        }
        
        this.objWindow.SetActive(value:  false);
        val_13 = null;
        val_13 = null;
        AskNameManager.东丏丂丙丑丁丞丞万 = true;
        val_14 = null;
        val_14 = null;
        if(PlayerPanel.丄丘七三上丕世丞业 != 0)
        {
                val_15 = null;
            val_15 = null;
            PlayerPanel.丄丘七三上丕世丞业.UpdateNickPlayer();
        }
        
        val_16 = null;
        val_16 = null;
        AskNameManager.丆丄丗七丂丐世丂七 = false;
        AskNameManager.且一丗丟丙丟丙专世 = 0;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == true)
        {
                return;
        }
        
        if(Rilisoft.丐丌丝七下丈丒丅丗.丕万世丄丄七丐丘丈() == false)
        {
                return;
        }
        
        if((CloudHashMigrationValidator.七一一丑七丒上丐丑(丛专下丞丒丛下下与:  true)) != false)
        {
                if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
        {
            goto label_28;
        }
        
        }
        
        val_17 = 0;
        goto label_29;
        label_28:
        CloudHashMigrationValidator.丄万丁三业万丛东丑();
        val_17 = 1;
        label_29:
        UnityEngine.Coroutine val_11 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.世丐不丗不业七丘丐(与下丛丂丒丘丛三丆:  false, 丄丌丟丛丆丝东世一:  true, 丙丛丐东与丒且丂上:  false, 且丏下一下上丟与丐:  true));
    }
    public void TestShow()
    {
        null = null;
        AskNameManager.东丏丂丙丑丁丞丞万 = false;
        this.丂丒丅丛丂丙丁丕丄();
    }
    public void DEV_Show()
    {
    
    }
    public AskNameManager()
    {
        this.世上丏丑丅丌丈丒丝 = "";
    }
    private static AskNameManager()
    {
    
    }

}
