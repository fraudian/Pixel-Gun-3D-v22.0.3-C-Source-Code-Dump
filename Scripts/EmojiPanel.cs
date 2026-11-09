using UnityEngine;
public class EmojiPanel : MonoBehaviour
{
    // Fields
    private const float 上丟丂不丑东丘丟丕 = 2.5;
    internal float 丘丁丏东丁丂世丟上;
    internal bool 且丁丛丈七下且万丁;
    internal bool 丆丕万业丈一丛丆丒;
    public Rilisoft.ButtonHandler emojiShowButton;
    public UnityEngine.GameObject emojiTable;
    public UnityEngine.GameObject emojiTableLeft;
    public UnityEngine.GameObject[] emojiButtons;
    public UITweener[] emojiTableAnimations;
    public UITweener[] emojiTableLeftSideAnimations;
    public UIButton emojiButton;
    private float 万丂丆丝丁丕丅丕丌;
    private float 上丅丂不且丐与丟丐;
    private bool 七丒丛丘丟万下东丘;
    private bool 东业东七丂丞丒丙丛;
    private static float 一上三丏东丑丒丑下;
    private static System.Action<bool> 专丏丁万下东丝丟与;
    
    // Properties
    private UnityEngine.GameObject 万丗丌丒丄万丄一丑 { get; }
    private UITweener[] 与丑业丌丙一丌业丌 { get; }
    internal bool 专专丐万丂丂一丐丅 { get; }
    
    // Methods
    private UnityEngine.GameObject 丞丕业万丈与丂丟且()
    {
        UnityEngine.GameObject val_5;
        if((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) && (GameConnect.万不丒丌丙万丗东不() != true))
        {
                if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                val_5 = this;
            if(this.emojiTableLeft != 0)
        {
                return (UnityEngine.GameObject)mem[this.emojiTable];
        }
        
        }
        
        }
        
        val_5 = this.emojiTable;
        return (UnityEngine.GameObject)mem[this.emojiTable];
    }
    private UITweener[] 业丑丂丅丗丒丅七丑()
    {
        UITweener[] val_4;
        if((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) && (GameConnect.万不丒丌丙万丗东不() != true))
        {
                if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                val_4 = this;
            if(this.emojiTableLeftSideAnimations.Length != 0)
        {
                return (UITweener[])mem[this.emojiTableAnimations];
        }
        
        }
        
        }
        
        val_4 = this.emojiTableAnimations;
        return (UITweener[])mem[this.emojiTableAnimations];
    }
    internal bool 三丗丟下丘世三上三()
    {
        return (bool)this.东业东七丂丞丒丙丛;
    }
    internal static void 丟丄三与专不丞丗丆(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  EmojiPanel.专丏丁万下东丝丟与, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(EmojiPanel.专丏丁万下东丝丟与 != 1152921505059885064);
    
    }
    internal static void 丅且丒业丌丁丒丏丈(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  EmojiPanel.专丏丁万下东丝丟与, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(EmojiPanel.专丏丁万下东丝丟与 != 1152921505059885064);
    
    }
    private void Awake()
    {
        if(PolygonController.一下一万丄丅丘且丑 != 0)
        {
                this.gameObject.SetActive(value:  false);
            return;
        }
        
        this.emojiShowButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void EmojiPanel::EmojiButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.emojiButton = this.emojiShowButton.GetComponent<UIButton>();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.emojiShowButton, 丏业丟一东丂东丘丛:  PGCompany.丁东丌世与丕东丆上.一丘且丑丟丒丗丐丏());
    }
    private void 丗丄万七万世丐丙丏()
    {
        object val_4;
        var val_5;
        丅三丝丙丝万上丝业 val_6;
        val_4 = this;
        if(this.七丒丛丘丟万下东丘 == true)
        {
                return;
        }
        
        this.七丒丛丘丟万下东丘 = true;
        val_5 = null;
        val_5 = null;
        if(((System.Delegate.Combine(a:  UICamera.onClick, b:  new UICamera.丅三丝丙丝万上丝业(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void EmojiPanel::丆丗世下且丒丏丂丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)))) != null) && (null != null))
        {
                val_6 = 0;
        }
        
        UICamera.onClick = val_6;
    }
    private void 丙丘丅万且丁丐丆丟()
    {
        object val_4;
        var val_5;
        丅三丝丙丝万上丝业 val_6;
        val_4 = this;
        if(this.七丒丛丘丟万下东丘 == false)
        {
                return;
        }
        
        this.七丒丛丘丟万下东丘 = false;
        val_5 = null;
        val_5 = null;
        if(((System.Delegate.Remove(source:  UICamera.onClick, value:  new UICamera.丅三丝丙丝万上丝业(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void EmojiPanel::丆丗世下且丒丏丂丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)))) != null) && (null != null))
        {
                val_6 = 0;
        }
        
        UICamera.onClick = val_6;
    }
    private void OnEnable()
    {
    
    }
    private void OnDisable()
    {
        var val_1;
        this.HideEmojiiTable(丌丝丌丁下丐丞丆一:  true);
        val_1 = null;
        val_1 = null;
        EmojiPanel.专丏丁万下东丝丟与.Invoke(obj:  true);
    }
    private void 丆丗世下且丒丏丂丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_4;
        bool val_5;
        var val_6;
        var val_7;
        var val_5 = 0;
        label_6:
        if(val_5 >= this.emojiButtons.Length)
        {
            goto label_2;
        }
        
        val_5 = val_5 + 1;
        if((this.emojiButtons[0] & 1) == 0)
        {
            goto label_6;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        val_4 = null;
        val_4 = null;
        float val_6 = 2.5f;
        val_6 = UnityEngine.Time.time + val_6;
        EmojiPanel.一上三丏东丑丒丑下 = val_6;
        if(EmojiController.丘丆专丕丏且不丏丑 != 0)
        {
                string val_3 = 丝三丁东丈丒世丅业.name;
        }
        
        val_5 = this;
        if(this.丆丕万业丈一丛丆丒 == false)
        {
            goto label_19;
        }
        
        this.HideEmojiiTable(丌丝丌丁下丐丞丆一:  this.且丁丛丈七下且万丁);
        val_6 = null;
        val_6 = null;
        EmojiPanel.专丏丁万下东丝丟与.Invoke(obj:  true);
        goto label_18;
        label_2:
        val_5 = this.丆丕万业丈一丛丆丒;
        label_18:
        if(val_5 != false)
        {
                return;
        }
        
        label_19:
        this.HideEmojiiTable(丌丝丌丁下丐丞丆一:  this.且丁丛丈七下且万丁);
        val_7 = null;
        val_7 = null;
        EmojiPanel.专丏丁万下东丝丟与.Invoke(obj:  true);
    }
    private void Update()
    {
        var val_7;
        float val_8;
        var val_9;
        val_7 = null;
        val_7 = null;
        val_8 = UnityEngine.Time.time;
        if(this.emojiButton != 0)
        {
                var val_3 = (EmojiPanel.一上三丏东丑丒丑下 < 0) ? 1 : 0;
        }
        
        if(this.东业东七丂丞丒丙丛 == false)
        {
                return;
        }
        
        if(this.万丂丆丝丁丕丅丕丌 > 0f)
        {
                float val_4 = UnityEngine.Time.deltaTime;
            val_4 = this.万丂丆丝丁丕丅丕丌 - val_4;
            this.万丂丆丝丁丕丅丕丌 = val_4;
            if(val_4 <= 0f)
        {
                this.丞丕业万丈与丂丟且().SetActive(value:  false);
            this.东业东七丂丞丒丙丛 = false;
        }
        
        }
        
        val_8 = this.上丅丂不且丐与丟丐;
        if(val_8 <= 0f)
        {
                return;
        }
        
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = val_8 - val_6;
        this.上丅丂不且丐与丟丐 = val_6;
        if(val_6 > 0f)
        {
                return;
        }
        
        this.HideEmojiiTable(丌丝丌丁下丐丞丆一:  false);
        val_9 = null;
        val_9 = null;
        EmojiPanel.专丏丁万下东丝丟与.Invoke(obj:  true);
    }
    public void ShowEmojiTable()
    {
        var val_3;
        this.东业东七丂丞丒丙丛 = true;
        this.万丂丆丝丁丕丅丕丌 = -1f;
        this.丞丕业万丈与丂丟且().SetActive(value:  true);
        val_3 = 0;
        goto label_1;
        label_5:
        this.业丑丂丅丗丒丅七丑()[0].PlayForward();
        val_3 = 1;
        label_1:
        if(val_3 < val_2.Length)
        {
            goto label_5;
        }
        
        this.上丅丂不且丐与丟丐 = 5f;
        this.丗丄万七万世丐丙丏();
    }
    public void HideEmojiiTable(bool 丌丝丌丁下丐丞丆一 = False)
    {
        float val_3;
        var val_4;
        this.上丅丂不且丐与丟丐 = -1f;
        if(丌丝丌丁下丐丞丆一 == false)
        {
            goto label_0;
        }
        
        this.丞丕业万丈与丂丟且().SetActive(value:  false);
        this.东业东七丂丞丒丙丛 = false;
        val_3 = -1f;
        goto label_2;
        label_0:
        val_4 = 0;
        goto label_3;
        label_7:
        this.业丑丂丅丗丒丅七丑()[0].PlayReverse();
        val_4 = 1;
        label_3:
        if(val_4 < val_2.Length)
        {
            goto label_7;
        }
        
        val_3 = this.丘丁丏东丁丂世丟上;
        label_2:
        this.万丂丆丝丁丕丅丕丌 = val_3;
        this.丙丘丅万且丁丐丆丟();
    }
    public void EmojiButtonClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        var val_3;
        System.Action<System.Boolean> val_4;
        var val_5;
        var val_6;
        var val_7;
        val_2 = null;
        val_2 = null;
        float val_1 = UnityEngine.Time.time;
        if(this.丆丕万业丈一丛丆丒 == false)
        {
            goto label_3;
        }
        
        if(EmojiPanel.一上三丏东丑丒丑下 >= 0)
        {
                return;
        }
        
        if(this.东业东七丂丞丒丙丛 == false)
        {
            goto label_5;
        }
        
        if(this.上丅丂不且丐与丟丐 >= 0)
        {
                return;
        }
        
        if(this.万丂丆丝丁丕丅丕丌 > 0f)
        {
                return;
        }
        
        this.HideEmojiiTable(丌丝丌丁下丐丞丆一:  false);
        val_3 = null;
        val_3 = null;
        val_4 = EmojiPanel.专丏丁万下东丝丟与;
        val_5 = 1152921516635255488;
        val_6 = 1;
        goto label_11;
        label_3:
        if(EmojiPanel.一上三丏东丑丒丑下 >= 0)
        {
                return;
        }
        
        if(this.东业东七丂丞丒丙丛 == true)
        {
                return;
        }
        
        label_5:
        this.ShowEmojiTable();
        val_7 = null;
        val_7 = null;
        val_4 = EmojiPanel.专丏丁万下东丝丟与;
        val_5 = 1152921516635255488;
        val_6 = 0;
        label_11:
        val_4.Invoke(obj:  false);
    }
    public EmojiPanel()
    {
        this.丘丁丏东丁丂世丟上 = 0.5f;
        this.万丂丆丝丁丕丅丕丌 = -1f;
        this.上丅丂不且丐与丟丐 = -1f;
    }
    private static EmojiPanel()
    {
        null = null;
        EmojiPanel.专丏丁万下东丝丟与 = new System.Action<System.Boolean>(object:  EmojiPanel.<>c.<>9, method:  System.Void EmojiPanel.<>c::三丟丗丏且丞与世丘(bool 世丗丈丗丂业丙一不));
    }

}
