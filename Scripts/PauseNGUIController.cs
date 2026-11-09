using UnityEngine;
public sealed class PauseNGUIController : ControlsSettingsBase
{
    // Fields
    internal static PauseNGUIController 丄丞丁丈与业上丞丟;
    private static System.Action 万丅丏不一丙一专世;
    public UIButton resumeButton;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    internal static void 丒一世七业丙东丒丂(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  PauseNGUIController.万丅丏不一丙一专世, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(PauseNGUIController.万丅丏不一丙一专世 != 1152921505103495176);
    
    }
    internal static void 丈一丞丘世丌丄上丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  PauseNGUIController.万丅丏不一丙一专世, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(PauseNGUIController.万丅丏不一丙一专世 != 1152921505103495176);
    
    }
    private void Awake()
    {
        null = null;
        PauseNGUIController.丄丞丁丈与业上丞丟 = this;
    }
    private void Start()
    {
        this.Start();
        this.resumeButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PauseNGUIController::且三丑丄不七丞七丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 且三丑丄不七丞七丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.业丝专世业上丒丒丘() != false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private bool 业丝专世业上丒丒丘()
    {
        InGameGUI val_3 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_3 == 0)
        {
                return false;
        }
        
        val_3 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 552];
        val_3 = InGameGUI.丙丞专丌丁丞与不丐.playerMoveC;
        if(val_3 == 0)
        {
                return false;
        }
        
        if(null != 0)
        {
                return 业丘世丆且世丄丟丈();
        }
        
        return 业丘世丆且世丄丟丈();
    }
    private void Update()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = this;
        val_5 = 58289;
        if(true == 0)
        {
            goto label_1;
        }
        
        val_5 = 137113600;
        bool val_1 = activeInHierarchy;
        if(val_1 == false)
        {
            goto label_3;
        }
        
        val_5 = val_4;
        goto label_4;
        label_3:
        bool val_2 = val_1.业丝专世业上丒丒丘();
        if(val_2 == false)
        {
            goto label_5;
        }
        
        label_4:
        mem[1152921535468313696] = 0;
        label_1:
        if(val_2.业丝专世业上丒丒丘() == true)
        {
                return;
        }
        
        val_4 = 1152921505171275776;
        val_6 = null;
        val_6 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        return;
        label_5:
        this.且三丑丄不七丞七丝(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  null);
        mem[1152921535468313696] = 0;
    }
    private void OnEnable()
    {
        UnityEngine.Object val_14;
        var val_15;
        var val_17;
        var val_18;
        Rilisoft.七丕丟丏三丈一丄世 val_1 = GameConnect.丑丌丛丈丅丅与不业();
        this.东东一世专业下丒丌(丙业与丙丗丝不丈东:  下丂世丂不丛专一一.丕丙丛万丒七业丄下(上且丗一丏丏万丅丌:  val_1));
        this.OnEnable();
        val_14 = val_1;
        if(val_14 == 0)
        {
                iPhoneXOrientationDetector val_4 = this.GetComponentInChildren<iPhoneXOrientationDetector>(includeInactive:  true);
            mem[1152921535468464656] = val_4;
        }
        
        if(val_4.业丝专世业上丒丒丘() != true)
        {
                val_15 = null;
            val_15 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
            UnityEngine.Vector2 val_6 = NetworkStartTable.万丆丅丁一丒丈丄丗();
            ExperienceController.sharedController.posRanks = val_6;
            ExperienceController.sharedController.__unknownFiledOffset_38 = val_6.y;
        }
        
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_14 = 0;
            val_14 = val_14 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PauseNGUIController::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Pause");
        val_17 = null;
        val_17 = null;
        val_18 = System.Delegate.Combine(a:  丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 + 48, b:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PauseNGUIController::丐专丁丞七与与丞丏()));
        if(丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 == null)
        {
            goto label_26;
        }
        
        if(val_18 != null)
        {
            goto label_27;
        }
        
        goto label_30;
        label_26:
        if(val_18 == null)
        {
            goto label_30;
        }
        
        label_27:
        if(null != null)
        {
                val_18 = 0;
        }
        
        label_30:
        丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三.__unknownFiledOffset_30 = val_18;
    }
    private void 丐专丁丞七与与丞丏()
    {
        this.东东一世专业下丒丌(丙业与丙丗丝不丈东:  下丂世丂不丛专一一.丕丙丛万丒七业丄下(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()));
        if((ControlFireSettings.丈业且丘丈不丄丈丒(丁丅丈丌丟世丗丗丟:  this.丐三不与丅丒丆万且())) != null)
        {
                与丂丏丛丞丞丒丟丄.与丟丂三丄丄丒下三(丙业与丙丗丝不丈东:  (val_4.IsAutoShooting == true) ? 1 : 0);
            与丂丏丛丞丞丒丟丄.且丒丅丘丝上丏丒丏(丙业与丙丗丝不丈东:  val_4.IsAiming);
            与丂丏丛丞丞丒丟丄.专丅万丄专专一丝丑(丙业与丙丗丝不丈东:  val_4.Style);
            丟丌丁且且世丈丈丟.丙丗专东丂丁一一丛(丙业与丙丗丝不丈东:  (val_4.IsLeftHanded == false) ? 1 : 0);
        }
        
        this.且丐丌丞一丞一丕丝();
    }
    private void OnDestroy()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        PauseNGUIController.丄丞丁丈与业上丞丟 = 0;
        val_5 = null;
        val_5 = null;
        val_6 = System.Delegate.Remove(source:  丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 + 48, value:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PauseNGUIController::丐专丁丞七与与丞丏()));
        if(丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 == null)
        {
            goto label_6;
        }
        
        if(val_6 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_6 == null)
        {
            goto label_10;
        }
        
        label_7:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_10:
        丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三.__unknownFiledOffset_30 = val_6;
    }
    private void OnDisable()
    {
        var val_6;
        var val_8;
        var val_9;
        if(this.业丝专世业上丒丒丘() != true)
        {
                val_6 = null;
            val_6 = null;
            ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = System.Delegate.Remove(source:  丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 + 48, value:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void PauseNGUIController::丐专丁丞七与与丞丏()));
        if(丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三 == null)
        {
            goto label_13;
        }
        
        if(val_9 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_9 == null)
        {
            goto label_17;
        }
        
        label_14:
        if(null != null)
        {
                val_9 = 0;
        }
        
        label_17:
        丟丌丁且且世丈丈丟.丁丐业万丐丄丞丐三.__unknownFiledOffset_30 = val_9;
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        if(this.业丝专世业上丒丒丘() == true)
        {
                return;
        }
        
        mem[1152921535469031536] = 1;
    }
    protected override void 与业丞丗丂业丙丌丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        this.与业丞丗丂业丙丌丂(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
        val_3 = null;
        val_3 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        this.resumeButton.gameObject.SetActive(value:  true);
    }
    protected override void 丟丒丙丝三与丁丟丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        this.CancelPositionChanges();
        SetActive(value:  false);
        SetActive(value:  true);
        val_3 = null;
        val_3 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        ExpController.丑七不且上丗丁一世().丟丁专丁丈丕丁一丙(丙业与丙丗丝不丈东:  true);
        this.resumeButton.gameObject.SetActive(value:  true);
    }
    public PauseNGUIController()
    {
    
    }
    private static PauseNGUIController()
    {
    
    }

}
