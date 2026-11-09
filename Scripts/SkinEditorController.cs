using UnityEngine;
public class SkinEditorController : MonoBehaviour
{
    // Fields
    private static System.Action<string> 丑丛丝不丄丗七一丝;
    internal static UnityEngine.Color 丐不三丐丅三丆且丅;
    internal static UnityEngine.Color[] 且与上丄东一丕丏与;
    internal static SkinEditorController.丒上丄丐世世丙丞丐 丝丝丂不且丒丐丌上;
    internal static SkinEditorController.丒上丄丐世世丙丞丐 丐丌丁一丞丁丝丁下;
    public UnityEngine.GameObject topPart;
    public UnityEngine.GameObject downPart;
    public UnityEngine.GameObject leftPart;
    public UnityEngine.GameObject frontPart;
    public UnityEngine.GameObject rigthPart;
    public UnityEngine.GameObject backPart;
    internal static SkinEditorController.丂丒丕东丈丄丄丁丟 丐丁世与三丅丗不一;
    internal static SkinEditorController 丄丞丁丈与业上丞丟;
    public Rilisoft.ButtonHandler saveButton;
    public Rilisoft.ButtonHandler backButton;
    public Rilisoft.ButtonHandler fillButton;
    public Rilisoft.ButtonHandler eraserButton;
    public Rilisoft.ButtonHandler brashButton;
    public Rilisoft.ButtonHandler pencilButton;
    public Rilisoft.ButtonHandler pipetteButton;
    public Rilisoft.ButtonHandler colorButton;
    public Rilisoft.ButtonHandler okColorInPalitraButton;
    public Rilisoft.ButtonHandler setColorButton;
    public Rilisoft.ButtonHandler saveChangesButton;
    public Rilisoft.ButtonHandler cancelInSaveChangesButton;
    public Rilisoft.ButtonHandler okInSaveSkin;
    public Rilisoft.ButtonHandler cancelInSaveSkin;
    public Rilisoft.ButtonHandler yesInLeaveSave;
    public Rilisoft.ButtonHandler noInLeaveSave;
    public Rilisoft.ButtonHandler prevHistoryButton;
    public Rilisoft.ButtonHandler nextHistoryButton;
    public Rilisoft.ButtonHandler yesSaveButtonInEdit;
    public Rilisoft.ButtonHandler noSaveButtonInEdit;
    public Rilisoft.ButtonHandler presetsButton;
    public Rilisoft.ButtonHandler closePresetPanelButton;
    public Rilisoft.ButtonHandler selectPresetButton;
    public Rilisoft.ButtonHandler centeredPresetButton;
    public UnityEngine.GameObject previewPers;
    public UnityEngine.GameObject previewPersShadow;
    public UnityEngine.GameObject skinPreviewPanel;
    public UnityEngine.GameObject partPreviewPanel;
    public UnityEngine.GameObject editorPanel;
    public UnityEngine.GameObject colorPanel;
    public UnityEngine.GameObject saveChangesPanel;
    public UnityEngine.GameObject saveSkinPanel;
    public UnityEngine.GameObject leavePanel;
    public UnityEngine.GameObject savePanelInEditorTexture;
    public UnityEngine.GameObject presetsPanel;
    public string selectedPartName;
    public UnityEngine.GameObject selectedSide;
    internal static UnityEngine.Texture2D 东业丕三且丁与上丂;
    internal static string 业丈下丟世丑丂丙丙;
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, UnityEngine.Rect>> 七丅一丗丌东上不丁;
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D>> 且且丐丘东丑不丐丟;
    public UILabel pensilLabel;
    public UILabel brashLabel;
    public UILabel eraserLabel;
    public UILabel fillLabel;
    public UILabel pipetteLabel;
    public UITexture editorTexture;
    public UISprite oldColor;
    public UISprite newColor;
    public UISprite[] colorHistorySprites;
    public Rilisoft.ButtonHandler[] colorHistoryButtons;
    public UIInput skinNameInput;
    internal static bool 丁世丁丄不丅丙丄丛;
    internal static bool 丐三丌丏下且丏丄丕;
    public bool isSaveAndExit;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丂专东丌丈丒业一丝;
    private string 丁东上丗丌丝一丛七;
    public UISprite[] colorOnBrashSprites;
    public FrameResizer frameResizer;
    public UIWrapContent skinPresentsWrap;
    private System.Collections.Generic.List<string> 上业下丁丐丂世丈业;
    private CharacterInterfaceV2 东丗丏世丑与丌丒丄;
    private bool 丒丙与丙丅七七一世;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    private System.Collections.Generic.List<string> 且一丗丛丐丏丌专丞 { get; set; }
    
    // Methods
    internal static void 丒丛七丘丙一东丛东(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  SkinEditorController.丑丛丝不丄丗七一丝, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丄七丌丄专东东七丑(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  SkinEditorController.丑丛丝不丄丗七一丝, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    private System.Collections.Generic.List<string> 不丝专下丄丈丒丑丅()
    {
        if(this.上业下丁丐丂世丈业 != null)
        {
                return val_1;
        }
        
        System.Collections.Generic.List<System.String> val_1 = SkinsController.东下东上丙丏七下上();
        this.上业下丁丐丂世丈业 = val_1;
        return val_1;
    }
    private void 丆丈丘丂丄三万丌丌(System.Collections.Generic.List<string> 丙业与丙丗丝不丈东)
    {
        this.上业下丁丐丂世丈业 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        UnityEngine.GameObject val_12;
        var val_13;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Character_model_V2");
        if(val_1 != null)
        {
                var val_2 = (null == 1152921504834002944) ? (val_1) : 0;
        }
        else
        {
                val_12 = 0;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(x:  0f, y:  158.15f, z:  0f);
        CharacterInterfaceV2 val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_12, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}).GetComponent<CharacterInterfaceV2>();
        this.东丗丏世丑与丌丒丄 = val_6;
        val_6.transform.SetParent(parent:  this.previewPers.transform, worldPositionStays:  false);
        this.东丗丏世丑与丌丒丄.丅丈丅丟万丄丙丅丒();
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.东丗丏世丑与丌丒丄.gameObject);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.东丗丏世丑与丌丒丄.gameObject, 不东丛三丂丌丑专丆:  this.previewPers.layer);
        val_13 = null;
        val_13 = null;
        SkinEditorController.丄丞丁丈与业上丞丟 = this;
    }
    private void Start()
    {
        UnityEngine.Color val_103;
        float val_104;
        var val_105;
        var val_106;
        var val_107;
        var val_108;
        var val_109;
        var val_110;
        var val_111;
        var val_112;
        丙丏丒丐丑三丆丝世 val_113;
        SkinEditorController.丝丝丂不且丒丐丌上 = 0;
        SkinEditorController.丐三丌丏下且丏丄丕 = false;
        SkinEditorController.丁世丁丄不丅丙丄丛 = false;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.业丌丘世丞丙且下上(丞下上且一上丙不丏:  this.GetComponent<UnityEngine.AudioSource>());
        if(ExperienceController.sharedController != 0)
        {
                ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        
        float val_3 = UnityEngine.PlayerPrefs.GetFloat(key:  "ColorForPaintR", defaultValue:  0f);
        float val_4 = UnityEngine.PlayerPrefs.GetFloat(key:  "ColorForPaintG", defaultValue:  1f);
        float val_5 = UnityEngine.PlayerPrefs.GetFloat(key:  "ColorForPaintB", defaultValue:  0f);
        SkinEditorController.丐不三丐丅三丆且丅 = 0;
        SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C = 0;
        SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14 = 0;
        this.colorButton.gameObject.GetComponent<UIButton>().defaultColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        val_103 = SkinEditorController.丐不三丐丅三丆且丅;
        val_104 = 0f;
        val_105 = 0f;
        val_106 = 0f;
        this.okColorInPalitraButton.gameObject.GetComponent<UIButton>().defaultColor = new UnityEngine.Color() {r = 0f, g = 0f, b = val_104, a = 0f};
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        goto label_26;
        label_33:
        val_103 = SkinEditorController.丐不三丐丅三丆且丅;
        val_104 = 0f;
        val_105 = 0f;
        val_106 = 0f;
        this.colorOnBrashSprites[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = val_104, a = 0f};
        label_26:
        if(1 < this.colorOnBrashSprites.Length)
        {
            goto label_33;
        }
        
        if(SkinEditorController.丐丁世与三丅丗不一 != 0)
        {
            goto label_36;
        }
        
        if(SkinEditorController.业丈下丟世丑丂丙丙 == null)
        {
            goto label_39;
        }
        
        SkinEditorController.东业丕三且丁与上丂 = SkinsController.与业七丙三三万丕上.Item[SkinEditorController.业丈下丟世丑丂丙丙];
        if((SkinsController.丛上不下丐丐丞丒专.ContainsKey(key:  SkinEditorController.业丈下丟世丑丂丙丙)) == false)
        {
            goto label_46;
        }
        
        string val_12 = SkinsController.丛上不下丐丐丞丒专.Item[SkinEditorController.业丈下丟世丑丂丙丙];
        if(this.skinNameInput != null)
        {
            goto label_53;
        }
        
        goto label_53;
        label_39:
        UnityEngine.Object val_13 = UnityEngine.Resources.Load(path:  "Clear_Skin");
        if(val_13 != null)
        {
                var val_14 = (null == null) ? (val_13) : 0;
        }
        
        SkinEditorController.东业丕三且丁与上丂 = 0;
        SkinEditorController.东业丕三且丁与上丂.filterMode = 0;
        label_53:
        this.skinNameInput.value = "";
        label_46:
        UnityEngine.Debug.Log(message:  "modeEditor== ModeEditor.SkinPers");
        this.partPreviewPanel.SetActive(value:  false);
        this.skinPreviewPanel.SetActive(value:  true);
        this.editorPanel.SetActive(value:  false);
        this.丂专东丌丈丒业一丝.Add(item:  this.previewPers);
        this.丂专东丌丈丒业一丝.Add(item:  this.previewPersShadow);
        this.万丅丒一丁丄上丞世();
        label_36:
        if(SkinEditorController.丐丁世与三丅丗不一 != 1)
        {
                if(SkinEditorController.丐丁世与三丅丗不一 != 2)
        {
            goto label_72;
        }
        
        }
        
        if(SkinEditorController.丐丁世与三丅丗不一 != 1)
        {
            goto label_75;
        }
        
        if(SkinsController.丌七丞东丟丌世且不 != 0)
        {
            goto label_91;
        }
        
        goto label_81;
        label_75:
        if(SkinEditorController.东业丕三且丁与上丂 != 0)
        {
            goto label_86;
        }
        
        if(SkinsController.丄丞上丟专丘丒丝不 != 0)
        {
            goto label_91;
        }
        
        label_81:
        label_91:
        SkinEditorController.东业丕三且丁与上丂 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  "Clan_Previews/icon_clan_001"));
        label_86:
        this.partPreviewPanel.SetActive(value:  false);
        this.skinPreviewPanel.SetActive(value:  false);
        this.editorPanel.SetActive(value:  true);
        this.editorTexture.gameObject.GetComponent<EditorTextures>().SetStartCanvas(丞丝丈丑丐丝丌丛丆:  SkinEditorController.东业丕三且丁与上丂);
        label_72:
        this.savePanelInEditorTexture.SetActive(value:  false);
        SkinsController.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  this.previewPers, 丐丅丁丂丐下丘世丄:  SkinEditorController.东业丕三且丁与上丂, 丕丂丝丗丈三与东专:  0);
        this.previewPers.丗丂上专丗业丕丘丕();
        this.UpdateTexturesPartsInDictionary();
        this.colorPanel.SetActive(value:  false);
        this.saveChangesPanel.SetActive(value:  false);
        this.saveSkinPanel.SetActive(value:  false);
        this.leavePanel.SetActive(value:  false);
        if(this.topPart != 0)
        {
                Rilisoft.ButtonHandler val_23 = this.topPart.GetComponent<Rilisoft.ButtonHandler>();
            if(val_23 != 0)
        {
                val_23.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丘丄且丏丗业丌丆不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.downPart != 0)
        {
                Rilisoft.ButtonHandler val_27 = this.downPart.GetComponent<Rilisoft.ButtonHandler>();
            if(val_27 != 0)
        {
                val_27.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丘丄且丏丗业丌丆不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.leftPart != 0)
        {
                Rilisoft.ButtonHandler val_31 = this.leftPart.GetComponent<Rilisoft.ButtonHandler>();
            if(val_31 != 0)
        {
                val_31.add_Clicked(丙业与丙丗丝不丈东:  new System.Boolean(object:  this, method:  System.Void SkinEditorController::丘丄且丏丗业丌丆不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.frontPart != 0)
        {
                Rilisoft.ButtonHandler val_35 = this.frontPart.GetComponent<Rilisoft.ButtonHandler>();
            if(val_35 != 0)
        {
                val_35.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丘丄且丏丗业丌丆不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.rigthPart != 0)
        {
                Rilisoft.ButtonHandler val_39 = this.rigthPart.GetComponent<Rilisoft.ButtonHandler>();
            if(val_39 != 0)
        {
                val_39.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丘丄且丏丗业丌丆不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.backPart != 0)
        {
                Rilisoft.ButtonHandler val_43 = this.backPart.GetComponent<Rilisoft.ButtonHandler>();
            if(val_43 != 0)
        {
                val_43.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丘丄且丏丗业丌丆不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.saveButton != 0)
        {
                this.saveButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::专丞丕专下专东丆丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.backButton != 0)
        {
                this.backButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丆丞丟三丟下三丆丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.fillButton != 0)
        {
                this.fillButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::下丐专业下一丗专丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.brashButton != 0)
        {
                this.brashButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::下丐专业下一丗专丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.pencilButton != 0)
        {
                this.pencilButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::下丐专业下一丗专丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.pipetteButton != 0)
        {
                this.pipetteButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::下丐专业下一丗专丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.eraserButton != 0)
        {
                this.eraserButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::下丐专业下一丗专丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.colorButton != 0)
        {
                this.colorButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丛丐丙世丌丕丏专七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.setColorButton != 0)
        {
                this.setColorButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void SkinEditorController::HandleSetColorClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.saveChangesButton != 0)
        {
                val_107 = this.saveChangesButton.GetComponent<Rilisoft.DialogEscape>();
            if(val_107 == null)
        {
                val_107 = this.saveChangesButton.gameObject.AddComponent<Rilisoft.DialogEscape>();
        }
        
            val_107.Context = "Save Skin Changes Dialog";
            this.saveChangesButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丅与下丈世下一且丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.cancelInSaveChangesButton != 0)
        {
                this.cancelInSaveChangesButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::世丝世世东三丐丑丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.okInSaveSkin != 0)
        {
                val_108 = this.okInSaveSkin.GetComponent<Rilisoft.DialogEscape>();
            if(val_108 == null)
        {
                val_108 = this.okInSaveSkin.gameObject.AddComponent<Rilisoft.DialogEscape>();
        }
        
            val_108.Context = "Save Skin as... Dialog";
            this.okInSaveSkin.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丌与丗且丆三七三丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.cancelInSaveSkin != 0)
        {
                this.cancelInSaveSkin.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::上业丑与丘丁业上丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.yesInLeaveSave != 0)
        {
                val_109 = this.yesInLeaveSave.GetComponent<Rilisoft.DialogEscape>();
            if(val_109 == null)
        {
                val_109 = this.yesInLeaveSave.gameObject.AddComponent<Rilisoft.DialogEscape>();
        }
        
            val_109.Context = "Save Skin Dialog";
            this.yesInLeaveSave.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丅丝东与丈丘丛不丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.noInLeaveSave != 0)
        {
                this.noInLeaveSave.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丘丑上丞业丅丝且下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.yesSaveButtonInEdit != 0)
        {
                val_110 = this.yesSaveButtonInEdit.GetComponent<Rilisoft.DialogEscape>();
            if(val_110 == null)
        {
                val_110 = this.yesSaveButtonInEdit.gameObject.AddComponent<Rilisoft.DialogEscape>();
        }
        
            val_110.Context = "Save Cape Dialog";
            this.yesSaveButtonInEdit.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丛一且丁且上三丕且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.noSaveButtonInEdit != 0)
        {
                this.noSaveButtonInEdit.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::东丝丘丂专一三丕丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        val_111 = 0;
        goto label_247;
        label_252:
        this.colorHistoryButtons[0].add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void SkinEditorController::HandleSetHistoryColorClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        val_111 = 1;
        label_247:
        if(val_111 < this.colorHistoryButtons.Length)
        {
            goto label_252;
        }
        
        if(this.presetsButton != 0)
        {
                this.presetsButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::世丛丟上一七丝丛业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.closePresetPanelButton != 0)
        {
                this.closePresetPanelButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丘不上世七一丑丐丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.selectPresetButton != 0)
        {
                this.selectPresetButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丑与与上下万丄丆丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.centeredPresetButton != 0)
        {
                this.centeredPresetButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void SkinEditorController::丑与与上下万丄丆丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        val_112 = null;
        val_112 = null;
        this.丕东丐丑丞丕丕丗不(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        this.丄七且专一丟丑丂东();
        this.丅丝丕东与与丞业东();
        val_113 = System.Delegate.Combine(a:  this.skinPresentsWrap.onInitializeItem, b:  new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SkinEditorController::丝七丞丆丏与七丄上(UnityEngine.GameObject 万且万且丑丗且丌丆, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)));
        if(this.skinPresentsWrap == null)
        {
            goto label_272;
        }
        
        if(val_113 != null)
        {
            goto label_273;
        }
        
        goto label_276;
        label_272:
        if(val_113 == null)
        {
            goto label_276;
        }
        
        label_273:
        if(null != null)
        {
                val_113 = 0;
        }
        
        label_276:
        this.skinPresentsWrap.onInitializeItem = val_113;
    }
    private void 丝七丞丆丏与七丄上(UnityEngine.GameObject 万且万且丑丗且丌丆, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)
    {
        var val_9;
        WrapIndex val_1 = 万且万且丑丗且丌丆.GetComponent<WrapIndex>();
        val_1.myIndex = 丞丂业丅丟丙丏七丗;
        val_9 = null;
        val_9 = null;
        SkinsController.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  万且万且丑丗且丌丆.transform.GetChild(index:  0).GetChild(index:  0).gameObject, 丐丅丁丂丐下丘世丄:  SkinsController.与业七丙三三万丕上.Item[this.不丝专下丄丈丒丑丅().Item[丞丂业丅丟丙丏七丗]], 丕丂丝丗丈三与东专:  0);
    }
    private void 丅丝丕东与与丞业东()
    {
        this.上业下丁丐丂世丈业 = SkinsController.东下东上丙丏七下上();
        this.skinPresentsWrap.maxIndex = this.不丝专下丄丈丒丑丅().Count - 1;
    }
    private void 丞丌丛丙专与丑与丗()
    {
        var val_24;
        this.丆丗丞丈丈业丐业一();
        if(this.丒丙与丙丅七七一世 == true)
        {
            goto label_1;
        }
        
        this.丒丙与丙丅七七一世 = true;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Character_model_V2");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        
        val_24 = 0;
        goto label_4;
        label_29:
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        CharacterInterfaceV2 val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  0, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}).GetComponent<CharacterInterfaceV2>();
        val_6.transform.SetParent(parent:  this.skinPresentsWrap.transform.GetChild(index:  0).GetChild(index:  0).GetChild(index:  0), worldPositionStays:  false);
        if(val_6 != null)
        {
                val_6.丛丟三东丈丐丈丁东();
        }
        else
        {
                val_6.丛丟三东丈丐丈丁东();
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_6.gameObject);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_6.gameObject, 不东丛三丂丌丑专丆:  this.skinPresentsWrap.transform.GetChild(index:  0).gameObject.layer);
        val_24 = 1;
        label_4:
        if(val_24 < this.skinPresentsWrap.transform.childCount)
        {
            goto label_29;
        }
        
        label_1:
        this.presetsPanel.SetActive(value:  true);
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SkinEditorController::丟丕丁丂丞万丏且丆()), 与且专丈不万东一万:  "Skin Editor Presets Window");
    }
    private void 世丛丟上一七丝丛业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丞丌丛丙专与丑与丗();
    }
    private void 丘不上世七一丑丐丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.万丅丒一丁丄上丞世();
        this.presetsPanel.SetActive(value:  false);
        this.OnEnable();
    }
    private void 丑与与上下万丄丆丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        UnityEngine.GameObject val_2 = this.skinPresentsWrap.GetComponent<MyCenterOnChild>().centeredObject;
        if(val_2 == 0)
        {
                return;
        }
        
        this.丈丑丟丂与丟丈与与(万且万且丑丗且丌丆:  val_2);
        this.丘不上世七一丑丐丟(不丟丗丏丛丕不丁丌:  val_2, 丗丛不丁丑专专丂且:  0);
    }
    private void 丈丑丟丂与丟丈与与(UnityEngine.GameObject 万且万且丑丗且丌丆)
    {
        if((万且万且丑丗且丌丆.GetComponent<WrapIndex>()) == 0)
        {
                return;
        }
        
        this.丈丑丟丂与丟丈与与(丞世不丒下上上丝丑:  val_1.myIndex);
    }
    private void 丈丑丟丂与丟丈与与(int 丞世不丒下上上丝丑)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        SkinEditorController.东业丕三且丁与上丂 = SkinsController.与业七丙三三万丕上.Item[this.不丝专下丄丈丒丑丅().Item[丞世不丒下上上丝丑]];
        SkinsController.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  this.previewPers, 丐丅丁丂丐下丘世丄:  SkinEditorController.东业丕三且丁与上丂, 丕丂丝丗丈三与东专:  0);
        this.previewPers.丗丂上专丗业丕丘丕();
        this.UpdateTexturesPartsInDictionary();
    }
    private void 丛一且丁且上三丕且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_1;
        var val_9;
        UnityEngine.Texture2D val_10;
        long val_11;
        var val_12;
        var val_13;
        UnityEngine.Texture2D val_14;
        var val_15;
        System.EventArgs val_16;
        val_9 = null;
        val_9 = null;
        if(SkinEditorController.丐丁世与三丅丗不一 == 2)
        {
                UnityEngine.Debug.Log(message:  "modeEditor==ModeEditor.LogoClan");
            val_10 = this.editorTexture;
            if((val_10 != null) && (null != null))
        {
                val_10 = 0;
        }
        
            val_11 = 0;
            val_12 = 1152921505039646720;
            val_13 = null;
            val_13 = null;
            SkinsController.丄丞上丟专丘丒丝不 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_10);
            val_9 = null;
        }
        
        val_9 = null;
        if(SkinEditorController.丐丁世与三丅丗不一 == 1)
        {
                val_14 = this.editorTexture;
            if((val_14 != null) && (null != null))
        {
                val_14 = 0;
        }
        
            val_15 = null;
            val_15 = null;
            SkinsController.丌七丞东丟丌世且不 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_14);
            System.DateTime val_5 = System.DateTime.UtcNow;
            long val_6 = val_5.dateData.Ticks;
            val_1 = 0;
            val_12 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_11 = 0;
            val_12.丟七丒与丘丌丛丅丏(丞丅上丏丂且下丅与:  val_11, 丒丘丏上丙丟丑丕丈:  "", 丑丞丈丗丄丙丟万丄:  SkinsController.StringFromTexture(三与丕丘丌丈一丆七:  SkinsController.丌七丞东丟丌世且不));
            val_9 = null;
        }
        
        val_9 = null;
        SkinEditorController.丁世丁丄不丅丙丄丛 = false;
        if(SkinEditorController.丐丁世与三丅丗不一 != 2)
        {
            goto label_26;
        }
        
        丒丟丕七丑丞不七丒 val_8 = null;
        val_16 = val_8;
        val_8 = new 丒丟丕七丑丞不七丒();
        val_11 = 1;
        val_8.丟不丏业丌丐丟丏丌(丙业与丙丗丝不丈东:  true);
        if(this != null)
        {
            goto label_30;
        }
        
        goto label_29;
        label_26:
        val_16 = 0;
        if(this != null)
        {
            goto label_30;
        }
        
        label_29:
        label_30:
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  val_11, 丗丛不丁丑专专丂且:  val_16);
    }
    private void 东丝丘丂专一三丕丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SkinEditorController.丁世丁丄不丅丙丄丛 = false;
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  0);
    }
    private void 丌与丗且丆三七三丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_5;
        this.万丅丒一丁丄上丞世();
        val_5 = null;
        val_5 = null;
        string val_3 = SkinsController.丒业丒丑上丆丙丌与(丅东丆丕丝丁世丈丁:  丞东丑专丛丆丄丝世.丁丈丛且丟丘丂丙万(丙业与丙丗丝不丈东:  this.skinNameInput.value), 三与丕丘丌丈一丆七:  SkinEditorController.东业丕三且丁与上丂, 丆七丄丁丆东丄丙丒:  SkinEditorController.业丈下丟世丑丂丙丙);
        this.丁东上丗丌丝一丛七 = val_3;
        SkinsController.丙丘与万业丒丁丆丛(丒丘丏上丙丟丑丕丈:  val_3);
        SkinEditorController.丐三丌丏下且丏丄丕 = false;
        this.saveSkinPanel.SetActive(value:  false);
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
        if((System.String.op_Inequality(a:  SkinEditorController.业丈下丟世丑丂丙丙, b:  val_3)) == false)
        {
                return;
        }
        
        Rilisoft.丝丄三业丙专丛与不.东三丆丁三下七丑上(丝丏业丅丈东业丝丒:  "create_custom_skin", 丗丟上上丒丐丗丞丙:  0);
    }
    private void 上业丑与丘丁业上丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        UnityEngine.GameObject val_1;
        var val_2;
        if(this.isSaveAndExit != false)
        {
                this.saveSkinPanel.SetActive(value:  false);
            val_1 = this.leavePanel;
            val_2 = 1;
        }
        else
        {
                this.万丅丒一丁丄上丞世();
            val_1 = this.saveSkinPanel;
            val_2 = 0;
        }
        
        val_1.SetActive(value:  false);
    }
    private void 丅丝东与丈丘丛不丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.leavePanel.SetActive(value:  false);
        this.saveSkinPanel.SetActive(value:  true);
        this.isSaveAndExit = true;
    }
    private void 丘丑上丞业丅丝且下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SkinEditorController.丐三丌丏下且丏丄丕 = false;
        this.万丅丒一丁丄上丞世();
        this.leavePanel.SetActive(value:  false);
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    internal void 业业丘丟丒丗一丙丗()
    {
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  0);
    }
    private void 万丅丒一丁丄上丞世()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.丂专东丌丈丒业一丝.GetEnumerator();
        label_4:
        if((835818800 & 1) == 0)
        {
            goto label_2;
        }
        
        val_3.丐丏七丌丕丗业且上().SetActive(value:  true);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UIButton val_6 = this.backButton.gameObject.GetComponent<UIButton>();
        UIButton val_8 = this.saveButton.gameObject.GetComponent<UIButton>();
        if((this.presetsButton.gameObject.GetComponent<UIButton>()) != null)
        {
                return;
        }
    
    }
    private void 丆丗丞丈丈业丐业一()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.丂专东丌丈丒业一丝.GetEnumerator();
        label_4:
        if((836020912 & 1) == 0)
        {
            goto label_2;
        }
        
        val_3.丐丏七丌丕丗业且上().SetActive(value:  false);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UIButton val_6 = this.backButton.gameObject.GetComponent<UIButton>();
        UIButton val_8 = this.saveButton.gameObject.GetComponent<UIButton>();
        if((this.presetsButton.gameObject.GetComponent<UIButton>()) != null)
        {
                return;
        }
    
    }
    private void 丅与下丈世下一且丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SkinEditorController.丁世丁丄不丅丙丄丛 = false;
        SkinEditorController.丐三丌丏下且丏丄丕 = true;
        this.saveChangesPanel.SetActive(value:  false);
        this.不东一三业与与一丝(专三丆丗丆三丘万东:  this.selectedPartName);
        SkinEditorController.东业丕三且丁与上丂 = SkinEditorController.万丗一一与业丗丒丆(丘七丛一丄丐且业丗:  SkinEditorController.且且丐丘东丑不丐丟);
        SkinsController.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  this.previewPers, 丐丅丁丂丐下丘世丄:  SkinEditorController.东业丕三且丁与上丂, 丕丂丝丗丈三与东专:  0);
        this.UpdateTexturesPartsInDictionary();
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  SkinEditorController.东业丕三且丁与上丂, 丗丛不丁丑专专丂且:  0);
    }
    private void 世丝世世东三丐丑丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        null = null;
        SkinEditorController.丁世丁丄不丅丙丄丛 = false;
        this.saveChangesPanel.SetActive(value:  false);
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
    }
    private void 丛丐丙世丌丕丏专七(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        var val_4;
        this.SetColorClickedUp();
        this.editorPanel.SetActive(value:  false);
        this.colorPanel.SetActive(value:  true);
        val_3 = null;
        val_3 = null;
        this.oldColor.color = new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14};
        this.newColor.color = new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14};
        UIButton val_2 = this.okColorInPalitraButton.gameObject.GetComponent<UIButton>();
        val_2.defaultColor = new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14};
        val_4 = null;
        if(val_2 == null)
        {
                val_4 = null;
        }
        
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
    }
    private void 七丕丕丐丞七东丑七(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        var val_5;
        var val_6;
        float val_7;
        float val_8;
        var val_9;
        float val_10;
        var val_11;
        var val_12;
        val_5 = null;
        val_5 = null;
        SkinEditorController.丐不三丐丅三丆且丅 = 丑丞丈丗丄丙丟万丄.r;
        SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C = 丑丞丈丗丄丙丟万丄.g;
        SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10 = 丑丞丈丗丄丙丟万丄.b;
        SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14 = 丑丞丈丗丄丙丟万丄.a;
        UIButton val_2 = this.colorButton.gameObject.GetComponent<UIButton>();
        val_2.defaultColor = new UnityEngine.Color() {r = SkinEditorController.丐不三丐丅三丆且丅, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14};
        val_6 = null;
        if(val_2 == null)
        {
                val_6 = null;
        }
        
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        UIButton val_4 = this.okColorInPalitraButton.gameObject.GetComponent<UIButton>();
        val_7 = SkinEditorController.丐不三丐丅三丆且丅;
        val_8 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        val_4.defaultColor = new UnityEngine.Color() {r = val_7, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = val_8, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14};
        val_9 = null;
        if(val_4 == null)
        {
                val_9 = null;
        }
        
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        val_10 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C;
        if(val_4 == null)
        {
                val_9 = null;
        }
        
        mem2[0] = SkinEditorController.丐不三丐丅三丆且丅;
        mem2[0] = val_10;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        mem2[0] = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14;
        UnityEngine.PlayerPrefs.SetFloat(key:  "ColorForPaintR", value:  SkinEditorController.丐不三丐丅三丆且丅);
        UnityEngine.PlayerPrefs.SetFloat(key:  "ColorForPaintG", value:  SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C);
        UnityEngine.PlayerPrefs.SetFloat(key:  "ColorForPaintB", value:  SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10);
        val_11 = 0;
        goto label_13;
        label_20:
        val_10 = 0;
        val_12 = null;
        val_12 = null;
        val_7 = SkinEditorController.丐不三丐丅三丆且丅;
        val_8 = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_10;
        this.colorOnBrashSprites[val_10].color = new UnityEngine.Color() {r = val_7, g = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C, b = val_8, a = SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14};
        val_11 = 1;
        label_13:
        if(val_11 < this.colorOnBrashSprites.Length)
        {
            goto label_20;
        }
    
    }
    private void 丄七且专一丟丑丂东()
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = 0;
        goto label_1;
        label_29:
        val_7 = null;
        val_7 = null;
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        this.colorHistoryButtons[0].gameObject.SetActive(value:  UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = SkinEditorController.且与上丄东一丕丏与.Length + 32, g = SkinEditorController.且与上丄东一丕丏与.Length + 32 + 4, b = SkinEditorController.且与上丄东一丕丏与.Length + 40, a = SkinEditorController.且与上丄东一丕丏与.Length + 40 + 4}, rhs:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}));
        this.colorHistorySprites[0].color = new UnityEngine.Color() {r = SkinEditorController.且与上丄东一丕丏与.Length + 32, g = SkinEditorController.且与上丄东一丕丏与.Length + 32 + 4, b = SkinEditorController.且与上丄东一丕丏与.Length + 40, a = SkinEditorController.且与上丄东一丕丏与.Length + 40 + 4};
        this.colorHistoryButtons[0].GetComponent<UIButton>().defaultColor = new UnityEngine.Color() {r = SkinEditorController.且与上丄东一丕丏与.Length + 32, g = SkinEditorController.且与上丄东一丕丏与.Length + 32 + 4, b = SkinEditorController.且与上丄东一丕丏与.Length + 40, a = SkinEditorController.且与上丄东一丕丏与.Length + 40 + 4};
        mem2[0] = SkinEditorController.且与上丄东一丕丏与.Length + 32;
        mem2[0] = SkinEditorController.且与上丄东一丕丏与.Length + 32 + 4;
        mem2[0] = SkinEditorController.且与上丄东一丕丏与.Length + 40;
        mem2[0] = SkinEditorController.且与上丄东一丕丏与.Length + 40 + 4;
        val_6 = 1;
        mem2[0] = SkinEditorController.且与上丄东一丕丏与.Length + 32;
        mem2[0] = SkinEditorController.且与上丄东一丕丏与.Length + 36;
        mem2[0] = SkinEditorController.且与上丄东一丕丏与.Length + 44;
        label_1:
        val_8 = null;
        val_8 = null;
        if(val_6 < SkinEditorController.且与上丄东一丕丏与.Length)
        {
            goto label_29;
        }
        
        this.frameResizer.ResizeFrame();
    }
    private void 丕东丐丑丞丕丕丗不(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.Color[] val_8;
        var val_9;
        this.七丕丕丐丞七东丑七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
        var val_5 = 0;
        label_9:
        val_5 = null;
        val_5 = null;
        if(val_5 >= SkinEditorController.且与上丄东一丕丏与.Length)
        {
            goto label_4;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = val_5 + 1;
        if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = SkinEditorController.且与上丄东一丕丏与.Length + 32, g = SkinEditorController.且与上丄东一丕丏与.Length + 32 + 4, b = SkinEditorController.且与上丄东一丕丏与.Length + 40, a = SkinEditorController.且与上丄东一丕丏与.Length + 40 + 4}, rhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a})) == false)
        {
            goto label_9;
        }
        
        return;
        label_4:
        val_7 = 1;
        goto label_10;
        label_21:
        val_8 = SkinEditorController.且与上丄东一丕丏与;
        if(SkinEditorController.且与上丄东一丕丏与 == null)
        {
                val_8 = SkinEditorController.且与上丄东一丕丏与;
        }
        
        int val_6 = SkinEditorController.且与上丄东一丕丏与.Length;
        val_6 = (-2) + val_6;
        UnityEngine.Color[] val_2 = val_8 + (((long)(int)((-2 + SkinEditorController.且与上丄东一丕丏与.Length))) << 4);
        int val_3 = (-2) + SkinEditorController.且与上丄东一丕丏与.Length;
        val_3 = val_3 + 1;
        UnityEngine.Color[] val_4 = SkinEditorController.且与上丄东一丕丏与 + (((long)(int)(((-2 + SkinEditorController.且与上丄东一丕丏与.Length) + 1))) << 4);
        val_7 = 2;
        (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)(((-2 + SkinEditorController.且与上丄东一丕丏与.Length) + 1))) << 4).__unknownFiledOffset_20 = (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)((-2 + SkinEditorController.且与上丄东一丕丏与.Length))) << 4) + 32;
        (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)(((-2 + SkinEditorController.且与上丄东一丕丏与.Length) + 1))) << 4).__unknownFiledOffset_24 = (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)((-2 + SkinEditorController.且与上丄东一丕丏与.Length))) << 4) + 32 + 4;
        (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)(((-2 + SkinEditorController.且与上丄东一丕丏与.Length) + 1))) << 4).__unknownFiledOffset_28 = (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)((-2 + SkinEditorController.且与上丄东一丕丏与.Length))) << 4) + 40;
        (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)(((-2 + SkinEditorController.且与上丄东一丕丏与.Length) + 1))) << 4).__unknownFiledOffset_2C = (SkinEditorController.且与上丄东一丕丏与 + ((long)(int)((-2 + SkinEditorController.且与上丄东一丕丏与.Length))) << 4) + 40 + 4;
        label_10:
        val_9 = null;
        val_9 = null;
        if(SkinEditorController.且与上丄东一丕丏与 == null)
        {
                val_9 = null;
        }
        
        if(val_7 < SkinEditorController.且与上丄东一丕丏与.Length)
        {
            goto label_21;
        }
        
        val_9 = null;
        SkinEditorController.且与上丄东一丕丏与.__unknownFiledOffset_20 = 丑丞丈丗丄丙丟万丄.r;
        SkinEditorController.且与上丄东一丕丏与.__unknownFiledOffset_24 = 丑丞丈丗丄丙丟万丄.g;
        SkinEditorController.且与上丄东一丕丏与.__unknownFiledOffset_28 = 丑丞丈丗丄丙丟万丄.b;
        SkinEditorController.且与上丄东一丕丏与.__unknownFiledOffset_2C = 丑丞丈丗丄丙丟万丄.a;
        this.丄七且专一丟丑丂东();
    }
    public void HandleSetColorClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.editorPanel.SetActive(value:  true);
        this.colorPanel.SetActive(value:  false);
        UnityEngine.Color val_1 = this.newColor.color;
        this.丕东丐丑丞丕丕丗不(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
    }
    public void HandleSetHistoryColorClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        var val_3;
        val_2 = 0;
        goto label_1;
        label_11:
        if((this.colorHistoryButtons[0].Equals(other:  不丟丗丏丛丕不丁丌)) != false)
        {
                val_3 = null;
            val_3 = null;
            this.七丕丕丐丞七东丑七(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = SkinEditorController.且与上丄东一丕丏与.Length + 32, g = SkinEditorController.且与上丄东一丕丏与.Length + 32 + 4, b = SkinEditorController.且与上丄东一丕丏与.Length + 40, a = SkinEditorController.且与上丄东一丕丏与.Length + 40 + 4});
        }
        
        val_2 = 1;
        label_1:
        if(val_2 < this.colorHistoryButtons.Length)
        {
            goto label_11;
        }
    
    }
    public void SetColorClickedUp()
    {
        if(SkinEditorController.丝丝丂不且丒丐丌上 != 4)
        {
                return;
        }
        
        null = null;
        SkinEditorController.丝丝丂不且丒丐丌上 = SkinEditorController.丐丌丁一丞丁丝丁下;
        if(SkinEditorController.丝丝丂不且丒丐丌上 > 3)
        {
                return;
        }
        
        var val_7 = 106023760 + (SkinEditorController.丐丌丁一丞丁丝丁下) << 2;
        val_7 = val_7 + 106023760;
        goto (106023760 + (SkinEditorController.丐丌丁一丞丁丝丁下) << 2 + 106023760);
    }
    private void 下丐专业下一丗专丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_9;
        object val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        丒上丄丐世世丙丞丐 val_17;
        if(不丟丗丏丛丕不丁丌 != null)
        {
                val_9 = null;
            val_9 = null;
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (UnityEngine.MonoBehaviour.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_9) ? 不丟丗丏丛丕不丁丌 : 0;
        }
        
        val_10 = 0.gameObject.name;
        UnityEngine.Debug.Log(message:  val_10);
        if((val_10.Equals(value:  "Fill")) != false)
        {
                val_11 = null;
            val_11 = null;
            SkinEditorController.丝丝丂不且丒丐丌上 = 3;
        }
        
        if((val_10.Equals(value:  "Brash")) != false)
        {
                val_12 = null;
            val_12 = null;
            SkinEditorController.丝丝丂不且丒丐丌上 = 1;
        }
        
        if((val_10.Equals(value:  "Pencil")) != false)
        {
                val_13 = null;
            val_13 = null;
            SkinEditorController.丝丝丂不且丒丐丌上 = 0;
        }
        
        if((val_10.Equals(value:  "Eraser")) != false)
        {
                val_14 = null;
            val_14 = null;
            SkinEditorController.丝丝丂不且丒丐丌上 = 2;
        }
        
        if((val_10.Equals(value:  "Pipette")) == false)
        {
                return;
        }
        
        val_10 = 1152921505296302080;
        val_15 = null;
        val_15 = null;
        val_17 = SkinEditorController.丝丝丂不且丒丐丌上;
        if(val_17 != 4)
        {
                val_15 = null;
            val_17 = SkinEditorController.丝丝丂不且丒丐丌上;
            SkinEditorController.丐丌丁一丞丁丝丁下 = val_17;
        }
        
        val_15 = null;
        SkinEditorController.丝丝丂不且丒丐丌上 = 4;
    }
    private void 丘丄且丏丗业丌丆不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_9;
        UnityEngine.Texture2D val_10;
        if(不丟丗丏丛丕不丁丌 != null)
        {
                val_9 = null;
            val_9 = null;
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (UnityEngine.MonoBehaviour.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_9) ? 不丟丗丏丛丕不丁丌 : 0;
        }
        
        this.selectedSide = 0.gameObject;
        this.editorPanel.SetActive(value:  true);
        this.partPreviewPanel.SetActive(value:  false);
        EditorTextures val_4 = this.editorTexture.gameObject.GetComponent<EditorTextures>();
        val_10 = this.selectedSide.transform.GetChild(index:  0).GetComponent<UITexture>();
        if(val_4 == null)
        {
            goto label_14;
        }
        
        if(val_10 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_10 == null)
        {
            goto label_18;
        }
        
        label_15:
        if(null != null)
        {
                val_10 = 0;
        }
        
        label_18:
        val_4.SetStartCanvas(丞丝丈丑丐丝丌丛丆:  val_10);
    }
    private void 专丞丕专下专东丆丅(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.isSaveAndExit = false;
        this.saveSkinPanel.SetActive(value:  true);
        this.丆丗丞丈丈业丐业一();
    }
    private void 丆丞丟三丟下三丆丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        System.EventArgs val_31;
        var val_32;
        var val_33;
        var val_35;
        var val_37;
        丂丒丕东丈丄丄丁丟 val_38;
        UnityEngine.GameObject val_39;
        var val_40;
        var val_41;
        UnityEngine.Texture2D val_42;
        val_31 = 丗丛不丁丑专专丂且;
        val_32 = this;
        if(this.partPreviewPanel.activeSelf == false)
        {
            goto label_2;
        }
        
        val_33 = null;
        val_33 = null;
        if(SkinEditorController.丁世丁丄不丅丙丄丛 == false)
        {
            goto label_5;
        }
        
        this.saveChangesPanel.SetActive(value:  true);
        UIButton val_3 = this.backButton.gameObject.GetComponent<UIButton>();
        UIButton val_4 = this.topPart.GetComponent<UIButton>();
        UIButton val_5 = this.downPart.GetComponent<UIButton>();
        UIButton val_6 = this.leftPart.GetComponent<UIButton>();
        UIButton val_7 = this.frontPart.GetComponent<UIButton>();
        UIButton val_8 = this.rigthPart.GetComponent<UIButton>();
        val_35 = this.backPart.GetComponent<UIButton>();
        if(val_35 != null)
        {
            goto label_22;
        }
        
        goto label_22;
        label_2:
        if(this.editorPanel.activeSelf == false)
        {
            goto label_24;
        }
        
        val_37 = null;
        val_37 = null;
        val_38 = SkinEditorController.丐丁世与三丅丗不一;
        if(val_38 == 0)
        {
            goto label_27;
        }
        
        val_37 = null;
        val_38 = SkinEditorController.丐丁世与三丅丗不一;
        if(val_38 != 1)
        {
                val_37 = null;
            val_38 = SkinEditorController.丐丁世与三丅丗不一;
            if(val_38 != 2)
        {
                return;
        }
        
        }
        
        val_37 = null;
        if(SkinEditorController.丁世丁丄不丅丙丄丛 == false)
        {
            goto label_64;
        }
        
        val_39 = this.savePanelInEditorTexture;
        val_40 = 1;
        goto label_38;
        label_24:
        if(this.colorPanel.activeSelf == false)
        {
            goto label_40;
        }
        
        this.editorPanel.SetActive(value:  true);
        val_39 = this.colorPanel;
        val_40 = 0;
        label_38:
        val_39.SetActive(value:  false);
        return;
        label_5:
        this.partPreviewPanel.SetActive(value:  false);
        this.skinPreviewPanel.SetActive(value:  true);
        UIButton val_13 = this.backButton.gameObject.GetComponent<UIButton>();
        UIButton val_14 = this.topPart.GetComponent<UIButton>();
        UIButton val_15 = this.downPart.GetComponent<UIButton>();
        UIButton val_16 = this.leftPart.GetComponent<UIButton>();
        UIButton val_17 = this.frontPart.GetComponent<UIButton>();
        UIButton val_18 = this.rigthPart.GetComponent<UIButton>();
        val_35 = this.backPart.GetComponent<UIButton>();
        label_22:
        val_31 = ???;
        val_32 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
        label_40:
        if((val_32 + 280.activeSelf) == false)
        {
                return;
        }
        
        val_41 = null;
        val_41 = null;
        if(SkinEditorController.丐三丌丏下且丏丄丕 == false)
        {
            goto label_64;
        }
        
        val_32 + 328.SetActive(value:  true);
        val_32.丆丗丞丈丈业丐业一();
        return;
        label_27:
        this.editorPanel.SetActive(value:  false);
        this.partPreviewPanel.SetActive(value:  true);
        val_32 = this.selectedSide.transform.GetChild(index:  0).GetComponent<UITexture>();
        val_42 = this.editorTexture;
        if((val_42 != null) && (null != null))
        {
                val_42 = 0;
        }
        
        UnityEngine.Texture2D val_30 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_42);
        return;
        label_64:
        this.丑三丏丌与世丈丕丗(丗丛不丁丑专专丂且:  val_31);
    }
    private void 不东一三业与与一丝(string 专三丆丗丆三丘万东)
    {
        var val_6;
        var val_64;
        var val_65;
        UnityEngine.Texture2D val_66;
        UnityEngine.Texture2D val_67;
        UnityEngine.Texture2D val_68;
        UnityEngine.Texture2D val_69;
        UnityEngine.Texture2D val_70;
        UnityEngine.Texture2D val_71;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D> val_1 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>();
        val_64 = null;
        val_64 = null;
        Dictionary.Enumerator<TKey, TValue> val_3 = SkinEditorController.且且丐丘东丑不丐丟.Item[专三丆丗丆三丘万东].GetEnumerator();
        val_65 = 1152921524535814544;
        label_60:
        if((839239680 & 1) == 0)
        {
            goto label_5;
        }
        
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Top")) != false)
        {
                val_66 = this.topPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            if((val_66 != null) && (null != null))
        {
                val_66 = 0;
        }
        
            val_1.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_66));
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Down")) != false)
        {
                val_67 = this.downPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            if((val_67 != null) && (null != null))
        {
                val_67 = 0;
        }
        
            val_1.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_67));
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Left")) != false)
        {
                val_68 = this.leftPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            if((val_68 != null) && (null != null))
        {
                val_68 = 0;
        }
        
            val_1.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_68));
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Front")) != false)
        {
                val_69 = this.frontPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            if((val_69 != null) && (null != null))
        {
                val_69 = 0;
        }
        
            val_1.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_69));
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Right")) != false)
        {
                val_70 = this.rigthPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            if((val_70 != null) && (null != null))
        {
                val_70 = 0;
        }
        
            val_1.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_70));
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Back")) == false)
        {
            goto label_60;
        }
        
        val_71 = this.backPart.transform.GetChild(index:  0).GetComponent<UITexture>();
        if((val_71 != null) && (null != null))
        {
                val_71 = 0;
        }
        
        val_1.Add(key:  val_7._value._obj.丐丏七丌丕丗业且上(), value:  EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_71));
        goto label_60;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if((专三丆丗丆三丘万东.Equals(value:  "Arm_right")) != true)
        {
                if((专三丆丗丆三丘万东.Equals(value:  "Arm_left")) == false)
        {
            goto label_129;
        }
        
        }
        
        val_74 = null;
        val_74 = null;
        val_75 = 1152921539805810960;
        bool val_57 = SkinEditorController.且且丐丘东丑不丐丟.Remove(key:  "Arm_right");
        SkinEditorController.且且丐丘东丑不丐丟.Add(key:  "Arm_right", value:  val_1);
        val_65 = "Arm_left";
        bool val_58 = SkinEditorController.且且丐丘东丑不丐丟.Remove(key:  "Arm_left");
        SkinEditorController.且且丐丘东丑不丐丟.Add(key:  "Arm_left", value:  val_1);
        label_129:
        if((专三丆丗丆三丘万东.Equals(value:  "Foot_right")) != true)
        {
                if((专三丆丗丆三丘万东.Equals(value:  "Foot_left")) == false)
        {
            goto label_139;
        }
        
        }
        
        val_76 = null;
        val_76 = null;
        val_75 = 1152921539805810960;
        bool val_61 = SkinEditorController.且且丐丘东丑不丐丟.Remove(key:  "Foot_right");
        SkinEditorController.且且丐丘东丑不丐丟.Add(key:  "Foot_right", value:  val_1);
        val_65 = "Foot_left";
        bool val_62 = SkinEditorController.且且丐丘东丑不丐丟.Remove(key:  "Foot_left");
        SkinEditorController.且且丐丘东丑不丐丟.Add(key:  "Foot_left", value:  val_1);
        label_139:
        val_77 = null;
        val_77 = null;
        bool val_63 = SkinEditorController.且且丐丘东丑不丐丟.Remove(key:  专三丆丗丆三丘万东);
        SkinEditorController.且且丐丘东丑不丐丟.Add(key:  专三丆丗丆三丘万东, value:  val_1);
    }
    private void 丗丂上专丗业丕丘丕()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>> val_8;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_1 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>();
        val_8 = SkinEditorController.七丅一丗丌东上不丁;
        val_8.Clear();
        if(SkinEditorController.丐丁世与三丅丗不一 != 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_2 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>();
        val_2.Add(key:  "Top", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_2.Add(key:  "Down", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_2.Add(key:  "Left", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_2.Add(key:  "Front", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_2.Add(key:  "Right", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_2.Add(key:  "Back", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        SkinEditorController.七丅一丗丌东上不丁.Add(key:  "Head", value:  val_2);
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_3 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>();
        val_3.Add(key:  "Top", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_3.Add(key:  "Down", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_3.Add(key:  "Left", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_3.Add(key:  "Front", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_3.Add(key:  "Right", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_3.Add(key:  "Back", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        SkinEditorController.七丅一丗丌东上不丁.Add(key:  "Foot_left", value:  val_3);
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_4 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>();
        val_4.Add(key:  "Top", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_4.Add(key:  "Down", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_4.Add(key:  "Left", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_4.Add(key:  "Front", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_4.Add(key:  "Right", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_4.Add(key:  "Back", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        SkinEditorController.七丅一丗丌东上不丁.Add(key:  "Foot_right", value:  val_4);
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_5 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>();
        val_5.Add(key:  "Top", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_5.Add(key:  "Down", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_5.Add(key:  "Left", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_5.Add(key:  "Front", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_5.Add(key:  "Right", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_5.Add(key:  "Back", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        SkinEditorController.七丅一丗丌东上不丁.Add(key:  "BodyMesh", value:  val_5);
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_6 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>();
        val_6.Add(key:  "Top", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_6.Add(key:  "Down", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_6.Add(key:  "Left", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_6.Add(key:  "Front", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_6.Add(key:  "Right", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_6.Add(key:  "Back", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        SkinEditorController.七丅一丗丌东上不丁.Add(key:  "Arm_right", value:  val_6);
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_7 = null;
        val_8 = val_7;
        val_7 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>();
        val_7.Add(key:  "Top", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_7.Add(key:  "Down", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_7.Add(key:  "Left", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_7.Add(key:  "Front", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_7.Add(key:  "Right", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        val_7.Add(key:  "Back", value:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        SkinEditorController.七丅一丗丌东上不丁.Add(key:  "Arm_left", value:  val_7);
    }
    public void UpdateTexturesPartsInDictionary()
    {
        var val_4;
        var val_12;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_26;
        val_20 = null;
        val_20 = null;
        SkinEditorController.且且丐丘东丑不丐丟.Clear();
        Dictionary.Enumerator<TKey, TValue> val_1 = SkinEditorController.七丅一丗丌东上不丁.GetEnumerator();
        val_21 = 0;
        val_22 = 0;
        var val_20 = 0;
        label_35:
        if((839776128 & 1) == 0)
        {
            goto label_5;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D> val_6 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>();
        val_23 = null;
        val_23 = null;
        Dictionary.Enumerator<TKey, TValue> val_9 = SkinEditorController.七丅一丗丌东上不丁.Item[val_5._value._obj.丐丏七丌丕丗业且上()].GetEnumerator();
        label_16:
        if((839776064 & 1) == 0)
        {
            goto label_10;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_10 = val_4.RemoteEndpoint;
        val_24 = null;
        val_24 = null;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect> val_15 = SkinEditorController.七丅一丗丌东上不丁.Item[val_5._value._obj.丐丏七丌丕丗业且上()];
        UnityEngine.Rect val_17 = val_15.Item[val_12.丐丏七丌丕丗业且上()];
        null.Add(key:  val_12.丐丏七丌丕丗业且上(), value:  val_15.丕不丄丌丟丅丁丟三(东世丞丟上丄专丙丐:  SkinEditorController.东业丕三且丁与上丂, 三丅丐丅丈丌东丙东:  new UnityEngine.Rect() {m_XMin = val_17.m_XMin, m_YMin = val_17.m_YMin, m_Width = val_17.m_Width, m_Height = val_17.m_Height}));
        goto label_16;
        label_10:
        val_20 = val_20 + 1;
        mem2[0] = 152;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_20 != 1) && ((839775936 + ((0 + 1)) << 2) == 152))
        {
                var val_21 = 0;
            val_21 = val_21 ^ (val_20 >> 31);
            val_20 = val_20 + val_21;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        SkinEditorController.且且丐丘东丑不丐丟.Add(key:  val_5._value._obj.丐丏七丌丕丗业且上(), value:  null);
        goto label_35;
        label_5:
        val_20 = val_20 + 1;
        mem2[0] = 198;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_20 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((839775936 + ((0 + 1)) << 2) == 198)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal static UnityEngine.Texture2D 万丗一一与业丗丒丆(System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D>> 丘七丛一丄丐且业丗)
    {
        var val_8;
        float val_40;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_48;
        var val_49;
        val_40 = 0;
        val_42 = null;
        val_42 = null;
        int val_1 = SkinEditorController.东业丕三且丁与上丂.width;
        int val_2 = SkinEditorController.东业丕三且丁与上丂.height;
        UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  val_1, height:  val_2, textureFormat:  4, mipChain:  false);
        UnityEngine.Color val_4 = UnityEngine.Color.clear;
        if(val_2 >= 1)
        {
                var val_41 = 0;
            do
        {
            if(val_1 >= 1)
        {
                var val_40 = 0;
            do
        {
            val_40 = val_4.r;
            val_3.SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_40, g = val_4.g, b = val_4.b, a = val_4.a});
            val_40 = val_40 + 1;
        }
        while(val_1 != val_40);
        
        }
        
            val_41 = val_41 + 1;
        }
        while(val_41 != val_2);
        
        }
        
        Dictionary.Enumerator<TKey, TValue> val_5 = 丘七丛一丄丐且业丗.GetEnumerator();
        val_43 = 0;
        label_69:
        if((840065184 & 1) == 0)
        {
            goto label_11;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_8.GetAwaiter();
        Dictionary.Enumerator<TKey, TValue> val_12 = 丘七丛一丄丐且业丗.Item[val_9._value._obj.丐丏七丌丕丗业且上()].GetEnumerator();
        label_31:
        if((840065120 & 1) == 0)
        {
            goto label_14;
        }
        
        ConfiguredValueTaskAwaiter val_13 = val_8.GetAwaiter();
        val_44 = null;
        val_44 = null;
        UnityEngine.Rect val_17 = SkinEditorController.七丅一丗丌东上不丁.Item[val_9._value._obj.丐丏七丌丕丗业且上()].Item[val_13._value._obj.丐丏七丌丕丗业且上()];
        UnityEngine.Rect val_23 = SkinEditorController.七丅一丗丌东上不丁.Item[val_9._value._obj.丐丏七丌丕丗业且上()].Item[val_13._value._obj.丐丏七丌丕丗业且上()];
        UnityEngine.Rect val_28 = SkinEditorController.七丅一丗丌东上不丁.Item[val_9._value._obj.丐丏七丌丕丗业且上()].Item[val_13._value._obj.丐丏七丌丕丗业且上()];
        UnityEngine.Rect val_33 = SkinEditorController.七丅一丗丌东上不丁.Item[val_9._value._obj.丐丏七丌丕丗业且上()].Item[val_13._value._obj.丐丏七丌丕丗业且上()];
        val_3.SetPixels(x:  UnityEngine.Mathf.RoundToInt(f:  val_17.m_XMin.System.IConvertible.ToSingle(provider:  0)), y:  UnityEngine.Mathf.RoundToInt(f:  val_23.m_XMin), blockWidth:  UnityEngine.Mathf.RoundToInt(f:  val_28.m_XMin), blockHeight:  UnityEngine.Mathf.RoundToInt(f:  val_33.m_XMin), colors:  丘七丛一丄丐且业丗.Item[val_9._value._obj.丐丏七丌丕丗业且上()].Item[val_13._value._obj.丐丏七丌丕丗业且上()].GetPixels());
        goto label_31;
        label_14:
        val_45 = 0;
        val_46 = 0 + 1;
        mem2[0] = 373;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_46 == 1) || ((1152921539806650352 + ((0 + 1)) << 2) != 373))
        {
            goto label_66;
        }
        
        var val_42 = 0;
        val_42 = val_42 ^ (val_46 >> 31);
        val_46 = val_46 + val_42;
        goto label_69;
        label_66:
        if( == 0)
        {
            goto label_69;
        }
        
        goto label_69;
        label_11:
        val_48 = 0;
        val_49 = 0 + 1;
        mem2[0] = 401;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_46 == 1)
        {
            goto label_76;
        }
        
        if(( == 0) || ((1152921539806650352 + ((0 + 1)) << 2) == 401))
        {
            goto label_82;
        }
        
        label_81:
        label_82:
        if(val_3 == null)
        {
            goto label_79;
        }
        
        val_3.filterMode = 0;
        goto label_80;
        label_76:
        if( != 0)
        {
            goto label_81;
        }
        
        goto label_82;
        label_79:
        0.filterMode = 0;
        label_80:
        val_3.Apply();
        return val_3;
    }
    public void SelectPart(string 专三丆丗丆三丘万东)
    {
        var val_6;
        string val_75;
        SkinEditorController val_76;
        var val_77;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>> val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        val_75 = 专三丆丗丆三丘万东;
        val_76 = this;
        val_77 = 1152921505296302080;
        val_78 = SkinEditorController.且且丐丘东丑不丐丟;
        if((val_78.ContainsKey(key:  val_75)) == false)
        {
            goto label_4;
        }
        
        SkinEditorController.丁世丁丄不丅丙丄丛 = false;
        this.selectedPartName = val_75;
        this.topPart.SetActive(value:  false);
        this.downPart.SetActive(value:  false);
        this.leftPart.SetActive(value:  false);
        this.frontPart.SetActive(value:  false);
        this.rigthPart.SetActive(value:  false);
        this.backPart.SetActive(value:  false);
        val_78 = SkinEditorController.且且丐丘东丑不丐丟.Item[val_75];
        Dictionary.Enumerator<TKey, TValue> val_3 = val_78.GetEnumerator();
        val_79 = 1152921524535814544;
        val_80 = "Top";
        val_81 = 1152921526217218544;
        goto label_129;
        label_4:
        UnityEngine.Debug.Log(message:  "texturesParts not contain key");
        return;
        label_151:
        ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  X23)) != false)
        {
                this.topPart.SetActive(value:  true);
            string val_11 =  * val_75;
            string val_12 =  * val_75;
            val_6 = 0;
            this.topPart.GetComponent<UnityEngine.Renderer>().size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Renderer val_15 = this.topPart.transform.GetChild(index:  0).GetComponent<UnityEngine.Renderer>();
            val_15.width =  * val_75;
            val_15.height =  * val_75;
            float val_74 = -1.152922E+18f;
            float val_75 = (float) + SkinEditorController.且且丐丘东丑不丐丟.Item[val_75].Item["Front"].height;
            val_74 = val_74 * S8;
            val_75 = val_75 * S8;
            val_74 = val_74 * S9;
            val_75 = val_75 * S9;
            this.topPart.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Texture2D val_23 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_7._value._obj);
            val_77 = val_77;
            val_76 = val_76;
            val_82 = 1152921524535816592;
            val_80 = "Top";
            val_81 = 1152921526217218544;
            val_83 = X28;
            val_84 = 22;
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Down")) != false)
        {
                this.downPart.SetActive(value:  true);
            val_6 = 0;
            this.downPart.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UITexture val_29 = this.downPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            val_29.width = 1312276928;
            val_29.height = 1312276928;
            float val_76 = -1.152922E+18f;
            float val_77 = (float)-(SkinEditorController.且且丐丘东丑不丐丟.Item[val_75].Item["Front"].height + );
            val_76 = val_76 * S8;
            val_77 = val_77 * S8;
            val_76 = val_76 * S9;
            val_77 = val_77 * S9;
            this.downPart.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Texture2D val_35 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_7._value._obj);
            val_83 = val_83;
            val_77 = 1152921505296302080;
            val_82 = 1152921524535816592;
            val_80 = "Top";
            val_81 = 1152921526217218544;
            val_84 = 22;
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Left")) != false)
        {
                this.leftPart.SetActive(value:  true);
            val_6 = 0;
            this.leftPart.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UITexture val_41 = this.leftPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            val_41.width = 1312276928;
            val_41.height = 1312276928;
            val_85 = null;
            float val_78 = 1.152922E+18f;
            val_78 = val_78 * S8;
            val_78 = val_78 + (float)SkinEditorController.且且丐丘东丑不丐丟.Item[val_75].Item["Front"].width;
            val_78 = val_78 * S10;
            this.leftPart.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Texture2D val_46 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_7._value._obj);
            val_80 = val_80;
            val_81 = val_81;
            val_83 = val_83;
            val_82 = 1152921524535816592;
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Front")) != false)
        {
                this.frontPart.SetActive(value:  true);
            val_6 = 0;
            this.frontPart.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UITexture val_52 = this.frontPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            val_52.width = 1312276928;
            val_52.height = 1312276928;
            float val_79 = 1.152922E+18f;
            val_79 = val_79 * S8;
            val_79 = val_79 * S10;
            this.frontPart.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Texture2D val_54 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_7._value._obj);
            val_80 = val_80;
            val_81 = val_81;
            val_83 = val_83;
        }
        
        if((val_7._value._obj.丐丏七丌丕丗业且上().Equals(value:  "Right")) != false)
        {
                this.rigthPart.SetActive(value:  true);
            val_6 = 0;
            this.rigthPart.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UITexture val_60 = this.rigthPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            val_60.width = 1312276928;
            val_60.height = 1312276928;
            float val_80 = 1.152922E+18f;
            val_80 = val_80 * S8;
            val_80 = val_80 * S9;
            this.rigthPart.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Texture2D val_62 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_7._value._obj);
            val_80 = val_80;
            val_81 = val_81;
            val_83 = val_83;
        }
        
        val_78 = val_7._value._obj.丐丏七丌丕丗业且上();
        val_79 = 1152921524535814544;
        if((val_78.Equals(value:  "Back")) != false)
        {
                this.backPart.SetActive(value:  true);
            val_6 = 0;
            this.backPart.GetComponent<UnityEngine.BoxCollider>().size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_78 = this.backPart.transform.GetChild(index:  0).GetComponent<UITexture>();
            val_78.width = 1312276928;
            val_78.height = 1312276928;
            val_86 = null;
            val_86 = null;
            float val_81 = 1.152922E+18f;
            val_81 = val_81 * S8;
            val_81 = val_81 + (float)SkinEditorController.且且丐丘东丑不丐丟.Item[val_75].Item["Right"].width;
            val_81 = val_81 * S9;
            this.backPart.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Texture2D val_73 = EditorTextures.世丙三丌一三下丈丘(业丌世丂三丙丅丗丘:  val_7._value._obj);
            val_80 = val_80;
            val_81 = val_81;
            val_79 = 1152921524535814544;
        }
        
        label_129:
        if((840552112 & 1) != 0)
        {
            goto label_151;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem[1152921539807149920].SetActive(value:  true);
        val_75 = mem[1152921539807149912];
        val_75.SetActive(value:  false);
    }
    private UnityEngine.Texture2D 丕不丄丌丟丅丁丟三(UnityEngine.Texture2D 东世丞丟上丄专丙丐, UnityEngine.Rect 三丅丐丅丈丌东丙东)
    {
        float val_1 = 三丅丐丅丈丌东丙东.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Color[] val_2 = 东世丞丟上丄专丙丐.GetPixels(x:  (int)val_1, y:  (int)val_1, blockWidth:  (int)val_1, blockHeight:  (int)val_1);
        UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  (int)val_1, height:  (int)val_1);
        if(val_3 != null)
        {
                val_3.filterMode = 0;
            val_3.SetPixels(colors:  val_2);
        }
        else
        {
                0.filterMode = 0;
            val_3.SetPixels(colors:  val_2);
        }
        
        val_3.Apply();
        return val_3;
    }
    private void 丑三丏丌与世丈丕丗(System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_5;
        System.Action<System.String> val_6;
        string val_7;
        var val_8;
        UnityEngine.Object val_9;
        var val_10;
        var val_11;
        var val_12;
        val_5 = null;
        val_5 = null;
        val_6 = SkinEditorController.丑丛丝不丄丗七一丝;
        if(val_6 != null)
        {
                if(((丗丛不丁丑专专丂且 != null) && ((SkinEditorController.丐丁世与三丅丗不一 == 2) && (null == null))) && (丗丛不丁丑专专丂且.万丛三丝不丐与丐业() != false))
        {
                val_7 = "SAVED";
        }
        else
        {
                val_7 = this.丁东上丗丌丝一丛七;
        }
        
            Invoke(obj:  mem[this.丁东上丗丌丝一丛七]);
            val_8 = null;
            val_8 = null;
            SkinEditorController.业丈下丟世丑丂丙丙 = 0;
        }
        
        val_9 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_9);
        val_10 = null;
        val_10 = null;
        if(SkinEditorController.丐丁世与三丅丗不一 == 2)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_6 = 1152921505061052416;
        val_11 = null;
        val_11 = null;
        val_9 = ExperienceController.sharedController;
        if(val_9 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
    }
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.下一丏下丞丞万专七();
    }
    private void OnDisable()
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
    internal void 下一丏下丞丞万专七()
    {
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void SkinEditorController::丈一丘世丆丙七万丙()), 与且专丈不万东一万:  "Skin Editor");
    }
    private void OnDestroy()
    {
        null = null;
        SkinEditorController.丄丞丁丈与业上丞丟 = 0;
    }
    public SkinEditorController()
    {
        this.丂专东丌丈丒业一丝 = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }
    private static SkinEditorController()
    {
        SkinEditorController.丑丛丝不丄丗七一丝 = 0;
        SkinEditorController.丐不三丐丅三丆且丅 = 0;
        SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_C = 0;
        SkinEditorController.丑丛丝不丄丗七一丝.__il2cppRuntimeField_14 = 0;
        UnityEngine.Color[] val_1 = new UnityEngine.Color[5];
        UnityEngine.Color val_2 = UnityEngine.Color.clear;
        val_1[0] = val_2;
        val_1[0] = val_2.g;
        val_1[0] = val_2.b;
        val_1[0] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.clear;
        val_1[1] = val_3;
        val_1[1] = val_3.g;
        val_1[1] = val_3.b;
        val_1[1] = val_3.a;
        UnityEngine.Color val_4 = UnityEngine.Color.clear;
        val_1[2] = val_4;
        val_1[2] = val_4.g;
        val_1[2] = val_4.b;
        val_1[2] = val_4.a;
        UnityEngine.Color val_5 = UnityEngine.Color.clear;
        val_1[3] = val_5;
        val_1[3] = val_5.g;
        val_1[3] = val_5.b;
        val_1[3] = val_5.a;
        UnityEngine.Color val_6 = UnityEngine.Color.clear;
        val_1[4] = val_6;
        val_1[4] = val_6.g;
        val_1[4] = val_6.b;
        val_1[4] = val_6.a;
        SkinEditorController.且与上丄东一丕丏与 = val_1;
        SkinEditorController.丝丝丂不且丒丐丌上 = 0;
        SkinEditorController.丐丌丁一丞丁丝丁下 = 0;
        SkinEditorController.丐丁世与三丅丗不一 = 0;
        SkinEditorController.丄丞丁丈与业上丞丟 = 0;
        SkinEditorController.东业丕三且丁与上丂 = 0;
        SkinEditorController.业丈下丟世丑丂丙丙 = 0;
        SkinEditorController.七丅一丗丌东上不丁 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, UnityEngine.Rect>>();
        SkinEditorController.且且丐丘东丑不丐丟 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>>();
        SkinEditorController.丁世丁丄不丅丙丄丛 = false;
        SkinEditorController.丐三丌丏下且丏丄丕 = false;
    }
    private void 丟丕丁丂丞万丏且丆()
    {
        this.丘不上世七一丑丐丟(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }
    private void 丈一丘世丆丙七万丙()
    {
        null = null;
        this.丆丞丟三丟下三丆丏(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  System.EventArgs.Empty);
    }

}
