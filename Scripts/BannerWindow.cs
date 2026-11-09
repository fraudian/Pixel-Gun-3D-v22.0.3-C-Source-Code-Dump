using UnityEngine;
public class BannerWindow : PGBehaviour
{
    // Fields
    private bool 业丑丈一丟一丅丕丅;
    public UITexture Background;
    public UIButton ExitButton;
    private bool _needAmbientLightSwitcher;
    private BannerWindowType <丟七丒三丙丝丅不不>k__BackingField;
    private PGCompany.丆下丐丁丏世丈上丟 <东三丝丆丏丑不丐丈>k__BackingField;
    
    // Properties
    public BannerWindowType 丁丅丈丌丟世丗丗丟 { get; set; }
    internal PGCompany.丆下丐丁丏世丈上丟 丕丈丏丑丌丂且万不 { get; set; }
    public bool 丞丄丂丘丌一丒丙上 { get; set; }
    
    // Methods
    public BannerWindowType get_type()
    {
        return (BannerWindowType)this.<丟七丒三丙丝丅不不>k__BackingField;
    }
    public void set_type(BannerWindowType 丙业与丙丗丝不丈东)
    {
        this.<丟七丒三丙丝丅不不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal PGCompany.丆下丐丁丏世丈上丟 丑丐丙丄丅世世丑丒()
    {
    
    }
    internal void 丟世丛丌丏丙丒丏东(PGCompany.丆下丐丁丏世丈上丟 丙业与丙丗丝不丈东)
    {
    
    }
    public bool get_IsShow()
    {
        return (bool)this.业丑丈一丟一丅丕丅;
    }
    private void 丁丐且丈业且丌丂丘(bool 丙业与丙丗丝不丈东)
    {
        this.业丑丈一丟一丅丕丅 = 丙业与丙丗丝不丈东;
    }
    protected virtual void Awake()
    {
        if(this._needAmbientLightSwitcher == false)
        {
                return;
        }
        
        if((this.丅与丌专丟一丝业三().GetComponent<PGCompany.AmbientLightSwitcher>()) != 0)
        {
                return;
        }
        
        PGCompany.AmbientLightSwitcher val_5 = this.丅与丌专丟一丝业三().AddComponent<PGCompany.AmbientLightSwitcher>();
    }
    protected virtual void Start()
    {
    
    }
    protected virtual void OnDestroy()
    {
    
    }
    protected virtual void OnEnable()
    {
    
    }
    protected virtual void OnDisable()
    {
        this.业丑丈一丟一丅丕丅 = false;
    }
    public void SetBackgroundImage(UnityEngine.Texture2D 东上万丆七丌且丒丈)
    {
        if(this.Background == 0)
        {
                return;
        }
        
        if(this.Background == null)
        {
            
        }
    
    }
    public void SetEnableExitButton(bool 丑丒业丘丑东丕世丅)
    {
        if(this.ExitButton == 0)
        {
                return;
        }
        
        this.ExitButton.gameObject.SetActive(value:  丑丒业丘丑东丕世丅);
    }
    protected virtual void 丄上不七丈丐专丗不()
    {
        this.gameObject.SetActive(value:  true);
        this.业丑丈一丟一丅丕丅 = true;
    }
    public virtual void Show()
    {
        AdmobPerelivWindow val_1 = this.GetComponent<AdmobPerelivWindow>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.Show();
    }
    public virtual void Hide()
    {
        AdmobPerelivWindow val_1 = this.GetComponent<AdmobPerelivWindow>();
        if(val_1 != 0)
        {
                val_1.Hide();
        }
        else
        {
                this.gameObject.SetActive(value:  false);
        }
        
        this.业丑丈一丟一丅丕丅 = false;
    }
    public void EventX3ExitClick()
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        BannerWindowController.下丑上丞丅上丏丟一(丙业与丙丗丝不丈东:  专七专下且专三一且.上且一丈丐三丄一丆());
        BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
    }
    public void EventX3ApplyClick()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        this.EventX3ExitClick();
        val_3 = null;
        val_3 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_4 = null;
            val_4 = null;
            val_5 = null;
            val_5 = null;
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  true, 丆丟七丝丏业丅上丄:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 世丁丙世丄一万丆三:  "", 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
            return;
        }
        
        val_6 = static_value_081DACA8;
        val_6 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return;
        }
        
        val_7 = static_value_081DACA8;
        val_7 = static_value_081DACA8;
        val_8 = null;
        val_8 = null;
        static_value_081DACA8 + 184 + 16.上世与丗丁丕丌丘上(丆丟七丝丏业丅上丄:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
    }
    internal virtual void 且丄丆丁丗丏三业专()
    {
    
    }
    protected virtual void 万万丄丌与丐丘东三(BannerWindowType 世丌丒丌上丗丛丈丒)
    {
        UnityEngine.Object val_7;
        UnityEngine.Object val_8;
        val_7 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_8 = 0;
        if(val_7 != val_8)
        {
                BannerWindowController val_3 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_7 = val_3.东一丏七业丙万丞丅;
            val_8 = this;
            if(val_7 == this)
        {
                BannerWindowController.与丅与丒丅专丙丐丗().ResetStateBannerShowed(丌丅丕一丛丛丄一万:  世丌丒丌上丗丛丈丒);
            BannerWindowController.与丅与丒丅专丙丐丗().HideBannerWindow();
        }
        
        }
    
    }
    public virtual void HideSelf()
    {
        goto typeof(BannerWindow).__il2cppRuntimeField_1F8;
    }
    public void U__HideSelf()
    {
        goto typeof(BannerWindow).__il2cppRuntimeField_208;
    }
    public BannerWindow()
    {
    
    }

}
